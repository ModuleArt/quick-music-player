using System;
using System.Windows.Forms;

namespace quick_music_player
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				SetProcessDPIAware();
			}

			ThemeManager.allowDarkModeForApp(true);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
