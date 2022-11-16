using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Database
    {
        private static string server = "localhost";
        private static string database = "maloprodaja";
        private static string user = "root";
        private static string password = "";
        private static MySqlConnection conn = null;

        public static void createConnection()
        {
            if (conn == null)
            {
                string connStr = $"server={server};user={user};database={database};port=3306;password={password};convert zero datetime=True";
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
        }

        public static void closeConnection()
        {
            conn.Close();
            conn = null;
        }

        //"SELECT username, password FROM users WHERE usenrame = @username";
        public static MySqlDataReader select(string query, Dictionary<string, string> parameters)
        {
            createConnection();
            MySqlDataReader rdr = null;

            MySqlCommand cmd = new MySqlCommand(query, conn);
            foreach (var key in parameters.Keys)
            {
                cmd.Parameters.AddWithValue($"@{key}", parameters[key]);
            }

            rdr = cmd.ExecuteReader();

            //rdr.Close();

            //conn.Close();
            return rdr;
        }

        //INSERT INTO users (username, password) VALUES (@username, @password)";
        public static void insert(string query, Dictionary<string, string> parameters)
        {
            createConnection();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            foreach (var key in parameters.Keys)
            {
                cmd.Parameters.AddWithValue($"@{key}", parameters[key]);
            }

            cmd.ExecuteNonQuery();

            closeConnection();
        }

        //UPDATE users SET password=@password WHERE username=@username";
        public static void update(string query, Dictionary<string, string> parameters)
        {
            insert(query, parameters);
        }


        //DELETE users WHERE username=@username";
        public static void delete(string query, Dictionary<string, string> parameters)
        {
            insert(query, parameters);
        }

        public static string hash(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}