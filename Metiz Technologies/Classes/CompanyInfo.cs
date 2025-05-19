namespace Metiz_Technologies.Classes
{
    internal class CompanyInfo
    {
        internal static readonly string CompanyName = "Metiz Company";

        internal static string programLanguage { get; set; } = "us";

        internal static readonly string DatabaseConnectionLink =
            @"Data Source=zhanpc;Initial Catalog=""Metiz Company"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
    }
}