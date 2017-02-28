using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//azure database
using DT = System.Data;            // System.Data.dll  
using QC = System.Data.SqlClient;  // System.Data.dll  

namespace BlinkBlink_EyeJoah
{
    class UserInfoAzureDB
    {
        //singleton pattern
        private static UserInfoAzureDB userInfoAzureDB;
        public static UserInfoAzureDB getInstance()
        {
            if (userInfoAzureDB == null)
            {
                userInfoAzureDB = new UserInfoAzureDB();
            }
            return userInfoAzureDB;
        }

        //check if row exists in database EyeInfoTable
        public bool checkIfRowExists(QC.SqlConnection connection, String nicknameID)
        {
            object returnValue = "f";
            String cmdString = "if exists(select*from EyeInfoTable where nicknameID='" + nicknameID + "') select 'true' else select 'false' return";

            using (var command = new QC.SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = cmdString;
                command.ExecuteNonQuery();
                QC.SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    returnValue = reader.GetSqlValue(0).ToString(); //String값으로 받아옴
                }
                reader.Close();
            }
            if (returnValue.Equals("true"))
            {
                return true;
            }
            else if (returnValue.Equals("false"))
            {
                return false;
            }
            else return false;
        }

        //insert UserInfo data with queries
        public void insertData(String nickname)
        {
            //create user data rows in azure database
            using (var connection = new QC.SqlConnection(
               "Server=tcp:blinkerserver.database.windows.net,1433;Initial Catalog=blinker_db;Persist Security Info=False;User ID=sm5duck;Password=Ajtwlstjdals2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                ))
            {
                connection.Open();

                string cmdString = "INSERT INTO EyeInfoTable values(@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12, @val13, @val14, @val15, @val16, @val17, @val18, @val19, @val20, @val21, @val22, @val23, @val24, @val25)";
                //string connString = "your connection string";

                using (var command = new QC.SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = cmdString;
                    command.Parameters.AddWithValue("@val1", nickname);
                    command.Parameters.AddWithValue("@val2", 0);
                    command.Parameters.AddWithValue("@val3", 0);
                    command.Parameters.AddWithValue("@val4", 0);
                    command.Parameters.AddWithValue("@val5", 0);
                    command.Parameters.AddWithValue("@val6", 0);
                    command.Parameters.AddWithValue("@val7", 0);
                    command.Parameters.AddWithValue("@val8", 0);
                    command.Parameters.AddWithValue("@val9", 0);
                    command.Parameters.AddWithValue("@val10", 0);
                    command.Parameters.AddWithValue("@val11", 0);
                    command.Parameters.AddWithValue("@val12", 0);
                    command.Parameters.AddWithValue("@val13", 0);
                    command.Parameters.AddWithValue("@val14", 0);
                    command.Parameters.AddWithValue("@val15", 0);
                    command.Parameters.AddWithValue("@val16", 0);
                    command.Parameters.AddWithValue("@val17", 0);
                    command.Parameters.AddWithValue("@val18", 0);
                    command.Parameters.AddWithValue("@val19", 0);
                    command.Parameters.AddWithValue("@val20", 0);
                    command.Parameters.AddWithValue("@val21", 0);
                    command.Parameters.AddWithValue("@val22", 0);
                    command.Parameters.AddWithValue("@val23", 0);
                    command.Parameters.AddWithValue("@val24", 0);
                    command.Parameters.AddWithValue("@val25", 0);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        //check nickname duplication
        public void idDupCheck()
        {
            // nameTxtbox.Text
            using (var connection = new QC.SqlConnection(
                 "Server=tcp:blinkerserver.database.windows.net,1433;Initial Catalog=blinker_db;Persist Security Info=False;User ID=sm5duck;Password=Ajtwlstjdals2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                  ))
            {
                //sql 연결
                connection.Open();

                //데이터 존재 유무 확인
                if (userInfoAzureDB.checkIfRowExists(connection, FaceTraining.faceTraining.nameText()).Equals(true))
                {
                    FaceTraining.faceTraining.updateCheckText("The nickname already exists", System.Drawing.Color.Red);
                    FaceTraining.faceTraining.updateNameDup(false); //fail
                }
                else //false
                {
                    FaceTraining.faceTraining.updateCheckText("Nickname available", System.Drawing.Color.Blue);
                    FaceTraining.faceTraining.updateNameDup(true); //pass
                }

                connection.Close();
            }
        }
    }
}
