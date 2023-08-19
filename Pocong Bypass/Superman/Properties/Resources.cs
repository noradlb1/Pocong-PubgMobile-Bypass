using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Superman.Properties
{
	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	internal class Resources
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x000022A7 File Offset: 0x000004A7
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000AE38 File Offset: 0x00009038
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					ResourceManager resourceManager = new ResourceManager("Superman.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceManager_0 = resourceManager;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000AE78 File Offset: 0x00009078
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000237C File Offset: 0x0000057C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000AE8C File Offset: 0x0000908C
		internal static Bitmap BYPASSPOCONG
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("BYPASSPOCONG", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000AEB8 File Offset: 0x000090B8
		internal static byte[] click
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("click", Resources.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000AEE4 File Offset: 0x000090E4
		internal static byte[] hosts
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("hosts", Resources.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000AF10 File Offset: 0x00009110
		internal static Bitmap MODE_LOGIN
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("MODE LOGIN", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000AF3C File Offset: 0x0000913C
		internal static byte[] Service
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Service", Resources.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x040000EA RID: 234
		private static ResourceManager resourceManager_0;

		// Token: 0x040000EB RID: 235
		private static CultureInfo cultureInfo_0;
	}
}
