using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Superman.Properties;

namespace Superman
{

	public partial class LoginForm : Form
	{

		public LoginForm()
		{
			this.InitializeComponent();
		}

	
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}


		public string executee(string arg)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "\\cmd.exe",
				Arguments = "/c " + arg
			};
			process.Start();
			process.WaitForExit();
			return process.StandardOutput.ReadToEnd();
		}

	
		[DllImport("MemLib.dll")]
		public static extern void LoggClck();

	
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}


		private void LoginForm_Load(object sender, EventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				string a = webClient.DownloadString("https://nskmedia.net/rizwan/BPSTOPHERE/Pocong");
				if (a == "KICK")
				{
					MessageBox.Show("Please Recharge Your Panel..Thanks", "Developer");
					Application.Exit();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please Connect To Internet And Start Again.", "Developer");
				Application.Exit();
			}
			if (!File.Exists("C:\\\\Windows\\\\click.wav"))
			{
				File.WriteAllBytes("C:\\click.wav", Resources.click);
			}
			if (!File.Exists("MemLib.dll"))
			{
				using (WebClient webClient2 = new WebClient())
				{
					webClient2.DownloadFile("https://nskmedia.net/rizwan/LOG/Memlib", "C:\\\\ProgramData\\\\MemLib.dll");
					File.Move("C:\\ProgramData\\MemLib.dll", "MemLib.dll");
				}
			}
			this.executee("attrib -h -s -r Temp");
			this.executee("attrib +h +s +r MemLib.dll");
			if (File.Exists("Temp"))
			{
				this.executee("attrib +h +s +r Temp");
				this.executee("attrib -h -s -r MemLib.dll");
				File.Delete("MemLib.dll");
				File.Move("Temp", "MemLib.dll");
			}
			if (File.Exists("C:\\\\BP.lic"))
			{
				this.license.Text = File.ReadAllText("C:\\\\BP.lic");
			}
			if (!File.Exists("C:\\\\Windows\\\\adb.exe"))
			{
				using (WebClient webClient3 = new WebClient())
				{
					webClient3.DownloadFile("https://nskmedia.net/rizwan/LOG/adb", "C:\\\\Windows\\\\adb.exe");
				}
			}
			if (!File.Exists("C:\\\\Windows\\\\AdbWinApi.dll"))
			{
				using (WebClient webClient4 = new WebClient())
				{
					webClient4.DownloadFile("https://nskmedia.net/rizwan/LOG/AdbWinApi", "C:\\\\Windows\\\\AdbWinApi.dll");
				}
			}
		}


		private void method_0(object sender, EventArgs e)
		{
		}


		private void Exit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void method_3(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void LOGINBUTTON_Click(object sender, EventArgs e)
		{
			TextWriter textWriter = new StreamWriter("C:\\\\BP.lic");
			textWriter.Write(this.license.Text);
			textWriter.Close();
			TextWriter textWriter2 = new StreamWriter("C:\\\\Windows\\\\Start");
			textWriter2.Write(this.license.Text);
			textWriter2.Close();
			LoginForm.LoggClck();
			MainForm mainForm = new MainForm();
			mainForm.Show();
			base.Hide();
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}


		
		public const string fileName = "C:\\\\BP.lic";
	}
}
