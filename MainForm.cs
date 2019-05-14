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

namespace VproTest
{
    public partial class MainForm : Form
    {
        CogToolBlock m_tb;
        CogImage8Grey m_Image;
        public MainForm()
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
            m_tb = (CogToolBlock)CogSerializer.LoadObjectFromFile(Application.StartupPath + "\\TestMY.vpp");
        }

        private void btn_edittoolblock_Click(object sender, EventArgs e)
        {
            TooblockForm dlg = new TooblockForm();
            dlg.tb = m_tb;
            dlg.ShowDialog();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (true)
            {
                m_tb.Inputs["OutputImage"].Value = m_Image;
                m_tb.Run();

                cogRecordDisplay1.Image = m_Image;

                cogRecordDisplay1.Record = m_tb.CreateLastRunRecord().SubRecords[0];
                cogRecordDisplay1.Fit();

                textBox1.Text = m_tb.Outputs["Results_Item_0_Score"].Value.ToString();
                double angle = (double)m_tb.Outputs["Results_Item_0_GetPose_Rotation"].Value;
                //angle = angle * 180 / Math.PI;

                textBox2.Text = angle.ToString();
                textBox3.Text = m_tb.Outputs["Results_Item_0_GetPose_TranslationY"].Value.ToString();
            }


            //if (false)
            //{
            //    m_tb.Inputs["OutputImage"].Value = m_Image;
            //    m_tb.Run();
            //    cogRecordDisplay1.Image = m_Image;
            //    cogRecordDisplay1.Record = m_tb.CreateLastRunRecord().SubRecords[0];
            //    cogRecordDisplay1.Fit();
            //    textBox1.Text = m_tb.Outputs["Num"].Value.ToString();
            //    double angle = (double)m_tb.Outputs["Angle"].Value;
            //    angle = angle * 180 / Math.PI;
            //    textBox2.Text = angle.ToString();
            //    textBox3.Text = m_tb.Outputs["Distance"].Value.ToString();
            //}

        }
    }
}
