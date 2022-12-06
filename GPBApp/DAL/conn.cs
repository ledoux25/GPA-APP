using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBApp.DAL
{
    public static class conn
    {
        public static string connection = @"Data Source=(LocalDB\MSSQLLocalDB;AttachDbFilename=C:\Users\Kanteu_ananga\Documents\c#\basic\GPA-APP\GPBApp.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection BDconn = new SqlConnection(connection);
        public static SqlCommand cmd;
    }
}
