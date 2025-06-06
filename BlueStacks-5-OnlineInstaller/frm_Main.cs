using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStacks_5_OnlineInstaller
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        Process process = new Process();
        public string lang = string.Empty;




        private void StartInstall(string android,string Ver)
        {

            try
            {

                processStartInfo.FileName = System.IO.Path.Combine(Application.StartupPath,"BlueStacksInstaller_" + android + "_" + Ver + ".exe");
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
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void StartUninstall()
        {
            try
            {

                processStartInfo.FileName = System.IO.Path.Combine(Application.StartupPath, "BSTCleaner_native", "BSTCleaner.exe");
                processStartInfo.Arguments = "-oem nxt";
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                processStartInfo.WorkingDirectory = System.IO.Path.Combine(Application.StartupPath, "BSTCleaner_native");

                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
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
                string androidVersion = string.Empty;
                string Ver = string.Empty;
                if (cbo_Android.SelectedIndex == 0)
                {
                    androidVersion = "Nougat32";
                } else if (cbo_Android.SelectedIndex == 1)
                {
                    androidVersion = "Pie64";
                }
                if (rdo_VerGG.Checked)
                {
                    Ver = "GG";
                }
                else if (rdo_VerNoGG.Checked)
                {
                    Ver = "NoGG";
                }
                StartInstall(androidVersion, Ver);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(abort_Content, "");
            }
        }

        private void grp_SelectVer_Enter(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cbo_Android.Items.Add("Android 7 (32bit)");
            cbo_Android.Items.Add("Android 9 (64bit)");
            cbo_Android.SelectedIndex = 0;
            if (lang == "vi")
            {
                this.Text = "BlueStacks Installer - Hiếu GL Lite";
                lbl_EmuName.Text = "Giả lập: BlueStacks 5.22.51";
                lbl_Android.Text = "Phiên bản Android:";
                grp_SelectVer.Text = "Dịch vụ Google";
                rdo_VerGG.Text = "Có";
                rdo_VerNoGG.Text = "Không";
                btn_Start.Text = "Bắt đầu cài đặt";
            }
            else if (lang == "en")
            {
                this.Text = "BlueStacks Installer - Hieu GL Lite";
                lbl_EmuName.Text = "Emulator: BlueStacks 5.22.51";
                lbl_Android.Text = "Android version:";
                grp_SelectVer.Text = "Google Services";
                rdo_VerGG.Text = "Yes";
                rdo_VerNoGG.Text = "No";
                btn_Start.Text = "Start installation";
            }
        }
      
    

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
