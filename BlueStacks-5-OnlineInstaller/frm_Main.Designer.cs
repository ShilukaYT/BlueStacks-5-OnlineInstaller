namespace BlueStacks_5_OnlineInstaller
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_EmuName = new System.Windows.Forms.Label();
            this.grp_SelectVer = new System.Windows.Forms.GroupBox();
            this.rdo_VerGG = new System.Windows.Forms.RadioButton();
            this.rdo_VerNoGG = new System.Windows.Forms.RadioButton();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Android = new System.Windows.Forms.Label();
            this.cbo_Android = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_SelectVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(124, 16);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "BlueStacks Installer";
            // 
            // lbl_EmuName
            // 
            this.lbl_EmuName.AutoSize = true;
            this.lbl_EmuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmuName.Location = new System.Drawing.Point(12, 37);
            this.lbl_EmuName.Name = "lbl_EmuName";
            this.lbl_EmuName.Size = new System.Drawing.Size(178, 16);
            this.lbl_EmuName.TabIndex = 2;
            this.lbl_EmuName.Text = "Emulator: BlueStacks 5.22.51";
            // 
            // grp_SelectVer
            // 
            this.grp_SelectVer.Controls.Add(this.rdo_VerGG);
            this.grp_SelectVer.Controls.Add(this.rdo_VerNoGG);
            this.grp_SelectVer.Location = new System.Drawing.Point(15, 100);
            this.grp_SelectVer.Name = "grp_SelectVer";
            this.grp_SelectVer.Size = new System.Drawing.Size(136, 41);
            this.grp_SelectVer.TabIndex = 5;
            this.grp_SelectVer.TabStop = false;
            this.grp_SelectVer.Text = "Google services";
            this.grp_SelectVer.Enter += new System.EventHandler(this.grp_SelectVer_Enter);
            // 
            // rdo_VerGG
            // 
            this.rdo_VerGG.AutoSize = true;
            this.rdo_VerGG.Location = new System.Drawing.Point(78, 18);
            this.rdo_VerGG.Name = "rdo_VerGG";
            this.rdo_VerGG.Size = new System.Drawing.Size(43, 17);
            this.rdo_VerGG.TabIndex = 1;
            this.rdo_VerGG.TabStop = true;
            this.rdo_VerGG.Text = "Yes";
            this.rdo_VerGG.UseVisualStyleBackColor = true;
            // 
            // rdo_VerNoGG
            // 
            this.rdo_VerNoGG.AutoSize = true;
            this.rdo_VerNoGG.Location = new System.Drawing.Point(6, 18);
            this.rdo_VerNoGG.Name = "rdo_VerNoGG";
            this.rdo_VerNoGG.Size = new System.Drawing.Size(39, 17);
            this.rdo_VerNoGG.TabIndex = 0;
            this.rdo_VerNoGG.TabStop = true;
            this.rdo_VerNoGG.Text = "No";
            this.rdo_VerNoGG.UseVisualStyleBackColor = true;
            this.rdo_VerNoGG.CheckedChanged += new System.EventHandler(this.rdo_VerNoGG_CheckedChanged);
            // 
            // btn_Start
            // 
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Location = new System.Drawing.Point(171, 105);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(108, 36);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start Install";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Android
            // 
            this.lbl_Android.AutoSize = true;
            this.lbl_Android.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Android.Location = new System.Drawing.Point(12, 61);
            this.lbl_Android.Name = "lbl_Android";
            this.lbl_Android.Size = new System.Drawing.Size(104, 16);
            this.lbl_Android.TabIndex = 8;
            this.lbl_Android.Text = "Android version:";
            // 
            // cbo_Android
            // 
            this.cbo_Android.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Android.FormattingEnabled = true;
            this.cbo_Android.Location = new System.Drawing.Point(136, 60);
            this.cbo_Android.Name = "cbo_Android";
            this.cbo_Android.Size = new System.Drawing.Size(143, 21);
            this.cbo_Android.TabIndex = 7;
            this.cbo_Android.SelectedIndexChanged += new System.EventHandler(this.cbo_Android_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(295, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 63);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 153);
            this.Controls.Add(this.lbl_Android);
            this.Controls.Add(this.cbo_Android);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.grp_SelectVer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_EmuName);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 192);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 192);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlueStacks Installer - Hieu GL Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.grp_SelectVer.ResumeLayout(false);
            this.grp_SelectVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_EmuName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grp_SelectVer;
        private System.Windows.Forms.RadioButton rdo_VerGG;
        private System.Windows.Forms.RadioButton rdo_VerNoGG;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Android;
        private System.Windows.Forms.ComboBox cbo_Android;
    }
}

