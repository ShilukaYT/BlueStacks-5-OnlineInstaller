using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlueStacksInstaller_HieuGLLite;

namespace BlueStacks_5_OnlineInstaller
{
    public partial class frm_Lang : Form
    {
        public frm_Lang()
        {
            InitializeComponent();
        }
        public string langcode=string.Empty;
        frm_Main main = null;
        private void frm_Lang_Load(object sender, EventArgs e)
        {
            cbo_lang.Items.Add("English");
            cbo_lang.Items.Add("Tiếng Việt");
            cbo_lang.SelectedIndex = 0;
        }

        private void cbo_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_lang.SelectedItem.ToString() == "English")
            {
                this.Text = "Select language";
                btn_next.Text = "Next";
                langcode = "en";
            }
            else if (cbo_lang.SelectedItem.ToString() == "Tiếng Việt")
            {
                this.Text = "Chọn ngôn ngữ";
                btn_next.Text = "Tiếp";
                langcode = "vi";
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            main = new frm_Main();
            this.Hide();
            main.lang = langcode;
            main.Show();
        }

        private void frm_Lang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
