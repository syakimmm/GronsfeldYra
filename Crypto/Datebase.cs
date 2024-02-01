using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Crypto
{
    public class Datebase
    {
        private readonly string _connectionString; 
        private SQLiteConnection _conn;
      
        public Datebase(string connectionString)
        {
            //создаём новый конект к БД с известным источником данных
            _conn = new SQLiteConnection(_connectionString = connectionString);
        }

        // создание новой БД
        public bool InitializeDatabase()
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SQLiteCommand cmd = _conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS users("
                                  + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                                  + "login TEXT, "
                                  + "password TEXT)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool CreateUser(string username, string password)
        {
            // создание нового пользователя
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SQLiteCommand cmd = _conn.CreateCommand();
                // имя пользователя сохраняется большими буквами (ToUpper)
                // в пароль сохраняется значение функции хэша (GenMD5Hash)
                cmd.CommandText = string.Format("INSERT INTO users (login, password) VALUES ('{0}', '{1}')",
                    username.ToUpper(), Hash(username, password)); 
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool CheckUser(string username, string password, bool anypass)
        { //проверка есть ли этот пользователь в базе данных
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SQLiteCommand cmd = _conn.CreateCommand();
                if (anypass) //пользователь с любым паролем (не проверяем пароль)
                {
                    cmd.CommandText = string.Format("SELECT login, password FROM users where login = '{0}'", username.ToUpper());
                }
                else
                {
                    cmd.CommandText = string.Format("SELECT login, password FROM users where login = '{0}' AND password = '{1}'",
                        username.ToUpper(), Hash(username, password));
                }
                return cmd.ExecuteScalar() != null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void CloseDB()
        { 
            //закрыть базу в конце работы
            if (_conn.State == ConnectionState.Open) _conn.Close();
        }

        static string Hash(string user, string password)
        {
            //получение хэша пароля
            byte[] passwordBytes = Encoding.UTF8.GetBytes($"{user.ToUpper()}{password}");
            byte[] res = new MD5CryptoServiceProvider().ComputeHash(passwordBytes);
            return Convert.ToBase64String(res);
        }

    }
}
