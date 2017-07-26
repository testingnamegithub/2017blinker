using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlinkBlink_EyeJoah
{
    class NicknameCheck
    {
        private static NicknameCheck login;
        public static NicknameCheck getInstance()
        {
            if (login == null)
                login = new NicknameCheck();
            return login;
        }

        Regex rex;
        string idStr = @"^[a-zA-Z]+[0-9]";

        //데이터베이스에서 아이디 검사
        public bool DuplicationCheck(string dbName)
        {
            LocalDatabase localDB = LocalDatabase.getInstance();
            if (localDB.DBFileExists(dbName))
            {
                return true;
                //MessageBox.Show("아이디 이미 존재");
            }
            else
            {
                return false;
                //MessageBox.Show("아이디 생성 가능");
            }
        }

        //public bool InputCheck(string input)
        //{
        //    if (CheckingIdEngNum(input) == true && CheckingIdLength(input) == true) //한글 체크
        //    {
        //        return true;
        //        //MessageBox.Show("OK");
        //    }
        //    else
        //    {
        //        return false;
        //        //MessageBox.Show("아이디 안됨 (영문과 숫자 조합으로 6~12자)");
        //    }
        //}

        //id 길이 체크(6자 이상 12자 이하)
        public bool CheckingIdLength(string txt)
        {
            if (txt.Length >= 6 && txt.Length <= 12)
            {
                return true;
            }
            else
                return false;
        }

        //영소문자로 구성되어 있는지 체크
        public bool CheckingIdEngNum(string txt)
        {
            rex = new Regex(idStr);
            return rex.IsMatch(txt);
        }

    }
}
