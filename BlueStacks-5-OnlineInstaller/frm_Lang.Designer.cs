namespace BlueStacks_5_OnlineInstaller
{
    partial class frm_Lang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lang));
            this.cbo_lang = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_lang
            // 
            this.cbo_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_lang.FormattingEnabled = true;
            this.cbo_lang.Location = new System.Drawing.Point(12, 12);
            this.cbo_lang.Name = "cbo_lang";
            this.cbo_lang.Size = new System.Drawing.Size(144, 21);
            this.cbo_lang.TabIndex = 0;
            this.cbo_lang.SelectedIndexChanged += new System.EventHandler(this.cbo_lang_SelectedIndexChanged);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(50, 40);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // frm_Lang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 75);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cbo_lang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Lang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select language";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Lang_FormClosing);
            this.Load += new System.EventHandler(this.frm_Lang_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ComboBox cbo_lang;
    }
}