using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Superman.Properties
{
	// Token: 0x02000020 RID: 32
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000AF68 File Offset: 0x00009168
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040000EC RID: 236
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
