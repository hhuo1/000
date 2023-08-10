using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Creep.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000265F File Offset: 0x0000085F
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000266C File Offset: 0x0000086C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Creep.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000026CB File Offset: 0x000008CB
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000026D4 File Offset: 0x000008D4
		internal static byte[] _000
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("_000", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002704 File Offset: 0x00000904
		internal static byte[] one
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("one", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002734 File Offset: 0x00000934
		internal static byte[] street
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("street", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002764 File Offset: 0x00000964
		internal static byte[] subox
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("subox", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002794 File Offset: 0x00000994
		internal static byte[] texticon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("texticon", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000027C4 File Offset: 0x000009C4
		internal static byte[] txt
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("txt", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000027F4 File Offset: 0x000009F4
		internal static byte[] windl
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("windl", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x0400000F RID: 15
		private static ResourceManager resourceMan;

		// Token: 0x04000010 RID: 16
		private static CultureInfo resourceCulture;
	}
}
