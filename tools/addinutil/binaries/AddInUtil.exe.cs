using System;
using System.AddIn.Hosting;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: AssemblyTitle("AddInUtil.exe")]
[assembly: AssemblyDescription("AddInUtil.exe")]
[assembly: AssemblyDefaultAlias("AddInUtil.exe")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("4.8.9032.0")]
[assembly: AssemblyInformationalVersion("4.8.9032.0")]
[assembly: SatelliteContractVersion("4.0.0.0")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile("f:\\dd\\tools\\devdiv\\EcmaPublicKey.snk")]
[assembly: AssemblySignatureKey("002400000c800000140100000602000000240000525341310008000001000100613399aff18ef1a2c2514a273a42d9042b72321f1757102df9ebada69923e2738406c21e5b801552ab8d200a65a235e001ac9adc25f2d811eb09496a4c6a59d4619589c69f5baf0c4179a47311d92555cd006acc8b5959f2bd6e10e360c34537a1d266da8085856583c85d81da7f3ec01ed9564c58d93d713cd0172c8e23a10f0239b80c96b07736f5d8b022542a4e74251a5f432824318b3539a5a087f8e53d2f135f9ca47f3bb2e10aff0af0849504fb7cea3ff192dc8de0edad64c68efde34c56d302ad55fd6e80f302d5efcdeae953658d3452561b5f36c542efdbdd9f888538d374cef106acf7d93a4445c3c73cd911f0571aaf3d54da12b11ddec375b3", "a5a866e1ee186f807668209f3b11236ace5e21f117803a3143abb126dd035d7d2f876b6938aaf2ee3414d5420d753621400db44a49c486ce134300a2106adb6bdb433590fef8ad5c43cba82290dc49530effd86523d9483c00f458af46890036b0e2c61d077d7fbac467a506eba29e467a87198b053c749aa2a4d2840c784e6d")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.System32 | DllImportSearchPath.AssemblyDirectory)]
[assembly: AssemblyVersion("4.0.0.0")]
internal static class FXAssembly
{
	internal const string Version = "4.0.0.0";
}
internal static class ThisAssembly
{
	internal const string Title = "AddInUtil.exe";

	internal const string Description = "AddInUtil.exe";

	internal const string DefaultAlias = "AddInUtil.exe";

	internal const string Copyright = "© Microsoft Corporation.  All rights reserved.";

	internal const string Version = "4.0.0.0";

	internal const string InformationalVersion = "4.8.9032.0";

	internal const string DailyBuildNumberStr = "30319";

	internal const string BuildRevisionStr = "0";

	internal const int DailyBuildNumber = 30319;
}
internal static class AssemblyRef
{
	internal const string EcmaPublicKey = "b77a5c561934e089";

	internal const string EcmaPublicKeyToken = "b77a5c561934e089";

	internal const string EcmaPublicKeyFull = "00000000000000000400000000000000";

	internal const string SilverlightPublicKey = "31bf3856ad364e35";

	internal const string SilverlightPublicKeyToken = "31bf3856ad364e35";

	internal const string SilverlightPublicKeyFull = "0024000004800000940000000602000000240000525341310004000001000100B5FC90E7027F67871E773A8FDE8938C81DD402BA65B9201D60593E96C492651E889CC13F1415EBB53FAC1131AE0BD333C5EE6021672D9718EA31A8AEBD0DA0072F25D87DBA6FC90FFD598ED4DA35E44C398C454307E8E33B8426143DAEC9F596836F97C8F74750E5975C64E2189F45DEF46B2A2B1247ADC3652BF5C308055DA9";

	internal const string SilverlightPlatformPublicKey = "7cec85d7bea7798e";

	internal const string SilverlightPlatformPublicKeyToken = "7cec85d7bea7798e";

	internal const string SilverlightPlatformPublicKeyFull = "00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB";

	internal const string PlatformPublicKey = "b77a5c561934e089";

	internal const string PlatformPublicKeyToken = "b77a5c561934e089";

	internal const string PlatformPublicKeyFull = "00000000000000000400000000000000";

	internal const string Mscorlib = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemData = "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemDataOracleClient = "System.Data.OracleClient, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string System = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemCore = "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemNumerics = "System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemRuntimeRemoting = "System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemThreadingTasksDataflow = "System.Threading.Tasks.Dataflow, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemWindowsForms = "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemXml = "System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string MicrosoftPublicKey = "b03f5f7f11d50a3a";

	internal const string MicrosoftPublicKeyToken = "b03f5f7f11d50a3a";

	internal const string MicrosoftPublicKeyFull = "002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293";

	internal const string SharedLibPublicKey = "31bf3856ad364e35";

	internal const string SharedLibPublicKeyToken = "31bf3856ad364e35";

	internal const string SharedLibPublicKeyFull = "0024000004800000940000000602000000240000525341310004000001000100B5FC90E7027F67871E773A8FDE8938C81DD402BA65B9201D60593E96C492651E889CC13F1415EBB53FAC1131AE0BD333C5EE6021672D9718EA31A8AEBD0DA0072F25D87DBA6FC90FFD598ED4DA35E44C398C454307E8E33B8426143DAEC9F596836F97C8F74750E5975C64E2189F45DEF46B2A2B1247ADC3652BF5C308055DA9";

	internal const string SystemComponentModelDataAnnotations = "System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemConfiguration = "System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemConfigurationInstall = "System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemDeployment = "System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemDesign = "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemDirectoryServices = "System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemDrawingDesign = "System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemDrawing = "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemEnterpriseServices = "System.EnterpriseServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemManagement = "System.Management, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemMessaging = "System.Messaging, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemNetHttp = "System.Net.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemNetHttpWebRequest = "System.Net.Http.WebRequest, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemRuntimeSerializationFormattersSoap = "System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemRuntimeWindowsRuntime = "System.Runtime.WindowsRuntime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemRuntimeWindowsRuntimeUIXaml = "System.Runtime.WindowsRuntimeUIXaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemSecurity = "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemServiceModelWeb = "System.ServiceModel.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemServiceProcess = "System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemWeb = "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemWebAbstractions = "System.Web.Abstractions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemWebDynamicData = "System.Web.DynamicData, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemWebDynamicDataDesign = "System.Web.DynamicData.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemWebEntityDesign = "System.Web.Entity.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	internal const string SystemWebExtensions = "System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemWebExtensionsDesign = "System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemWebMobile = "System.Web.Mobile, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemWebRegularExpressions = "System.Web.RegularExpressions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string SystemWebRouting = "System.Web.Routing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string SystemWebServices = "System.Web.Services, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string WindowsBase = "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	internal const string MicrosoftVisualStudio = "Microsoft.VisualStudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string MicrosoftVisualStudioWindowsForms = "Microsoft.VisualStudio.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string VJSharpCodeProvider = "VJSharpCodeProvider, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string ASPBrowserCapsPublicKey = "b7bd7678b977bd8f";

	internal const string ASPBrowserCapsFactory = "ASP.BrowserCapsFactory, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b7bd7678b977bd8f";

	internal const string MicrosoftVSDesigner = "Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string MicrosoftVisualStudioWeb = "Microsoft.VisualStudio.Web, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string MicrosoftWebDesign = "Microsoft.Web.Design.Client, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string MicrosoftVSDesignerMobile = "Microsoft.VSDesigner.Mobile, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	internal const string MicrosoftJScript = "Microsoft.JScript, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
}
namespace System.Tools;

public static class AddInUtil
{
	private static void Usage()
	{
		Console.WriteLine(Strings.Usage, FileVersionInfo.GetVersionInfo(Assembly.GetCallingAssembly().Location).ProductVersion);
	}

	private static void SetConsoleUICulture()
	{
		Thread currentThread = Thread.CurrentThread;
		currentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != Encoding.UTF8.CodePage && Console.OutputEncoding.CodePage != currentThread.CurrentUICulture.TextInfo.OEMCodePage && Console.OutputEncoding.CodePage != currentThread.CurrentUICulture.TextInfo.ANSICodePage)
		{
			currentThread.CurrentUICulture = new CultureInfo("en-US");
		}
	}

	[LoaderOptimization(LoaderOptimization.MultiDomainHost)]
	private static int Main(string[] args)
	{
		SetConsoleUICulture();
		string text = null;
		string text2 = null;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < args.Length; i++)
		{
			if (args[i] == "-?" || args[i] == "/?")
			{
				Usage();
				return 4;
			}
			if (string.Equals("-silent", args[i], StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				continue;
			}
			if (string.Equals("-rebuild", args[i], StringComparison.OrdinalIgnoreCase))
			{
				flag2 = true;
				continue;
			}
			if (args[i].StartsWith("-addinroot:", StringComparison.OrdinalIgnoreCase))
			{
				text2 = args[i].Substring(11);
				continue;
			}
			if (args[i].StartsWith("-pipelineroot:", StringComparison.OrdinalIgnoreCase))
			{
				text = args[i].Substring(14);
				continue;
			}
			Console.Error.WriteLine(string.Format(CultureInfo.CurrentCulture, Strings.UnknownParameter, new object[1] { args[i] }));
			return 3;
		}
		string text3 = (string.IsNullOrEmpty(text) ? text2 : text);
		if (string.IsNullOrEmpty(text3))
		{
			Console.Error.WriteLine(Strings.MustSpecifyPipelineOrAddInRoot);
			return 2;
		}
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
		{
			Console.Error.WriteLine(Strings.MustNotSpecifyBothPipelineOrAddInRoot);
			return 6;
		}
		try
		{
			Path.GetFullPath(text3);
		}
		catch (ArgumentException ex)
		{
			Console.Error.WriteLine(string.Format(CultureInfo.CurrentCulture, Strings.PathInvalid, new object[2] { text3, ex.Message }));
			return 5;
		}
		string[] array = null;
		bool flag3 = false;
		try
		{
			array = ((!string.IsNullOrEmpty(text)) ? ((!flag2) ? AddInStore.Update(text) : AddInStore.Rebuild(text)) : ((!flag2) ? AddInStore.UpdateAddIns(text2) : AddInStore.RebuildAddIns(text2)));
			flag3 = true;
		}
		catch (DirectoryNotFoundException ex2)
		{
			Console.Error.WriteLine(Strings.Error1, ex2.Message);
		}
		catch (AddInSegmentDirectoryNotFoundException ex3)
		{
			Console.Error.WriteLine(Strings.Error1, ex3.Message);
		}
		catch (Exception ex4)
		{
			Console.Error.WriteLine(Strings.Error1, ex4.ToString());
		}
		if (!flag && array != null && array.Length != 0)
		{
			string[] array2 = array;
			foreach (string arg in array2)
			{
				Console.WriteLine(Strings.Warning, arg);
			}
		}
		else if (flag3)
		{
			Console.WriteLine(Strings.Done);
		}
		if (!flag3)
		{
			return 1;
		}
		return 0;
	}
}
[GeneratedCode("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Strings
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("System.Tools.Strings", typeof(Strings).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Done => ResourceManager.GetString("Done", resourceCulture);

	internal static string Error1 => ResourceManager.GetString("Error1", resourceCulture);

	internal static string Error2 => ResourceManager.GetString("Error2", resourceCulture);

	internal static string MustNotSpecifyBothPipelineOrAddInRoot => ResourceManager.GetString("MustNotSpecifyBothPipelineOrAddInRoot", resourceCulture);

	internal static string MustSpecifyPipelineOrAddInRoot => ResourceManager.GetString("MustSpecifyPipelineOrAddInRoot", resourceCulture);

	internal static string PathInvalid => ResourceManager.GetString("PathInvalid", resourceCulture);

	internal static string UnknownParameter => ResourceManager.GetString("UnknownParameter", resourceCulture);

	internal static string Usage => ResourceManager.GetString("Usage", resourceCulture);

	internal static string Warning => ResourceManager.GetString("Warning", resourceCulture);

	internal Strings()
	{
	}
}
