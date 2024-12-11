using System;
using System.Windows.Forms;

namespace Krnl_remake
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000470A File Offset: 0x0000290A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
