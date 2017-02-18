using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;


namespace BlinkBlink_EyeJoah
{
    class TrainingData
    {
        /* 싱글톤 적용 변수 */
        private static TrainingData instance = null;

        /* training에 관한 변수들 */
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> trainedNamesList = new List<string>();
        int CountTrain = 0;

        /* 생성자 */
        public TrainingData() { }

        /* 싱글톤 */
        public static TrainingData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrainingData();
                }
                return instance;
            }
        }

        public void loadTrainingData()
        {
            try
            {
                //파일에 있는 Training Image 및 label load.
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] trainedNames = Labelsinfo.Split('%');
                CountTrain = Convert.ToInt16(trainedNames[0]);

                // 파일에 있는 TrainingImage List에 저장
                string LoadFaces;
                for (int tf = 1; tf < CountTrain + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    trainedNamesList.Add(trainedNames[tf]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void saveTrainingData()
        {
            //등록한 얼굴 수 TrainedLabels.txt에 저장 --> WriteAllText를 통해 File 존재시 덮어씀
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //등록한 얼굴 bmp 파일로 저장 및 이름 TrainedLabels.txt에 저장
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainedNamesList.ToArray()[i - 1] + "%");
            }
        }

        public List<Image<Gray, byte>> getset_TrainingImages
        {
            get { return trainingImages; }
            set { trainingImages = value; }
        }
        public List<string> getset_trainedNamesList
        {
            get { return trainedNamesList; }
            set { trainedNamesList = value; }
        }
        public int getset_CountTrain
        {
            get { return CountTrain; }
            set { CountTrain = value; }
        }
    }
}
