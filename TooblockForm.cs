using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;


namespace VproTest
{     
    public partial class TooblockForm : Form
    {
        public CogToolBlock tb; 
        public TooblockForm()
        {
            InitializeComponent();
        }

        private void TooblockForm_Load(object sender, EventArgs e)
        {
            cogToolBlockEditV21.Subject = tb;
        }
    }
}
