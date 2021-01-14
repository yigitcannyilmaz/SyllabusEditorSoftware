using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess
    {
        public static List<SyllabusModel> LoadSyllabusList()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SyllabusModel>("select * from Syllabus", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveSyllabus(SyllabusModel syllabus)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Syllabus (Faculty, Code) values (@Faculty , @Code)", syllabus);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
