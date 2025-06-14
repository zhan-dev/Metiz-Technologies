﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;
using Metiz_Technologies.Classes;
using Metiz_Technologies.Properties;

namespace Metiz_Technologies.User_Controls
{
    public partial class Reports_userControl: UserControl
    {
        public Reports_userControl()
        {
            InitializeComponent();
        }

        //Metods
        private void BindDataExcel(string filePath) //for Excel file loader
        {
            //using (OpenFileDialog dialog = new OpenFileDialog())
            //if (dialog.ShowDialog() == DialogResult.OK)

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        tableCollection = result.Tables;
                        cboSheet_cb.Items.Clear();
                        foreach (DataTable table in tableCollection)
                            cboSheet_cb.Items.Add(table.TableName); //add sheet to combobox

                        expensesData_dgv.DataSource = result.Tables[0]; // As default open List №1
                        cboSheet_cb.Text = cboSheet_cb.Items[0].ToString(); //As default in combobox loaded List №1
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System error");
                }
            }
        }

        private void BindDataCSV(string filePath) //for CSV file loader
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                //first line to create header              
                string firstLine = lines[1]; //указание начальной строки для названий столбцов

                string[] headerLabels = firstLine.Split(','); //разделитель стобцов в файле

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                //for data
                for (int i = 2; i < lines.Length; i++) //где i-первая строка начала нужной выборки данных
                {
                    string[] dataWords = lines[i].Split(',');

                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;

                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }

                if (dt.Rows.Count > 0)
                {
                    expensesData_dgv.DataSource = dt;
                }
            }
            // Замена разделителя '.' на ','
            for (int i = 0; i < expensesData_dgv.Rows.Count; ++i)
            {
                expensesData_dgv[1, i].Value = expensesData_dgv[1, i].Value.ToString().Replace('.', ',');
                expensesData_dgv[2, i].Value = expensesData_dgv[2, i].Value.ToString().Replace('.', ',');
            }
        }

        private void GeneralDataCorrections()
        {
            //Работа с загруженным материалом
            product_lbl.Text = expensesData_dgv[2, 2].Value.ToString();
            product_lbl.Text = product_lbl.Text.Substring(product_lbl.Text.IndexOf(":") + 2);

            endDate_txt.Text = expensesData_dgv[2, 0].Value.ToString();
            startDate_txt.Text = expensesData_dgv[2, 1].Value.ToString();

            endDate_txt.Text = endDate_txt.Text.Substring(endDate_txt.Text.IndexOf(":") + 2);
            startDate_txt.Text = startDate_txt.Text.Substring(startDate_txt.Text.IndexOf(":") + 2);

            endDate_txt.Text = endDate_txt.Text.Remove(endDate_txt.Text.IndexOf(" "));
            startDate_txt.Text = startDate_txt.Text.Remove(startDate_txt.Text.IndexOf(" "));

            DateTime endDate = DateTime.ParseExact(endDate_txt.Text, "M/d/yyyy", CultureInfo.InvariantCulture);
            DateTime startDate = DateTime.ParseExact(startDate_txt.Text, "M/d/yyyy", CultureInfo.InvariantCulture);

            TimeSpan date = endDate - startDate;
            Double months = Math.Ceiling(date.TotalDays / 30.4);
            date_txt.Text = months.ToString();

            //Перезапись названия столбцов
            foreach (DataGridViewColumn item in expensesData_dgv.Columns)
            {
                //переприсвоение дат
                expensesData_dgv[item.Index, 4].Value = 
                    expensesData_dgv[item.Index, 4].Value.ToString() == "" ?
                    expensesData_dgv[item.Index - 1, 4].Value.ToString() : expensesData_dgv[item.Index, 4].Value.ToString();

                expensesData_dgv[item.Index, 4].Value = 
                    expensesData_dgv[item.Index, 4].Value.ToString().Contains("12:00:00 AM") ?
                    expensesData_dgv[item.Index, 4].Value.ToString().Replace(" 12:00:00 AM", "") : 
                    expensesData_dgv[item.Index, 4].Value.ToString();

                expensesData_dgv[item.Index, 4].Value = 
                    expensesData_dgv[item.Index, 4].Value.ToString().Contains("Номенклатура.") ?
                    expensesData_dgv[item.Index, 4].Value.ToString().Replace("Номенклатура.", "") : 
                    expensesData_dgv[item.Index, 4].Value.ToString();

                expensesData_dgv[item.Index, 5].Value = 
                    expensesData_dgv[item.Index, 5].Value.ToString().Contains("Количество") ?
                    expensesData_dgv[item.Index, 5].Value.ToString().Replace("Количество ", "") : 
                    expensesData_dgv[item.Index, 5].Value.ToString();

                expensesData_dgv.Columns[item.Index].HeaderText =
                    $"{expensesData_dgv[item.Index, 4].Value.ToString()}\n{expensesData_dgv[item.Index, 5].Value.ToString()}";


                string getHeight = expensesData_dgv.ColumnHeadersHeight.ToString();
                expensesData_dgv.Columns[item.Index].Width = 100 + Convert.ToInt32(getHeight);
            }

            //костыльное Удаление лишних столбцов и строк
            int colIndex = expensesData_dgv.CurrentCell.ColumnIndex;
            int rowIndex = expensesData_dgv.CurrentCell.RowIndex;

            expensesData_dgv.Columns.RemoveAt(colIndex + 1);
            expensesData_dgv.Columns.RemoveAt(colIndex + 1);
            expensesData_dgv.Columns.RemoveAt(colIndex + 2);

            expensesData_dgv.Rows.RemoveAt(rowIndex);
            expensesData_dgv.Rows.RemoveAt(rowIndex);
            expensesData_dgv.Rows.RemoveAt(rowIndex);
            expensesData_dgv.Rows.RemoveAt(rowIndex);
            expensesData_dgv.Rows.RemoveAt(rowIndex);
            expensesData_dgv.Rows.RemoveAt(rowIndex);
            expensesData_dgv.Rows.RemoveAt(rowIndex);

            //удаление последней строки с итогом (2 потому что таблицу можно редактировать и посл. строка пустая)
            expensesData_dgv.Rows.RemoveAt(expensesData_dgv.Rows.Count - 2);

            //Зануление таблицы
            DataTableToNull();
        }

        private void DataTableToNull()
        {
            foreach (DataGridViewColumn itemCol in this.expensesData_dgv.Columns)
            {
                int j = itemCol.Index;

                foreach (DataGridViewRow itemRow in this.expensesData_dgv.Rows)
                {
                    int i = itemRow.Index;

                    expensesData_dgv.Rows[i].Cells[j].Value = 
                        expensesData_dgv.Rows[i].Cells[j].Value is DBNull ? 0 : expensesData_dgv.Rows[i].Cells[j].Value;
                }
            }
        }

        private void DGVRowsDel()
        {
            int rowIndex = expensesData_dgv.CurrentCell.RowIndex;
            int countRows = 0;
            do
            {
                expensesData_dgv.Rows.RemoveAt(rowIndex);
                countRows++;
            } while (countRows < 4);

            //productData_dgv.Rows.RemoveAt(productData_dgv.Rows.Count - 1); //удаление последней строки с итогом

        }
        
        private void DGVColumnsDel(int colStarts)
        {
            int colIndex = expensesData_dgv.CurrentCell.ColumnIndex + colStarts;
            int countColumns = 0;
            do
            {
                expensesData_dgv.Columns.RemoveAt(colIndex);
                countColumns++;
            } while (countColumns < 4);
        }

        private void WhereUsedDGVProProdSum()
        {
            int strErrCount = 0;

            foreach (DataGridViewColumn itemCol in this.expensesData_dgv.Columns)
            {
                int j = itemCol.Index;

                if ((expensesData_dgv.Columns[itemCol.Index].HeaderText == "Количество ПРО") &&
                    (expensesData_dgv.Columns[itemCol.Index + 1].HeaderText == "Количество продажа"))
                {
                    expensesData_dgv.Columns[itemCol.Index - 1].HeaderText =
                                $"\n ПРО + Продажа";

                    foreach (DataGridViewRow itemRow in this.expensesData_dgv.Rows)
                    {
                        int i = itemRow.Index;

                        try
                        {
                            expensesData_dgv.Rows[i].Cells[j - 1].Value = Convert.ToDouble(expensesData_dgv.Rows[i].Cells[j].Value) +
                                                             Convert.ToDouble(expensesData_dgv.Rows[i].Cells[j + 1].Value);
                        }
                        //catch (Exception ex)
                        //{

                        //    MessageBox.Show($"{ex.Message} {strErrCount}", $@"Error");
                        //    strErrCount++;
                        //}
                        catch
                        {

                        }
                    }
                }
            }
        }

        private async void PrintText(string text) //асинхронный метод для имитации печатного текста
        {
            dragANDdrop_lbl.Text = "";
            char[] chars = text.ToCharArray();
            foreach (char print_ch in chars)
            {
                this.dragANDdrop_lbl.Text += print_ch.ToString();
                await Task.Delay(20);
            }
        }

        private void Inform(string inform) //my method for Inform 
        {
            MessageBox.Show(inform, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Metods

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            if (reportsMenuSidebar_panel.Width == 200)
            {
                dashboard_btn.Image = Resources.BlackDrag_List_Down_40;
                reportsMenuSidebar_panel.Width = 52;
                dashboard_btn.Text = "";
                expenses_btn.Text = "";
            }
            else
            {
                dashboard_btn.Image = Resources.BlackBulleted_List_40;
                reportsMenuSidebar_panel.Width = 200;
                dashboard_btn.Text = "Dashboard";
                expenses_btn.Text = "Прогноз закупок";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            markAsActive_panel.Top = salary_btn.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            markAsActive_panel.Top = incomingMoney_btn.Top;
        }

        private void purchasePrediction_btn_Click(object sender, EventArgs e)
        {
            markAsActive_panel.Top = expenses_btn.Top;
        }

        private void CleanDGVTable()
        {
            int count = this.expensesData_dgv.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                this.expensesData_dgv.Columns.RemoveAt(0);
            }
        }

        private void import_panel_DragDrop(object sender, DragEventArgs e)
        {       
            import_panel.BackgroundImage = Resources.BlackUploadToTheCloud_150;
            CleanDGVTable();

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop); //получение пути к файлу
            filePath_txt.Text = file[0].ToString();

            if (filePath_txt.Text.Contains(".xls") || filePath_txt.Text.Contains(".xlsx"))
            {
                BindDataExcel(filePath_txt.Text);

                GeneralDataCorrections();

                if (product_lbl.Text.Contains("Канат"))
                {
                    DGVColumnsDel(6);
                }
                else if (product_lbl.Text.Contains("Комплектующие"))
                {
                    DGVColumnsDel(2);
                }
                //else if (product_lbl.Text.Contains("Проволока"))
                //{

                //}
                else
                {
                    MessageBox.Show("Error");
                }

                //остановился где-то тут
                //WhereUsedDGVProProdSum();
            }

            else if (filePath_txt.Text.Contains(".csv"))
            {
                BindDataCSV(filePath_txt.Text);
            }

            else
            {
                Inform("This File format can't be loaded.\nLoad File .csv or .xlsx");
            }

            PrintText("Drag your File here");
        }

        private void import_panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                dragANDdrop_lbl.Text = "Drop your File here";
                import_panel.BackgroundImage = Resources.GreenUploadToTheCloud_150;
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void import_panel_DragLeave(object sender, EventArgs e)
        {
            dragANDdrop_lbl.Text = "Drag your File here";
            import_panel.BackgroundImage = Resources.BlackUploadToTheCloud_150;
        }

        private void productData_dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //нумерация строк таблицы
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        public DataTableCollection tableCollection;
        private void cboSheet_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Для переключение cboSheet
            DataTable dt = tableCollection[cboSheet_cb.SelectedItem.ToString()];
            expensesData_dgv.DataSource = dt;
        }

        private void cboSheet_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //запрет ввода в combobox
        }

        private void UIpanel_btn_Click(object sender, EventArgs e)
        {
            if (reportsAdditionalSidebar_panel.Width == 200)
            {
                hidePanel_btn.Image = Resources.BlackArrowToLeft_25;
                hidePanel_btn.ImageAlign = ContentAlignment.MiddleCenter;
                reportsAdditionalSidebar_panel.Width = 52;
                additional_panel.Visible = false;
            }
            else
            {
                hidePanel_btn.Image = Resources.BlackArrowToRight_25;
                hidePanel_btn.ImageAlign = ContentAlignment.MiddleLeft;
                reportsAdditionalSidebar_panel.Width = 200;
                additional_panel.Visible = true;
            }
        }
    }
}
