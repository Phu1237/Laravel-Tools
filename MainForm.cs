using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Laravel_Tools
{
    public partial class MainForm : Form
    {
        // Variables
        private string path = "C:\\";
        private bool isLaravel = false;
        // MainForm
        public MainForm()
        {
            InitializeComponent();
        }
        /**
         * Handling function
         */
        // Chạy sau khi đã chọn xong thư mục làm việc
        private void StartHandling()
        {
            if (isLaravel)
            {
                // Xử lí text box hiện đường dẫn
                textBoxPath.Text = path;
                // Xử lí tên project
                string[] arrListStr = path.Split('\\'); // Cat chuoi path bang ki tu \
                int count = arrListStr.Count();
                labelName2.Text = arrListStr[count - 1]; // Lay chuoi cuoi cung cua mang da cat
                // Xử lí version laravel
                string str = GetCommandResult("php artisan -V");
                arrListStr = str.Split(' '); // Cat chuoi path bang ki tu space
                count = arrListStr.Count();
                str = arrListStr[count - 1];
                labelVersion2.Text = str.Trim();
                // Xử lí version PHP
                str = GetCommandResult("php -v");
                arrListStr = str.Split(' '); // Cat chuoi path bang ki tu space
                count = arrListStr.Count();
                str = arrListStr[1];
                labelPHP2.Text = str.Trim();
                // Xử lí version Composer
                str = GetCommandResult("composer -V");
                arrListStr = str.Split(' '); // Cat chuoi path bang ki tu space
                str = arrListStr[2];
                labelComposer2.Text = str.Trim();
                // Dua command vao bang
                HandlingCommandTable(dataGridView1);
            }
        }
        // Kiểm tra xem có phải laravel không
        private bool CheckIsLaravel(string path)
        {
            if (File.Exists(path + @"\artisan"))
            {
                return true;
            }
            return false;
        }
        // Thêm dữ liệu vào cột trong bảng command
        private void HandlingCommandTable(DataGridView dataGridView)
        {
            if (isLaravel)
            {
                string pattern = @"(\w+):(\w+|\w+-\w+)\s+(.*)$";
                string sentence = GetCommandResult("php artisan");

                foreach (Match match in Regex.Matches(sentence, pattern, RegexOptions.Multiline))
                {
                    string itemName = match.Groups[1].Value;
                    itemName = FirstLetterCapital(itemName) + ":" + match.Groups[2].Value;
                    string itemDescription = match.Groups[3].Value;
                    string itemCommand = "php artisan " + match.Groups[1].Value + ":" + match.Groups[2].Value; // php artisan name:command
                    dataGridView.Rows.Add(itemName, itemDescription, itemCommand);
                }
            }
        }
        // Chạy lệnh từ bảng command sau khi nhấn nút
        private void ExecuteCommand(string command)
        {
            if (isLaravel && command != null)
            {

                double TotalProcessorTime = 0;
                // Start the process.
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "cmd";
                startInfo.WorkingDirectory = path;
                startInfo.Arguments = "/C " + command + " " + textBoxAdditionalCMD.Text;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                process.StartInfo = startInfo;
                /* Async process
                process.OutputDataReceived += new DataReceivedEventHandler((s, e) =>
                {
                    textBoxResult.Text += e.Data + Environment.NewLine;
                    textBoxResult.Select(textBoxResult.Text.Length, 0);
                    textBoxResult.ScrollToCaret();
                });*/
                process.Start();
                using (process)
                {
                    // Display the process statistics until
                    // the user closes the program.
                    do
                    {
                        if (!process.HasExited)
                        {
                            labelResultStatus2.Text = "Executing...";
                            // Refresh the current process property values.
                            process.Refresh();
                            textBoxResult.Text = "Command: " + command + " " + textBoxAdditionalCMD.Text + Environment.NewLine + Environment.NewLine;
                            /* Async process
                             * process.BeginOutputReadLine();
                             */

                            textBoxResult.Text += process.StandardOutput.ReadToEnd().Replace("\n", Environment.NewLine);
                            //textBoxResult.Select(textBoxResult.Text.Length, 0);
                            //textBoxResult.ScrollToCaret();
                            TotalProcessorTime = process.TotalProcessorTime.TotalMilliseconds; // Total Procesor Time
                        }
                    }
                    while (!process.WaitForExit(1000));
                    if (!process.HasExited) process.Kill();
                    labelResultStatus2.Text = "Stopped!";
                    textBoxResult.Text += Environment.NewLine + "Process exit code: " + process.ExitCode + Environment.NewLine;
                    textBoxResult.Text += "Process time: " + TotalProcessorTime + "ms";
                }
            }
        }
        // Chạy lệnh từ bảng command sau khi nhấn nút
        private string GetCommandResult(string command)
        {
            if (isLaravel && command != null)
            {
                // Start the process.
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "cmd";
                startInfo.WorkingDirectory = path;
                startInfo.Arguments = "/C " + command;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                process.StartInfo = startInfo;
                process.Start();
                using (process)
                {
                    // Display the process statistics until
                    // the user closes the program.
                    do
                    {
                        if (!process.HasExited)
                        {
                            // Refresh the current process property values.
                            process.Refresh();
                            return process.StandardOutput.ReadToEnd().Replace("\n", Environment.NewLine);
                        }
                    } while (!process.WaitForExit(1000));
                    if (!process.HasExited) process.Kill();
                }
            }
            return "";
        }
        // Viết hoa chữ cái đầu tiên
        private string FirstLetterCapital(string str)
        {
            return Char.ToUpper(str[0]) + str.Remove(0, 1);
        }

        /**
         * Events
         */
        private void ButtonBrowser_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lastUsedFolder != "Desktop" && isLaravel == false)
            {
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.lastUsedFolder;
            }
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Bat dau xu li thong tin lay duoc
                if (isLaravel == true) // Kiểm tra nếu là isLaravel đã từng được set thành true
                {
                    if (CheckIsLaravel(folderBrowserDialog.SelectedPath) == false)
                    {
                        MessageBox.Show("Thư mục được chọn không phải là một project Laravel");
                    }
                } else
                {
                    isLaravel = CheckIsLaravel(folderBrowserDialog.SelectedPath);
                    if (isLaravel)
                    {
                        string path = folderBrowserDialog.SelectedPath;
                        this.path = path;
                        Properties.Settings.Default.lastUsedFolder = path;
                        Properties.Settings.Default.Save();
                        StartHandling();
                    }
                    else
                    {
                        MessageBox.Show("Thư mục được chọn không phải là một project Laravel");
                    }
                }
            }
        }

        private async void ButtonExecute_Click(object sender, EventArgs e)
        {
            string command = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            progressBar.Style = ProgressBarStyle.Marquee;
            await Task.Run(() => ExecuteCommand(command));
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = 100;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
