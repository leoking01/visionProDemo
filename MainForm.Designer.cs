namespace VproTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.btn_openimage = new System.Windows.Forms.Button();
            this.btn_edittoolblock = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学习roi设置方法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.研究图像缝合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(12, 27);
            this.cogRecordDisplay1.Margin = new System.Windows.Forms.Padding(2);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(1006, 678);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // btn_openimage
            // 
            this.btn_openimage.Location = new System.Drawing.Point(607, 27);
            this.btn_openimage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_openimage.Name = "btn_openimage";
            this.btn_openimage.Size = new System.Drawing.Size(91, 33);
            this.btn_openimage.TabIndex = 1;
            this.btn_openimage.Text = "openGrayPIc";
            this.btn_openimage.UseVisualStyleBackColor = true;
            this.btn_openimage.Click += new System.EventHandler(this.btn_openimage_Click);
            // 
            // btn_edittoolblock
            // 
            this.btn_edittoolblock.Location = new System.Drawing.Point(702, 27);
            this.btn_edittoolblock.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edittoolblock.Name = "btn_edittoolblock";
            this.btn_edittoolblock.Size = new System.Drawing.Size(108, 33);
            this.btn_edittoolblock.TabIndex = 2;
            this.btn_edittoolblock.Text = "edit-Toolblock";
            this.btn_edittoolblock.UseVisualStyleBackColor = true;
            this.btn_edittoolblock.Click += new System.EventHandler(this.btn_edittoolblock_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(814, 27);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(91, 33);
            this.btn_Run.TabIndex = 3;
            this.btn_Run.Text = "run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(682, 456);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 21);
            this.textBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学习roi设置方法ToolStripMenuItem,
            this.研究图像缝合ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 学习roi设置方法ToolStripMenuItem
            // 
            this.学习roi设置方法ToolStripMenuItem.Name = "学习roi设置方法ToolStripMenuItem";
            this.学习roi设置方法ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.学习roi设置方法ToolStripMenuItem.Text = "学习roi设置方法";
            this.学习roi设置方法ToolStripMenuItem.Click += new System.EventHandler(this.studyRroiSettingMethodToolStripMenuItem_Click);
            // 
            // 研究图像缝合ToolStripMenuItem
            // 
            this.研究图像缝合ToolStripMenuItem.Name = "研究图像缝合ToolStripMenuItem";
            this.研究图像缝合ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.研究图像缝合ToolStripMenuItem.Text = "研究图像缝合";
            this.研究图像缝合ToolStripMenuItem.Click += new System.EventHandler(this.研究图像缝合ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 538);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_edittoolblock);
            this.Controls.Add(this.btn_openimage);
            this.Controls.Add(this.cogRecordDisplay1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.Button btn_openimage;
        private System.Windows.Forms.Button btn_edittoolblock;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学习roi设置方法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 研究图像缝合ToolStripMenuItem;
    }
}

