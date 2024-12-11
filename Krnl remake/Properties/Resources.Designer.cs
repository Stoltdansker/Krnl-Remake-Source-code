using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Krnl_remake.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00004725 File Offset: 0x00002925
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004730 File Offset: 0x00002930
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("Krnl_remake.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004778 File Offset: 0x00002978
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000478F File Offset: 0x0000298F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004798 File Offset: 0x00002998
		internal static Bitmap idk__1_
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("idk (1)", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x04000024 RID: 36
		private static ResourceManager resourceMan;

		// Token: 0x04000025 RID: 37
		private static CultureInfo resourceCulture;
	}
}
