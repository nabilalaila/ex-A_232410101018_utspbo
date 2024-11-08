using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _1018_Nabila_Laila_Sholihah_UTS_PBO.Context
{
    internal class TugasContext : DatabaseWrapper
    {
        private static string table = "tugas";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable Tugasdata = queryExecutor(query);
            return Tugasdata;
        }

    }
}

