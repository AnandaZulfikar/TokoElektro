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
        public static string conn = $"Data Source=MIWON\\SQLEXPRESS;Initial Catalog='{dbname}';Integrated Security=True;";
    }
}
