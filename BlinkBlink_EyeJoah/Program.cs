using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlinkBlink_EyeJoah
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // User 파일이 존재하면 Form1 실행
            // 처음 들어온 경우면 FaceTraining 실행
            //if (File.Exists(Application.StartupPath + "/TrainedFaces/UserName.txt"))
            Application.Run(new Form1());
            ////else
            //    Application.Run(new FaceTraining());

        }
    }
}
