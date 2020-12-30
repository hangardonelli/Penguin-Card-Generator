
namespace PenguinCardGenerator
{
    partial class PNGConfig
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
            this.localRB = new System.Windows.Forms.RadioButton();
            this.HTTPRB = new System.Windows.Forms.RadioButton();
            this.FTPRB = new System.Windows.Forms.RadioButton();
            this.SFTPRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.localSearchFolderBtn = new System.Windows.Forms.Button();
            this.localPatchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // localRB
            // 
            this.localRB.AutoSize = true;
            this.localRB.Location = new System.Drawing.Point(6, 19);
            this.localRB.Name = "localRB";
            this.localRB.Size = new System.Drawing.Size(127, 17);
            this.localRB.TabIndex = 0;
            this.localRB.Text = "Local (recommended)";
            this.localRB.UseVisualStyleBackColor = true;
            this.localRB.CheckedChanged += new System.EventHandler(this.localRB_CheckedChanged);
            // 
            // HTTPRB
            // 
            this.HTTPRB.AutoSize = true;
            this.HTTPRB.Location = new System.Drawing.Point(139, 19);
            this.HTTPRB.Name = "HTTPRB";
            this.HTTPRB.Size = new System.Drawing.Size(54, 17);
            this.HTTPRB.TabIndex = 1;
            this.HTTPRB.Text = "HTTP";
            this.HTTPRB.UseVisualStyleBackColor = true;
            this.HTTPRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FTPRB
            // 
            this.FTPRB.AutoSize = true;
            this.FTPRB.Location = new System.Drawing.Point(196, 19);
            this.FTPRB.Name = "FTPRB";
            this.FTPRB.Size = new System.Drawing.Size(45, 17);
            this.FTPRB.TabIndex = 2;
            this.FTPRB.Text = "FTP";
            this.FTPRB.UseVisualStyleBackColor = true;
            this.FTPRB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SFTPRB
            // 
            this.SFTPRB.AutoSize = true;
            this.SFTPRB.Location = new System.Drawing.Point(247, 19);
            this.SFTPRB.Name = "SFTPRB";
            this.SFTPRB.Size = new System.Drawing.Size(52, 17);
            this.SFTPRB.TabIndex = 3;
            this.SFTPRB.Text = "SFTP";
            this.SFTPRB.UseVisualStyleBackColor = true;
            this.SFTPRB.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localRB);
            this.groupBox1.Controls.Add(this.SFTPRB);
            this.groupBox1.Controls.Add(this.HTTPRB);
            this.groupBox1.Controls.Add(this.FTPRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select protocol to get png";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(315, 215);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.localSearchFolderBtn);
            this.tabPage1.Controls.Add(this.localPatchtxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HTTP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(307, 125);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FTP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(307, 189);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SFTP";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // localSearchFolderBtn
            // 
            this.localSearchFolderBtn.Location = new System.Drawing.Point(267, 33);
            this.localSearchFolderBtn.Name = "localSearchFolderBtn";
            this.localSearchFolderBtn.Size = new System.Drawing.Size(24, 20);
            this.localSearchFolderBtn.TabIndex = 3;
            this.localSearchFolderBtn.Text = "...";
            this.localSearchFolderBtn.UseVisualStyleBackColor = true;
            this.localSearchFolderBtn.Click += new System.EventHandler(this.localSearchFolderBtn_Click);
            // 
            // localPatchtxt
            // 
            this.localPatchtxt.Enabled = false;
            this.localPatchtxt.Location = new System.Drawing.Point(15, 33);
            this.localPatchtxt.Name = "localPatchtxt";
            this.localPatchtxt.Size = new System.Drawing.Size(246, 20);
            this.localPatchtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "\"600\" folder location";
            // 
            // PNGConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 306);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PNGConfig";
            this.Text = "[PNG] Configuration Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton localRB;
        private System.Windows.Forms.RadioButton HTTPRB;
        private System.Windows.Forms.RadioButton FTPRB;
        private System.Windows.Forms.RadioButton SFTPRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button localSearchFolderBtn;
        private System.Windows.Forms.TextBox localPatchtxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}