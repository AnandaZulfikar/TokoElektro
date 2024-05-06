using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoElektro
{
    internal class dbconfig
    {
        static string dbname = "tokoelektro";
        static string source = "MIWON\\SQLEXPRESS";
        public static string conn = $"Data Source='{source}';Initial Catalog='{dbname}';Integrated Security=True;";
    }
}
