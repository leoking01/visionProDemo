using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro;


using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;

namespace VproTest
{
    public partial class MainForm : Form
    {
        CogToolBlock   m_tb;
        CogImage8Grey  m_Image;
        public MainForm(   )
        {
             InitializeComponent();
        }

        private void btn_openimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CogImageFile imagefile = new CogImageFile();
                imagefile.Open(dlg.FileName, CogImageFileModeConstants.Read);
                m_Image = (CogImage8Grey)imagefile[0];
                cogRecordDisplay1.Image = imagefile[0];
                cogRecordDisplay1.Fit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_tb = new CogToolBlock();
            string nameOfVpp = Application.StartupPath + "\\..\\..\\..\\demo.vpp";
            m_tb = (CogToolBlock)CogSerializer.LoadObjectFromFile(nameOfVpp);

            CogImageFile imagefile = new CogImageFile();
            imagefile.Open(Application.StartupPath + "/../../../in/bracket_std.idb", CogImageFileModeConstants.Read);

            //imagefile.IsSynchronized ;//();
            //m_Image = 
            CogToolCollection tbTc = m_tb.Tools;
            //tbTc.
            //((CogImageFileTool)tbTc["CogImageFileTool1"]).Name = "";
            ((CogImageFileTool)tbTc["CogImageFileTool1"]).InputImage = (CogImage8Grey)imagefile[0];
        }

        private void btn_edittoolblock_Click(object sender, EventArgs e)
        {
            TooblockForm dlg = new TooblockForm(  );
            dlg.tb = m_tb;
            dlg.ShowDialog();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (true)
            {
                m_tb.Inputs["OutputImage"].Value = m_Image;
                //m_tb.Inputs["InputImage"].Value = m_Image;
                m_tb.Run();

                cogRecordDisplay1.Image = m_Image;

                cogRecordDisplay1.Record = m_tb.CreateLastRunRecord().SubRecords[0];
                cogRecordDisplay1.Fit();

                textBox1.Text = m_tb.Outputs["Results_Item_0_Score"].Value.ToString();
                double angle = (double)m_tb.Outputs["Results_Item_0_GetPose_Rotation"].Value;
                //  angle = angle * 180 / Math.PI;
            }
        }

        private void studyRroiSettingMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //InitializeFifo();
            MessageBox.Show("study  roi  visonpro . ");

            if (false)
            {
                aaa();
                bbb();  //  错误演示-- 未将对象引用设置到对象的实例” 
            }
        }

#region  JJJ
        private CogFrameGrabbers myFrameGrabbers;
        private ICogFrameGrabber myFrameGrabber;
        private ICogAcqFifo myAcqFifo;

        private void InitializeFifo()
        {
            const string VIDEO_FORMAT = "Sony XC75 640x480";
            ICogAcqROI ROIParams;

            myFrameGrabbers = new CogFrameGrabbers();
            myFrameGrabber = myFrameGrabbers[0];
            myAcqFifo = myFrameGrabber.CreateAcqFifo(VIDEO_FORMAT,
                Cognex.VisionPro.CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);

            ROIParams = myAcqFifo.OwnedROIParams;
            if (ROIParams != null)
                ROIParams.SetROIXYWidthHeight(10, 20, 300, 200);
        }
#endregion

        public string[ ] c;

        private void Page_Load(object sender, System.EventArgs e)
        {
            aaa();
            bbb();
        }

        private void aaa()
        {
            string[] c = new string[3];    //  错误演示-- 未将对象引用设置到对象的实例” 
            //c = new string[3];    //  正确的做法 
            c[0] = "我们";
            c[1] = "西部";
            c[2] = "学习";
        }

        private void bbb()
        {
            //System.Console.WriteLine(c[0] + c[1] + c[2]);

            string resD = c[0] + c[1] + c[2];
        }

        private void 研究图像缝合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CogImageFile imagefile_0 = new CogImageFile();
            imagefile_0.Open(Application.StartupPath + "/../../../street/street_0.bmp", CogImageFileModeConstants.Read);
            CogImage24PlanarColor image_24_0 = new CogImage24PlanarColor();
            image_24_0 = (CogImage24PlanarColor)imagefile_0[0];
            CogImage8Grey imageGray8_0 = CogImageConvert.GetIntensityImage(image_24_0, 0, 0, image_24_0.Width, image_24_0.Height);


            CogImageFile imagefile_1 = new CogImageFile();
            imagefile_1.Open(Application.StartupPath + "/../../../street/street_1.bmp", CogImageFileModeConstants.Read);
            CogImage24PlanarColor image_24_1 = new CogImage24PlanarColor();
            image_24_1 = (CogImage24PlanarColor)imagefile_1[0];
            CogImage8Grey imageGray8_1 = CogImageConvert.GetIntensityImage(image_24_1, 0, 0, image_24_1.Width, image_24_1.Height);


            CogImageFile imagefile_2 = new CogImageFile();
            imagefile_2.Open(Application.StartupPath + "/../../../street/street_2.bmp", CogImageFileModeConstants.Read);
            CogImage24PlanarColor image_24_2 = new CogImage24PlanarColor();
            image_24_2 = (CogImage24PlanarColor)imagefile_2[0];
            CogImage8Grey imageGray8_2 = CogImageConvert.GetIntensityImage(image_24_2, 0, 0, image_24_2.Width, image_24_2.Height);


            // 灰度图像 
            //CogImage8Grey image8 = (CogImage8Grey)m_tb.GetScriptTerminalData("imageInput");   
            CogImage8Grey image8 = (CogImage8Grey)m_tb.GetScriptTerminalData("OutputImage");
            image8 = imageGray8_0.Copy();
            CogToolCollection tbTc = m_tb.Tools;
            //tbTc.
            if (false)
            {
                image8 = (CogImage8Grey)((CogImageFileTool)tbTc["CogImageFileTool1"]).OutputImage;
            }
           



            CogImage8Grey image_002 = new CogImage8Grey();
            //image_002 = image8;
            image_002 = image8.Copy();
            CogImage8Grey image_003 = image8.Copy();



            // 将各个图像进行缝合组成一个完整的大图
            // 灰度图像 
            //CogIPOneImageTool imageCtrl_02 = (CogIPOneImageTool)mToolBlock.Tools["CogIPOneImageTool2"];
            CogRectangle rt = new CogRectangle();
            rt.SetCenterWidthHeight(0, 0, image8.Width * 3, image8.Height * 3);
            CogImage8Grey m_gray = rt.CreateRLE( 128, 0).CreateImage8Grey();
            //imageCtrl_02.InputImage = m_gray;



            //    CogImage8Grey inputImage = ( CogImage8Grey ) image8;
            //    tb.SetScriptTerminalData("Input", inputImage);
            CogImageStitch stt = new CogImageStitch();
            CogTransform2DLinear rootFromBlending = new CogTransform2DLinear();
            //缩放，旋转，平移
            rootFromBlending.SetScalingsRotationsTranslation(    1,    1,    0,   0,    0   , 0   );
            //    rootFromBlending.SetScalingsRotationTranslation();
            stt.AllocateBlendingBuffer(   image8.Width *3 ,   image8.Height*3 ,   rootFromBlending   );
            //stt.BlendImageIntoBuffer(image8, m_gray);
            stt.BlendImageIntoBuffer( imageGray8_0, imageGray8_0, m_gray,           0,       0             );
            stt.BlendImageIntoBuffer( imageGray8_1, imageGray8_1, m_gray, image8.Width,   image8.Height       );
            stt.BlendImageIntoBuffer( imageGray8_2, imageGray8_2, m_gray, image8.Width*2, image8.Height*2    );








            stt.FillDestinationImageFromBuffer(  m_gray   );
            //    BlendImageIntoBuffer(  CogImage8Grey, CogImage8Grey, CogImage8Grey, Int32, Int32 )


            //   
            CogCopyRegionTool ccft = new CogCopyRegionTool();


            //switch (  true )
            //{
            //case :
            //    break;
            //}


            cogRecordDisplay1.Image = m_gray;
            cogRecordDisplay1.Fit();
        }




    }
}
