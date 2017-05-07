using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlinkBlink_EyeJoah
{
    class LocalDatabase
    {
        private static LocalDatabase localDB;
        public static LocalDatabase getInstance()
        {
            if (localDB == null)
            {
                localDB = new LocalDatabase();
            }
            return localDB;
        }

        private SQLiteConnection dbConnection;

        //데이터베이스 sqlite파일 생성(bin-x64-Debug)
        public void CreateDatabase(string dbName)
        {
            //if (!File.Exists(Form1.form.dbName+".sqlite"))
            //{
            SQLiteConnection.CreateFile(dbName + ".sqlite");
            //}
        }

        public bool DBFileExists(string dbName) //디비파일 생성 여부
        {
            if (File.Exists(dbName + ".sqlite")) //이미 동일한 데베가 존재하면
            {
                return true;
            }
            else
                return false;
        }

        public bool TableExists(string tableName, string dbName)
        {
            ConnectionToDB(dbName);
            string sql = "SELECT COUNT(*) FROM sqlite_master WHERE name = '" + tableName + "'";

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

            MessageBox.Show(command.ExecuteScalar().ToString());
            int result = Convert.ToInt32(command.ExecuteScalar());
            DisconnectionToDB();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateTable(string tableName)
        {
            string sql = "create table if not exists " + tableName + " (idTime int, blinkTimes double, UNIQUE(idTime))"; //존재하지 않는 경우에만 테이블 추가

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        //데이터 삽입(테이블 생성 포함)
        public void InsertDataToTable(string dbName, string tableName, int idTime, double blinkTimes)
        {
            ConnectionToDB(dbName);

            //테이블 생성(테이블 존재하지 않을 경우에만 생성)
            CreateTable(tableName);

            string sql = "insert or ignore into " + tableName + " (idTime, blinkTimes) values (" + idTime + "," + blinkTimes + ")";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            DisconnectionToDB();
        }

        public void ReadAllDataFromTable(ref int [,] arrayData, string dbName, string tableName)
        {
            ConnectionToDB(dbName);

            string sql = "select * from " + tableName + " order by idTime asc"; //오름차순
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                arrayData[i++, 1] = Convert.ToInt32(reader["blinkTimes"]);
            }
            //Form1.form.UpdateText("idTime: " + reader["idTime"] + "  blinkTimes: " + reader["blinkTimes"]);

            DisconnectionToDB();
        }

        //public void SelectTables(string dbName)
        //{
        //    ConnectionToDB(dbName);

        //    string sql = "select name from BlinkerDB where type='table'";
        //    SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
        //    SQLiteDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //        Form1.form.UpdateText("idTime= " + reader["idTime"]);

        //    DisconnectionToDB();
        //}

        public void ConnectionToDB(string dbName)
        {
            dbConnection = new SQLiteConnection("Data Source=" + dbName + ".sqlite;Version=3;");
            dbConnection.Open();
        } //Connection Open

        public void DisconnectionToDB()
        {
            if (dbConnection != null)
            {
                dbConnection.Close();
            }
        }  //Connection Close
    }
}
