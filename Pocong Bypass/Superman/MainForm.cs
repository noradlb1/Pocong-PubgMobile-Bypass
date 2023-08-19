using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DiscordRPC;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using Superman.Properties;
using SupermanLove;

namespace Superman
{
	// Token: 0x02000011 RID: 17
	public partial class MainForm : Form
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00005ADC File Offset: 0x00003CDC
		public MainForm()
		{
			this.InitializeComponent();
			this.BackColor = Color.Gray;
			base.TransparencyKey = Color.Gray;
			this.timer_0 = new System.Windows.Forms.Timer();
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_0.Interval = (int)TimeSpan.FromHours(24.0).TotalMilliseconds;
			this.timer_0.Start();
		}

		// Token: 0x06000078 RID: 120
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		// Token: 0x06000079 RID: 121
		[DllImport("kernel32.dll")]
		public static extern int Process32First(IntPtr handle, ref MainForm.ProcessEntry32 pe);

		// Token: 0x0600007A RID: 12
		[DllImport("kernel32.dll")]
		public static extern int Process32Next(IntPtr handle, ref MainForm.ProcessEntry32 pe);

	
		[DllImport("user32.dll")]
		public static extern int FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);


		private void kfkjWodJaS(object sender, EventArgs e)
		{
		}

	
		public void system(string arg)
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




		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(MainForm.ThreadAccess threadAccess_0, bool bool_0, uint uint_0);

	
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr intptr_0);

	
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr intptr_0);


		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr intptr_0);

		public void WriteConig(string data)
		{
			string path = "C:\\\\INJETORCONFIG.ini";
			if (!File.Exists(path))
			{
				using (StreamWriter streamWriter = new StreamWriter(path, true))
				{
					streamWriter.WriteLine(data);
					return;
				}
			}
			if (File.Exists(path))
			{
				using (StreamWriter streamWriter2 = new StreamWriter(path, true))
				{
					streamWriter2.WriteLine(data);
				}
			}
		}

	
		[DllImport("MemLib.dll")]
		public static extern void EmuStart();


		[DllImport("MemLib.dll")]
		public static extern void checkkeyok();


		public void Loop()
		{
			do
			{
				this.executee("attrib +h +s +r C:\\Windows\\BypassDone");
				this.executee("attrib +h +s +r C:\\Windows\\EmuFound");
				Thread.Sleep(2000);
				if (File.Exists("C:\\\\Windows\\\\EmuFound"))
				{
					this.executee("attrib -h -s -r C:\\Windows\\EmuFound");
					File.Delete("C:\\\\Windows\\\\EmuFound");
					this.jdIjvSeZrj.Text = "READY...!                                                             ";
					this.jdIjvSeZrj.ForeColor = Color.Lime;
					this.jdIjvSeZrj.Refresh();
					Thread.Sleep(2000);
					this.jdIjvSeZrj.Text = "WAIT FOR BYPASS DONE!                                                             ";
					this.jdIjvSeZrj.ForeColor = Color.Yellow;
					this.jdIjvSeZrj.Refresh();
				}
			}
			while (!File.Exists("C:\\\\Windows\\\\BypassDone"));
			this.executee("attrib -h -s -r C:\\Windows\\BypassDone");
			File.Delete("C:\\\\Windows\\\\BypassDone");
			this.jdIjvSeZrj.Text = "POCONG BYPASS DONE...!                                                             ";
			this.jdIjvSeZrj.ForeColor = Color.Lime;
			this.jdIjvSeZrj.Refresh();
		}

		////////private void guna2GradientTileButton1_Click(object sender, EventArgs e)
		////////{
		////////	MainForm.<Guna2GradientTileButton1_Click>d__35 <Guna2GradientTileButton1_Click>d__ = new MainForm.<Guna2GradientTileButton1_Click>d__35();
		////////	<Guna2GradientTileButton1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		////////	<Guna2GradientTileButton1_Click>d__.<>4__this = this;
		////////	<Guna2GradientTileButton1_Click>d__.sender = sender;
		////////	<Guna2GradientTileButton1_Click>d__.e = e;
		////////	<Guna2GradientTileButton1_Click>d__.<>1__state = -1;
		////////	<Guna2GradientTileButton1_Click>d__.<>t__builder.Start<MainForm.<Guna2GradientTileButton1_Click>d__35>(ref <Guna2GradientTileButton1_Click>d__);
		////////}


		private void exit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000022B2 File Offset: 0x000004B2
		private void jdIjvSeZrj_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005FC4 File Offset: 0x000041C4
		//private void method_3()
		//{
		//	this.discordRpcClient_0 = new DiscordRpcClient("1125958841473970196", -1, null, true, null);
		//	this.discordRpcClient_0.Initialize();
		//	string text = "https://discord.gg/byg";
		//	string text2 = "Join Discord";
			//this.button_0[0] = JsonConvert.DeserializeObject<System.Web.UI.WebControls.Button>(string.Concat(new string[]
			//{
			//	"{\"Url\":\"",
			//	text,
			//	"\", \"Label\":\"",
			//	text2,
			//	"\"}"
			//}));
		//	RichPresence presence = new RichPresence
		//	{
		//		Details = "Pocong with love",
		//		State = "PUBG MOBILE",
		//		Timestamps = Timestamps.Now,
		//		Assets = new Assets
		//		{
		//			LargeImageKey = "https://s12.gifyu.com/images/tenor-29a7a7b400440eeeb.gif",
		//			SmallImageKey = "https://media.giphy.com/media/yoTCgY1ysO7cLfa6s7/giphy.gif"
		//		}
		//	};
		//	this.discordRpcClient_0.SetPresence(presence);
		//}

	
		private void MainForm_Load(object sender, EventArgs e)
		{
			string text = File.ReadAllText("C:\\\\Windows\\\\Expire.txt");
			this.Expire.Text = text;
			this.Expire.ForeColor = Color.Red;
			this.Expire.Refresh();
			//this.method_3();
		}


		private void guna2GradientTileButton2_Click(object sender, EventArgs e)
		{
			new SoundPlayer
			{
				SoundLocation = "C:\\click.wav"
			}.Play();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerAsync();
		}


		private void LOOPEX_CheckedChanged(object sender, EventArgs e)
		{
		}

	
		private void IPADVIEW_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void ProcID_Click(object sender, EventArgs e)
		{
		}


		private void RECOIL_CheckedChanged(object sender, EventArgs e)
		{
		}

	
		private void Minimized_Click(object sender, EventArgs e)
		{
		}

		private void Musicon_Click(object sender, EventArgs e)
		{
			new SoundPlayer
			{
				SoundLocation = "C:\\Windows\\song.wav"
			}.Play();
		}


		private void MusicOff_Click(object sender, EventArgs e)
		{
			new SoundPlayer
			{
				SoundLocation = "C:\\Windows\\song.wav"
			}.Stop();
		}

	
		private void method_5(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/byg");
		}

		private void method_6(object sender, EventArgs e)
		{
			Process.Start("https://t.me/MS_GAM");
		}

		private void method_7(object sender, EventArgs e)
		{
			Process.Start("http://www.byg-shop.com");
		}

		[CompilerGenerated]
		private void timer_0_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("Time Over Again Login Please");
			try
			{
				int num = MainForm.FindWindow(null, "Select RESET NETWORK");
				if (num > 0)
				{
					MainForm.SendMessage(num, 274U, 61536, 0);
				}
				num = MainForm.FindWindow(null, "RESET NETWORK");
				if (num > 0)
				{
					MainForm.SendMessage(num, 274U, 61536, 0);
				}
				this.jdIjvSeZrj.Text = "PROCESSING...                                                          ";
				this.jdIjvSeZrj.Refresh();
				this.jdIjvSeZrj.ForeColor = Color.Red;
				this.jdIjvSeZrj.Refresh();
				this.RECOIL.CheckState = CheckState.Unchecked;
				this.IPADVIEW.CheckState = CheckState.Unchecked;
				this.DEVICEID.CheckState = CheckState.Unchecked;
				Process process = new Process();
				process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					FileName = "cmd.exe",
					CreateNoWindow = true,
					RedirectStandardInput = true,
					UseShellExecute = false
				};
				process.Start();
				using (StreamWriter standardInput = process.StandardInput)
				{
					if (!standardInput.BaseStream.CanWrite)
					{
						return;
					}
					standardInput.WriteLine("taskkill /F /im GameLoader.exe");
					standardInput.WriteLine("TaskKill /F /IM RuntimeBroker.exe");
					standardInput.WriteLine("TaskKill /F /IM QMEmulatorService.exe");
					standardInput.WriteLine("taskkill /F /im TBSWebRenderer.exe");
					standardInput.WriteLine("taskkill /F /im AndroidEmulator.exe");
					standardInput.WriteLine("taskkill /F /im AndroidEmulatorEn.exe");
					standardInput.WriteLine("taskkill /F /im AndroidEmulatorEx.exe");
					standardInput.WriteLine("taskkill /f /im SmartGaGa.exe");
					standardInput.WriteLine("taskkill /f /im ProjectTitan.exe");
					standardInput.WriteLine("taskkill /f /im AndroidProcess.exe");
					standardInput.WriteLine(" taskkill /f /im anubischeats.SG.vmp.exe  ");
					standardInput.WriteLine("taskkill /f /im adb.exe  ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q %USERPROFILE%\appdata\\local\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\Prefetch\\*.* ");
					standardInput.WriteLine("del /f /q /S C: \\Users\\% username %\\Documents\\*.exe  ");
					standardInput.WriteLine("cacls C:\\Users\\%username%\\Documents /E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\Users\\% username %\\AppData\\Local\\Temp /E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\ProgramData / E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\Windows\\Prefetch /E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\Windows\\Temp /E /P everyone:f ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q %USERPROFILE%\appdata\\local\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\Prefetch\\*.* ");
					standardInput.WriteLine("del /f /q /S C: \\Users\\% username %\\Documents\\*.exe ");
					standardInput.WriteLine("netsh firewall reset");
					standardInput.WriteLine("netsh winsock reset ");
					standardInput.WriteLine("netsh int ip reset ");
					standardInput.WriteLine("ipconfig /release ");
					standardInput.WriteLine("ipconfig /renew ");
					standardInput.WriteLine("ipconfig /flushdns ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\Prefetch\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\System32\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q %USERPROFILE%\\appdata\\local\\temp\\*.* ");
					standardInput.Flush();
					standardInput.Close();
					process.WaitForExit();
					File.WriteAllBytes("C:\\Windows\\System32\\drivers\\etc\\hosts", Resources.hosts);
					this.jdIjvSeZrj.Text = "SAFE EXIT DONE";
					this.jdIjvSeZrj.Refresh();
					this.jdIjvSeZrj.ForeColor = Color.Lime;
					this.jdIjvSeZrj.Refresh();
				}
			}
			catch
			{
				this.jdIjvSeZrj.Text = "EROR 404 PLEASE TRY AGAIN       ";
				this.jdIjvSeZrj.ForeColor = Color.Red;
			}
			Environment.Exit(0);
		}

		[CompilerGenerated]
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			//////////this.method_4(1);
		}

		public string userName = Environment.UserName;

		public long enumerable = 0L;

		public string GagaPath = null;

		public Mem MemLib = new Mem();

		public string GameVersion = "";

		public int bypassed = 0;

		private System.Windows.Forms.Timer timer_0;

		private BackgroundWorker backgroundWorker_0;

		//private DiscordRpcClient discordRpcClient_0;

		public const int WM_SYSCOMMAND = 274;

		public const int SC_CLOSE = 61536;

		//private Button[] button_0 = new Button[1];

		public struct ProcessEntry32
		{
			public uint dwSize;

			public uint cntUsage;

			public uint th32ProcessID;

			public IntPtr th32DefaultHeapID;

			public uint th32ModuleID;

			public uint cntThreads;

			public uint uint_0;

			public int pcPriClassBase;

			public uint dwFlags;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}


		public class Data
		{

			public long Address { get; set; }

			[CompilerGenerated]
			private long long_0;
		}

		[Flags]
		public enum ThreadAccess
		{
			TERMINATE = 1,
			SUSPEND_RESUME = 2,
			GET_CONTEXT = 8,
			SET_CONTEXT = 16,
			SET_INFORMATION = 32,
			QUERY_INFORMATION = 64,
			SET_THREAD_TOKEN = 128,
			IMPERSONATE = 256,
			DIRECT_IMPERSONATION = 512
		}
	}
}
