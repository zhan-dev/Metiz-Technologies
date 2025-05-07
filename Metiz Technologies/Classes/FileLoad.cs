//using ExcelDataReader;
//using Metiz_Technologies.User_Controls;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Metiz_Technologies.Classes
//{
//    class FileLoad : Reports_userControl
//    {
//        public FileLoad()
//        {
//            BindDataExcel("test");
//        }
//        //public FileLoad()
//        //{

//        //}

//        private void BindDataExcel(string filePath) //for Excel file loader
//        {
//            //using (OpenFileDialog dialog = new OpenFileDialog())
//            //if (dialog.ShowDialog() == DialogResult.OK)

//            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
//            {
//                try
//                {
//                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
//                    {
//                        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
//                        {
//                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
//                            {
//                                UseHeaderRow = true
//                            }
//                        });
//                        tableCollection = result.Tables;
//                        cboSheet_cb.Items.Clear();
//                        foreach (DataTable table in tableCollection)
//                            cboSheet_cb.Items.Add(table.TableName); //add sheet to combobox

//                        productData_dgv.DataSource = result.Tables[0]; // As default open List №1
//                        cboSheet_cb.Text = cboSheet_cb.Items[0].ToString(); //As default in combobox loaded List №1
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message, "System error");
//                }
//            }
//        }

//        private void BindDataCSV(string filePath) //for CSV file loader
//        {
//            DataTable dt = new DataTable();
//            string[] lines = File.ReadAllLines(filePath);

//            if (lines.Length > 0)
//            {
//                //first line to create header              
//                string firstLine = lines[1]; //указание начальной строки для названий столбцов

//                string[] headerLabels = firstLine.Split(','); //разделитель стобцов в файле

//                foreach (string headerWord in headerLabels)
//                {
//                    dt.Columns.Add(new DataColumn(headerWord));
//                }

//                //for data
//                for (int i = 2; i < lines.Length; i++) //где i-первая строка начала нужной выборки данных
//                {
//                    string[] dataWords = lines[i].Split(',');

//                    DataRow dr = dt.NewRow();
//                    int columnIndex = 0;

//                    foreach (string headerWord in headerLabels)
//                    {
//                        dr[headerWord] = dataWords[columnIndex++];
//                    }
//                    dt.Rows.Add(dr);
//                }

//                if (dt.Rows.Count > 0)
//                {
//                    productData_dgv.DataSource = dt;
//                }
//            }
//            // Замена разделителя '.' на ','
//            for (int i = 0; i < productData_dgv.Rows.Count; ++i)
//            {
//                productData_dgv[1, i].Value = productData_dgv[1, i].Value.ToString().Replace('.', ',');
//                productData_dgv[2, i].Value = productData_dgv[2, i].Value.ToString().Replace('.', ',');
//            }
//        }
//    }
//}
