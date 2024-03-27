using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParbaudesUzdevums
{
    public class SqliteDataAccess
    {
        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection db = new SQLiteConnection(LoadConnectionString()))
            {
                var output = db.Query<UserModel>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
            using (IDbConnection db = new SQLiteConnection(LoadConnectionString()))
            {
                db.Execute($"insert into User (FirstName, LastName, EmailAddress, MobilePhone) values ('{user.FirstName}', '{user.LastName}', '{user.EmailAddress}', '{user.MobilePhone}')", new DynamicParameters());
            }
        }

        public static void UpdateUser(UserModel user)
        {
            using (IDbConnection db = new SQLiteConnection(LoadConnectionString()))
            {
                db.Execute($"update User set FirstName = '{user.FirstName}', LastName = '{user.LastName}', EmailAddress = '{user.EmailAddress}', MobilePhone = '{user.MobilePhone}' where Id = '{user.Id}'", new DynamicParameters());
            }
        }


        public static void DeleteUser(UserModel user)
        {
            using (IDbConnection db = new SQLiteConnection(LoadConnectionString()))
            {
                db.Execute($"delete from User where Id = '{user.Id}'", new DynamicParameters());
            }
        }

        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}
