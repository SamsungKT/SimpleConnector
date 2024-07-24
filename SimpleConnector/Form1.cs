using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace SimpleConnector
{
    public partial class Form1 : Form
    {
        string url = "https://www.naver.com";
        string home = "https://www.naver.com";
        string sectionName = "Server"; // Replace with the actual section name
        string cfgContent;
        string ip;
        string port;
        string runExe = "calc.exe";   //
        //string runExe = "Lin.bin.exe";   //   실행할 파일명
        //string dxwndExe = "calc2.exe";
        string dxwndExe = "dxwnd.exe";
        string dxwndIni = "dxwnd.ini";
        string myCfgFile = "SimpleConnector.cfg";
        bool isFullMode = false;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(myCfgFile) == false)
                InitMyCfg();

            ReadMyCfg();

            url = ReadCfgValue(myCfgFile, "URL");
            home = ReadCfgValue(myCfgFile, "HOME");
            runExe = ReadCfgValue(myCfgFile, "RUNEXE");

            GetWebCfg();

            if (cfgContent != null )
            {
                ip = GetWebCfgValue("IP");
                port = GetWebCfgValue("PORT");
                if ( ip != null && port != null)
                {
                    Console.WriteLine($"IP : {ip}, Port : {port}");
                    textRemoteIp.Text = ip;
                    textPort.Text = port;

                    WriteCfgValue(myCfgFile, "IP", ip);
                    WriteCfgValue(myCfgFile, "PORT", port);
                }

            }

            WriteCfgValue(dxwndIni, "exepath", Environment.CurrentDirectory + "\\");
            WriteCfgValue(dxwndIni, "path0", Environment.CurrentDirectory + "\\" + runExe);
            WriteCfgValue(dxwndIni, "launchpath0", Environment.CurrentDirectory + "\\" + runExe + " " + ip + " " + port);


            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Image.FromFile("my.gif");
            //groupBox1.Parent = pictureBox1;

            btn_connect.Parent = pictureBox1; 
            btn_connect.BackColor = Color.Transparent;

            btn_home.Parent = pictureBox1;
            btn_setting.Parent = pictureBox1;



        }

        public void GetWebCfg()
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    cfgContent = webClient.DownloadString(url);
                } catch(Exception ex)
                {
                    Console.WriteLine($"Exception : {ex.Message}");
                }
                
            }
        }

        public string GetWebCfgValue(string keyName)
        {
            var iniParser = new IniParser(cfgContent);
            string value = iniParser.GetValue(sectionName, keyName);

            if (value != null)
            {
                Console.WriteLine($"Value for [{sectionName}] {keyName}: {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"Key [{keyName}] not found in section [{sectionName}].");
                return null;
            }
        }

        private void InitMyCfg()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("SimpleConnector.cfg");
                //Write a line of text
                sw.WriteLine("[Screen]");
                sw.WriteLine("MODE=FULL");
                sw.WriteLine("SIZX0=800");
                sw.WriteLine("SIZY0=600");
                sw.WriteLine("[Server]");
                sw.WriteLine("IP=127.0.0.1");
                sw.WriteLine("PORT=3000");
                sw.WriteLine("URL=https://www.naver.com");
                sw.WriteLine("HOME=https://www.naver.com");
                sw.WriteLine("RUNEXE=TacticsLand.exe");
                sw.WriteLine("DXWNDEXE=dxwnd.exe");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                
            }
        }

        private void ReadMyCfg()
        {
            string mode = ReadCfgValue(myCfgFile, "MODE");
            if(mode != null)
            {
                radioFull.Checked = false;
                radio640.Checked = false;
                radio1280.Checked = false;
                radioCustom.Checked = false;
                textWidth.ReadOnly = true;
                textHeight.ReadOnly = true;
                isFullMode = false;

                switch (mode)
                {
                    case "FULL":
                        radioFull.Checked = true;
                        //WriteCfgValue(myCfgFile, "MODE", "FULL");
                        isFullMode = true;
                        break;
                    case "640":
                        radio640.Checked = true;
                        //WriteCfgValue(myCfgFile, "MODE", "640");
                        WriteCfgValue(dxwndIni, "sizx0", "640");
                        WriteCfgValue(dxwndIni, "sizy0", "480");
                        break;
                    case "1280":
                        radio1280.Checked = true;
                        //WriteCfgValue(myCfgFile, "MODE", "1280");
                        WriteCfgValue(dxwndIni, "sizx0", "1280");
                        WriteCfgValue(dxwndIni, "sizy0", "960");
                        break;
                    case "CUSTOM":
                        radioCustom.Checked = true;
                        //WriteCfgValue(myCfgFile, "MODE", "CUSTOM");

                        textWidth.ReadOnly = false;
                        textHeight.ReadOnly = false;
                        break;

                }
            }

            string width = ReadCfgValue(myCfgFile, "SIZX0");
            string height = ReadCfgValue(myCfgFile, "SIZY0");
            if (width != null)
                textWidth.Text = width;
            if (height != null)
                textHeight.Text = height;

            //WriteCfgValue(dxwndIni, "sizx0", textWidth.Text);
            //WriteCfgValue(dxwndIni, "sizy0", textHeight.Text);
            WriteCfgValue(dxwndIni, "initresw0", textWidth.Text);
            WriteCfgValue(dxwndIni, "initresh0", textHeight.Text);
        }

        private string ReadCfgValue(string filePath, string key)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (line.StartsWith($"{key}="))
                    {
                        return line.Substring(key.Length + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading INI file: {ex.Message}");
            }

            return null; // Key not found or error occurred
        }

        private void WriteCfgValue(string filePath, string key, string value)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding(51949));
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith($"{key}="))
                    {
                        lines[i] = $"{key}={value}";
                        File.WriteAllLines(filePath, lines, Encoding.GetEncoding(51949));
                        return;
                    }
                }

                // Key not found, add a new line
                File.AppendAllText(filePath, $"{key}={value}\n", Encoding.GetEncoding(51949));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to INI file: {ex.Message}");
            }
        }

        public void ProcessdxwndExe()
        {
            string processName = "dxwnd"; // 확인하려는 프로세스 이름
            bool isRunning = IsProcessRunning(processName);

            if (isRunning)
                return;

            try
            {
                Thread.Sleep(500);
                StringBuilder sb = new StringBuilder();
                //sb.AppendFormat("{0} {1:d}", ip, port);
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = dxwndExe;
                //processStartInfo.Arguments = sb.ToString();
                processStartInfo.Verb = "runas";
                processStartInfo.UseShellExecute = false;
                Process process = Process.Start(processStartInfo);
                process.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
            finally
            {

            }

        }

        public void ProcessRunExe(string _ip, string _port)
        {
            try
            {
                Thread.Sleep(500);
                Process process = new Process();
                process.StartInfo.FileName = dxwndExe ; // Replace with your executable
                process.StartInfo.Arguments = "/Y:#1"; // Replace with your arguments
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
            finally
            {

            }

        }

        static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        private void KillDxwnd()
        {
            string processName = "dxwnd"; // Replace with the name of the process you want to check

            // Get all processes with the specified name
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                Console.WriteLine($"{processName} is running. Killing the process...");

                // Kill each process
                foreach (Process process in processes)
                {
                    process.Kill();
                    Console.WriteLine($"Process {process.Id} killed.");
                }
            }
            else
            {
                Console.WriteLine($"{processName} is not running.");
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!isFullMode)
                ProcessdxwndExe();
            if (radioRemote.Checked)
            {
                ProcessRunExe(textRemoteIp.Text, textPort.Text);
            } else
            {
                ProcessRunExe(textLocalIp.Text, textPort.Text);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(home);
        }

        private void radioFull_Click(object sender, EventArgs e)
        {
            if (radioFull.Checked)
            {
                WriteCfgValue(myCfgFile, "MODE", "FULL");
                ReadMyCfg();
            }
        }

        private void radio640_Click(object sender, EventArgs e)
        {
            if (radio640.Checked)
            {
                WriteCfgValue(myCfgFile, "MODE", "640");
                ReadMyCfg();

                KillDxwnd();
            }
        }

        private void radio1280_Click(object sender, EventArgs e)
        {
            if (radio1280.Checked)
            {
                WriteCfgValue(myCfgFile, "MODE", "1280");
                ReadMyCfg();

                KillDxwnd();
            }
        }

        private void radioCustom_Click(object sender, EventArgs e)
        {
            if (radioCustom.Checked)
            {
                WriteCfgValue(myCfgFile, "MODE", "CUSTOM");
                ReadMyCfg();

                KillDxwnd();
            }
        }

        private void textWidth_TextChanged(object sender, EventArgs e)
        {
            WriteCfgValue(myCfgFile, "SIZX0", textWidth.Text);
            WriteCfgValue(dxwndIni, "sizx0", textWidth.Text);
            WriteCfgValue(dxwndIni, "initresw0", textWidth.Text);

            KillDxwnd();
        }

        private void textHeight_TextChanged(object sender, EventArgs e)
        {
            WriteCfgValue(myCfgFile, "SIZY0", textHeight.Text);
            WriteCfgValue(dxwndIni, "sizy0", textHeight.Text);
            WriteCfgValue(dxwndIni, "initresh0", textHeight.Text);

            KillDxwnd();
        }

        private void btn_screen_Click(object sender, EventArgs e)
        {

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1020, 383);
        }

        private void btn_setting_ok_Click(object sender, EventArgs e)
        {
            this.Size = new Size(708, 383);
        }
    }
}
