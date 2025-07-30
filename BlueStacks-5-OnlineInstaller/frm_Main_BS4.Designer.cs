namespace BlueStacksInstaller_HieuGLLite
{
    partial class frm_Main_BS4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main_BS4));
            this.lbl_InstallerName = new System.Windows.Forms.Label();
            this.lbl_emulator = new System.Windows.Forms.Label();
            this.pictureBox_Emulator = new System.Windows.Forms.PictureBox();
            this.pictureBox_HieuGLLite = new System.Windows.Forms.PictureBox();
            this.grp_SelectVer = new System.Windows.Forms.GroupBox();
            this.rdo_VerGG = new System.Windows.Forms.RadioButton();
            this.rdo_VerNoGG = new System.Windows.Forms.RadioButton();
            this.btn_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Emulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HieuGLLite)).BeginInit();
            this.grp_SelectVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_InstallerName
            // 
            this.lbl_InstallerName.AutoSize = true;
            this.lbl_InstallerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InstallerName.Location = new System.Drawing.Point(12, 9);
            this.lbl_InstallerName.Name = "lbl_InstallerName";
            this.lbl_InstallerName.Size = new System.Drawing.Size(131, 17);
            this.lbl_InstallerName.TabIndex = 0;
            this.lbl_InstallerName.Text = "BlueStacks Installer";
            // 
            // lbl_emulator
            // 
            this.lbl_emulator.AutoSize = true;
            this.lbl_emulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emulator.Location = new System.Drawing.Point(12, 30);
            this.lbl_emulator.Name = "lbl_emulator";
            this.lbl_emulator.Size = new System.Drawing.Size(202, 17);
            this.lbl_emulator.TabIndex = 1;
            this.lbl_emulator.Text = "Emulator: BlueStacks 4.240.20";
            this.lbl_emulator.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_Emulator
            // 
            this.pictureBox_Emulator.BackgroundImage = global::BlueStacksInstaller_HieuGLLite.Properties.Resources.BlueStacks;
            this.pictureBox_Emulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Emulator.Location = new System.Drawing.Point(287, 79);
            this.pictureBox_Emulator.Name = "pictureBox_Emulator";
            this.pictureBox_Emulator.Size = new System.Drawing.Size(79, 70);
            this.pictureBox_Emulator.TabIndex = 3;
            this.pictureBox_Emulator.TabStop = false;
            // 
            // pictureBox_HieuGLLite
            // 
            this.pictureBox_HieuGLLite.BackgroundImage = global::BlueStacksInstaller_HieuGLLite.Properties.Resources._475037745_1145609947169948_1808085165724307370_n;
            this.pictureBox_HieuGLLite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_HieuGLLite.Location = new System.Drawing.Point(287, 3);
            this.pictureBox_HieuGLLite.Name = "pictureBox_HieuGLLite";
            this.pictureBox_HieuGLLite.Size = new System.Drawing.Size(79, 70);
            this.pictureBox_HieuGLLite.TabIndex = 2;
            this.pictureBox_HieuGLLite.TabStop = false;
            // 
            // grp_SelectVer
            // 
            this.grp_SelectVer.Controls.Add(this.rdo_VerGG);
            this.grp_SelectVer.Controls.Add(this.rdo_VerNoGG);
            this.grp_SelectVer.Location = new System.Drawing.Point(15, 61);
            this.grp_SelectVer.Name = "grp_SelectVer";
            this.grp_SelectVer.Size = new System.Drawing.Size(136, 41);
            this.grp_SelectVer.TabIndex = 6;
            this.grp_SelectVer.TabStop = false;
            this.grp_SelectVer.Text = "Google services";
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
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(15, 108);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(130, 39);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Start Installation";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // frm_Main_BS4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 153);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.grp_SelectVer);
            this.Controls.Add(this.pictureBox_Emulator);
            this.Controls.Add(this.pictureBox_HieuGLLite);
            this.Controls.Add(this.lbl_emulator);
            this.Controls.Add(this.lbl_InstallerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 192);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 192);
            this.Name = "frm_Main_BS4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlueStacks Installer - Hieu GL Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_BS4_FormClosed);
            this.Load += new System.EventHandler(this.frm_Main_BS4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Emulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HieuGLLite)).EndInit();
            this.grp_SelectVer.ResumeLayout(false);
            this.grp_SelectVer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_InstallerName;
        private System.Windows.Forms.Label lbl_emulator;
        private System.Windows.Forms.PictureBox pictureBox_HieuGLLite;
        private System.Windows.Forms.PictureBox pictureBox_Emulator;
        private System.Windows.Forms.GroupBox grp_SelectVer;
        private System.Windows.Forms.RadioButton rdo_VerGG;
        private System.Windows.Forms.RadioButton rdo_VerNoGG;
        private System.Windows.Forms.Button btn_Start;
    }
}