using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStacksInstaller_HieuGLLite
{
    public partial class frm_Main_BS4 : Form
    {
        public frm_Main_BS4()
        {
            InitializeComponent();
        }

        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        Process process = new Process();
        public string lang = string.Empty;

        private void StartInstall(string Ver)
        {

            try
            {

                processStartInfo.FileName = System.IO.Path.Combine(Application.StartupPath, "BlueStacksInstaller" + Ver + ".exe");
                processStartInfo.Arguments = string.Empty;
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                processStartInfo.WorkingDirectory = System.IO.Path.Combine(Application.StartupPath);

                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();

            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"{ex.Message}");
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void StartUninstall()
        {
            try
            {

                processStartInfo.FileName = System.IO.Path.Combine(Application.StartupPath, "BSTCleaner_native", "BSTCleaner.exe");
                processStartInfo.Arguments = "-oem bgp";
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                processStartInfo.WorkingDirectory = System.IO.Path.Combine(Application.StartupPath, "BSTCleaner_native");

                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                DialogResult dialogResult =  MessageBox.Show($"{ex.Message}");
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string warning_Content = string.Empty;
            string warning_Title = string.Empty;
            string abort_Content = string.Empty;
            if (lang == "vi")
            {
                warning_Content = "Khi bạn cài đặt giả lập này, phiên bản giả lập hiện tại sẽ bị gỡ bỏ!\r\nBạn có muốn tiếp tục không?";
                warning_Title = "Cảnh báo!";
                abort_Content = "Quá trình cài đặt đã bị hủy!";

            }
            else if (lang == "en")
            {
                warning_Content = "When you install this emulator, the current emulator version will be uninstalled!\r\nDo you want to continue?";
                warning_Title = "Warning!";
                abort_Content = "The installation process has been aborted!";
            }
            DialogResult dialogResult = MessageBox.Show(warning_Content, warning_Title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                StartUninstall();
                string Ver = string.Empty;
                if (rdo_VerGG.Checked)
                {
                    Ver = "_GG";
                }
                else if (rdo_VerNoGG.Checked)
                {
                    Ver = string.Empty;
                }
                StartInstall(Ver);
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(abort_Content, "");
            }
        }


        private void frm_Main_BS4_Load(object sender, EventArgs e)
        {
            if (lang == "vi")
            {
                this.Text = "BlueStacks Installer - Hiếu GL Lite";
                grp_SelectVer.Text = "Dịch vụ Google";
                lbl_emulator.Text = "Giả lập: BlueStacks 4.240.20";
                rdo_VerGG.Text = "Có";
                rdo_VerNoGG.Text = "Không";
                btn_Start.Text = "Bắt đầu cài đặt";
            }
            else if (lang == "en")
            {
                this.Text = "BlueStacks Installer - Hieu GL Lite";
                grp_SelectVer.Text = "Google Services";
                lbl_emulator.Text = "Emulator: BlueStacks 4.240.20";
                rdo_VerGG.Text = "Yes";
                rdo_VerNoGG.Text = "No";
                btn_Start.Text = "Start install";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_BS4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
