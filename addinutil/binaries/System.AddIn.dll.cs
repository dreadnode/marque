#define TRACE
using System;
using System.AddIn.Contract;
using System.AddIn.Hosting;
using System.AddIn.MiniReflection;
using System.AddIn.MiniReflection.MetadataReader;
using System.AddIn.Pipeline;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;

[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: SecurityCritical]
[assembly: StringFreezing]
[assembly: DefaultDependency(LoadHint.Always)]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: SecurityRules(SecurityRuleSet.Level1, SkipVerificationInFullTrust = true)]
[assembly: AssemblyTitle("System.AddIn.dll")]
[assembly: AssemblyDescription("System.AddIn.dll")]
[assembly: AssemblyDefaultAlias("System.AddIn.dll")]
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
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("4.0.0.0")]
[module: UnverifiableCode]
internal static class FXAssembly
{
	internal const string Version = "4.0.0.0";
}
internal static class ThisAssembly
{
	internal const string Title = "System.AddIn.dll";

	internal const string Description = "System.AddIn.dll";

	internal const string DefaultAlias = "System.AddIn.dll";

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
namespace System
{
	[GeneratedCode("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Res
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
					ResourceManager resourceManager = new ResourceManager("System.Res", typeof(Res).Assembly);
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

		internal static string AddInAdapterLoadedInWrongAppDomain => ResourceManager.GetString("AddInAdapterLoadedInWrongAppDomain", resourceCulture);

		internal static string AddInAdapterMustBeMBRO => ResourceManager.GetString("AddInAdapterMustBeMBRO", resourceCulture);

		internal static string AddInAdapterMustImplementAnAddInContract => ResourceManager.GetString("AddInAdapterMustImplementAnAddInContract", resourceCulture);

		internal static string AddInAdapterNoUsableConstructors => ResourceManager.GetString("AddInAdapterNoUsableConstructors", resourceCulture);

		internal static string AddInAdapterOneUnusableConstructor => ResourceManager.GetString("AddInAdapterOneUnusableConstructor", resourceCulture);

		internal static string AddInAdapterToString => ResourceManager.GetString("AddInAdapterToString", resourceCulture);

		internal static string AddInBaseMustBeSubclassable => ResourceManager.GetString("AddInBaseMustBeSubclassable", resourceCulture);

		internal static string AddInBaseToString => ResourceManager.GetString("AddInBaseToString", resourceCulture);

		internal static string AddInInAddInViewFolder => ResourceManager.GetString("AddInInAddInViewFolder", resourceCulture);

		internal static string AddInMustSpecifyName => ResourceManager.GetString("AddInMustSpecifyName", resourceCulture);

		internal static string AddInNameEmpty => ResourceManager.GetString("AddInNameEmpty", resourceCulture);

		internal static string AddInNoLongerAvailable => ResourceManager.GetString("AddInNoLongerAvailable", resourceCulture);

		internal static string AddInToString => ResourceManager.GetString("AddInToString", resourceCulture);

		internal static string AppDomainNull => ResourceManager.GetString("AppDomainNull", resourceCulture);

		internal static string AssemblyLoadFileNotFound => ResourceManager.GetString("AssemblyLoadFileNotFound", resourceCulture);

		internal static string AssemblyLoadRefDefMismatch => ResourceManager.GetString("AssemblyLoadRefDefMismatch", resourceCulture);

		internal static string AssemblyLoadThrew => ResourceManager.GetString("AssemblyLoadThrew", resourceCulture);

		internal static string BadPEFile => ResourceManager.GetString("BadPEFile", resourceCulture);

		internal static string BadRVA => ResourceManager.GetString("BadRVA", resourceCulture);

		internal static string CantDeserializeData => ResourceManager.GetString("CantDeserializeData", resourceCulture);

		internal static string CantFindDeployedAddInsFile => ResourceManager.GetString("CantFindDeployedAddInsFile", resourceCulture);

		internal static string CantFindTypeName => ResourceManager.GetString("CantFindTypeName", resourceCulture);

		internal static string CodedIntegerTooLong => ResourceManager.GetString("CodedIntegerTooLong", resourceCulture);

		internal static string ComponentInWrongLocation => ResourceManager.GetString("ComponentInWrongLocation", resourceCulture);

		internal static string ComponentUnusableBecauseItIsGeneric => ResourceManager.GetString("ComponentUnusableBecauseItIsGeneric", resourceCulture);

		internal static string ContractAssemblyLoadedMultipleTimes => ResourceManager.GetString("ContractAssemblyLoadedMultipleTimes", resourceCulture);

		internal static string ContractMustBeInterface => ResourceManager.GetString("ContractMustBeInterface", resourceCulture);

		internal static string ContractMustImplementIContract => ResourceManager.GetString("ContractMustImplementIContract", resourceCulture);

		internal static string ContractToString => ResourceManager.GetString("ContractToString", resourceCulture);

		internal static string ControllerNotFound => ResourceManager.GetString("ControllerNotFound", resourceCulture);

		internal static string CouldNotCreateAddInProcess => ResourceManager.GetString("CouldNotCreateAddInProcess", resourceCulture);

		internal static string CouldntConnectNInvalidParts => ResourceManager.GetString("CouldntConnectNInvalidParts", resourceCulture);

		internal static string CouldntConnectOnePart => ResourceManager.GetString("CouldntConnectOnePart", resourceCulture);

		internal static string DeployedAddInsFileCorrupted => ResourceManager.GetString("DeployedAddInsFileCorrupted", resourceCulture);

		internal static string FailedToUnloadAppDomain => ResourceManager.GetString("FailedToUnloadAppDomain", resourceCulture);

		internal static string FileInAddInFolder => ResourceManager.GetString("FileInAddInFolder", resourceCulture);

		internal static string FileNotFoundForInspection => ResourceManager.GetString("FileNotFoundForInspection", resourceCulture);

		internal static string FolderNotFound => ResourceManager.GetString("FolderNotFound", resourceCulture);

		internal static string GenericSecurityExceptionMessage => ResourceManager.GetString("GenericSecurityExceptionMessage", resourceCulture);

		internal static string HostAdapterNoValidCtors => ResourceManager.GetString("HostAdapterNoValidCtors", resourceCulture);

		internal static string HostAdapterToString => ResourceManager.GetString("HostAdapterToString", resourceCulture);

		internal static string HostAdapterUnusableBecauseItIsGeneric => ResourceManager.GetString("HostAdapterUnusableBecauseItIsGeneric", resourceCulture);

		internal static string HostAdapterUnusableCtorBadParam => ResourceManager.GetString("HostAdapterUnusableCtorBadParam", resourceCulture);

		internal static string HostAdapterUnusableCtorMultipleParams => ResourceManager.GetString("HostAdapterUnusableCtorMultipleParams", resourceCulture);

		internal static string HostViewUnusableBecauseItIsGeneric => ResourceManager.GetString("HostViewUnusableBecauseItIsGeneric", resourceCulture);

		internal static string IncompatibleAddInBaseAssembly => ResourceManager.GetString("IncompatibleAddInBaseAssembly", resourceCulture);

		internal static string InspectingAssemblyThrew => ResourceManager.GetString("InspectingAssemblyThrew", resourceCulture);

		internal static string Invalid64bitPlatformOn32bitOS => ResourceManager.GetString("Invalid64bitPlatformOn32bitOS", resourceCulture);

		internal static string InvalidCompressedInt => ResourceManager.GetString("InvalidCompressedInt", resourceCulture);

		internal static string InvalidMetadataToken => ResourceManager.GetString("InvalidMetadataToken", resourceCulture);

		internal static string InvalidMetadataTokenNilTable => ResourceManager.GetString("InvalidMetadataTokenNilTable", resourceCulture);

		internal static string InvalidMetadataTokenTooManyRows => ResourceManager.GetString("InvalidMetadataTokenTooManyRows", resourceCulture);

		internal static string InvalidPipelineStoreExceptionMessage => ResourceManager.GetString("InvalidPipelineStoreExceptionMessage", resourceCulture);

		internal static string InvalidPipelineStoreLocation => ResourceManager.GetString("InvalidPipelineStoreLocation", resourceCulture);

		internal static string LifetimeTokenNotFound => ResourceManager.GetString("LifetimeTokenNotFound", resourceCulture);

		internal static string MakeRelativePathArgs => ResourceManager.GetString("MakeRelativePathArgs", resourceCulture);

		internal static string MissingAddInProcessExecutable => ResourceManager.GetString("MissingAddInProcessExecutable", resourceCulture);

		internal static string MissingAddInProcessRegistryPath => ResourceManager.GetString("MissingAddInProcessRegistryPath", resourceCulture);

		internal static string MultiFileAssembliesNotSupported => ResourceManager.GetString("MultiFileAssembliesNotSupported", resourceCulture);

		internal static string MultiModuleAssembliesNotSupported => ResourceManager.GetString("MultiModuleAssembliesNotSupported", resourceCulture);

		internal static string MultipleAddInBaseInterfaces => ResourceManager.GetString("MultipleAddInBaseInterfaces", resourceCulture);

		internal static string MustSpecifySecurityLevel => ResourceManager.GetString("MustSpecifySecurityLevel", resourceCulture);

		internal static string NeedSecurityFlags => ResourceManager.GetString("NeedSecurityFlags", resourceCulture);

		internal static string NilMetadataToken => ResourceManager.GetString("NilMetadataToken", resourceCulture);

		internal static string NoAddInBase => ResourceManager.GetString("NoAddInBase", resourceCulture);

		internal static string NoAddInBaseFound => ResourceManager.GetString("NoAddInBaseFound", resourceCulture);

		internal static string NoAddInFound => ResourceManager.GetString("NoAddInFound", resourceCulture);

		internal static string NoAddInModelPartsFound => ResourceManager.GetString("NoAddInModelPartsFound", resourceCulture);

		internal static string NoDefaultConstructor => ResourceManager.GetString("NoDefaultConstructor", resourceCulture);

		internal static string NoStrongName => ResourceManager.GetString("NoStrongName", resourceCulture);

		internal static string NotImplementedFeatureBadCtorParamOrAssembly => ResourceManager.GetString("NotImplementedFeatureBadCtorParamOrAssembly", resourceCulture);

		internal static string OperationNotValidOnCurrentProcess => ResourceManager.GetString("OperationNotValidOnCurrentProcess", resourceCulture);

		internal static string PartialTrustCannotActivate => ResourceManager.GetString("PartialTrustCannotActivate", resourceCulture);

		internal static string PathCantBeEmpty => ResourceManager.GetString("PathCantBeEmpty", resourceCulture);

		internal static string PipelineFolderNotFound => ResourceManager.GetString("PipelineFolderNotFound", resourceCulture);

		internal static string ProcessAlreadyRunning => ResourceManager.GetString("ProcessAlreadyRunning", resourceCulture);

		internal static string ProcessNotRunning => ResourceManager.GetString("ProcessNotRunning", resourceCulture);

		internal static string TokenCountZero => ResourceManager.GetString("TokenCountZero", resourceCulture);

		internal static string TypeCantBeEmpty => ResourceManager.GetString("TypeCantBeEmpty", resourceCulture);

		internal static string TypedByRefNotAllowed => ResourceManager.GetString("TypedByRefNotAllowed", resourceCulture);

		internal static string TypeNotFound => ResourceManager.GetString("TypeNotFound", resourceCulture);

		internal static string TypeShouldBeSerializableOrIContract => ResourceManager.GetString("TypeShouldBeSerializableOrIContract", resourceCulture);

		internal static string UnexpectedlyLoadingASatellite => ResourceManager.GetString("UnexpectedlyLoadingASatellite", resourceCulture);

		internal static string UnknownMetadataTable => ResourceManager.GetString("UnknownMetadataTable", resourceCulture);

		internal static string UnknownNamedAddInAttributeParameter => ResourceManager.GetString("UnknownNamedAddInAttributeParameter", resourceCulture);

		internal static string UnknownTokenType => ResourceManager.GetString("UnknownTokenType", resourceCulture);

		internal static string UnparsibleConstructorSignature => ResourceManager.GetString("UnparsibleConstructorSignature", resourceCulture);

		internal static string UnrecognizedCorElementType => ResourceManager.GetString("UnrecognizedCorElementType", resourceCulture);

		internal static string UnspecifiedUpdateWarningsInPartialTrust => ResourceManager.GetString("UnspecifiedUpdateWarningsInPartialTrust", resourceCulture);

		internal static string UnsupportedInterfaceType => ResourceManager.GetString("UnsupportedInterfaceType", resourceCulture);

		internal Res()
		{
		}
	}
}
namespace System.Collections.ObjectModel
{
	[Serializable]
	internal class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private IDictionary<TKey, TValue> m_dictionary;

		public TValue this[TKey key]
		{
			get
			{
				return m_dictionary[key];
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public ICollection<TKey> Keys => m_dictionary.Keys;

		public ICollection<TValue> Values => m_dictionary.Values;

		public int Count => m_dictionary.Count;

		public bool IsReadOnly => true;

		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			m_dictionary = dictionary;
		}

		public void Add(TKey key, TValue value)
		{
			throw new NotSupportedException();
		}

		public bool ContainsKey(TKey key)
		{
			return m_dictionary.ContainsKey(key);
		}

		public bool Remove(TKey key)
		{
			throw new NotSupportedException();
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return m_dictionary.TryGetValue(key, out value);
		}

		public void Add(KeyValuePair<TKey, TValue> pair)
		{
			throw new NotSupportedException();
		}

		public void Clear()
		{
			throw new NotSupportedException();
		}

		public bool Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return m_dictionary.Contains(keyValuePair);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			m_dictionary.CopyTo(array, arrayIndex);
		}

		public bool Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw new NotSupportedException();
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return m_dictionary.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
namespace System.AddIn
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class AddInAttribute : Attribute
	{
		private string _name;

		private string _publisher;

		private string _version;

		private string _description;

		public string Name => _name;

		public string Publisher
		{
			get
			{
				return _publisher;
			}
			set
			{
				_publisher = value;
			}
		}

		public string Version
		{
			get
			{
				return _version;
			}
			set
			{
				_version = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public AddInAttribute(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length <= 0)
			{
				throw new ArgumentException(Res.AddInNameEmpty);
			}
			_name = name;
		}
	}
	[Serializable]
	internal class ResourceState
	{
		internal string Name;

		internal string Publisher;

		internal string Description;
	}
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	internal static class NativeMethods
	{
		[DllImport("KERNEL32.DLL", ExactSpelling = true, SetLastError = true)]
		internal static extern bool IsWow64Process(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool bIsWow);
	}
	[Serializable]
	internal sealed class AddIn : PipelineComponent
	{
		private System.AddIn.MiniReflection.TypeInfo[] _potentialAddinBases;

		private string _version;

		private string _assemblyName;

		private ResourceState _unlocalized;

		[NonSerialized]
		private string _fullPathToAddIn;

		public ResourceState UnlocalizedResourceState => _unlocalized;

		public string AddInName => _unlocalized.Name;

		public string Publisher => _unlocalized.Publisher;

		public string Description => _unlocalized.Description;

		public AssemblyName AssemblyName => new AssemblyName(_assemblyName);

		public string Version => _version;

		internal System.AddIn.MiniReflection.TypeInfo[] AddInBaseTypeInfo => _potentialAddinBases;

		internal AddIn(System.AddIn.MiniReflection.TypeInfo typeInfo, string assemblyLocation, string fullPathToAddin, string assemblyName)
			: base(typeInfo, assemblyLocation)
		{
			_fullPathToAddIn = fullPathToAddin;
			_assemblyName = assemblyName;
			_unlocalized = new ResourceState();
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, Res.AddInToString, new object[2] { base.Name, base.BestAvailableLocation });
		}

		internal override bool Validate(System.AddIn.MiniReflection.TypeInfo type, Collection<string> warnings)
		{
			Type typeFromHandle = typeof(AddInAttribute);
			MiniCustomAttributeInfo[] customAttributeInfos = type.GetCustomAttributeInfos(typeFromHandle);
			if (customAttributeInfos.Length != 0)
			{
				MiniCustomAttributeInfo miniCustomAttributeInfo = customAttributeInfos[0];
				_unlocalized.Name = (string)miniCustomAttributeInfo.FixedArgs[0].Value;
				MiniCustomAttributeNamedArgInfo[] namedArgs = miniCustomAttributeInfo.NamedArgs;
				foreach (MiniCustomAttributeNamedArgInfo miniCustomAttributeNamedArgInfo in namedArgs)
				{
					switch (miniCustomAttributeNamedArgInfo.Name)
					{
					case "Description":
						_unlocalized.Description = (string)miniCustomAttributeNamedArgInfo.Value;
						continue;
					case "Version":
						_version = (string)miniCustomAttributeNamedArgInfo.Value;
						continue;
					case "Publisher":
						_unlocalized.Publisher = (string)miniCustomAttributeNamedArgInfo.Value;
						continue;
					}
					warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.UnknownNamedAddInAttributeParameter, new object[3]
					{
						miniCustomAttributeNamedArgInfo.Name,
						type.FullName,
						type.Assembly.ModuleName
					}));
				}
			}
			if (string.IsNullOrEmpty(_unlocalized.Name))
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInMustSpecifyName, new object[2]
				{
					type.FullName,
					type.Assembly.ModuleName
				}));
				return false;
			}
			bool flag = false;
			MiniConstructorInfo[] constructors = type.GetConstructors();
			foreach (MiniConstructorInfo miniConstructorInfo in constructors)
			{
				MiniParameterInfo[] parameters = miniConstructorInfo.GetParameters();
				if (parameters.Length == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.NoDefaultConstructor, new object[2]
				{
					type.FullName,
					type.Assembly.ModuleName
				}));
				return false;
			}
			_potentialAddinBases = PipelineComponent.FindBaseTypesAndInterfaces(type);
			if (_potentialAddinBases.Length == 0)
			{
				return false;
			}
			return base.Validate(type, warnings);
		}
	}
	[Serializable]
	internal sealed class AddInAdapter : PipelineComponent
	{
		private List<System.AddIn.MiniReflection.TypeInfo> _contracts;

		private List<System.AddIn.MiniReflection.TypeInfo> _constructors;

		public List<System.AddIn.MiniReflection.TypeInfo> Constructors => _constructors;

		public List<System.AddIn.MiniReflection.TypeInfo> Contracts => _contracts;

		public AddInAdapter(System.AddIn.MiniReflection.TypeInfo typeInfo, string assemblyLocation)
			: base(typeInfo, assemblyLocation)
		{
			_contracts = new List<System.AddIn.MiniReflection.TypeInfo>();
			_constructors = new List<System.AddIn.MiniReflection.TypeInfo>();
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterToString, new object[2] { base.Name, base.BestAvailableLocation });
		}

		internal override bool Validate(Type type, Collection<string> warnings)
		{
			if (!type.IsMarshalByRef)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterMustBeMBRO, new object[1] { type.AssemblyQualifiedName }));
				return false;
			}
			if (!PipelineComponent.IContractInReflectionLoaderContext.IsAssignableFrom(type))
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterMustImplementAnAddInContract, new object[1] { type.AssemblyQualifiedName }));
				return false;
			}
			Type[] interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				if (PipelineComponent.IContractInReflectionLoaderContext.IsAssignableFrom(type2))
				{
					_contracts.Add(new System.AddIn.MiniReflection.TypeInfo(type2));
				}
			}
			if (_contracts.Count == 0)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterMustImplementAnAddInContract, new object[1] { type.AssemblyQualifiedName }));
				return false;
			}
			ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (ConstructorInfo constructorInfo in constructors)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				if (parameters.Length != 1)
				{
					warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterOneUnusableConstructor, new object[1] { type.AssemblyQualifiedName }));
				}
				else
				{
					_constructors.Add(new System.AddIn.MiniReflection.TypeInfo(parameters[0].ParameterType));
				}
			}
			if (_constructors.Count == 0)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterNoUsableConstructors, new object[1] { type.AssemblyQualifiedName }));
				return false;
			}
			return base.Validate(type, warnings);
		}

		internal bool CanConnectTo(AddInBase addInBase)
		{
			if (!addInBase.TypeInfo.IsGeneric)
			{
				if (Constructors.Contains(addInBase.TypeInfo))
				{
					return true;
				}
				if (addInBase._activatableAs != null)
				{
					System.AddIn.MiniReflection.TypeInfo[] activatableAs = addInBase._activatableAs;
					foreach (System.AddIn.MiniReflection.TypeInfo item in activatableAs)
					{
						if (Constructors.Contains(item))
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}
	}
	[Serializable]
	internal sealed class AddInBase : PipelineComponent
	{
		internal System.AddIn.MiniReflection.TypeInfo[] _activatableAs;

		internal string _assemblyName;

		public AddInBase(System.AddIn.MiniReflection.TypeInfo typeInfo, System.AddIn.MiniReflection.TypeInfo[] activatableAs, string assemblyLocation, string assemblyName)
			: base(typeInfo, assemblyLocation)
		{
			_activatableAs = activatableAs;
			_assemblyName = assemblyName;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, Res.AddInBaseToString, new object[2] { base.Name, base.BestAvailableLocation });
		}

		internal override bool Validate(Type type, Collection<string> warnings)
		{
			if (type.IsClass && type.IsSealed)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInBaseMustBeSubclassable, new object[1] { base.Name }));
				return false;
			}
			return base.Validate(type, warnings);
		}

		internal bool CanDirectConnectTo(System.AddIn.MiniReflection.TypeInfo havTypeInfo)
		{
			bool flag = false;
			if (havTypeInfo.Equals(base.TypeInfo))
			{
				flag = true;
			}
			else if (_activatableAs != null)
			{
				for (int i = 0; i < _activatableAs.Length; i++)
				{
					if (flag)
					{
						break;
					}
					if (_activatableAs[i].Equals(havTypeInfo))
					{
						flag = true;
					}
				}
			}
			return flag;
		}
	}
	[Serializable]
	internal sealed class ContractComponent : PipelineComponent
	{
		public ContractComponent(System.AddIn.MiniReflection.TypeInfo typeInfo, string assemblyLocation)
			: base(typeInfo, assemblyLocation)
		{
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, Res.ContractToString, new object[2] { base.Name, base.BestAvailableLocation });
		}

		internal override bool Validate(Type type, Collection<string> warnings)
		{
			if (!PipelineComponent.IContractInReflectionLoaderContext.IsAssignableFrom(type))
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.ContractMustImplementIContract, new object[1] { base.Name }));
				return false;
			}
			if (!type.IsInterface)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.ContractMustBeInterface, new object[1] { base.Name }));
				return false;
			}
			return base.Validate(type, warnings);
		}
	}
	[Serializable]
	internal sealed class HostAdapter : PipelineComponent
	{
		private static readonly System.AddIn.MiniReflection.TypeInfo typeofIContract = new System.AddIn.MiniReflection.TypeInfo(typeof(IContract));

		private System.AddIn.MiniReflection.TypeInfo[] _potentialHAVs;

		private List<System.AddIn.MiniReflection.TypeInfo> _constructors;

		public List<System.AddIn.MiniReflection.TypeInfo> Constructors => _constructors;

		public System.AddIn.MiniReflection.TypeInfo[] HostAddinViews => _potentialHAVs;

		public HostAdapter(System.AddIn.MiniReflection.TypeInfo typeInfo, string assemblyLocation)
			: base(typeInfo, assemblyLocation)
		{
			_constructors = new List<System.AddIn.MiniReflection.TypeInfo>();
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, Res.HostAdapterToString, new object[2] { base.Name, base.BestAvailableLocation });
		}

		internal override bool Validate(System.AddIn.MiniReflection.TypeInfo type, Collection<string> warnings)
		{
			_potentialHAVs = PipelineComponent.FindBaseTypesAndInterfaces(type);
			if (_potentialHAVs.Length == 0)
			{
				return false;
			}
			MiniConstructorInfo[] constructors = type.GetConstructors(includePrivate: true);
			foreach (MiniConstructorInfo miniConstructorInfo in constructors)
			{
				MiniParameterInfo[] parameters = miniConstructorInfo.GetParameters();
				if (parameters.Length != 1)
				{
					warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.HostAdapterUnusableCtorMultipleParams, new object[1] { type.AssemblyQualifiedName }));
					continue;
				}
				System.AddIn.MiniReflection.TypeInfo parameterType = parameters[0].ParameterType;
				bool flag = false;
				try
				{
					if (parameterType.IsInterface && parameterType.Implements(typeofIContract))
					{
						_constructors.Add(parameterType);
						flag = true;
					}
				}
				catch (FileNotFoundException)
				{
				}
				catch (FileLoadException)
				{
				}
				if (!flag)
				{
					warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.HostAdapterUnusableCtorBadParam, new object[2] { type.AssemblyQualifiedName, parameterType.FullName }));
				}
			}
			if (_constructors.Count == 0)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.HostAdapterNoValidCtors, new object[1] { type.AssemblyQualifiedName }));
				return false;
			}
			return base.Validate(type, warnings);
		}
	}
	[Serializable]
	internal enum PipelineComponentType
	{
		HostAdapter,
		Contract,
		AddInAdapter,
		AddInBase,
		AddIn
	}
	[Serializable]
	internal abstract class PipelineComponent
	{
		private System.AddIn.MiniReflection.TypeInfo _typeInfo;

		private string _location;

		private string _relativeLocation;

		private bool _connectedToNeighbors;

		private bool _haveSetRootDirectory;

		private IDictionary<string, string> _qualificationData;

		internal static readonly IDictionary<string, string> s_emptyDictionary = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());

		private static volatile Type s_IContractInReflectionLoaderContext;

		private static volatile Type s_ContractAttrInReflectionLoaderContext;

		private static volatile Type s_AddInAdapterAttrInReflectionLoaderContext;

		private static volatile Type s_AddInBaseAttrInReflectionLoaderContext;

		private static volatile Type s_AddInAttrInReflectionLoaderContext;

		private static volatile Type s_QualificationDataAttrInReflectionLoaderContext;

		internal IDictionary<string, string> QualificationData => _qualificationData;

		protected static Type IContractInReflectionLoaderContext => s_IContractInReflectionLoaderContext;

		internal static Type ContractAttributeInReflectionLoaderContext => s_ContractAttrInReflectionLoaderContext;

		internal static Type AddInAdapterAttributeInReflectionLoaderContext => s_AddInAdapterAttrInReflectionLoaderContext;

		internal static Type AddInBaseAttributeInReflectionLoaderContext => s_AddInBaseAttrInReflectionLoaderContext;

		internal static Type AddInAttributeInReflectionLoaderContext => s_AddInAttrInReflectionLoaderContext;

		public string Location => _location;

		internal string RelativeLocation => _relativeLocation;

		protected string BestAvailableLocation
		{
			get
			{
				if (_haveSetRootDirectory)
				{
					return _location;
				}
				return _relativeLocation;
			}
		}

		public string Name => _typeInfo.Name;

		public System.AddIn.MiniReflection.TypeInfo TypeInfo => _typeInfo;

		public string FullName => _typeInfo.FullName;

		public bool ConnectedToNeighbors
		{
			get
			{
				return _connectedToNeighbors;
			}
			set
			{
				_connectedToNeighbors = value;
			}
		}

		internal PipelineComponent(System.AddIn.MiniReflection.TypeInfo typeInfo, string assemblyLocation)
		{
			if (typeInfo == null)
			{
				throw new ArgumentNullException("typeInfo");
			}
			if (assemblyLocation == null)
			{
				throw new ArgumentNullException("assemblyLocation");
			}
			_typeInfo = typeInfo;
			if (Path.IsPathRooted(assemblyLocation))
			{
				_location = assemblyLocation;
				_haveSetRootDirectory = true;
			}
			else
			{
				_relativeLocation = assemblyLocation;
			}
			if (_typeInfo.HasReflectionType)
			{
				IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(_typeInfo.ReflectionType);
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (CustomAttributeData item in customAttributes)
				{
					if ((object)item.Constructor.DeclaringType == s_QualificationDataAttrInReflectionLoaderContext)
					{
						IList<CustomAttributeTypedArgument> constructorArguments = item.ConstructorArguments;
						string key = (string)constructorArguments[0].Value;
						string value = (string)constructorArguments[1].Value;
						dictionary[key] = value;
					}
				}
				IDictionary<string, string> qualificationData;
				if (dictionary.Count != 0)
				{
					IDictionary<string, string> dictionary2 = new ReadOnlyDictionary<string, string>(dictionary);
					qualificationData = dictionary2;
				}
				else
				{
					qualificationData = s_emptyDictionary;
				}
				_qualificationData = qualificationData;
				return;
			}
			Type typeFromHandle = typeof(QualificationDataAttribute);
			MiniCustomAttributeInfo[] customAttributeInfos = typeInfo.GetCustomAttributeInfos(typeFromHandle);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			if (customAttributeInfos != null && customAttributeInfos.Length != 0)
			{
				MiniCustomAttributeInfo[] array = customAttributeInfos;
				foreach (MiniCustomAttributeInfo miniCustomAttributeInfo in array)
				{
					MiniCustomAttributeFixedArgInfo[] fixedArgs = miniCustomAttributeInfo.FixedArgs;
					string key2 = (string)fixedArgs[0].Value;
					string value2 = (string)fixedArgs[1].Value;
					dictionary3[key2] = value2;
				}
			}
			IDictionary<string, string> qualificationData2;
			if (dictionary3.Count != 0)
			{
				IDictionary<string, string> dictionary2 = new ReadOnlyDictionary<string, string>(dictionary3);
				qualificationData2 = dictionary2;
			}
			else
			{
				qualificationData2 = s_emptyDictionary;
			}
			_qualificationData = qualificationData2;
		}

		internal static void SetTypesFromReflectionLoaderContext(Assembly systemAddInInReflLoaderContext, Assembly systemAddInContractsInReflLoaderContext)
		{
			s_IContractInReflectionLoaderContext = systemAddInContractsInReflLoaderContext.GetType(typeof(IContract).FullName, throwOnError: true);
			s_ContractAttrInReflectionLoaderContext = systemAddInContractsInReflLoaderContext.GetType("System.AddIn.Pipeline.AddInContractAttribute", throwOnError: true);
			s_QualificationDataAttrInReflectionLoaderContext = systemAddInContractsInReflLoaderContext.GetType("System.AddIn.Pipeline.QualificationDataAttribute", throwOnError: true);
			s_AddInAdapterAttrInReflectionLoaderContext = systemAddInInReflLoaderContext.GetType("System.AddIn.Pipeline.AddInAdapterAttribute", throwOnError: true);
			s_AddInBaseAttrInReflectionLoaderContext = systemAddInInReflLoaderContext.GetType("System.AddIn.Pipeline.AddInBaseAttribute", throwOnError: true);
			s_AddInAttrInReflectionLoaderContext = systemAddInInReflLoaderContext.GetType("System.AddIn.AddInAttribute", throwOnError: true);
		}

		internal void SetRootDirectory(string root)
		{
			if (!_haveSetRootDirectory)
			{
				_location = Path.Combine(root, _relativeLocation);
				_haveSetRootDirectory = true;
			}
		}

		internal virtual bool Validate(Type type, Collection<string> warnings)
		{
			return Validate(new System.AddIn.MiniReflection.TypeInfo(type), warnings);
		}

		internal virtual bool Validate(System.AddIn.MiniReflection.TypeInfo type, Collection<string> warnings)
		{
			if (type.IsGeneric)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.ComponentUnusableBecauseItIsGeneric, new object[1] { type.Name }));
				return false;
			}
			return true;
		}

		[SecuritySafeCritical]
		internal static System.AddIn.MiniReflection.TypeInfo[] FindBaseTypesAndInterfaces(System.AddIn.MiniReflection.TypeInfo type)
		{
			System.AddIn.MiniReflection.TypeInfo typeInfo = type;
			System.AddIn.MiniReflection.TypeInfo value = new System.AddIn.MiniReflection.TypeInfo(typeof(object));
			List<System.AddIn.MiniReflection.TypeInfo> list = new List<System.AddIn.MiniReflection.TypeInfo>();
			try
			{
				while (!typeInfo.Equals(value))
				{
					typeInfo = typeInfo.TryGetTypeDef();
					if (typeInfo != null)
					{
						System.AddIn.MiniReflection.TypeInfo[] interfaces = typeInfo.GetInterfaces();
						if (interfaces != null)
						{
							list.AddRange(interfaces);
						}
						System.AddIn.MiniReflection.TypeInfo baseType = typeInfo.BaseType;
						list.Add(baseType);
						typeInfo = baseType;
						continue;
					}
					break;
				}
			}
			catch (GenericsNotImplementedException)
			{
			}
			return list.ToArray();
		}
	}
}
namespace System.AddIn.Pipeline
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class HostAdapterAttribute : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class AddInAdapterAttribute : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class AddInBaseAttribute : Attribute
	{
		private Type[] _activatableAs;

		public Type[] ActivatableAs
		{
			get
			{
				return _activatableAs;
			}
			set
			{
				_activatableAs = value;
			}
		}
	}
	public static class CollectionAdapters
	{
		public static IListContract<TContract> ToIListContract<TView, TContract>(IList<TView> collection, Converter<TView, TContract> viewContractAdapter, Converter<TContract, TView> contractViewAdapter)
		{
			if (collection == null)
			{
				return null;
			}
			return new ListContractAdapter<TView, TContract>(collection, viewContractAdapter, contractViewAdapter);
		}

		public static IListContract<T> ToIListContract<T>(IList<T> collection)
		{
			if (collection == null)
			{
				return null;
			}
			Converter<T, T> converter = IdentityConverter;
			return ToIListContract(collection, converter, converter);
		}

		public static IList<TView> ToIList<TContract, TView>(IListContract<TContract> collection, Converter<TContract, TView> contractViewAdapter, Converter<TView, TContract> viewContractAdapter)
		{
			if (collection == null)
			{
				return null;
			}
			return new ContractListAdapter<TContract, TView>(collection, contractViewAdapter, viewContractAdapter);
		}

		public static IList<T> ToIList<T>(IListContract<T> collection)
		{
			if (collection == null)
			{
				return null;
			}
			Converter<T, T> converter = IdentityConverter;
			return ToIList(collection, converter, converter);
		}

		private static T IdentityConverter<T>(T item)
		{
			return item;
		}
	}
	public static class ContractAdapter
	{
		public static ContractHandle ViewToContractAdapter(object view)
		{
			if (view == null)
			{
				throw new ArgumentNullException("view");
			}
			AddInController addInController = AddInController.GetAddInController(view);
			if (addInController != null)
			{
				return new ContractHandle(addInController.AddInControllerImpl.GetContract());
			}
			return null;
		}

		[SecuritySafeCritical]
		public static TView ContractToViewAdapter<TView>(ContractHandle contract, PipelineStoreLocation location)
		{
			if (location != 0)
			{
				throw new ArgumentException(Res.InvalidPipelineStoreLocation, "location");
			}
			string appBase = AddInStore.GetAppBase();
			return ContractToViewAdapterImpl<TView>(contract, appBase, demand: false);
		}

		[SecuritySafeCritical]
		public static TView ContractToViewAdapter<TView>(ContractHandle contract, string pipelineRoot)
		{
			return ContractToViewAdapterImpl<TView>(contract, pipelineRoot, demand: true);
		}

		[SecurityCritical]
		private static TView ContractToViewAdapterImpl<TView>(ContractHandle contract, string pipelineRoot, bool demand)
		{
			if (contract == null)
			{
				throw new ArgumentNullException("contract");
			}
			if (pipelineRoot == null)
			{
				throw new ArgumentNullException("pipelineRoot");
			}
			if (string.IsNullOrEmpty(pipelineRoot))
			{
				throw new ArgumentException(Res.PathCantBeEmpty);
			}
			if (demand)
			{
				new FileIOPermission(FileIOPermissionAccess.Read, pipelineRoot).Demand();
			}
			Type typeFromHandle = typeof(TView);
			System.AddIn.MiniReflection.TypeInfo info = new System.AddIn.MiniReflection.TypeInfo(typeFromHandle);
			List<PartialToken> partialTokens = AddInStore.GetPartialTokens(pipelineRoot);
			foreach (PartialToken item in partialTokens)
			{
				if (AddInStore.Contains(item.HostAdapter.HostAddinViews, info))
				{
					item.PipelineRootDirectory = pipelineRoot;
					IContract contract2 = contract.Contract.QueryContract(item._contract.TypeInfo.AssemblyQualifiedName);
					if (contract2 != null)
					{
						return AddInActivator.ActivateHostAdapter<TView>(item, contract2);
					}
				}
			}
			GC.KeepAlive(contract);
			return default(TView);
		}
	}
	public class ContractBase : MarshalByRefObject, IContract, ISponsor
	{
		private List<int> m_lifetimeTokens = new List<int>();

		private List<string> m_contractIdentifiers;

		private readonly object m_contractIdentifiersLock = new object();

		private Random m_random;

		private bool m_zeroReferencesLeft;

		private const int MaxAppDomainUnloadWaits = 15;

		private int m_tokenOfAppdomainOwner;

		public virtual bool RemoteEquals(IContract contract)
		{
			return Equals(contract);
		}

		public virtual string RemoteToString()
		{
			return ToString();
		}

		public virtual int GetRemoteHashCode()
		{
			return GetHashCode();
		}

		public virtual IContract QueryContract(string contractIdentifier)
		{
			if (contractIdentifier == null)
			{
				throw new ArgumentNullException("contractIdentifier");
			}
			if (m_contractIdentifiers == null)
			{
				lock (m_contractIdentifiersLock)
				{
					if (m_contractIdentifiers == null)
					{
						Type type = GetType();
						Type[] interfaces = type.GetInterfaces();
						List<string> list = new List<string>(interfaces.Length);
						Type typeFromHandle = typeof(IContract);
						Type[] array = interfaces;
						foreach (Type type2 in array)
						{
							if (typeFromHandle.IsAssignableFrom(type2))
							{
								list.Add(type2.AssemblyQualifiedName);
							}
						}
						list.Sort();
						Thread.MemoryBarrier();
						m_contractIdentifiers = list;
					}
				}
			}
			int num = m_contractIdentifiers.BinarySearch(contractIdentifier);
			if (num < 0)
			{
				return null;
			}
			return this;
		}

		public int AcquireLifetimeToken()
		{
			if (m_zeroReferencesLeft)
			{
				throw new InvalidOperationException(Res.TokenCountZero);
			}
			int num;
			lock (m_lifetimeTokens)
			{
				if (m_random == null)
				{
					m_random = new Random();
				}
				num = m_random.Next();
				while (m_lifetimeTokens.Contains(num))
				{
					num = m_random.Next();
				}
				m_lifetimeTokens.Add(num);
				if (m_lifetimeTokens.Count == 1)
				{
					RegisterAsSponsor();
					IContract contract = ContractHandle.AppDomainOwner(AppDomain.CurrentDomain);
					if (contract != null && contract != this)
					{
						m_tokenOfAppdomainOwner = contract.AcquireLifetimeToken();
					}
				}
			}
			return num;
		}

		[SecuritySafeCritical]
		public void RevokeLifetimeToken(int token)
		{
			lock (m_lifetimeTokens)
			{
				if (!m_lifetimeTokens.Remove(token))
				{
					throw new InvalidOperationException(Res.LifetimeTokenNotFound);
				}
				if (m_lifetimeTokens.Count != 0)
				{
					return;
				}
				m_zeroReferencesLeft = true;
				OnFinalRevoke();
				IContract contract = ContractHandle.AppDomainOwner(AppDomain.CurrentDomain);
				if (contract != null)
				{
					if (contract == this)
					{
						SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlThread);
						securityPermission.Assert();
						ThreadStart start = AppDomainUnload;
						Thread thread = new Thread(start);
						thread.Start();
					}
					else
					{
						contract.RevokeLifetimeToken(m_tokenOfAppdomainOwner);
					}
				}
			}
		}

		protected virtual void OnFinalRevoke()
		{
		}

		[SecurityCritical]
		private void AppDomainUnload()
		{
			SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlAppDomain);
			securityPermission.Assert();
			try
			{
				for (int i = 0; i < 15; i++)
				{
					try
					{
						AppDomain.Unload(AppDomain.CurrentDomain);
						return;
					}
					catch (CannotUnloadAppDomainException)
					{
						Thread.Sleep(1 << i);
					}
				}
				Thread.Sleep(32768);
				AppDomain.Unload(AppDomain.CurrentDomain);
			}
			catch (AppDomainUnloadedException)
			{
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception ex4)
			{
				Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, Res.FailedToUnloadAppDomain, new object[2]
				{
					AppDomain.CurrentDomain.FriendlyName,
					ex4.Message
				}));
			}
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
		public TimeSpan Renewal(ILease lease)
		{
			if (lease == null)
			{
				throw new ArgumentNullException("lease");
			}
			lock (m_lifetimeTokens)
			{
				return (m_lifetimeTokens.Count > 0) ? lease.InitialLeaseTime : TimeSpan.Zero;
			}
		}

		[SecuritySafeCritical]
		private void RegisterAsSponsor()
		{
			ILease lease = (ILease)GetLifetimeService();
			if (lease != null)
			{
				SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.RemotingConfiguration);
				securityPermission.Assert();
				try
				{
					lease.Register(this);
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
			}
		}
	}
	public class ContractHandle : IDisposable
	{
		private IContract m_contract;

		private int? m_token;

		internal const string s_appDomainOwner = "System.AddIn_Owner_Contract";

		public IContract Contract => m_contract;

		public ContractHandle(IContract contract)
		{
			if (contract == null)
			{
				throw new ArgumentNullException("contract");
			}
			m_contract = contract;
			m_token = m_contract.AcquireLifetimeToken();
		}

		~ContractHandle()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!m_token.HasValue)
			{
				return;
			}
			try
			{
				m_contract.RevokeLifetimeToken(m_token.Value);
			}
			catch (AppDomainUnloadedException)
			{
			}
			catch (RemotingException)
			{
			}
			catch (SerializationException)
			{
			}
			finally
			{
				m_token = null;
				m_contract = null;
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public static bool ContractOwnsAppDomain(IContract contract, AppDomain domain)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			if (contract == null)
			{
				throw new ArgumentNullException("contract");
			}
			return domain.GetData("System.AddIn_Owner_Contract") == contract;
		}

		public static IContract AppDomainOwner(AppDomain domain)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return (IContract)domain.GetData("System.AddIn_Owner_Contract");
		}
	}
	internal class ContractListAdapter<T, U> : IList<U>, ICollection<U>, IEnumerable<U>, IEnumerable
	{
		private IListContract<T> m_listContract;

		private Converter<T, U> m_wrapper;

		private Converter<U, T> m_unwrapper;

		private ContractHandle m_contractHandle;

		public U this[int index]
		{
			get
			{
				return m_wrapper(m_listContract.GetItem(index));
			}
			set
			{
				m_listContract.SetItem(index, m_unwrapper(value));
			}
		}

		public int Count => m_listContract.GetCount();

		public bool IsReadOnly => m_listContract.GetIsReadOnly();

		public ContractListAdapter(IListContract<T> source, Converter<T, U> wrapper, Converter<U, T> unwrapper)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (wrapper == null)
			{
				throw new ArgumentNullException("wrapper");
			}
			if (unwrapper == null)
			{
				throw new ArgumentNullException("unwrapper");
			}
			m_listContract = source;
			m_wrapper = wrapper;
			m_unwrapper = unwrapper;
			m_contractHandle = new ContractHandle(m_listContract);
		}

		public void Add(U item)
		{
			m_listContract.Add(m_unwrapper(item));
		}

		public void Clear()
		{
			m_listContract.Clear();
		}

		public bool Contains(U item)
		{
			return m_listContract.Contains(m_unwrapper(item));
		}

		public void CopyTo(U[] destination, int index)
		{
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int count = m_listContract.GetCount();
			if (index > destination.Length - count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			for (int i = 0; i < count; i++)
			{
				destination[index++] = m_wrapper(m_listContract.GetItem(i));
			}
		}

		public int IndexOf(U item)
		{
			return m_listContract.IndexOf(m_unwrapper(item));
		}

		public void Insert(int index, U item)
		{
			m_listContract.Insert(index, m_unwrapper(item));
		}

		public bool Remove(U item)
		{
			return m_listContract.Remove(m_unwrapper(item));
		}

		public void RemoveAt(int index)
		{
			m_listContract.RemoveAt(index);
		}

		public U GetItem(int index)
		{
			T item = m_listContract.GetItem(index);
			return m_wrapper(item);
		}

		public void SetItem(int index, U item)
		{
			m_listContract.SetItem(index, m_unwrapper(item));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<U> GetEnumerator()
		{
			return new ContractEnumeratorAdapter<T, U>(m_listContract.GetEnumeratorContract(), m_wrapper);
		}
	}
	internal class ContractEnumeratorAdapter<T, U> : IEnumerator<U>, IDisposable, IEnumerator
	{
		private IEnumeratorContract<T> m_enumerator;

		private Converter<T, U> m_wrapper;

		private ContractHandle m_contractHandle;

		public U Current
		{
			get
			{
				T current = m_enumerator.GetCurrent();
				return m_wrapper(current);
			}
		}

		object IEnumerator.Current => Current;

		public ContractEnumeratorAdapter(IEnumeratorContract<T> enumerator, Converter<T, U> wrapper)
		{
			if (enumerator == null)
			{
				throw new ArgumentNullException("enumerator");
			}
			if (wrapper == null)
			{
				throw new ArgumentNullException("wrapper");
			}
			m_enumerator = enumerator;
			m_wrapper = wrapper;
			m_contractHandle = new ContractHandle((IContract)m_enumerator);
		}

		public bool MoveNext()
		{
			return m_enumerator.MoveNext();
		}

		public void Reset()
		{
			m_enumerator.Reset();
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (m_contractHandle == null)
			{
				return;
			}
			if (disposing)
			{
				try
				{
					m_contractHandle.Dispose();
					if (m_enumerator != null)
					{
						m_enumerator.Dispose();
					}
				}
				catch (AppDomainUnloadedException)
				{
				}
				catch (RemotingException)
				{
				}
			}
			m_contractHandle = null;
		}

		~ContractEnumeratorAdapter()
		{
			Dispose(disposing: false);
		}
	}
	internal class ListContractAdapter<T, U> : ContractBase, IListContract<U>, IContract
	{
		private IList<T> m_list;

		private Converter<T, U> m_wrapper;

		private Converter<U, T> m_unwrapper;

		public ListContractAdapter(IList<T> source, Converter<T, U> wrapper, Converter<U, T> unwrapper)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (wrapper == null)
			{
				throw new ArgumentNullException("wrapper");
			}
			if (unwrapper == null)
			{
				throw new ArgumentNullException("unwrapper");
			}
			if (!typeof(U).IsSerializable && !typeof(IContract).IsAssignableFrom(typeof(U)))
			{
				throw new ArgumentException(Res.TypeShouldBeSerializableOrIContract, typeof(U).Name);
			}
			m_list = source;
			m_wrapper = wrapper;
			m_unwrapper = unwrapper;
		}

		public void Add(U item)
		{
			m_list.Add(m_unwrapper(item));
		}

		public void Clear()
		{
			m_list.Clear();
		}

		public bool Contains(U item)
		{
			return m_list.Contains(m_unwrapper(item));
		}

		public int IndexOf(U item)
		{
			return m_list.IndexOf(m_unwrapper(item));
		}

		public void Insert(int index, U item)
		{
			m_list.Insert(index, m_unwrapper(item));
		}

		public bool Remove(U item)
		{
			return m_list.Remove(m_unwrapper(item));
		}

		public void RemoveAt(int index)
		{
			m_list.RemoveAt(index);
		}

		public U GetItem(int index)
		{
			return m_wrapper(m_list[index]);
		}

		public void SetItem(int index, U item)
		{
			m_list[index] = m_unwrapper(item);
		}

		public int GetCount()
		{
			return m_list.Count;
		}

		public bool GetIsReadOnly()
		{
			return m_list.IsReadOnly;
		}

		public IEnumeratorContract<U> GetEnumeratorContract()
		{
			return new ListEnumeratorAdapter<T, U>(m_list.GetEnumerator(), m_wrapper);
		}
	}
	internal class ListEnumeratorAdapter<T, U> : ContractBase, IEnumeratorContract<U>, IDisposable
	{
		private IEnumerator<T> m_enumerator;

		private Converter<T, U> m_wrapper;

		public ListEnumeratorAdapter(IEnumerator<T> enumerator, Converter<T, U> wrapper)
		{
			if (enumerator == null)
			{
				throw new ArgumentNullException("enumerator");
			}
			if (wrapper == null)
			{
				throw new ArgumentNullException("wrapper");
			}
			m_enumerator = enumerator;
			m_wrapper = wrapper;
		}

		public U GetCurrent()
		{
			return m_wrapper(m_enumerator.Current);
		}

		public bool MoveNext()
		{
			return m_enumerator.MoveNext();
		}

		public void Reset()
		{
			m_enumerator.Reset();
		}

		public void Dispose()
		{
			m_enumerator.Dispose();
		}
	}
}
namespace System.AddIn.MiniReflection
{
	[Serializable]
	internal sealed class MiniAssembly : MiniModule
	{
		private enum Representation
		{
			PEFileReader = 1,
			ReflectionAssembly
		}

		private List<string> _dependencyDirs;

		private Representation _representation;

		private Assembly _reflectionAssembly;

		private string _fullName;

		public List<string> DependencyDirs => _dependencyDirs;

		internal bool IsReflectionAssembly => (_representation & Representation.ReflectionAssembly) != 0;

		internal string FullName
		{
			get
			{
				if ((_representation & Representation.ReflectionAssembly) != 0)
				{
					return AppDomain.CurrentDomain.ApplyPolicy(_reflectionAssembly.FullName);
				}
				if (_fullName == null)
				{
					AssemblyInfo result = default(AssemblyInfo);
					_peFile.GetAssemblyInfo(ref result);
					_fullName = AppDomain.CurrentDomain.ApplyPolicy(result.ToString());
				}
				return _fullName;
			}
		}

		public MiniAssembly(string peFileName)
			: base(peFileName)
		{
			_dependencyDirs = new List<string>();
			_dependencyDirs.Add(Path.GetDirectoryName(peFileName));
			base.Assembly = this;
			_representation = Representation.PEFileReader;
		}

		public MiniAssembly(Assembly assembly)
		{
			_reflectionAssembly = assembly;
			_representation = Representation.ReflectionAssembly;
		}

		public MiniModule[] GetModules()
		{
			MDTables metaData = _peFile.MetaData;
			for (uint num = 0u; num < metaData.RowsInTable(MDTables.Tables.File); num++)
			{
				metaData.SeekToRowOfTable(MDTables.Tables.File, num);
				MDFileAttributes mDFileAttributes = (MDFileAttributes)metaData.B.ReadUInt32();
				if ((mDFileAttributes & MDFileAttributes.ContainsNoMetaData) == 0)
				{
					throw new NotImplementedException(string.Format(CultureInfo.CurrentCulture, Res.MultiFileAssembliesNotSupported, new object[1] { FullName }));
				}
			}
			return new MiniModule[1] { this };
		}

		public IList<TypeInfo> GetTypesWithAttribute(Type customAttribute)
		{
			return GetTypesWithAttribute(customAttribute, includePrivate: false);
		}

		public TypeInfo FindTypeInfo(string typeName, string nameSpace)
		{
			MetadataToken typeDef = FindTypeDef(_peFile, _peFile.MetaData, typeName, nameSpace);
			return new TypeInfo(typeDef, this, typeName, nameSpace);
		}

		private static MetadataToken FindTypeDef(PEFileReader peFile, MDTables mdScope, string typeName, string nameSpace)
		{
			uint num = mdScope.RowsInTable(MDTables.Tables.TypeDef);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				mdScope.SeekToRowOfTable(MDTables.Tables.TypeDef, num2);
				peFile.B.ReadUInt32();
				string b = mdScope.ReadString();
				if (string.Equals(typeName, b))
				{
					string b2 = mdScope.ReadString();
					if (string.Equals(nameSpace, b2))
					{
						return new MetadataToken(MDTables.Tables.TypeDef, num2 + 1);
					}
				}
			}
			throw new TypeLoadException(string.Format(CultureInfo.CurrentCulture, Res.CantFindTypeName, new object[2] { nameSpace, typeName }));
		}

		public IList<TypeInfo> GetTypesWithAttribute(Type customAttribute, bool includePrivate)
		{
			if (base.IsDisposed)
			{
				throw new ObjectDisposedException(null);
			}
			if (customAttribute == null)
			{
				throw new ArgumentNullException("customAttribute");
			}
			List<TypeInfo> list = new List<TypeInfo>();
			MiniModule[] modules = GetModules();
			foreach (MiniModule miniModule in modules)
			{
				IList<TypeInfo> typesWithAttributeInModule = miniModule.GetTypesWithAttributeInModule(customAttribute, includePrivate);
				list.AddRange(typesWithAttributeInModule);
			}
			return list;
		}

		public MiniAssembly ResolveAssemblyRef(MetadataToken token, bool throwOnError)
		{
			PEFileReader pEFileReader = base.PEFileReader;
			MDTables metaData = pEFileReader.MetaData;
			metaData.SeekToMDToken(token);
			pEFileReader.B.ReadUInt64();
			pEFileReader.B.ReadUInt32();
			byte[] array = metaData.ReadBlob();
			string text = metaData.ReadString();
			string text2 = metaData.ReadString();
			if (!string.IsNullOrEmpty(text2))
			{
				throw new BadImageFormatException(Res.UnexpectedlyLoadingASatellite, FullName);
			}
			if (text == "mscorlib" && (text2.Length == 0 || text2 == "neutral"))
			{
				return new MiniAssembly(typeof(object).Assembly);
			}
			MiniAssembly miniAssembly = Open(text, _dependencyDirs, throwOnError);
			if (miniAssembly != null)
			{
				AssemblyName assemblyName = new AssemblyName(miniAssembly.FullName);
				if (!Utils.PublicKeyMatches(assemblyName, array))
				{
					throw new FileLoadException(string.Format(CultureInfo.CurrentCulture, Res.AssemblyLoadRefDefMismatch, new object[3]
					{
						text,
						array,
						assemblyName.GetPublicKeyToken()
					}));
				}
				if (!string.IsNullOrEmpty(assemblyName.CultureInfo.Name))
				{
					throw new FileLoadException(string.Format(CultureInfo.CurrentCulture, Res.AssemblyLoadRefDefMismatch, new object[3]
					{
						text,
						string.Empty,
						assemblyName.CultureInfo.Name
					}));
				}
			}
			return miniAssembly;
		}

		public static MiniAssembly Open(string simpleName, IList<string> dependencyDirs, bool throwOnError)
		{
			string text = FindAssembly(simpleName, dependencyDirs, throwOnError);
			if (!throwOnError && text == null)
			{
				return null;
			}
			return new MiniAssembly(text);
		}

		private static string FindAssembly(string simpleName, IList<string> searchDirs, bool throwOnError)
		{
			string text = simpleName + ".dll";
			string path = simpleName + ".exe";
			foreach (string searchDir in searchDirs)
			{
				string text2 = Path.Combine(searchDir, text);
				if (File.Exists(text2))
				{
					return text2;
				}
				text2 = Path.Combine(searchDir, path);
				if (File.Exists(text2))
				{
					return text2;
				}
			}
			if (throwOnError)
			{
				throw new FileNotFoundException(string.Format(CultureInfo.CurrentCulture, Res.FileNotFoundForInspection, new object[1] { simpleName }), text);
			}
			return null;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is MiniAssembly miniAssembly))
			{
				return false;
			}
			return Utils.AssemblyDefEqualsDef(FullName, miniAssembly.FullName);
		}

		public static bool Equals(MiniAssembly assemblyA, PEFileReader peFileB, MetadataToken assemblyRefB)
		{
			string assemblyDef;
			if (assemblyA.IsReflectionAssembly)
			{
				assemblyDef = AppDomain.CurrentDomain.ApplyPolicy(assemblyA._reflectionAssembly.FullName);
			}
			else
			{
				AssemblyInfo result = default(AssemblyInfo);
				assemblyA._peFile.GetAssemblyInfo(ref result);
				assemblyDef = AppDomain.CurrentDomain.ApplyPolicy(result.ToString());
			}
			AssemblyInfo assemblyInfo = ReadAssemblyRef(peFileB, assemblyRefB);
			string assemblyRef = AppDomain.CurrentDomain.ApplyPolicy(assemblyInfo.ToString());
			return Utils.AssemblyRefEqualsDef(assemblyRef, assemblyDef);
		}

		private static AssemblyInfo ReadAssemblyRef(PEFileReader peFile, MetadataToken assemblyRef)
		{
			MDTables metaData = peFile.MetaData;
			BinaryReader b = metaData.B;
			metaData.SeekToMDToken(assemblyRef);
			ushort major = b.ReadUInt16();
			ushort minor = b.ReadUInt16();
			ushort build = b.ReadUInt16();
			ushort revision = b.ReadUInt16();
			Version v = new Version(major, minor, build, revision);
			uint flags = b.ReadUInt32();
			byte[] publicKeyOrToken = metaData.ReadBlob();
			string name = metaData.ReadString();
			string text = metaData.ReadString();
			if (text != null && text.Length == 0)
			{
				text = null;
			}
			return new AssemblyInfo(v, flags, publicKeyOrToken, name, text);
		}

		public override int GetHashCode()
		{
			return FullName.GetHashCode();
		}
	}
	[Serializable]
	internal sealed class MiniConstructorInfo
	{
		private MiniParameterInfo[] _parameters;

		public MiniConstructorInfo(MiniParameterInfo[] parameters)
		{
			_parameters = parameters;
		}

		public MiniParameterInfo[] GetParameters()
		{
			return _parameters;
		}
	}
	[Serializable]
	internal sealed class MiniCustomAttributeInfo
	{
		private string _typeName;

		private MiniCustomAttributeFixedArgInfo[] _fixedArgs;

		private MiniCustomAttributeNamedArgInfo[] _namedArgs;

		public MiniCustomAttributeFixedArgInfo[] FixedArgs => _fixedArgs;

		public MiniCustomAttributeNamedArgInfo[] NamedArgs => _namedArgs;

		public MiniCustomAttributeInfo(string typeName, MiniCustomAttributeFixedArgInfo[] fixedArgs, MiniCustomAttributeNamedArgInfo[] namedArgs)
		{
			_typeName = typeName;
			_fixedArgs = fixedArgs;
			_namedArgs = namedArgs;
		}
	}
	[Serializable]
	internal sealed class MiniCustomAttributeNamedArgInfo
	{
		private string _argName;

		private CorElementType _type;

		private object _value;

		public object Value => _value;

		public string Name => _argName;

		public MiniCustomAttributeNamedArgInfo(CorElementType type, string name, object value)
		{
			_argName = name;
			_type = type;
			_value = value;
		}
	}
	[Serializable]
	internal sealed class MiniCustomAttributeFixedArgInfo
	{
		private object _value;

		public object Value => _value;

		public MiniCustomAttributeFixedArgInfo(object value)
		{
			_value = value;
		}
	}
	[Serializable]
	internal class MiniModule : IDisposable
	{
		[NonSerialized]
		protected PEFileReader _peFile;

		private MiniAssembly _assembly;

		private string _moduleName;

		public bool IsDisposed => _peFile == null;

		public MiniAssembly Assembly
		{
			get
			{
				return _assembly;
			}
			protected internal set
			{
				_assembly = value;
			}
		}

		public string ModuleName => _moduleName;

		internal PEFileReader PEFileReader
		{
			get
			{
				if (IsDisposed)
				{
					throw new ObjectDisposedException(null);
				}
				return _peFile;
			}
		}

		protected MiniModule(string peFileName)
		{
			_peFile = new PEFileReader(peFileName);
			_moduleName = Path.GetFileNameWithoutExtension(peFileName);
		}

		protected MiniModule()
		{
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_peFile != null)
			{
				if (disposing)
				{
					_peFile.Dispose();
				}
				_peFile = null;
			}
		}

		public IList<MetadataToken> GetGenericTypes()
		{
			List<MetadataToken> list = new List<MetadataToken>();
			uint num = _peFile.MetaData.RowsInTable(MDTables.Tables.GenericParam);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				_peFile.MetaData.SeekToRowOfTable(MDTables.Tables.GenericParam, num2);
				_peFile.B.ReadUInt16();
				_peFile.B.ReadUInt16();
				MetadataToken item = _peFile.MetaData.ReadMetadataToken(MDTables.Encodings.TypeOrMethodDef);
				list.Add(item);
			}
			return list;
		}

		public IList<TypeInfo> GetTypesWithAttributeInModule(Type customAttribute)
		{
			return GetTypesWithAttributeInModule(customAttribute, includePrivate: false);
		}

		public IList<TypeInfo> GetTypesWithAttributeInModule(Type customAttribute, bool includePrivate)
		{
			if (IsDisposed)
			{
				throw new ObjectDisposedException(null);
			}
			if (customAttribute == null)
			{
				throw new ArgumentNullException("customAttribute");
			}
			_peFile.InitMetaData();
			MDTables metaData = _peFile.MetaData;
			List<TypeInfo> list = new List<TypeInfo>();
			string name = customAttribute.Name;
			string @namespace = customAttribute.Namespace;
			IList<MetadataToken> genericTypes = GetGenericTypes();
			uint num = metaData.RowsInTable(MDTables.Tables.CustomAttribute);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				metaData.SeekToRowOfTable(MDTables.Tables.CustomAttribute, num2);
				MetadataToken metadataToken = metaData.ReadMetadataToken(MDTables.Encodings.HasCustomAttribute);
				MetadataToken token = metaData.ReadMetadataToken(MDTables.Encodings.CustomAttributeType);
				metaData.SeekToMDToken(token);
				string text = null;
				string text2 = null;
				if (token.Table != MDTables.Tables.MemberRef)
				{
					continue;
				}
				MetadataToken token2 = metaData.ReadMetadataToken(MDTables.Encodings.MemberRefParent);
				metaData.SeekToMDToken(token2);
				MetadataToken metadataToken2 = metaData.ReadMetadataToken(MDTables.Encodings.ResolutionScope);
				text = metaData.ReadString();
				if (!string.Equals(text, name))
				{
					continue;
				}
				text2 = metaData.ReadString();
				if (string.Equals(text2, @namespace))
				{
					MDTables.Tables table = metadataToken.Table;
					if (table != MDTables.Tables.TypeDef)
					{
						throw new NotImplementedException(string.Format(CultureInfo.CurrentCulture, Res.UnknownTokenType, new object[2] { metadataToken.Table, Assembly.FullName }));
					}
					metaData.SeekToMDToken(metadataToken);
					TypeAttributes typeAttributes = (TypeAttributes)_peFile.B.ReadUInt32();
					TypeAttributes typeAttributes2 = typeAttributes & TypeAttributes.VisibilityMask;
					bool flag = typeAttributes2 == TypeAttributes.Public;
					if (includePrivate || flag)
					{
						string typeName = metaData.ReadString();
						string nameSpace = metaData.ReadString();
						bool isGeneric = genericTypes.Contains(metadataToken);
						TypeInfo item = new TypeInfo(metadataToken, _assembly, this, typeName, nameSpace, isGeneric);
						list.Add(item);
					}
				}
			}
			return list;
		}
	}
	[Serializable]
	internal sealed class MiniParameterInfo
	{
		private CorElementType _elementType;

		private TypeInfo _paramType;

		public TypeInfo ParameterType
		{
			get
			{
				if (_elementType == CorElementType.Class || _elementType == CorElementType.ValueType)
				{
					return _paramType;
				}
				return _elementType switch
				{
					CorElementType.Boolean => new TypeInfo(typeof(bool)), 
					CorElementType.I1 => new TypeInfo(typeof(sbyte)), 
					CorElementType.U1 => new TypeInfo(typeof(byte)), 
					CorElementType.I2 => new TypeInfo(typeof(short)), 
					CorElementType.U2 => new TypeInfo(typeof(ushort)), 
					CorElementType.Char => new TypeInfo(typeof(char)), 
					CorElementType.I4 => new TypeInfo(typeof(int)), 
					CorElementType.U4 => new TypeInfo(typeof(uint)), 
					CorElementType.I8 => new TypeInfo(typeof(long)), 
					CorElementType.U8 => new TypeInfo(typeof(ulong)), 
					CorElementType.R4 => new TypeInfo(typeof(float)), 
					CorElementType.R8 => new TypeInfo(typeof(double)), 
					CorElementType.I => new TypeInfo(typeof(IntPtr)), 
					CorElementType.U => new TypeInfo(typeof(UIntPtr)), 
					CorElementType.String => new TypeInfo(typeof(string)), 
					CorElementType.Object => new TypeInfo(typeof(object)), 
					_ => throw new NotImplementedException(), 
				};
			}
		}

		public MiniParameterInfo(CorElementType elementType)
		{
			_elementType = elementType;
		}

		public MiniParameterInfo(CorElementType elementType, TypeInfo parameterType)
		{
			_elementType = elementType;
			_paramType = parameterType;
		}

		public static bool IsValid(CorElementType elementType)
		{
			if ((0 > (int)elementType || (int)elementType > 34) && elementType != CorElementType.Modifier && elementType != CorElementType.Sentinel)
			{
				return elementType == CorElementType.Pinned;
			}
			return true;
		}

		public override string ToString()
		{
			if (_elementType == CorElementType.Class || _elementType == CorElementType.ValueType)
			{
				return _paramType.ToString();
			}
			return _elementType.ToString();
		}
	}
	[Serializable]
	internal sealed class TypeInfo : IEquatable<TypeInfo>, ISerializable
	{
		[Flags]
		internal enum Representation
		{
			None = 0,
			Token = 1,
			Name = 2,
			AssemblyQualifiedName = 4,
			ReflectionType = 8,
			TypeRef = 0x10
		}

		private static volatile ICollection<string> Warnings;

		private const string AssemblyFieldName = "_assembly";

		private const string ModuleFieldName = "_module";

		private const string MDTokenFieldName = "_mdToken";

		private const string TypeNameFieldName = "_typeName";

		private const string NameSpaceFieldName = "_nameSpace";

		private const string AssemblyQualifiedFieldName = "_assemblyQualifiedName";

		private const string RepresentationFieldName = "_representation";

		private const string IsGenericFieldName = "_isGeneric";

		private readonly MiniAssembly _assembly;

		private readonly MiniModule _module;

		private readonly MetadataToken _mdToken;

		private volatile string _typeName;

		private volatile string _nameSpace;

		private volatile string _assemblyQualifiedName;

		private static readonly UTF8Encoding s_encoder = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

		[NonSerialized]
		private readonly Type _reflectionType;

		private volatile Representation _representation;

		private bool _isGeneric;

		internal string FullTypeName
		{
			get
			{
				if (!string.IsNullOrEmpty(_nameSpace))
				{
					return _nameSpace + "." + _typeName;
				}
				return _typeName;
			}
		}

		internal Type ReflectionType => _reflectionType;

		private bool HasAssemblyQualifiedName => (_representation & Representation.AssemblyQualifiedName) != 0;

		private bool HasName => (_representation & Representation.Name) != 0;

		private bool HasToken => (_representation & Representation.Token) != 0;

		internal bool HasReflectionType => (_representation & Representation.ReflectionType) != 0;

		private bool HasTypeRef => (_representation & Representation.TypeRef) != 0;

		internal MiniAssembly Assembly
		{
			get
			{
				MiniAssembly miniAssembly = _assembly;
				if (miniAssembly == null)
				{
					miniAssembly = new MiniAssembly(_reflectionType.Assembly);
				}
				return miniAssembly;
			}
		}

		internal bool IsGeneric => _isGeneric;

		public bool IsInterface
		{
			get
			{
				if (HasReflectionType)
				{
					return _reflectionType.IsInterface;
				}
				if (HasTypeRef)
				{
					TypeInfo typeInfo = TypeRefToTypeDef(_mdToken, throwOnError: true);
					return typeInfo.IsInterface;
				}
				PEFileReader pEFileReader = _assembly.PEFileReader;
				MDTables metaData = pEFileReader.MetaData;
				metaData.SeekToMDToken(_mdToken);
				TypeAttributes typeAttributes = (TypeAttributes)pEFileReader.B.ReadUInt32();
				return (typeAttributes & TypeAttributes.ClassSemanticsMask) != 0;
			}
		}

		public string Name => _typeName;

		public string FullName
		{
			get
			{
				if (string.IsNullOrEmpty(_nameSpace))
				{
					return _typeName;
				}
				return _nameSpace + "." + _typeName;
			}
		}

		public string AssemblyQualifiedName
		{
			get
			{
				if (HasAssemblyQualifiedName)
				{
					return _assemblyQualifiedName;
				}
				if (HasName)
				{
					_assemblyQualifiedName = FullName + ", " + _assembly.FullName;
					_representation |= Representation.AssemblyQualifiedName;
					return _assemblyQualifiedName;
				}
				throw new NotImplementedException();
			}
		}

		public string AssemblyName
		{
			get
			{
				if (HasAssemblyQualifiedName)
				{
					int num = _assemblyQualifiedName.IndexOf(',');
					return _assemblyQualifiedName.Substring(num + 2);
				}
				string fullName = _assembly.FullName;
				_assemblyQualifiedName = FullName + ", " + _assembly.FullName;
				_representation |= Representation.AssemblyQualifiedName;
				return fullName;
			}
		}

		public TypeInfo BaseType
		{
			get
			{
				if (HasTypeRef)
				{
					TypeInfo typeInfo = TypeRefToTypeDef(_mdToken, throwOnError: true);
					return typeInfo.BaseType;
				}
				PEFileReader pEFileReader = _assembly.PEFileReader;
				MDTables metaData = pEFileReader.MetaData;
				metaData.SeekToMDToken(_mdToken);
				pEFileReader.B.ReadUInt32();
				if (HasName)
				{
					metaData.ReadStringIndex();
					metaData.ReadStringIndex();
				}
				else
				{
					_typeName = metaData.ReadString();
					_nameSpace = metaData.ReadString();
					_representation |= Representation.Name;
				}
				MetadataToken token = pEFileReader.MetaData.ReadMetadataToken(MDTables.Encodings.TypeDefOrRef);
				return TypeInfoFromTypeDefOrRef(token);
			}
		}

		internal TypeInfo(MetadataToken typeDef, MiniAssembly assembly)
		{
			_mdToken = typeDef;
			_assembly = assembly;
			_representation = Representation.Token;
			PEFileReader pEFileReader = _assembly.PEFileReader;
			MDTables metaData = pEFileReader.MetaData;
			metaData.SeekToMDToken(_mdToken);
			pEFileReader.B.ReadUInt32();
			_typeName = metaData.ReadString();
			_nameSpace = metaData.ReadString();
			_representation |= Representation.Name;
		}

		internal TypeInfo(MetadataToken typeDef, MiniAssembly assembly, string typeName, string nameSpace)
		{
			_mdToken = typeDef;
			_assembly = assembly;
			_typeName = typeName;
			_nameSpace = nameSpace;
			_assemblyQualifiedName = FullTypeName + ", " + assembly.FullName;
			_representation = Representation.Token | Representation.Name | Representation.AssemblyQualifiedName;
		}

		internal TypeInfo(MetadataToken typeDef, MiniAssembly assembly, MiniModule module, string typeName, string nameSpace, bool isGeneric)
		{
			_mdToken = typeDef;
			_assembly = assembly;
			_module = module;
			_typeName = typeName;
			_nameSpace = nameSpace;
			_assemblyQualifiedName = FullTypeName + ", " + assembly.FullName;
			_representation = Representation.Token | Representation.Name | Representation.AssemblyQualifiedName;
			_isGeneric = isGeneric;
		}

		[SecuritySafeCritical]
		internal TypeInfo(MetadataToken typeRefToken, MiniAssembly referencingAssembly, bool disambiguatingJunkForTypeRefOverload)
		{
			_mdToken = typeRefToken;
			_assembly = referencingAssembly;
			_representation = Representation.Name | Representation.TypeRef;
			PEFileReader pEFileReader = referencingAssembly.PEFileReader;
			MDTables metaData = pEFileReader.MetaData;
			metaData.SeekToMDToken(typeRefToken);
			MetadataToken token = metaData.ReadMetadataToken(MDTables.Encodings.ResolutionScope);
			_typeName = metaData.ReadString();
			_nameSpace = metaData.ReadString();
			metaData.SeekToMDToken(token);
			ushort num = pEFileReader.B.ReadUInt16();
			ushort num2 = pEFileReader.B.ReadUInt16();
			ushort num3 = pEFileReader.B.ReadUInt16();
			ushort num4 = pEFileReader.B.ReadUInt16();
			pEFileReader.B.ReadUInt32();
			byte[] array = metaData.ReadBlob();
			string text = metaData.ReadString();
			string text2 = metaData.ReadString();
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllLocalFiles = FileIOPermissionAccess.PathDiscovery;
			fileIOPermission.Assert();
			Assembly assembly = typeof(object).Assembly;
			if (text == "mscorlib" && text2.Length == 0 && Utils.PublicKeyMatches(assembly.GetName(), array))
			{
				Type type = assembly.GetType(FullName, throwOnError: false);
				if (type != null)
				{
					_reflectionType = type;
					_representation |= Representation.ReflectionType;
				}
			}
			string text3 = string.Format(CultureInfo.InvariantCulture, "{0}, Version={1}.{2}.{3}.{4}, Culture={5}, PublicKeyToken={6}", text, num, num2, num3, num4, (text2.Length == 0) ? "neutral" : text2, Utils.PublicKeyToString(array));
			_assemblyQualifiedName = FullName + ", " + text3;
			_representation |= Representation.AssemblyQualifiedName;
		}

		internal TypeInfo(Type type)
		{
			_reflectionType = type;
			_assemblyQualifiedName = type.AssemblyQualifiedName;
			_isGeneric = type.ContainsGenericParameters || type.IsGenericType || type.GetGenericArguments().Length != 0;
			_typeName = type.Name;
			_nameSpace = type.Namespace;
			if (_nameSpace == null)
			{
				_nameSpace = string.Empty;
			}
			_representation = Representation.Name | Representation.AssemblyQualifiedName | Representation.ReflectionType;
		}

		internal TypeInfo(SerializationInfo info, StreamingContext context)
		{
			_assembly = (MiniAssembly)info.GetValue("_assembly", typeof(MiniAssembly));
			_module = (MiniModule)info.GetValue("_module", typeof(MiniModule));
			_mdToken = (MetadataToken)info.GetValue("_mdToken", typeof(MetadataToken));
			_typeName = info.GetString("_typeName");
			_nameSpace = info.GetString("_nameSpace");
			_assemblyQualifiedName = info.GetString("_assemblyQualifiedName");
			_representation = (Representation)info.GetInt32("_representation");
			_isGeneric = info.GetBoolean("_isGeneric");
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_assembly", _assembly);
			info.AddValue("_module", _module);
			info.AddValue("_mdToken", _mdToken);
			info.AddValue("_typeName", _typeName);
			info.AddValue("_nameSpace", _nameSpace);
			info.AddValue("_assemblyQualifiedName", _assemblyQualifiedName);
			Representation representation = _representation & ~Representation.ReflectionType;
			info.AddValue("_representation", representation);
			info.AddValue("_isGeneric", _isGeneric);
		}

		internal static void SetWarnings(ICollection<string> warnings)
		{
			Warnings = warnings;
		}

		private TypeInfo TypeInfoFromTypeDefOrRef(MetadataToken token)
		{
			if (token.Table == MDTables.Tables.TypeRef)
			{
				return new TypeInfo(token, _assembly, disambiguatingJunkForTypeRefOverload: false);
			}
			if (token.Table == MDTables.Tables.TypeDef)
			{
				return new TypeInfo(token, _assembly);
			}
			throw new GenericsNotImplementedException();
		}

		public MiniConstructorInfo[] GetConstructors()
		{
			return GetConstructors(includePrivate: false);
		}

		public MiniConstructorInfo[] GetConstructors(bool includePrivate)
		{
			List<MiniConstructorInfo> list = new List<MiniConstructorInfo>();
			PEFileReader pEFileReader = _assembly.PEFileReader;
			pEFileReader.InitMetaData();
			MDTables metaData = pEFileReader.MetaData;
			metaData.SeekToMDToken(_mdToken);
			TypeAttributes typeAttributes = (TypeAttributes)pEFileReader.B.ReadUInt32();
			TypeAttributes typeAttributes2 = TypeAttributes.VisibilityMask & typeAttributes;
			bool flag = typeAttributes2 == TypeAttributes.Public;
			if (!includePrivate && !flag)
			{
				return new MiniConstructorInfo[0];
			}
			metaData.ReadStringIndex();
			metaData.ReadStringIndex();
			MetadataToken metadataToken = metaData.ReadMetadataToken(MDTables.Encodings.TypeDefOrRef);
			uint num = metaData.ReadRowIndex(MDTables.Tables.FieldDef);
			uint num2 = metaData.ReadRowIndex(MDTables.Tables.MethodDef);
			uint num3;
			if (_mdToken.Index == metaData.RowsInTable(MDTables.Tables.TypeDef))
			{
				num3 = metaData.RowsInTable(MDTables.Tables.MethodDef);
			}
			else
			{
				metaData.SeekToRowOfTable(MDTables.Tables.TypeDef, _mdToken.Index);
				pEFileReader.B.ReadUInt32();
				metaData.ReadStringIndex();
				metaData.ReadStringIndex();
				metaData.ReadMetadataToken(MDTables.Encodings.TypeDefOrRef);
				metaData.ReadRowIndex(MDTables.Tables.FieldDef);
				uint num4 = metaData.ReadRowIndex(MDTables.Tables.MethodDef);
				num3 = num4 - 1;
			}
			for (uint num5 = num2; num5 <= num3; num5++)
			{
				MetadataToken token = new MetadataToken(MDTables.Tables.MethodDef, num5);
				metaData.SeekToMDToken(token);
				uint num6 = pEFileReader.B.ReadUInt32();
				ushort num7 = pEFileReader.B.ReadUInt16();
				MethodAttributes methodAttributes = (MethodAttributes)pEFileReader.B.ReadUInt16();
				if (!includePrivate && (methodAttributes & MethodAttributes.Public) == 0)
				{
					continue;
				}
				string a = metaData.ReadString();
				if (string.Equals(a, ".ctor"))
				{
					byte[] sig = metaData.ReadBlob();
					try
					{
						MiniParameterInfo[] parameters = ParseSig(sig);
						list.Add(new MiniConstructorInfo(parameters));
					}
					catch (GenericsNotImplementedException)
					{
					}
				}
			}
			return list.ToArray();
		}

		private MiniParameterInfo[] ParseSig(byte[] sig)
		{
			PEFileReader pEFileReader = _assembly.PEFileReader;
			pEFileReader.InitMetaData();
			MDTables metaData = pEFileReader.MetaData;
			uint num = 0u;
			num++;
			uint num2 = DecodeInteger(sig, ref num);
			while (true)
			{
				if (sig[num] == 32)
				{
					num++;
					continue;
				}
				if (sig[num] != 31)
				{
					break;
				}
				num++;
			}
			if (sig[num] == 1)
			{
				num++;
			}
			else if (sig[num] == 22)
			{
				num++;
			}
			else
			{
				if (sig[num] == 16)
				{
					num++;
				}
				ParseType(sig, ref num, allowTypedByRef: false, allowVoid: true);
			}
			MiniParameterInfo[] array = new MiniParameterInfo[num2];
			for (uint num3 = 0u; num3 < num2; num3++)
			{
				array[num3] = ParseType(sig, ref num, allowTypedByRef: false, allowVoid: false);
			}
			return array;
		}

		private MiniParameterInfo ParseType(byte[] sig, ref uint i, bool allowTypedByRef, bool allowVoid)
		{
			CorElementType corElementType = (CorElementType)sig[i++];
			switch (corElementType)
			{
			case CorElementType.Boolean:
			case CorElementType.Char:
			case CorElementType.I1:
			case CorElementType.U1:
			case CorElementType.I2:
			case CorElementType.U2:
			case CorElementType.I4:
			case CorElementType.U4:
			case CorElementType.I8:
			case CorElementType.U8:
			case CorElementType.R4:
			case CorElementType.R8:
			case CorElementType.String:
			case CorElementType.I:
			case CorElementType.U:
			case CorElementType.Object:
				return new MiniParameterInfo(corElementType);
			case CorElementType.TypedByRef:
				if (!allowTypedByRef)
				{
					throw new BadImageFormatException(Res.TypedByRefNotAllowed);
				}
				throw new NotImplementedException();
			case CorElementType.Void:
				if (!allowVoid)
				{
					throw new BadImageFormatException();
				}
				return new MiniParameterInfo(corElementType);
			case CorElementType.ValueType:
			case CorElementType.Class:
				return new MiniParameterInfo(corElementType, ParseTypeDefRefOrSpec(sig, ref i));
			case CorElementType.Ptr:
				throw new NotImplementedException();
			case CorElementType.FnPtr:
				throw new NotImplementedException();
			case CorElementType.SzArray:
				throw new NotImplementedException();
			case CorElementType.Array:
				throw new NotImplementedException();
			case CorElementType.ByRef:
				throw new NotImplementedException();
			case CorElementType.GenericInst:
				throw new GenericsNotImplementedException();
			case CorElementType.Var:
				throw new NotImplementedException();
			default:
				throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.UnrecognizedCorElementType, new object[1] { corElementType }));
			}
		}

		private TypeInfo ParseTypeDefRefOrSpec(byte[] sig, ref uint i)
		{
			uint num = DecodeInteger(sig, ref i);
			uint num2 = num & 3u;
			uint index = (uint)((num & -4) / 4);
			MDTables.Tables[] array = new MDTables.Tables[3]
			{
				MDTables.Tables.TypeDef,
				MDTables.Tables.TypeRef,
				MDTables.Tables.TypeSpec
			};
			MetadataToken metadataToken = new MetadataToken(array[num2], index);
			return num2 switch
			{
				0u => new TypeInfo(metadataToken, _assembly), 
				1u => new TypeInfo(metadataToken, _assembly, disambiguatingJunkForTypeRefOverload: false), 
				2u => throw new NotImplementedException(), 
				_ => throw new BadImageFormatException(Res.InvalidMetadataToken), 
			};
		}

		private static uint DecodeInteger(byte[] bytes, ref uint i)
		{
			uint num = bytes[i];
			i++;
			if ((num & 0x80) == 0)
			{
				return num;
			}
			if ((num & 0xC0) == 128)
			{
				uint num2 = bytes[i];
				i++;
				return ((num & 0x7F) * 256) | num2;
			}
			if ((num & 0xE0) == 192)
			{
				uint num3 = bytes[i];
				uint num4 = bytes[i + 1];
				uint num5 = bytes[i + 2];
				i += 3u;
				return ((num & 0x1F) * 1048576) | (num3 * 65536) | (num4 * 256) | num5;
			}
			throw new ArgumentOutOfRangeException("bytes", num, Res.CodedIntegerTooLong);
		}

		public bool Implements(TypeInfo ifaceType)
		{
			if (HasReflectionType)
			{
				Type[] interfaces = _reflectionType.GetInterfaces();
				foreach (Type type in interfaces)
				{
					if (Utils.FullTypeNameDefEqualsDef(type.AssemblyQualifiedName, ifaceType.AssemblyQualifiedName))
					{
						return true;
					}
				}
				return false;
			}
			PEFileReader pEFileReader = _assembly.PEFileReader;
			pEFileReader.InitMetaData();
			MDTables metaData = pEFileReader.MetaData;
			if (_mdToken.Table == MDTables.Tables.TypeRef)
			{
				TypeInfo typeInfo = TypeRefToTypeDef(_mdToken, throwOnError: true);
				return typeInfo.ImplementsHelper(typeInfo._assembly.PEFileReader, typeInfo._mdToken, ifaceType);
			}
			throw new NotImplementedException();
		}

		private bool ImplementsHelper(PEFileReader peFile, MetadataToken typeDefToken, TypeInfo ifaceType)
		{
			MDTables metaData = peFile.MetaData;
			uint num = metaData.RowsInTable(MDTables.Tables.InterfaceImpl);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				metaData.SeekToRowOfTable(MDTables.Tables.InterfaceImpl, num2);
				uint num3 = metaData.ReadRowIndex(MDTables.Tables.TypeDef);
				if (num3 != typeDefToken.Index)
				{
					continue;
				}
				MetadataToken token = metaData.ReadMetadataToken(MDTables.Encodings.TypeDefOrRef);
				if (ifaceType.HasName)
				{
					metaData.SeekToMDToken(token);
					switch (token.Table)
					{
					case MDTables.Tables.TypeRef:
					{
						MetadataToken assemblyRefB = metaData.ReadMetadataToken(MDTables.Encodings.ResolutionScope);
						string a3 = metaData.ReadString();
						if (string.Equals(a3, ifaceType._typeName))
						{
							string a4 = metaData.ReadString();
							if (string.Equals(a4, ifaceType._nameSpace) && MiniAssembly.Equals(ifaceType.Assembly, peFile, assemblyRefB))
							{
								return true;
							}
						}
						break;
					}
					case MDTables.Tables.TypeDef:
					{
						metaData.B.ReadUInt32();
						string a = metaData.ReadString();
						if (string.Equals(a, ifaceType._typeName))
						{
							string a2 = metaData.ReadString();
							if (string.Equals(a2, ifaceType._nameSpace) && _assembly.Equals(ifaceType._assembly))
							{
								return true;
							}
						}
						break;
					}
					default:
						throw new NotImplementedException(string.Format(CultureInfo.CurrentCulture, Res.UnsupportedInterfaceType, new object[1] { token.Table }));
					case MDTables.Tables.TypeSpec:
						break;
					}
					continue;
				}
				throw new NotImplementedException();
			}
			return false;
		}

		internal TypeInfo TypeRefToTypeDef(MetadataToken typeRef, bool throwOnError)
		{
			PEFileReader pEFileReader = _assembly.PEFileReader;
			pEFileReader.InitMetaData();
			MDTables metaData = pEFileReader.MetaData;
			metaData.SeekToMDToken(_mdToken);
			MetadataToken token = metaData.ReadMetadataToken(MDTables.Encodings.ResolutionScope);
			string typeName = metaData.ReadString();
			string nameSpace = metaData.ReadString();
			return _assembly.ResolveAssemblyRef(token, throwOnError)?.FindTypeInfo(typeName, nameSpace);
		}

		internal TypeInfo TryGetTypeDef()
		{
			if (HasReflectionType)
			{
				return null;
			}
			if (HasTypeRef)
			{
				return TypeRefToTypeDef(_mdToken, throwOnError: false);
			}
			return this;
		}

		public TypeInfo[] GetInterfaces()
		{
			List<TypeInfo> list = new List<TypeInfo>();
			if (HasReflectionType)
			{
				Type[] interfaces = _reflectionType.GetInterfaces();
				foreach (Type type in interfaces)
				{
					list.Add(new TypeInfo(type));
				}
			}
			else
			{
				if (HasTypeRef)
				{
					TypeInfo typeInfo = TypeRefToTypeDef(_mdToken, throwOnError: true);
					return typeInfo.GetInterfaces();
				}
				PEFileReader pEFileReader = _assembly.PEFileReader;
				MDTables metaData = pEFileReader.MetaData;
				uint num = metaData.RowsInTable(MDTables.Tables.InterfaceImpl);
				for (uint num2 = 0u; num2 < num; num2++)
				{
					try
					{
						metaData.SeekToRowOfTable(MDTables.Tables.InterfaceImpl, num2);
						uint num3 = metaData.ReadRowIndex(MDTables.Tables.TypeDef);
						if (num3 == _mdToken.Index)
						{
							MetadataToken token = metaData.ReadMetadataToken(MDTables.Encodings.TypeDefOrRef);
							list.Add(TypeInfoFromTypeDefOrRef(token));
						}
					}
					catch (GenericsNotImplementedException)
					{
					}
				}
			}
			return list.ToArray();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is TypeInfo value))
			{
				return false;
			}
			return Equals(value);
		}

		public bool Equals(TypeInfo value)
		{
			if (value == null)
			{
				return false;
			}
			string assemblyQualifiedName = AssemblyQualifiedName;
			string assemblyQualifiedName2 = value.AssemblyQualifiedName;
			return Utils.FullTypeNameDefEqualsDef(assemblyQualifiedName, assemblyQualifiedName2);
		}

		public override int GetHashCode()
		{
			return AssemblyQualifiedName.GetHashCode();
		}

		public override string ToString()
		{
			if (_typeName != null)
			{
				return _nameSpace + "::" + _typeName;
			}
			return "MD Token: " + _mdToken.ToString();
		}

		internal MiniCustomAttributeInfo[] GetCustomAttributeInfos(Type caReflectedType)
		{
			List<MiniCustomAttributeInfo> list = new List<MiniCustomAttributeInfo>();
			PEFileReader pEFileReader = _assembly.PEFileReader;
			pEFileReader.InitMetaData();
			MDTables metaData = pEFileReader.MetaData;
			uint num = metaData.RowsInTable(MDTables.Tables.CustomAttribute);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				metaData.SeekToRowOfTable(MDTables.Tables.CustomAttribute, num2);
				MetadataToken metadataToken = metaData.ReadMetadataToken(MDTables.Encodings.HasCustomAttribute);
				MetadataToken token = metaData.ReadMetadataToken(MDTables.Encodings.CustomAttributeType);
				byte[] caBlob = metaData.ReadBlob();
				if (!metadataToken.Equals(_mdToken))
				{
					continue;
				}
				metaData.SeekToMDToken(token);
				string text = null;
				string text2 = null;
				if (token.Table == MDTables.Tables.MemberRef)
				{
					MetadataToken token2 = metaData.ReadMetadataToken(MDTables.Encodings.MemberRefParent);
					metaData.SeekToMDToken(token2);
					MetadataToken metadataToken2 = metaData.ReadMetadataToken(MDTables.Encodings.ResolutionScope);
					text = metaData.ReadString();
					text2 = metaData.ReadString();
					if (text == caReflectedType.Name && text2 == caReflectedType.Namespace)
					{
						MiniCustomAttributeInfo item = ParseCustomAttribute(caBlob, caReflectedType);
						list.Add(item);
					}
				}
			}
			return list.ToArray();
		}

		private static MiniCustomAttributeInfo ParseCustomAttribute(byte[] caBlob, Type caReflectedType)
		{
			uint b = 2u;
			BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public;
			List<MiniCustomAttributeFixedArgInfo> list = new List<MiniCustomAttributeFixedArgInfo>();
			ConstructorInfo[] constructors = caReflectedType.GetConstructors(bindingAttr);
			if (constructors.Length > 1)
			{
				throw new NotImplementedException();
			}
			ConstructorInfo constructorInfo = constructors[0];
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				if (parameterInfo.ParameterType == typeof(string))
				{
					string value = ReadSerString(caBlob, ref b);
					list.Add(new MiniCustomAttributeFixedArgInfo(value));
					continue;
				}
				throw new NotImplementedException();
			}
			byte b2 = caBlob[b++];
			byte b3 = caBlob[b++];
			int num = (b3 * 256) | b2;
			List<MiniCustomAttributeNamedArgInfo> list2 = new List<MiniCustomAttributeNamedArgInfo>();
			for (int j = 0; j < num; j++)
			{
				ReadNamedArg(caBlob, ref b, out var name, out var value2);
				list2.Add(new MiniCustomAttributeNamedArgInfo(CorElementType.String, name, value2));
			}
			return new MiniCustomAttributeInfo(caReflectedType.Name, list.ToArray(), list2.ToArray());
		}

		private static string ReadSerString(byte[] bytes, ref uint b)
		{
			if (bytes[b] == byte.MaxValue)
			{
				b++;
				return null;
			}
			uint num = DecodeInteger(bytes, ref b);
			string @string = s_encoder.GetString(bytes, (int)b, (int)num);
			b += num;
			return @string;
		}

		private static void ReadNamedArg(byte[] bytes, ref uint b, out string name, out string value)
		{
			int num = bytes[b++];
			int num2 = bytes[b++];
			if (num2 != 14)
			{
				throw new NotImplementedException();
			}
			string text = ReadSerString(bytes, ref b);
			name = text;
			string text2 = ReadSerString(bytes, ref b);
			value = text2;
		}
	}
	[Serializable]
	internal class GenericsNotImplementedException : Exception
	{
		protected GenericsNotImplementedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		internal GenericsNotImplementedException()
		{
		}
	}
}
namespace System.AddIn.MiniReflection.MetadataReader
{
	internal struct AssemblyInfo
	{
		private Version m_Version;

		private uint m_Flags;

		private string m_SimpleName;

		private string m_Culture;

		private byte[] m_PublicKey;

		private string m_FullName;

		private string m_PublicKeyToken;

		public string PublicKeyToken
		{
			get
			{
				if (m_PublicKeyToken == null)
				{
					if (m_PublicKey == null)
					{
						return null;
					}
					byte[] array = new byte[8];
					if ((m_Flags & (true ? 1u : 0u)) != 0)
					{
						using SHA1 sHA = SHA1.Create();
						byte[] array2 = sHA.ComputeHash(m_PublicKey);
						int num = 0;
						int num2 = array2.Length - 1;
						while (num < 8)
						{
							array[num] = array2[num2];
							num++;
							num2--;
						}
					}
					else
					{
						array = m_PublicKey;
					}
					m_PublicKeyToken = PEFileReader.BytesToHexString(array);
				}
				return m_PublicKeyToken;
			}
		}

		public Version Version => m_Version;

		public AssemblyInfo(AssemblyName AN)
		{
			m_Version = AN.Version;
			m_Flags = (uint)AN.Flags;
			byte[] array = (((m_Flags & (true ? 1u : 0u)) != 0) ? AN.GetPublicKey() : AN.GetPublicKeyToken());
			if (array != null && array.Length == 0)
			{
				m_PublicKey = null;
			}
			else
			{
				m_PublicKey = array;
			}
			m_SimpleName = AN.Name;
			m_Culture = AN.CultureInfo.Name;
			if (m_Culture.Length == 0)
			{
				m_Culture = null;
			}
			m_FullName = null;
			m_PublicKeyToken = null;
		}

		internal AssemblyInfo(Version V, uint Flags, byte[] PublicKeyOrToken, string Name, string Culture)
		{
			m_Version = V;
			m_Flags = Flags;
			m_PublicKey = PublicKeyOrToken;
			m_SimpleName = Name;
			m_Culture = Culture;
			m_FullName = null;
			m_PublicKeyToken = null;
		}

		public static implicit operator AssemblyInfo(AssemblyName AN)
		{
			return new AssemblyInfo(AN);
		}

		public override string ToString()
		{
			if (m_FullName == null)
			{
				m_FullName = m_SimpleName + ", Version=" + Version.Major + "." + Version.Minor + "." + Version.Build + "." + Version.Revision;
				m_FullName = m_FullName + ", Culture=" + ((m_Culture == null) ? "neutral" : m_Culture);
				string publicKeyToken = PublicKeyToken;
				m_FullName = m_FullName + ", PublicKeyToken=" + ((publicKeyToken == null) ? "null" : publicKeyToken);
			}
			return m_FullName;
		}
	}
	[Serializable]
	internal enum CorElementType : byte
	{
		End = 0,
		Void = 1,
		Boolean = 2,
		Char = 3,
		I1 = 4,
		U1 = 5,
		I2 = 6,
		U2 = 7,
		I4 = 8,
		U4 = 9,
		I8 = 10,
		U8 = 11,
		R4 = 12,
		R8 = 13,
		String = 14,
		Ptr = 15,
		ByRef = 16,
		ValueType = 17,
		Class = 18,
		Var = 19,
		Array = 20,
		GenericInst = 21,
		TypedByRef = 22,
		I = 24,
		U = 25,
		FnPtr = 27,
		Object = 28,
		SzArray = 29,
		MVar = 30,
		CModReqd = 31,
		CModOpt = 32,
		Internal = 33,
		Max = 34,
		Modifier = 64,
		Sentinel = 65,
		Pinned = 69
	}
	[Serializable]
	[Flags]
	internal enum MdSigCallingConvention : byte
	{
		CallConvMask = 0xF,
		Default = 0,
		C = 1,
		StdCall = 2,
		ThisCall = 3,
		FastCall = 4,
		Vararg = 5,
		Field = 6,
		LocalSig = 7,
		Property = 8,
		Unmgd = 9,
		GenericInst = 0xA,
		Generic = 0x10,
		HasThis = 0x20,
		ExplicitThis = 0x40
	}
	internal enum MDFileAttributes
	{
		ContainsMetaData,
		ContainsNoMetaData
	}
	[Serializable]
	internal struct MetadataToken
	{
		public MDTables.Tables Table;

		public uint Index;

		public MetadataToken(MDTables.Tables table, uint index)
		{
			Table = table;
			Index = index;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "Table {0} ({1}), entry {2}", new object[3]
			{
				MDTables.Names[(int)Table],
				(uint)Table,
				Index
			});
		}

		public string ToMDToken()
		{
			return string.Format(CultureInfo.InvariantCulture, "{0:x2}{1:x6}", new object[2]
			{
				(uint)Table,
				Index
			});
		}
	}
	internal sealed class MDTables
	{
		internal enum Tables
		{
			Invalid = -1,
			XModule = 0,
			TypeRef = 1,
			TypeDef = 2,
			FieldPtr = 3,
			FieldDef = 4,
			MethodPtr = 5,
			MethodDef = 6,
			ParamPtr = 7,
			ParamDef = 8,
			InterfaceImpl = 9,
			MemberRef = 10,
			Constant = 11,
			CustomAttribute = 12,
			FieldMarshal = 13,
			DeclSecurity = 14,
			ClassLayout = 15,
			FieldLayout = 16,
			StandAloneSig = 17,
			EventMap = 18,
			EventPtr = 19,
			XEvent = 20,
			PropertyMap = 21,
			PropertyPtr = 22,
			XProperty = 23,
			MethodSemantics = 24,
			MethodImpl = 25,
			ModuleRef = 26,
			TypeSpec = 27,
			ImplMap = 28,
			FieldRVA = 29,
			XAssembly = 32,
			AssemblyProcessor = 33,
			AssemblyOS = 34,
			AssemblyRef = 35,
			AssemblyRefProcessor = 36,
			AssemblyRefOS = 37,
			File = 38,
			ExportedType = 39,
			ManifestResource = 40,
			NestedClass = 41,
			GenericParam = 42,
			GenericMethod = 43,
			GenericConstraint = 44,
			MaxTable = 63
		}

		internal enum Encodings
		{
			TypeDefOrRef,
			HasConstant,
			HasCustomAttribute,
			HasFieldMarshall,
			HasDeclSecurity,
			MemberRefParent,
			HasSemantics,
			MethodDefOrRef,
			MemberForwarded,
			Implementation,
			CustomAttributeType,
			ResolutionScope,
			TypeOrMethodDef
		}

		private struct EncodingDesc
		{
			private string Name;

			internal int TagBits;

			internal Tables[] WhichTables;

			internal EncodingDesc(string N, int T, Tables[] W)
			{
				Name = N;
				TagBits = T;
				WhichTables = W;
			}
		}

		internal static readonly string[] Names;

		internal static readonly bool[] IsDefined;

		private static readonly UTF8Encoding Encoder;

		internal BinaryReader B;

		private StreamDesc stringStream;

		private StreamDesc blobStream;

		private uint[] lengths;

		private uint[] tableAt;

		private uint[] NRows;

		private uint stringIndex;

		private uint blobIndex;

		private uint GUIDIndex;

		private static readonly EncodingDesc[] EncodingDescs;

		static MDTables()
		{
			Names = new string[64];
			IsDefined = new bool[64];
			Encoder = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
			EncodingDescs = new EncodingDesc[13]
			{
				new EncodingDesc("TypeDefOrRef", 2, new Tables[3]
				{
					Tables.TypeDef,
					Tables.TypeRef,
					Tables.TypeSpec
				}),
				new EncodingDesc("HasConstant", 2, new Tables[3]
				{
					Tables.FieldDef,
					Tables.ParamDef,
					Tables.XProperty
				}),
				new EncodingDesc("HasCustomAttribute", 5, new Tables[22]
				{
					Tables.MethodDef,
					Tables.FieldDef,
					Tables.TypeRef,
					Tables.TypeDef,
					Tables.ParamDef,
					Tables.InterfaceImpl,
					Tables.MemberRef,
					Tables.XModule,
					Tables.DeclSecurity,
					Tables.XProperty,
					Tables.XEvent,
					Tables.StandAloneSig,
					Tables.ModuleRef,
					Tables.TypeSpec,
					Tables.XAssembly,
					Tables.AssemblyRef,
					Tables.File,
					Tables.ExportedType,
					Tables.ManifestResource,
					Tables.GenericParam,
					Tables.GenericConstraint,
					Tables.GenericParam
				}),
				new EncodingDesc("HasFieldMarshall", 1, new Tables[2]
				{
					Tables.FieldDef,
					Tables.ParamDef
				}),
				new EncodingDesc("HasDeclSecurity", 2, new Tables[3]
				{
					Tables.TypeDef,
					Tables.MethodDef,
					Tables.XAssembly
				}),
				new EncodingDesc("MemberRefParent", 3, new Tables[5]
				{
					Tables.TypeDef,
					Tables.TypeRef,
					Tables.ModuleRef,
					Tables.MethodDef,
					Tables.TypeSpec
				}),
				new EncodingDesc("HasSemantics", 1, new Tables[2]
				{
					Tables.XEvent,
					Tables.XProperty
				}),
				new EncodingDesc("MethodDefOrRef", 1, new Tables[2]
				{
					Tables.MethodDef,
					Tables.MemberRef
				}),
				new EncodingDesc("MemberForwarded", 1, new Tables[2]
				{
					Tables.FieldDef,
					Tables.MethodDef
				}),
				new EncodingDesc("Implementation", 2, new Tables[3]
				{
					Tables.File,
					Tables.AssemblyRef,
					Tables.ExportedType
				}),
				new EncodingDesc("CustomAttributeType", 3, new Tables[4]
				{
					Tables.Invalid,
					Tables.Invalid,
					Tables.MethodDef,
					Tables.MemberRef
				}),
				new EncodingDesc("ResolutionScope", 2, new Tables[4]
				{
					Tables.XModule,
					Tables.ModuleRef,
					Tables.AssemblyRef,
					Tables.TypeRef
				}),
				new EncodingDesc("TypeOrMethodDef", 1, new Tables[2]
				{
					Tables.TypeDef,
					Tables.MethodDef
				})
			};
			Names[34] = "AssemblyOS";
			Names[33] = "AssemblyProcessor";
			Names[35] = "AssemblyRef";
			Names[37] = "AssemblyRefOS";
			Names[36] = "AssemblyRefProcessor";
			Names[15] = "ClassLayout";
			Names[11] = "Constant";
			Names[12] = "CustomAttribute";
			Names[14] = "DeclSecurity";
			Names[18] = "EventMap";
			Names[39] = "ExportedType";
			Names[4] = "FieldDef";
			Names[16] = "FieldLayout";
			Names[13] = "FieldMarshal";
			Names[29] = "FieldRVA";
			Names[38] = "File";
			Names[42] = "GenericParam";
			Names[43] = "GenericMethod";
			Names[44] = "GenericConstraint";
			Names[28] = "ImplMap";
			Names[9] = "InterfaceImpl";
			Names[40] = "ManifestResource";
			Names[10] = "MemberRef";
			Names[6] = "MethodDef";
			Names[25] = "MethodImpl";
			Names[24] = "MethodSemantics";
			Names[26] = "ModuleRef";
			Names[41] = "NestedClass";
			Names[8] = "ParamDef";
			Names[21] = "PropertyMap";
			Names[17] = "StandAloneSig";
			Names[2] = "TypeDef";
			Names[1] = "TypeRef";
			Names[27] = "TypeSpec";
			Names[32] = "Assembly";
			Names[20] = "Event";
			Names[0] = "Module";
			Names[23] = "Property";
			Names[3] = "FieldPointer";
			Names[5] = "MethodPointer";
			Names[7] = "ParamPointer";
			Names[19] = "EventPointer";
			Names[22] = "PropertyPointer";
			for (int i = 0; i <= 63; i++)
			{
				IsDefined[i] = Names[i] != null;
				if (!IsDefined[i])
				{
					Names[i] = string.Format(CultureInfo.InvariantCulture, "<<{0}>>", new object[1] { i });
				}
			}
		}

		internal MDTables(BinaryReader reader, StreamDesc stringSD, StreamDesc blobSD)
		{
			stringStream = stringSD;
			blobStream = blobSD;
			B = reader;
			B.BaseStream.Seek(4L, SeekOrigin.Current);
			byte b = B.ReadByte();
			byte b2 = B.ReadByte();
			byte b3 = B.ReadByte();
			stringIndex = (((b3 & 1) == 0) ? 2u : 4u);
			GUIDIndex = (((b3 & 2) == 0) ? 2u : 4u);
			blobIndex = (((b3 & 4) == 0) ? 2u : 4u);
			B.ReadByte();
			ulong num = B.ReadUInt64();
			ulong num2 = B.ReadUInt64();
			NRows = new uint[64];
			int num3 = 0;
			ulong num4 = 1uL;
			int num5 = 0;
			while (num5 <= 63)
			{
				if ((num & num4) != 0L)
				{
					NRows[num5] = B.ReadUInt32();
					_ = NRows[num5];
					num3++;
				}
				num5++;
				num4 <<= 1;
			}
			ComputeRowLengths();
			tableAt = new uint[64];
			num4 = 1uL;
			uint num6 = (uint)B.BaseStream.Position;
			int num7 = 0;
			while (num7 <= 63)
			{
				tableAt[num7] = num6;
				num6 += lengths[num7] * NRows[num7];
				if ((num & num4) != 0L && NRows[num7] != 0 && lengths[num7] == 0)
				{
					throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.UnknownMetadataTable, new object[1] { num7 }));
				}
				num7++;
				num4 <<= 1;
			}
		}

		private uint MetadataTokenSize(Encodings Which)
		{
			EncodingDesc encodingDesc = EncodingDescs[(int)Which];
			int tagBits = encodingDesc.TagBits;
			uint num = 0u;
			Tables[] whichTables = encodingDesc.WhichTables;
			foreach (Tables tables in whichTables)
			{
				if (tables != Tables.Invalid)
				{
					uint num2 = NRows[(int)tables];
					if (num2 > num)
					{
						num = num2;
					}
				}
			}
			if (num >= 1 << 16 - tagBits)
			{
				return 4u;
			}
			return 2u;
		}

		private uint RowSize(Tables Table)
		{
			if (NRows[(int)Table] >= 65536)
			{
				return 4u;
			}
			return 2u;
		}

		private void ComputeRowLengths()
		{
			lengths = new uint[64];
			lengths[32] = 16 + blobIndex + 2 * stringIndex;
			lengths[34] = 12u;
			lengths[33] = 4u;
			lengths[35] = 12 + 2 * blobIndex + 2 * stringIndex;
			lengths[37] = 12 + RowSize(Tables.AssemblyRef);
			lengths[36] = 4 + RowSize(Tables.AssemblyRef);
			lengths[15] = 6 + RowSize(Tables.TypeDef);
			lengths[11] = 2 + MetadataTokenSize(Encodings.HasConstant) + blobIndex;
			lengths[12] = MetadataTokenSize(Encodings.HasCustomAttribute) + MetadataTokenSize(Encodings.CustomAttributeType) + blobIndex;
			lengths[14] = 2 + MetadataTokenSize(Encodings.HasDeclSecurity) + blobIndex;
			lengths[18] = RowSize(Tables.TypeDef) + RowSize(Tables.XEvent);
			lengths[20] = 2 + stringIndex + MetadataTokenSize(Encodings.TypeDefOrRef);
			lengths[39] = 8 + stringIndex * 2 + MetadataTokenSize(Encodings.Implementation);
			lengths[4] = 2 + stringIndex + blobIndex;
			lengths[16] = 4 + RowSize(Tables.FieldDef);
			lengths[13] = MetadataTokenSize(Encodings.HasFieldMarshall) + blobIndex;
			lengths[29] = 4 + RowSize(Tables.FieldDef);
			lengths[38] = 4 + stringIndex + blobIndex;
			lengths[42] = 4 + MetadataTokenSize(Encodings.TypeOrMethodDef) + stringIndex;
			lengths[43] = MetadataTokenSize(Encodings.MethodDefOrRef) + blobIndex;
			lengths[44] = RowSize(Tables.GenericParam) + MetadataTokenSize(Encodings.TypeDefOrRef);
			lengths[28] = 2 + MetadataTokenSize(Encodings.MemberForwarded) + stringIndex + RowSize(Tables.ModuleRef);
			lengths[9] = RowSize(Tables.TypeDef) + MetadataTokenSize(Encodings.TypeDefOrRef);
			lengths[40] = 8 + stringIndex + MetadataTokenSize(Encodings.Implementation);
			lengths[10] = MetadataTokenSize(Encodings.MemberRefParent) + stringIndex + blobIndex;
			lengths[6] = 8 + stringIndex + blobIndex + RowSize(Tables.ParamDef);
			lengths[25] = RowSize(Tables.TypeDef) + MetadataTokenSize(Encodings.MethodDefOrRef) * 2;
			lengths[24] = 2 + RowSize(Tables.MethodDef) + MetadataTokenSize(Encodings.HasSemantics);
			lengths[0] = 2 + stringIndex + GUIDIndex * 3;
			lengths[26] = stringIndex;
			lengths[41] = RowSize(Tables.TypeDef) * 2;
			lengths[8] = 4 + stringIndex;
			lengths[23] = 2 + stringIndex + blobIndex;
			lengths[21] = RowSize(Tables.TypeDef) + RowSize(Tables.XProperty);
			lengths[17] = blobIndex;
			lengths[2] = 4 + stringIndex * 2 + MetadataTokenSize(Encodings.TypeDefOrRef) + RowSize(Tables.FieldDef) + RowSize(Tables.MethodDef);
			lengths[1] = MetadataTokenSize(Encodings.ResolutionScope) + stringIndex * 2;
			lengths[27] = blobIndex;
			lengths[3] = RowSize(Tables.FieldDef);
			lengths[5] = RowSize(Tables.MethodDef);
			lengths[7] = RowSize(Tables.ParamDef);
			lengths[19] = RowSize(Tables.XEvent);
			lengths[22] = RowSize(Tables.XProperty);
		}

		internal void SeekToRowOfTable(Tables T, uint Row)
		{
			if (Row >= NRows[(int)T])
			{
				throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.InvalidMetadataTokenTooManyRows, Row, T, Names[(int)T], NRows[(int)T]));
			}
			B.BaseStream.Seek(tableAt[(int)T] + Row * lengths[(int)T], SeekOrigin.Begin);
		}

		internal void SeekToMDToken(MetadataToken token)
		{
			if (token.Index == 0)
			{
				throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.NilMetadataToken, new object[1] { token }));
			}
			SeekToRowOfTable(token.Table, token.Index - 1);
		}

		internal uint ReadStringIndex()
		{
			if (stringIndex == 2)
			{
				return B.ReadUInt16();
			}
			return B.ReadUInt32();
		}

		private string GetString(uint index)
		{
			stringStream.SeekTo(B, index);
			return ReadNextString();
		}

		private string ReadNextString()
		{
			List<byte> list = new List<byte>();
			byte item;
			while ((item = B.ReadByte()) != 0)
			{
				list.Add(item);
			}
			return Encoder.GetString(list.ToArray());
		}

		internal byte[] ReadBlob()
		{
			uint num = ReadBlobIndex();
			if (num == 0)
			{
				return null;
			}
			uint num2 = (uint)B.BaseStream.Position;
			blobStream.SeekTo(B, num);
			uint num3 = B.ReadByte();
			byte[] array = null;
			if ((num3 & 0x80u) != 0)
			{
				num3 = (((num3 & 0xC0) != 128) ? (((num3 & 0x7F) << 24) + (ushort)(B.ReadByte() << 16) + B.ReadUInt16()) : (((num3 & 0x7F) << 8) + B.ReadByte()));
			}
			if (num3 != 0)
			{
				array = new byte[num3];
				for (uint num4 = 0u; num4 < num3; num4++)
				{
					array[num4] = B.ReadByte();
				}
			}
			B.BaseStream.Seek(num2, SeekOrigin.Begin);
			return array;
		}

		internal string ReadString()
		{
			uint index = ReadStringIndex();
			uint num = (uint)B.BaseStream.Position;
			string @string = GetString(index);
			B.BaseStream.Seek(num, SeekOrigin.Begin);
			return @string;
		}

		internal uint ReadBlobIndex()
		{
			if (blobIndex == 2)
			{
				return B.ReadUInt16();
			}
			return B.ReadUInt32();
		}

		internal uint ReadRowIndex(Tables T)
		{
			if (RowSize(T) == 2)
			{
				return B.ReadUInt16();
			}
			return B.ReadUInt32();
		}

		internal uint RowsInTable(Tables T)
		{
			return NRows[(int)T];
		}

		internal MetadataToken ReadMetadataToken(Encodings E)
		{
			uint num = ((MetadataTokenSize(E) == 2) ? B.ReadUInt16() : B.ReadUInt32());
			EncodingDesc encodingDesc = EncodingDescs[(int)E];
			Tables[] whichTables = encodingDesc.WhichTables;
			uint num2 = (uint)((1 << encodingDesc.TagBits) - 1);
			MetadataToken result = default(MetadataToken);
			result.Table = whichTables[num & num2];
			result.Index = num >> encodingDesc.TagBits;
			if (result.Table == Tables.Invalid)
			{
				throw new BadImageFormatException(Res.InvalidMetadataTokenNilTable);
			}
			return result;
		}
	}
	internal sealed class StreamDesc
	{
		private uint offset;

		private uint position;

		internal string Name;

		internal StreamDesc(BinaryReader B, uint metadataRoot)
		{
			offset = B.ReadUInt32();
			position = offset + metadataRoot;
			B.ReadUInt32();
			int num = 1;
			StringBuilder stringBuilder = new StringBuilder();
			char value;
			while ((value = (char)B.ReadByte()) != 0)
			{
				stringBuilder.Append(value);
				num++;
			}
			while (((uint)num++ & 3u) != 0)
			{
				B.ReadByte();
			}
			Name = stringBuilder.ToString();
		}

		internal void SeekTo(BinaryReader B, uint Nth)
		{
			B.BaseStream.Seek(position + Nth, SeekOrigin.Begin);
		}
	}
	internal sealed class PEFileReader : IDisposable
	{
		private struct SectionDesc
		{
			private string Name;

			private uint VirtualAddress;

			private uint Size;

			private uint FileOffset;

			internal uint RVAToFileAddress(uint RVA)
			{
				if (RVA < VirtualAddress || RVA >= VirtualAddress + Size)
				{
					return 0u;
				}
				return RVA - VirtualAddress + FileOffset;
			}

			private static string ReadString(BinaryReader B, uint NChars)
			{
				StringBuilder stringBuilder = new StringBuilder((int)NChars);
				for (int i = 1; i <= NChars; i++)
				{
					byte b = B.ReadByte();
					stringBuilder.Append((char)((b == 0) ? 32 : b));
				}
				return stringBuilder.ToString();
			}

			internal void Read(BinaryReader B)
			{
				Name = ReadString(B, 8u);
				Size = B.ReadUInt32();
				VirtualAddress = B.ReadUInt32();
				B.ReadUInt32();
				FileOffset = B.ReadUInt32();
			}
		}

		private static readonly UTF8Encoding Encoder = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

		internal BinaryReader B;

		private SectionDesc[] Sections;

		private uint MetadataRoot;

		private StreamDesc[] Streams;

		private uint MetaDataDDRVA;

		private MDTables metaData;

		private bool parsedMetaData;

		private string _fileName;

		internal MDTables MetaData
		{
			get
			{
				if (!parsedMetaData)
				{
					InitMetaData();
				}
				return metaData;
			}
		}

		public PEFileReader(string fileName)
		{
			_fileName = fileName;
			FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.RandomAccess);
			B = new BinaryReader(input);
			B.BaseStream.Seek(60L, SeekOrigin.Begin);
			uint num = B.ReadUInt32();
			B.BaseStream.Seek(num, SeekOrigin.Begin);
			if (B.ReadByte() != 80 || B.ReadByte() != 69 || B.ReadByte() != 0 || B.ReadByte() != 0)
			{
				throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.BadPEFile, new object[1] { fileName }));
			}
			uint num2 = num + 24;
			B.BaseStream.Seek(num2, SeekOrigin.Begin);
			ushort num3 = B.ReadUInt16();
			ushort num4 = 0;
			num4 = num3 switch
			{
				267 => 96, 
				523 => 112, 
				_ => throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.BadPEFile, new object[1] { fileName })), 
			};
			uint num5 = num + 4;
			uint num6 = num5 + 2;
			uint num7 = num5 + 20;
			uint num8 = num7 + num4 + 112;
			B.BaseStream.Seek(num8, SeekOrigin.Begin);
			uint num9 = B.ReadUInt32();
			MetaDataDDRVA = num9 + 8;
			uint num10 = num7 + num4 + 128;
			B.BaseStream.Seek(num6, SeekOrigin.Begin);
			ushort num11 = B.ReadUInt16();
			B.BaseStream.Seek(num10, SeekOrigin.Begin);
			Sections = new SectionDesc[num11];
			for (ushort num12 = 0; num12 < num11; num12++)
			{
				B.BaseStream.Seek(num10 + num12 * 40, SeekOrigin.Begin);
				Sections[num12].Read(B);
			}
		}

		public void Dispose()
		{
			if (B != null)
			{
				B.Close();
				B = null;
			}
		}

		private bool FindStream(string name, out StreamDesc result)
		{
			StreamDesc[] streams = Streams;
			foreach (StreamDesc streamDesc in streams)
			{
				if (streamDesc.Name.Equals(name))
				{
					result = streamDesc;
					return true;
				}
			}
			result = null;
			return false;
		}

		private string ReadUTF8String(uint NChars)
		{
			return Encoder.GetString(B.ReadBytes((int)NChars));
		}

		private uint RVAToFileAddress(uint RVA)
		{
			SectionDesc[] sections = Sections;
			foreach (SectionDesc sectionDesc in sections)
			{
				uint num = sectionDesc.RVAToFileAddress(RVA);
				if (num != 0)
				{
					return num;
				}
			}
			throw new BadImageFormatException(string.Format(CultureInfo.CurrentCulture, Res.BadRVA, new object[1] { _fileName }));
		}

		private void SeekToRVA(uint RVA)
		{
			B.BaseStream.Seek(RVAToFileAddress(RVA), SeekOrigin.Begin);
		}

		internal void InitMetaData()
		{
			if (B == null)
			{
				throw new ObjectDisposedException(null);
			}
			if (!parsedMetaData)
			{
				SeekToRVA(MetaDataDDRVA);
				uint num = B.ReadUInt32();
				uint num2 = B.ReadUInt32();
				if (num == 0 || num2 == 0)
				{
					throw new BadImageFormatException();
				}
				MetadataRoot = RVAToFileAddress(num);
				uint num3 = num + 12;
				uint num4 = num3 + 4;
				SeekToRVA(num3);
				uint num5 = B.ReadUInt32();
				string text = ReadUTF8String(num5);
				uint num6 = num4 + num5;
				uint rVA = num6 + 2;
				SeekToRVA(rVA);
				ushort num7 = B.ReadUInt16();
				Streams = new StreamDesc[num7];
				for (int i = 0; i < num7; i++)
				{
					Streams[i] = new StreamDesc(B, MetadataRoot);
				}
				if (!FindStream("#~", out var result) && !FindStream("#-", out result))
				{
					throw new BadImageFormatException();
				}
				if (!FindStream("#Strings", out var result2))
				{
					throw new BadImageFormatException();
				}
				if (!FindStream("#Blob", out var result3))
				{
					throw new BadImageFormatException();
				}
				result.SeekTo(B, 0u);
				metaData = new MDTables(B, result2, result3);
				parsedMetaData = true;
			}
		}

		private static string HexChar(int x)
		{
			return x switch
			{
				0 => "0", 
				1 => "1", 
				2 => "2", 
				3 => "3", 
				4 => "4", 
				5 => "5", 
				6 => "6", 
				7 => "7", 
				8 => "8", 
				9 => "9", 
				10 => "a", 
				11 => "b", 
				12 => "c", 
				13 => "d", 
				14 => "e", 
				15 => "f", 
				_ => throw new ArgumentOutOfRangeException("x"), 
			};
		}

		internal static string ByteToHexString(byte b)
		{
			return HexChar((b & 0xF0) >> 4) + HexChar(b & 0xF);
		}

		internal static string BytesToHexString(byte[] bytes)
		{
			if (bytes == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(2 * bytes.Length);
			for (int i = 0; i < bytes.Length; i++)
			{
				stringBuilder.Append(ByteToHexString(bytes[i]));
			}
			return stringBuilder.ToString();
		}

		public bool GetAssemblyInfo(ref AssemblyInfo result)
		{
			InitMetaData();
			MetaData.SeekToRowOfTable(MDTables.Tables.XAssembly, 0u);
			uint num = B.ReadUInt32();
			ushort major = B.ReadUInt16();
			ushort minor = B.ReadUInt16();
			ushort build = B.ReadUInt16();
			ushort revision = B.ReadUInt16();
			Version v = new Version(major, minor, build, revision);
			uint flags = B.ReadUInt32();
			byte[] publicKeyOrToken = MetaData.ReadBlob();
			string name = MetaData.ReadString();
			string text = MetaData.ReadString();
			if (text != null && text.Length == 0)
			{
				text = null;
			}
			result = new AssemblyInfo(v, flags, publicKeyOrToken, name, text);
			return true;
		}
	}
}
namespace System.AddIn.Hosting
{
	internal sealed class ActivationWorker : MarshalByRefObject, IDisposable
	{
		private AddInToken _pipeline;

		private ResolveEventHandler _assemblyResolver;

		private PipelineComponentType _currentComponentType;

		private bool _usingHostAppDomain;

		internal bool UsingHostAppDomain
		{
			set
			{
				_usingHostAppDomain = value;
			}
		}

		internal ActivationWorker(AddInToken pipeline)
		{
			_pipeline = pipeline;
		}

		[SecuritySafeCritical]
		public void Dispose()
		{
			if (_assemblyResolver != null)
			{
				AppDomain.CurrentDomain.AssemblyResolve -= _assemblyResolver;
				_assemblyResolver = null;
			}
		}

		public override object InitializeLifetimeService()
		{
			return null;
		}

		[SecuritySafeCritical]
		internal IContract Activate()
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.Combine(_pipeline.PipelineRootDirectory, "Contracts")));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.Combine(_pipeline.PipelineRootDirectory, "AddInSideAdapters")));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.Combine(_pipeline.PipelineRootDirectory, "AddInViews")));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.GetDirectoryName(_pipeline._addin.Location)));
			permissionSet.Assert();
			Assembly.LoadFrom(_pipeline._contract.Location);
			bool flag = false;
			if (_usingHostAppDomain)
			{
				flag = IsAssemblyLoaded(_pipeline._addinBase._assemblyName);
			}
			if (!flag)
			{
				Assembly.LoadFrom(_pipeline._addinBase.Location);
			}
			Assembly assembly = Assembly.LoadFrom(_pipeline._addin.Location);
			Assembly addinAdapterAssembly = Assembly.LoadFrom(_pipeline._addinAdapter.Location);
			CodeAccessPermission.RevertAssert();
			_assemblyResolver = ResolveAssembly;
			AppDomain.CurrentDomain.AssemblyResolve += _assemblyResolver;
			_currentComponentType = PipelineComponentType.AddIn;
			Type type = assembly.GetType(_pipeline._addin.TypeInfo.FullName, throwOnError: true);
			object addIn = type.GetConstructor(new Type[0]).Invoke(new object[0]);
			return CreateAddInAdapter(addIn, addinAdapterAssembly);
		}

		[SecuritySafeCritical]
		private static bool IsAssemblyLoaded(string assemblyName)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllLocalFiles = FileIOPermissionAccess.PathDiscovery;
			fileIOPermission.Assert();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				if (assembly.FullName.Equals(assemblyName, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
				AssemblyName assemblyName2 = new AssemblyName(assemblyName);
				AssemblyName name = assembly.GetName();
				if (assemblyName2.Name == name.Name && assemblyName2.CultureInfo.Equals(name.CultureInfo) && Utils.PublicKeyMatches(assemblyName2, name) && assemblyName2.Version != name.Version)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.IncompatibleAddInBaseAssembly, new object[1] { assemblyName }));
				}
			}
			return false;
		}

		[SecuritySafeCritical]
		internal IContract CreateAddInAdapter(object addIn, Assembly addinAdapterAssembly)
		{
			IContract contract = null;
			_currentComponentType = PipelineComponentType.AddInAdapter;
			Type type = addinAdapterAssembly.GetType(_pipeline._addinAdapter.TypeInfo.FullName, throwOnError: true);
			Type type2 = Type.GetType(_pipeline._addinBase.TypeInfo.AssemblyQualifiedName, throwOnError: true);
			AddInActivator.InvokerDelegate invokerDelegate = AddInActivator.CreateConsInvoker(type, addIn.GetType());
			return (IContract)invokerDelegate(addIn);
		}

		[SecuritySafeCritical]
		internal Assembly ResolveAssembly(object sender, ResolveEventArgs args)
		{
			string name = args.Name;
			Assembly assembly = Utils.FindLoadedAssemblyRef(name);
			if (assembly != null)
			{
				return assembly;
			}
			string pipelineRootDirectory = _pipeline.PipelineRootDirectory;
			List<string> list = new List<string>();
			switch (_currentComponentType)
			{
			case PipelineComponentType.AddInAdapter:
				list.Add(Path.Combine(pipelineRootDirectory, "Contracts"));
				list.Add(Path.Combine(pipelineRootDirectory, "AddInViews"));
				break;
			case PipelineComponentType.AddIn:
				list.Add(Path.Combine(pipelineRootDirectory, "AddInViews"));
				break;
			default:
				throw new InvalidOperationException("Fell through switch in assembly resolve event!");
			}
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			foreach (string item in list)
			{
				permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, item));
			}
			permissionSet.Assert();
			return Utils.LoadAssemblyFrom(list, name);
		}
	}
	internal static class AddInActivator
	{
		internal delegate object InvokerDelegate(object contract);

		internal sealed class ResolverHelper
		{
			private ContractComponent _contract;

			internal ResolverHelper(AddInToken pipeline)
				: this(pipeline._contract)
			{
			}

			internal ResolverHelper(ContractComponent contract)
			{
				_contract = contract;
			}

			internal Assembly ResolveAssemblyForHostAdapter(object sender, ResolveEventArgs args)
			{
				string name = args.Name;
				Assembly assembly = Utils.FindLoadedAssemblyRef(name);
				if (assembly != null)
				{
					return assembly;
				}
				List<string> list = new List<string>();
				string directoryName = Path.GetDirectoryName(_contract.Location);
				list.Add(directoryName);
				return Utils.LoadAssemblyFrom(list, name);
			}
		}

		internal static T Activate<T>(AddInToken token, AddInSecurityLevel level)
		{
			if (token == null)
			{
				throw new ArgumentNullException("token");
			}
			return Activate<T>(token, level, token.Name);
		}

		internal static T Activate<T>(AddInToken token, AddInSecurityLevel level, string appDomainName)
		{
			if (token == null)
			{
				throw new ArgumentNullException("token");
			}
			if (appDomainName == null)
			{
				throw new ArgumentNullException("appDomainName");
			}
			PermissionSet permissionSetForLevel = GetPermissionSetForLevel(level);
			return Activate<T>(token, permissionSetForLevel, appDomainName);
		}

		[SecuritySafeCritical]
		internal static PermissionSet GetPermissionSetForLevel(AddInSecurityLevel level)
		{
			if (AddInSecurityLevel.Internet > level || level > AddInSecurityLevel.Host)
			{
				throw new ArgumentOutOfRangeException("level");
			}
			if (level == AddInSecurityLevel.Host)
			{
				return AppDomain.CurrentDomain.PermissionSet;
			}
			Evidence evidence = new Evidence();
			switch (level)
			{
			case AddInSecurityLevel.Internet:
				evidence.AddHostEvidence(new Zone(SecurityZone.Internet));
				break;
			case AddInSecurityLevel.Intranet:
				evidence.AddHostEvidence(new Zone(SecurityZone.Intranet));
				break;
			case AddInSecurityLevel.FullTrust:
				evidence.AddHostEvidence(new Zone(SecurityZone.MyComputer));
				break;
			default:
				if (level != 0)
				{
					throw new ArgumentOutOfRangeException("level");
				}
				break;
			}
			return SecurityManager.GetStandardSandbox(evidence);
		}

		[SecurityCritical]
		[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
		private static AppDomain CreateDomain(AddInToken token, PermissionSet permissionSet, string appDomainName)
		{
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.ApplicationBase = Path.GetDirectoryName(token._addin.Location);
			appDomainSetup.ConfigurationFile = token._addin.Location + ".config";
			Assembly assembly = typeof(AddInActivator).Assembly;
			AppDomain appDomain = AppDomain.CreateDomain(appDomainName, AppDomain.CurrentDomain.Evidence, appDomainSetup, permissionSet, CreateStrongName(assembly));
			appDomain.Load(assembly.FullName);
			return appDomain;
		}

		[SecuritySafeCritical]
		private static T Activate<T>(AddInToken token, PermissionSet permissionSet, string appDomainName)
		{
			permissionSet = permissionSet.Copy();
			if (!permissionSet.IsUnrestricted())
			{
				foreach (object item in permissionSet)
				{
					Assembly assembly = item.GetType().Assembly;
					if (!assembly.GlobalAssemblyCache)
					{
						new PermissionSet(PermissionState.Unrestricted).Demand();
						break;
					}
				}
			}
			permissionSet.Demand();
			AppDomain appDomain = null;
			try
			{
				appDomain = CreateDomain(token, permissionSet, appDomainName);
				AddInEnvironment environment = new AddInEnvironment(appDomain, skipDomainCheck: true);
				AddInControllerImpl controller = new AddInControllerImpl(environment, unloadDomainOnExit: true, token);
				return ActivateInAppDomain<T>(token, appDomain, controller, weOwn: true);
			}
			catch
			{
				if (appDomain != null)
				{
					try
					{
						Utils.UnloadAppDomain(appDomain);
					}
					catch (AppDomainUnloadedException)
					{
					}
				}
				throw;
			}
		}

		internal static T Activate<T>(AddInToken token, AppDomain target)
		{
			if (token == null)
			{
				throw new ArgumentNullException("token");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			AddInEnvironment environment = new AddInEnvironment(target);
			AddInControllerImpl controller = new AddInControllerImpl(environment, unloadDomainOnExit: false, token);
			return ActivateInAppDomain<T>(token, target, controller, weOwn: false);
		}

		internal static T Activate<T>(AddInToken token, PermissionSet permissionSet)
		{
			if (token == null)
			{
				throw new ArgumentNullException("token");
			}
			if (permissionSet == null)
			{
				throw new ArgumentNullException("permissionSet");
			}
			return Activate<T>(token, permissionSet, token.Name);
		}

		[SecuritySafeCritical]
		internal static T Activate<T>(AddInToken token, AddInProcess process, PermissionSet permissionSet)
		{
			if (token == null)
			{
				throw new ArgumentNullException("token");
			}
			if (permissionSet == null)
			{
				throw new ArgumentNullException("permissionSet");
			}
			if (process == null)
			{
				throw new ArgumentNullException("process");
			}
			if (!permissionSet.IsUnrestricted())
			{
				SecurityPermission securityPermission = (SecurityPermission)permissionSet.GetPermission(typeof(SecurityPermission));
				SecurityPermissionFlag securityPermissionFlag = SecurityPermissionFlag.Execution;
				if (securityPermission == null || (securityPermission.Flags & securityPermissionFlag) != securityPermissionFlag)
				{
					throw new ArgumentException(Res.NeedSecurityFlags);
				}
			}
			RemotingHelper.InitializeClientChannel();
			AddInServer addInServer = process.GetAddInServer();
			AddInServerWorker worker = addInServer.CreateDomain(token, permissionSet);
			AddInEnvironment environment = new AddInEnvironment(process, worker);
			return ActivateOutOfProcess<T>(token, environment, weOwn: true);
		}

		internal static T Activate<T>(AddInToken token, AddInProcess process, AddInSecurityLevel level)
		{
			PermissionSet permissionSetForLevel = GetPermissionSetForLevel(level);
			return Activate<T>(token, process, permissionSetForLevel);
		}

		internal static T Activate<T>(AddInToken token, AddInEnvironment environment)
		{
			if (environment == null)
			{
				throw new ArgumentNullException("environment");
			}
			if (environment.Process.IsCurrentProcess)
			{
				AddInControllerImpl controller = new AddInControllerImpl(environment, unloadDomainOnExit: false, token);
				return ActivateInAppDomain<T>(token, environment.AppDomain, controller, weOwn: false);
			}
			return ActivateOutOfProcess<T>(token, environment, weOwn: false);
		}

		private static T ActivateOutOfProcess<T>(AddInToken token, AddInEnvironment environment, bool weOwn)
		{
			ActivationWorker worker;
			IContract contract = environment.AddInServerWorker.Activate(token, out worker);
			AddInControllerImpl addInControllerImpl = new AddInControllerImpl(environment, weOwn, token);
			addInControllerImpl.ActivationWorker = worker;
			T val = AdaptToHost<T>(token, contract);
			if (weOwn)
			{
				environment.AddInServerWorker.SetAppDomainOwner(contract);
			}
			addInControllerImpl.AssociateWithHostAddinView(val, contract);
			return val;
		}

		[SecuritySafeCritical]
		private static T ActivateInAppDomain<T>(AddInToken pipeline, AppDomain domain, AddInControllerImpl controller, bool weOwn)
		{
			ContractComponent contract = pipeline._contract;
			HostAdapter hostAdapter = pipeline._hostAdapter;
			bool flag = domain == AppDomain.CurrentDomain;
			if (AddInToken.EnableDirectConnect && !weOwn && flag)
			{
				Type typeFromHandle = typeof(T);
				System.AddIn.MiniReflection.TypeInfo havTypeInfo = new System.AddIn.MiniReflection.TypeInfo(typeFromHandle);
				if (pipeline._addinBase.CanDirectConnectTo(havTypeInfo))
				{
					PermissionSet permissionSet = new PermissionSet(PermissionState.None);
					permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.GetDirectoryName(pipeline._addin.Location)));
					permissionSet.Assert();
					Assembly assembly = Assembly.LoadFrom(pipeline._addin.Location);
					Type type = assembly.GetType(pipeline._addin.TypeInfo.FullName, throwOnError: true);
					object obj = type.GetConstructor(new Type[0]).Invoke(new object[0]);
					controller.AssociateWithHostAddinView(obj, null);
					return (T)obj;
				}
			}
			Type typeFromHandle2 = typeof(ActivationWorker);
			object[] args = new object[1] { pipeline };
			ObjectHandle objectHandle = Activator.CreateInstance(domain, typeFromHandle2.Assembly.FullName, typeFromHandle2.FullName, ignoreCase: false, BindingFlags.Instance | BindingFlags.NonPublic, null, args, null, null);
			ActivationWorker activationWorker = (ActivationWorker)objectHandle.Unwrap();
			activationWorker.UsingHostAppDomain = flag;
			IContract contract2 = null;
			try
			{
				contract2 = activationWorker.Activate();
			}
			catch (Exception inner)
			{
				CheckForDuplicateAssemblyProblems(pipeline, inner);
				throw;
			}
			if (weOwn)
			{
				domain.SetData("System.AddIn_Owner_Contract", contract2);
			}
			controller.ActivationWorker = activationWorker;
			T val = AdaptToHost<T>(pipeline, contract2);
			controller.AssociateWithHostAddinView(val, contract2);
			return val;
		}

		[SecuritySafeCritical]
		private static T AdaptToHost<T>(AddInToken pipeline, IContract addInContract)
		{
			if (addInContract == null)
			{
				throw new ArgumentNullException("addInContract");
			}
			ContractComponent contract = pipeline._contract;
			HostAdapter hostAdapter = pipeline._hostAdapter;
			LoadContractAndHostAdapter(contract, hostAdapter, out var contractType, out var hostAdapterType);
			int? num = null;
			try
			{
				num = addInContract.AcquireLifetimeToken();
				ResolverHelper @object = new ResolverHelper(pipeline);
				ResolveEventHandler value = @object.ResolveAssemblyForHostAdapter;
				AppDomain.CurrentDomain.AssemblyResolve += value;
				InvokerDelegate invokerDelegate = CreateConsInvoker(hostAdapterType, contractType);
				try
				{
					return (T)invokerDelegate(addInContract);
				}
				catch (ArgumentException inner)
				{
					CheckForLoaderContextProblems(contract, pipeline._addinAdapter, inner);
					throw;
				}
				finally
				{
					AppDomain.CurrentDomain.AssemblyResolve -= value;
				}
			}
			finally
			{
				if (num.HasValue)
				{
					addInContract?.RevokeLifetimeToken(num.Value);
				}
			}
		}

		[SecuritySafeCritical]
		internal static InvokerDelegate CreateConsInvoker(Type targetType, Type argType)
		{
			ConstructorInfo constructor = targetType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { argType }, null);
			Type[] methodArgs = new Type[1] { typeof(object) };
			DynamicMethod dynamicMethod = AssertAndCreateInvoker(targetType, argType, methodArgs, constructor);
			return (InvokerDelegate)dynamicMethod.CreateDelegate(typeof(InvokerDelegate));
		}

		[SecurityCritical]
		[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
		private static DynamicMethod AssertAndCreateInvoker(Type targetType, Type argType, Type[] methodArgs, ConstructorInfo havCtor)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(targetType.Name + "_ConstructorInvoker", typeof(object), methodArgs, restrictedSkipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Castclass, argType);
			iLGenerator.Emit(OpCodes.Newobj, havCtor);
			iLGenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		[SecuritySafeCritical]
		internal static void LoadContractAndHostAdapter(ContractComponent contract, HostAdapter hostAdapter, out Type contractType, out Type hostAdapterType)
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, hostAdapter.Location));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, contract.Location));
			permissionSet.Assert();
			Assembly assembly = Assembly.LoadFrom(hostAdapter.Location);
			Assembly assembly2 = Assembly.LoadFrom(contract.Location);
			hostAdapterType = assembly.GetType(hostAdapter.TypeInfo.FullName, throwOnError: true);
			contractType = assembly2.GetType(contract.TypeInfo.FullName, throwOnError: true);
		}

		[SecuritySafeCritical]
		internal static T ActivateHostAdapter<T>(PartialToken pipeline, IContract addIn)
		{
			if (pipeline == null)
			{
				throw new ArgumentNullException("pipeline");
			}
			if (addIn == null)
			{
				throw new ArgumentNullException("addIn");
			}
			ContractComponent contract = pipeline._contract;
			HostAdapter hostAdapter = pipeline._hostAdapter;
			LoadContractAndHostAdapter(contract, hostAdapter, out var contractType, out var hostAdapterType);
			ResolverHelper @object = new ResolverHelper(contract);
			ResolveEventHandler value = @object.ResolveAssemblyForHostAdapter;
			AppDomain.CurrentDomain.AssemblyResolve += value;
			InvokerDelegate invokerDelegate = CreateConsInvoker(hostAdapterType, contractType);
			try
			{
				return (T)invokerDelegate(addIn);
			}
			catch (ArgumentException inner)
			{
				CheckForLoaderContextProblems(contract, pipeline._addinAdapter, inner);
				throw;
			}
			finally
			{
				AppDomain.CurrentDomain.AssemblyResolve -= value;
			}
		}

		private static void CheckForDuplicateAssemblyProblems(AddInToken pipeline, Exception inner)
		{
			Collection<string> collection = new Collection<string>();
			if (pipeline.HasDuplicatedAssemblies(null, collection))
			{
				string[] array = new string[collection.Count];
				collection.CopyTo(array, 0);
				throw new InvalidOperationException(string.Join("\n", array), inner);
			}
		}

		private static void CheckForLoaderContextProblems(ContractComponent contract, AddInAdapter addinAdapter, Exception inner)
		{
			string assemblyName = contract.TypeInfo.AssemblyName;
			string assemblyName2 = addinAdapter.TypeInfo.AssemblyName;
			List<Assembly> list = new List<Assembly>();
			List<Assembly> list2 = new List<Assembly>();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				string fullName = assembly.GetName().FullName;
				if (fullName == assemblyName)
				{
					list.Add(assembly);
				}
				if (fullName == assemblyName2)
				{
					list2.Add(assembly);
				}
			}
			if (list2.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (Assembly item in list2)
				{
					stringBuilder.Append(Environment.NewLine);
					stringBuilder.Append(item.CodeBase);
				}
				Exception ex = new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.AddInAdapterLoadedInWrongAppDomain, new object[3]
				{
					addinAdapter.TypeInfo.AssemblyName,
					addinAdapter.Location,
					stringBuilder.ToString()
				}), inner);
				ex.Data["Incorrectly loaded add-in adapters"] = list2;
				ex.Data["Expected adapter location"] = addinAdapter.Location;
				if (list.Count > 1)
				{
					ex.Data["Duplicate Contracts"] = list;
				}
				throw ex;
			}
			if (list.Count <= 1)
			{
				return;
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			foreach (Assembly item2 in list)
			{
				stringBuilder2.Append(Environment.NewLine);
				stringBuilder2.Append(item2.CodeBase);
			}
			Exception ex2 = new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.ContractAssemblyLoadedMultipleTimes, new object[3]
			{
				contract.TypeInfo.AssemblyName,
				contract.Location,
				stringBuilder2.ToString()
			}), inner);
			ex2.Data["Incorrectly loaded contracts"] = list;
			ex2.Data["Expected contract location"] = contract.Location;
			throw ex2;
		}

		[SecuritySafeCritical]
		internal static StrongName CreateStrongName(Assembly assembly)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllLocalFiles = FileIOPermissionAccess.PathDiscovery;
			fileIOPermission.Assert();
			AssemblyName name = assembly.GetName();
			CodeAccessPermission.RevertAssert();
			byte[] publicKey = name.GetPublicKey();
			if (publicKey == null || publicKey.Length == 0)
			{
				throw new InvalidOperationException(Res.NoStrongName);
			}
			StrongNamePublicKeyBlob blob = new StrongNamePublicKeyBlob(publicKey);
			return new StrongName(blob, name.Name, name.Version);
		}
	}
	[Serializable]
	public class AddInSegmentDirectoryNotFoundException : Exception
	{
		public AddInSegmentDirectoryNotFoundException(string message)
			: base(message)
		{
		}

		public AddInSegmentDirectoryNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected AddInSegmentDirectoryNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public AddInSegmentDirectoryNotFoundException()
		{
		}
	}
	public enum AddInSegmentType
	{
		HostViewOfAddIn,
		HostSideAdapter,
		Contract,
		AddInSideAdapter,
		AddInView,
		AddIn
	}
	public sealed class AddInController
	{
		private AddInControllerImpl _impl;

		private object _hostViewOfAddIn;

		private ContractHandle _contractHandle;

		public AppDomain AppDomain => _impl.AppDomain;

		public AddInToken Token => _impl.Token;

		public AddInEnvironment AddInEnvironment => _impl.AddInEnvironment;

		internal AddInControllerImpl AddInControllerImpl => _impl;

		internal AddInController(AddInControllerImpl impl, object hostViewOfAddIn, ContractHandle contractHandle)
		{
			_impl = impl;
			_hostViewOfAddIn = hostViewOfAddIn;
			_contractHandle = contractHandle;
		}

		public static AddInController GetAddInController(object addIn)
		{
			return AddInControllerImpl.GetAddInController(addIn);
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void Shutdown()
		{
			_impl.Shutdown();
		}
	}
	internal sealed class AddInControllerImpl
	{
		internal sealed class HAVControllerPair
		{
			internal WeakReference _HAV;

			internal AddInControllerImpl _controller;

			internal HAVControllerPair _next;

			public HAVControllerPair(object hav, AddInControllerImpl controller)
			{
				_HAV = new WeakReference(hav);
				_controller = controller;
			}
		}

		private static HAVControllerPair _havList;

		private static readonly object _havLock = new object();

		private bool _unloadDomainOnExit;

		private AddInToken _token;

		private AddInEnvironment _addInEnvironment;

		private static int _addInCountSinceLastPrune;

		private const int AddInCountSinceLastPruneLimit = 25;

		internal IContract _contract;

		private ActivationWorker _activationWorker;

		private WeakReference _havReference;

		internal ActivationWorker ActivationWorker
		{
			set
			{
				_activationWorker = value;
			}
		}

		internal AppDomain AppDomain
		{
			get
			{
				if (_addInEnvironment == null)
				{
					throw new ObjectDisposedException("appdomain");
				}
				return _addInEnvironment.AppDomain;
			}
		}

		internal AddInToken Token => _token;

		internal AddInEnvironment AddInEnvironment => _addInEnvironment;

		internal AddInControllerImpl(AddInEnvironment environment, bool unloadDomainOnExit, AddInToken token)
		{
			_unloadDomainOnExit = unloadDomainOnExit;
			_token = token;
			_addInEnvironment = environment;
		}

		internal static AddInController GetAddInController(object addIn)
		{
			if (addIn == null)
			{
				throw new ArgumentNullException("addIn");
			}
			AddInControllerImpl addInControllerImpl = FindController(addIn, remove: false);
			if (addInControllerImpl != null)
			{
				ContractHandle contractHandle = null;
				try
				{
					contractHandle = new ContractHandle(addInControllerImpl._contract);
				}
				catch (Exception)
				{
				}
				return new AddInController(addInControllerImpl, addIn, contractHandle);
			}
			throw new ArgumentException(Res.ControllerNotFound);
		}

		private static AddInControllerImpl FindController(object addIn, bool remove)
		{
			lock (_havLock)
			{
				HAVControllerPair hAVControllerPair = _havList;
				HAVControllerPair hAVControllerPair2 = null;
				while (hAVControllerPair != null)
				{
					object target = hAVControllerPair._HAV.Target;
					if (target == null)
					{
						if (hAVControllerPair2 == null)
						{
							_havList = hAVControllerPair._next;
							continue;
						}
						hAVControllerPair2._next = hAVControllerPair._next;
						hAVControllerPair = hAVControllerPair._next;
						continue;
					}
					if (addIn.Equals(target))
					{
						AddInControllerImpl controller = hAVControllerPair._controller;
						if (remove)
						{
							if (hAVControllerPair2 == null)
							{
								_havList = hAVControllerPair._next;
							}
							else
							{
								hAVControllerPair2._next = hAVControllerPair._next;
							}
						}
						return controller;
					}
					hAVControllerPair2 = hAVControllerPair;
					hAVControllerPair = hAVControllerPair._next;
				}
			}
			return null;
		}

		internal void AssociateWithHostAddinView(object hostAddinView, IContract contract)
		{
			_contract = contract;
			_havReference = new WeakReference(hostAddinView);
			lock (_havLock)
			{
				HAVControllerPair hAVControllerPair = new HAVControllerPair(hostAddinView, this);
				hAVControllerPair._next = _havList;
				_havList = hAVControllerPair;
				_addInCountSinceLastPrune++;
				if (_addInCountSinceLastPrune == 25)
				{
					FindController(new object(), remove: false);
					_addInCountSinceLastPrune = 0;
				}
			}
		}

		[SecuritySafeCritical]
		internal IContract GetContract()
		{
			if (_contract != null)
			{
				return _contract;
			}
			object target = _havReference.Target;
			if (target == null)
			{
				throw new InvalidOperationException(Res.AddInNoLongerAvailable);
			}
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.Combine(_token.PipelineRootDirectory, "Contracts")));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, Path.Combine(_token.PipelineRootDirectory, "AddInSideAdapters")));
			permissionSet.Assert();
			Assembly.LoadFrom(_token._contract.Location);
			Assembly addinAdapterAssembly = Assembly.LoadFrom(_token._addinAdapter.Location);
			CodeAccessPermission.RevertAssert();
			ActivationWorker activationWorker = new ActivationWorker(_token);
			_contract = activationWorker.CreateAddInAdapter(target, addinAdapterAssembly);
			return _contract;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void Shutdown()
		{
			lock (this)
			{
				AddInEnvironment addInEnvironment = _addInEnvironment;
				if (addInEnvironment != null)
				{
					try
					{
						if (_contract != null)
						{
							object target = _havReference.Target;
							if (target is IDisposable disposable)
							{
								try
								{
									disposable.Dispose();
								}
								catch (AppDomainUnloadedException ex)
								{
									Log(ex.ToString());
								}
								catch (RemotingException ex2)
								{
									Log(ex2.ToString());
								}
								catch (SerializationException ex3)
								{
									Log(ex3.ToString());
								}
							}
							if (_contract is IDisposable disposable2)
							{
								try
								{
									disposable2.Dispose();
								}
								catch (AppDomainUnloadedException ex4)
								{
									Log(ex4.ToString());
								}
								catch (RemotingException ex5)
								{
									Log(ex5.ToString());
								}
								catch (SerializationException ex6)
								{
									Log(ex6.ToString());
								}
							}
							_contract = null;
						}
						if (_activationWorker != null)
						{
							try
							{
								_activationWorker.Dispose();
							}
							catch (AppDomainUnloadedException)
							{
							}
							catch (RemotingException)
							{
							}
							catch (SerializationException)
							{
							}
							_activationWorker = null;
						}
					}
					finally
					{
						if (_unloadDomainOnExit)
						{
							try
							{
								addInEnvironment.UnloadAppDomain();
							}
							catch (AppDomainUnloadedException)
							{
							}
							catch (RemotingException)
							{
							}
						}
					}
					_addInEnvironment = null;
					lock (_havLock)
					{
						object target2 = _havReference.Target;
						if (target2 != null)
						{
							FindController(target2, remove: true);
						}
					}
					GC.WaitForPendingFinalizers();
					GC.Collect();
					return;
				}
				throw new InvalidOperationException(Res.AppDomainNull);
			}
		}

		private static void Log(string message)
		{
			Debugger.Log(0, "AddInController", message);
		}
	}
	[Serializable]
	internal sealed class AddInDeploymentState : DeploymentState
	{
		private List<AddIn> _addins;

		private int _fileCount;

		internal List<AddIn> AddIns => _addins;

		internal int FileCount
		{
			get
			{
				return _fileCount;
			}
			set
			{
				_fileCount = value;
			}
		}

		internal AddInDeploymentState()
		{
			_addins = new List<AddIn>();
		}
	}
	public sealed class AddInEnvironment
	{
		private AddInProcess _process;

		private AppDomain _appDomain;

		private AddInServerWorker _addInServerWorker;

		public AddInProcess Process => _process;

		internal AppDomain AppDomain => _appDomain;

		internal AddInServerWorker AddInServerWorker => _addInServerWorker;

		public AddInEnvironment(AppDomain appDomain)
		{
			if (appDomain == null)
			{
				throw new ArgumentNullException("appDomain");
			}
			if (appDomain != AppDomain.CurrentDomain && !Utils.HasFullTrust())
			{
				throw new SecurityException(Res.PartialTrustCannotActivate);
			}
			_appDomain = appDomain;
			_process = AddInProcess.Current;
		}

		internal AddInEnvironment(AppDomain appDomain, bool skipDomainCheck)
		{
			if (appDomain == null)
			{
				throw new ArgumentNullException("appDomain");
			}
			_appDomain = appDomain;
			_process = AddInProcess.Current;
		}

		internal AddInEnvironment(AddInProcess process, AddInServerWorker worker)
		{
			_addInServerWorker = worker;
			_process = process;
		}

		[SecuritySafeCritical]
		internal void UnloadAppDomain()
		{
			if (Process.IsCurrentProcess)
			{
				SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlAppDomain);
				securityPermission.Assert();
				AppDomain.Unload(AppDomain);
				CodeAccessPermission.RevertAssert();
				return;
			}
			try
			{
				_addInServerWorker.UnloadAppDomain();
			}
			catch (AppDomainUnloadedException)
			{
			}
			catch (RemotingException)
			{
			}
		}
	}
	[Serializable]
	public enum Platform
	{
		Host,
		AnyCpu,
		X86,
		X64,
		ARM
	}
	public sealed class AddInProcess
	{
		private bool _keepAlive;

		private volatile Process _process;

		private Guid _guid;

		private Platform _platform;

		private string _pathToAddInProcess;

		private readonly object _processLock = new object();

		private const int ERROR_FILE_NOT_FOUND = 2;

		private const int ERROR_ACCESS_DENIED = 5;

		private TimeSpan _startupTimeout = new TimeSpan(0, 0, 10);

		private static AddInProcess s_currentProcess = new AddInProcess(internalOnly: true);

		public TimeSpan StartupTimeout
		{
			get
			{
				return _startupTimeout;
			}
			set
			{
				if (value.TotalSeconds < 0.0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				lock (_processLock)
				{
					if (_process == null)
					{
						_startupTimeout = value;
						return;
					}
					throw new InvalidOperationException(Res.ProcessAlreadyRunning);
				}
			}
		}

		public Platform Platform => _platform;

		public int ProcessId
		{
			[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
			get
			{
				lock (_processLock)
				{
					if (this == s_currentProcess)
					{
						return Process.GetCurrentProcess().Id;
					}
					if (_process == null)
					{
						return -1;
					}
					return _process.Id;
				}
			}
		}

		internal static AddInProcess Current => s_currentProcess;

		internal Guid Guid
		{
			get
			{
				if (IsCurrentProcess)
				{
					return Guid.Empty;
				}
				Start();
				return _guid;
			}
		}

		public bool IsCurrentProcess => this == s_currentProcess;

		public bool KeepAlive
		{
			get
			{
				return _keepAlive;
			}
			set
			{
				_keepAlive = value;
			}
		}

		public event EventHandler<CancelEventArgs> ShuttingDown;

		[SecurityCritical]
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public AddInProcess()
			: this(Platform.Host)
		{
		}

		[SecurityCritical]
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public AddInProcess(Platform platform)
		{
			_platform = platform;
			string runtimeDirectory = RuntimeEnvironment.GetRuntimeDirectory();
			string processName = GetProcessName(platform);
			_pathToAddInProcess = Path.Combine(runtimeDirectory, processName);
			if (!File.Exists(_pathToAddInProcess))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.MissingAddInProcessExecutable, new object[1] { _pathToAddInProcess }));
			}
			RemotingHelper.InitializeClientChannel();
		}

		internal AddInProcess(bool internalOnly)
		{
		}

		internal void SendShuttingDown(CancelEventArgs args)
		{
			if (KeepAlive)
			{
				args.Cancel = true;
			}
			else
			{
				ShutDownUnlessCancelled(args);
			}
		}

		private void ShutDownUnlessCancelled(CancelEventArgs args)
		{
			if (this.ShuttingDown != null)
			{
				this.ShuttingDown(this, args);
			}
			if (args.Cancel)
			{
				return;
			}
			try
			{
				lock (_processLock)
				{
					AddInServer addInServer = GetAddInServer();
					_process = null;
					_guid = Guid.Empty;
					addInServer.ExitProcess();
				}
			}
			catch (RemotingException)
			{
			}
			catch (SerializationException)
			{
			}
		}

		internal AddInServer GetAddInServer()
		{
			return RemotingHelper.GetAddInServer(Guid.ToString());
		}

		[SecurityCritical]
		public bool Start()
		{
			if (this == s_currentProcess)
			{
				throw new InvalidOperationException(Res.OperationNotValidOnCurrentProcess);
			}
			if (_process == null)
			{
				lock (_processLock)
				{
					if (_process == null)
					{
						_process = CreateAddInProcess();
						AddInServer addInServer = GetAddInServer();
						addInServer.Initialize(new EventWorker(this));
					}
				}
				return true;
			}
			return false;
		}

		public bool Shutdown()
		{
			if (this == s_currentProcess)
			{
				throw new InvalidOperationException(Res.OperationNotValidOnCurrentProcess);
			}
			if (_process == null)
			{
				return false;
			}
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			ShutDownUnlessCancelled(cancelEventArgs);
			if (cancelEventArgs.Cancel)
			{
				return false;
			}
			return true;
		}

		[SecurityCritical]
		private static string GetProcessName(Platform platform)
		{
			switch (platform)
			{
			case Platform.Host:
				return CurrentlyRunning32Bit() ? "AddInProcess32.exe" : "AddInProcess.exe";
			case Platform.X86:
			case Platform.ARM:
				return "AddInProcess32.exe";
			case Platform.X64:
				if (!CurrentlyRunning32Bit() || CurrentlyRunningWow64())
				{
					return "AddInProcess.exe";
				}
				throw new InvalidOperationException(Res.Invalid64bitPlatformOn32bitOS);
			case Platform.AnyCpu:
				return "AddInProcess.exe";
			default:
				throw new ArgumentOutOfRangeException("platform");
			}
		}

		private static bool CurrentlyRunning32Bit()
		{
			return IntPtr.Size == 4;
		}

		[SecurityCritical]
		private static bool CurrentlyRunningWow64()
		{
			bool bIsWow = false;
			try
			{
				if (!NativeMethods.IsWow64Process(Process.GetCurrentProcess().Handle, ref bIsWow))
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				return bIsWow;
			}
			catch (EntryPointNotFoundException)
			{
				return false;
			}
		}

		[SecurityCritical]
		private Process CreateAddInProcess()
		{
			Process process = new Process();
			Guid guid = Guid.NewGuid();
			string arguments = string.Format(CultureInfo.InvariantCulture, "/guid:{0} /pid:{1}", new object[2]
			{
				guid,
				Process.GetCurrentProcess().Id
			});
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.Arguments = arguments;
			process.StartInfo.FileName = _pathToAddInProcess;
			Guid guid2 = guid;
			EventWaitHandle eventWaitHandle = new EventWaitHandle(initialState: false, EventResetMode.ManualReset, "AddInProcess:" + guid2.ToString());
			process.Start();
			bool flag = eventWaitHandle.WaitOne(_startupTimeout, exitContext: false);
			eventWaitHandle.Close();
			if (!flag)
			{
				try
				{
					process.Kill();
				}
				catch (Exception)
				{
				}
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.CouldNotCreateAddInProcess, new object[1] { _startupTimeout.ToString() }));
			}
			_guid = guid;
			return process;
		}
	}
	internal class AddInIpcChannel : IpcChannel
	{
		[SecurityCritical]
		public AddInIpcChannel(IDictionary props, IClientChannelSinkProvider client, IServerChannelSinkProvider server)
			: base(props, new AddInBinaryClientFormaterSinkProvider(client), new AddInBinaryServerFormaterSinkProvider(server))
		{
		}
	}
	internal class AddInBinaryServerFormaterSinkProvider : IServerChannelSinkProvider
	{
		internal IServerChannelSinkProvider _sinkProvider;

		public IServerChannelSinkProvider Next
		{
			[SecurityCritical]
			get
			{
				return _sinkProvider.Next;
			}
			[SecurityCritical]
			set
			{
				_sinkProvider.Next = value;
			}
		}

		public AddInBinaryServerFormaterSinkProvider(IServerChannelSinkProvider sink)
		{
			_sinkProvider = sink;
		}

		[SecurityCritical]
		public IServerChannelSink CreateSink(IChannelReceiver channel)
		{
			return new AddInBinaryServerSink(_sinkProvider.CreateSink(channel));
		}

		[SecurityCritical]
		public void GetChannelData(IChannelDataStore channelData)
		{
			_sinkProvider.GetChannelData(channelData);
		}
	}
	internal class AddInBinaryServerSink : IServerChannelSink, IChannelSinkBase
	{
		private IServerChannelSink _sink;

		public IServerChannelSink NextChannelSink
		{
			[SecurityCritical]
			get
			{
				return _sink.NextChannelSink;
			}
		}

		public IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				return _sink.Properties;
			}
		}

		public AddInBinaryServerSink(IServerChannelSink sink)
		{
			_sink = sink;
		}

		[SecurityCritical]
		public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream)
		{
			_sink.AsyncProcessResponse(sinkStack, state, msg, headers, stream);
		}

		[SecurityCritical]
		public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers)
		{
			return _sink.GetResponseStream(sinkStack, state, msg, headers);
		}

		[SecurityCritical]
		public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream)
		{
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SerializationFormatter).Assert();
			return _sink.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
		}
	}
	internal class AddInBinaryClientFormaterSinkProvider : IClientChannelSinkProvider
	{
		private IClientChannelSinkProvider _provider;

		public IClientChannelSinkProvider Next
		{
			[SecurityCritical]
			get
			{
				return _provider.Next;
			}
			[SecurityCritical]
			set
			{
				_provider.Next = value;
			}
		}

		public AddInBinaryClientFormaterSinkProvider(IClientChannelSinkProvider provider)
		{
			_provider = provider;
		}

		[SecurityCritical]
		public IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData)
		{
			return new AddInBinaryClientFormaterSink(_provider.CreateSink(channel, url, remoteChannelData));
		}
	}
	internal class AddInBinaryClientFormaterSink : IClientChannelSink, IChannelSinkBase, IMessageSink
	{
		private IClientChannelSink _sink;

		private IMessageSink _mSink;

		public IClientChannelSink NextChannelSink
		{
			[SecurityCritical]
			get
			{
				return _sink.NextChannelSink;
			}
		}

		public IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				return _sink.Properties;
			}
		}

		public IMessageSink NextSink
		{
			[SecurityCritical]
			get
			{
				return _mSink.NextSink;
			}
		}

		public AddInBinaryClientFormaterSink(IClientChannelSink sink)
		{
			_sink = sink;
			_mSink = (IMessageSink)sink;
		}

		[SecurityCritical]
		public void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream)
		{
			_sink.AsyncProcessRequest(sinkStack, msg, headers, stream);
		}

		[SecurityCritical]
		public void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream)
		{
			_sink.AsyncProcessResponse(sinkStack, state, headers, stream);
		}

		[SecurityCritical]
		public Stream GetRequestStream(IMessage msg, ITransportHeaders headers)
		{
			return _sink.GetRequestStream(msg, headers);
		}

		[SecurityCritical]
		public void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream)
		{
			_sink.ProcessMessage(msg, requestHeaders, requestStream, out responseHeaders, out responseStream);
		}

		[SecurityCritical]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return _mSink.AsyncProcessMessage(msg, replySink);
		}

		[SecurityCritical]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SerializationFormatter).Assert();
			return _mSink.SyncProcessMessage(msg);
		}
	}
	[Serializable]
	public struct QualificationDataItem
	{
		private AddInSegmentType m_type;

		private string m_key;

		private string m_value;

		public AddInSegmentType Segment => m_type;

		public string Name => m_key;

		public string Value => m_value;

		internal QualificationDataItem(AddInSegmentType addInSegmentType, string name, string val)
		{
			m_type = addInSegmentType;
			m_key = name;
			m_value = val;
		}

		public override bool Equals(object obj)
		{
			QualificationDataItem qualificationDataItem = (QualificationDataItem)obj;
			if (string.Equals(m_key, qualificationDataItem.m_key, StringComparison.Ordinal) && string.Equals(m_value, qualificationDataItem.m_value, StringComparison.Ordinal))
			{
				return m_type == qualificationDataItem.m_type;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_type.GetHashCode() ^ ((Name != null) ? Name.GetHashCode() : 0);
		}

		public static bool operator ==(QualificationDataItem item1, QualificationDataItem item2)
		{
			return item1.Equals(item2);
		}

		public static bool operator !=(QualificationDataItem item1, QualificationDataItem item2)
		{
			return !item1.Equals(item2);
		}
	}
	[Serializable]
	public enum AddInSecurityLevel
	{
		Internet,
		Intranet,
		FullTrust,
		Host
	}
	public static class AddInStore
	{
		private struct CacheInfo
		{
			internal DeploymentState State;

			internal DateTime FileTimeStamp;
		}

		private delegate DeploymentState Reader(string path, string filename);

		private delegate DeploymentState Builder(string rootDir, Collection<string> warnings);

		private const string PipelineCacheFileName = "PipelineSegments.store";

		private const string AddInCacheFileName = "AddIns.store";

		internal const string HostAdaptersDirName = "HostSideAdapters";

		internal const string ContractsDirName = "Contracts";

		internal const string AddInAdaptersDirName = "AddInSideAdapters";

		internal const string AddInBasesDirName = "AddInViews";

		internal const string AddInsDirName = "AddIns";

		private const int StoreFileFormatVersion = 1;

		private const uint HRESULT_FOR_ERROR_SHARING_VIOLATION = 2147942432u;

		private static readonly Dictionary<string, CacheInfo> StateCache = new Dictionary<string, CacheInfo>();

		[SecurityCritical]
		private static string[] UpdateImpl(string pipelineRootFolderPath, bool demand)
		{
			if (pipelineRootFolderPath == null)
			{
				throw new ArgumentNullException("pipelineRootFolderPath");
			}
			if (pipelineRootFolderPath.Length == 0)
			{
				throw new ArgumentException(Res.PathCantBeEmpty, "pipelineRootFolderPath");
			}
			bool flag = Utils.HasFullTrust();
			try
			{
				pipelineRootFolderPath = ValidatePipelineRoot(pipelineRootFolderPath);
				if (demand)
				{
					new FileIOPermission(FileIOPermissionAccess.Read, pipelineRootFolderPath).Demand();
				}
				flag = HasPathDiscovery(pipelineRootFolderPath);
				string text = Path.Combine(pipelineRootFolderPath, "PipelineSegments.store");
				Collection<string> collection = new Collection<string>();
				FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, pipelineRootFolderPath);
				fileIOPermission.Assert();
				if (!File.Exists(text) || PipelineStoreIsOutOfDate(text, pipelineRootFolderPath))
				{
					BuildPipelineCache(pipelineRootFolderPath, collection);
				}
				string addInsPath = Path.Combine(pipelineRootFolderPath, "AddIns");
				UpdateAddInsIfExist(addInsPath, collection);
				string[] array;
				if (!flag)
				{
					array = ((collection.Count <= 0) ? new string[0] : new string[1] { Res.UnspecifiedUpdateWarningsInPartialTrust });
				}
				else
				{
					array = new string[collection.Count];
					collection.CopyTo(array, 0);
				}
				return array;
			}
			catch (Exception)
			{
				if (flag)
				{
					throw;
				}
				throw GetGenericSecurityException();
			}
		}

		[SecuritySafeCritical]
		public static string[] Update(PipelineStoreLocation location)
		{
			if (location != 0)
			{
				throw new ArgumentException(Res.InvalidPipelineStoreLocation, "location");
			}
			string appBase = GetAppBase();
			return UpdateImpl(appBase, demand: false);
		}

		[SecurityCritical]
		public static string[] Update(string pipelineRootFolderPath)
		{
			return UpdateImpl(pipelineRootFolderPath, demand: true);
		}

		[SecurityCritical]
		public static string[] UpdateAddIns(string addInsFolderPath)
		{
			if (addInsFolderPath == null)
			{
				throw new ArgumentNullException("addInsFolderPath");
			}
			bool flag = Utils.HasFullTrust();
			try
			{
				addInsFolderPath = ValidateAddInPath(addInsFolderPath);
				new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, addInsFolderPath).Demand();
				flag = HasPathDiscovery(addInsFolderPath);
				Collection<string> collection = new Collection<string>();
				UpdateAddInsIfExist(addInsFolderPath, collection);
				string[] array;
				if (flag)
				{
					array = new string[collection.Count];
					collection.CopyTo(array, 0);
				}
				else
				{
					array = new string[0];
				}
				return array;
			}
			catch (Exception)
			{
				if (flag)
				{
					throw;
				}
				throw GetGenericSecurityException();
			}
		}

		[SecurityCritical]
		public static string[] RebuildAddIns(string addInsFolderPath)
		{
			if (addInsFolderPath == null)
			{
				throw new ArgumentNullException("addInsFolderPath");
			}
			bool flag = false;
			try
			{
				addInsFolderPath = ValidateAddInPath(addInsFolderPath);
				new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, addInsFolderPath).Demand();
				flag = HasPathDiscovery(addInsFolderPath);
				string path = Path.Combine(addInsFolderPath, "AddIns.store");
				Collection<string> collection = new Collection<string>();
				bool flag2 = false;
				try
				{
					BuildAddInCache(addInsFolderPath, collection);
					flag2 = true;
				}
				finally
				{
					if (!flag2 && File.Exists(path))
					{
						try
						{
							File.Delete(path);
						}
						catch
						{
						}
					}
				}
				string[] array;
				if (flag)
				{
					array = new string[collection.Count];
					collection.CopyTo(array, 0);
				}
				else
				{
					array = new string[0];
				}
				return array;
			}
			catch (Exception)
			{
				if (flag)
				{
					throw;
				}
				throw GetGenericSecurityException();
			}
		}

		[SecuritySafeCritical]
		private static void UpdateAddInsIfExist(string addInsPath, Collection<string> warningsCollection)
		{
			string path = Path.Combine(addInsPath, "AddIns.store");
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, addInsPath);
			fileIOPermission.Assert();
			if (Directory.Exists(addInsPath) && (!File.Exists(path) || AddInStoreIsOutOfDate(addInsPath)))
			{
				BuildAddInCache(addInsPath, warningsCollection);
			}
		}

		private static bool PipelineStoreIsOutOfDate(string deploymentStore, string path)
		{
			DateTime lastWriteTime = File.GetLastWriteTime(deploymentStore);
			string text = Path.Combine(path, "HostSideAdapters");
			string text2 = Path.Combine(path, "Contracts");
			string text3 = Path.Combine(path, "AddInSideAdapters");
			string text4 = Path.Combine(path, "AddInViews");
			string text5 = Path.Combine(path, "AddIns");
			string[] array = new string[4] { text, text2, text3, text4 };
			int[] array2 = new int[4];
			int num = 0;
			string[] array3 = array;
			foreach (string path2 in array3)
			{
				if (DirectoryNeedsUpdating(path2, lastWriteTime, ref array2[num++]))
				{
					return true;
				}
			}
			PipelineDeploymentState pipelineDeploymentState = GetPipelineDeploymentState(path);
			List<int> fileCounts = pipelineDeploymentState.FileCounts;
			for (int j = 0; j < array2.Length; j++)
			{
				if (array2[j] != pipelineDeploymentState.FileCounts[j])
				{
					return true;
				}
			}
			return false;
		}

		private static bool AddInStoreIsOutOfDate(string addInPath)
		{
			if (addInPath == null)
			{
				throw new ArgumentNullException("addInPath");
			}
			string path = Path.Combine(addInPath, "AddIns.store");
			DateTime lastWriteTime = File.GetLastWriteTime(path);
			int fileCount = 0;
			if (Directory.Exists(addInPath))
			{
				string[] directories = Directory.GetDirectories(addInPath);
				foreach (string path2 in directories)
				{
					if (DirectoryNeedsUpdating(path2, lastWriteTime, ref fileCount))
					{
						return true;
					}
				}
			}
			AddInDeploymentState addInDeploymentState = GetAddInDeploymentState(addInPath);
			if (addInDeploymentState == null)
			{
				return true;
			}
			if (fileCount != addInDeploymentState.FileCount)
			{
				return true;
			}
			return false;
		}

		private static bool DirectoryNeedsUpdating(string path, DateTime storeTime, ref int fileCount)
		{
			if (storeTime < Directory.GetLastWriteTime(path))
			{
				return true;
			}
			foreach (string executableFile in GetExecutableFiles(path))
			{
				try
				{
					if (storeTime < Directory.GetLastWriteTime(executableFile))
					{
						return true;
					}
					fileCount++;
				}
				catch (IOException)
				{
				}
				catch (SecurityException)
				{
				}
			}
			return false;
		}

		private static List<string> GetExecutableFiles(string path)
		{
			List<string> list = new List<string>();
			list.AddRange(Directory.GetFiles(path, "*.dll"));
			list.AddRange(Directory.GetFiles(path, "*.exe"));
			return list;
		}

		[SecurityCritical]
		public static string[] Rebuild(string pipelineRootFolderPath)
		{
			return RebuildImpl(pipelineRootFolderPath, demand: true);
		}

		[SecuritySafeCritical]
		public static string[] Rebuild(PipelineStoreLocation location)
		{
			if (location != 0)
			{
				throw new ArgumentException(Res.InvalidPipelineStoreLocation, "location");
			}
			string appBase = GetAppBase();
			return RebuildImpl(appBase, demand: false);
		}

		[SecurityCritical]
		private static string[] RebuildImpl(string pipelineRootFolderPath, bool demand)
		{
			if (pipelineRootFolderPath == null)
			{
				throw new ArgumentNullException("pipelineRootFolderPath");
			}
			if (pipelineRootFolderPath.Length == 0)
			{
				throw new ArgumentException(Res.PathCantBeEmpty, "pipelineRootFolderPath");
			}
			bool flag = Utils.HasFullTrust();
			try
			{
				pipelineRootFolderPath = ValidatePipelineRoot(pipelineRootFolderPath);
				if (demand)
				{
					new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, pipelineRootFolderPath).Demand();
				}
				flag = HasPathDiscovery(pipelineRootFolderPath);
				string path = Path.Combine(pipelineRootFolderPath, "PipelineSegments.store");
				Collection<string> collection = new Collection<string>();
				bool flag2 = false;
				try
				{
					BuildPipelineCache(pipelineRootFolderPath, collection);
					string rootDir = Path.Combine(pipelineRootFolderPath, "AddIns");
					BuildAddInCache(rootDir, collection);
					flag2 = true;
				}
				finally
				{
					if (!flag2 && File.Exists(path))
					{
						try
						{
							File.Delete(path);
						}
						catch
						{
						}
					}
				}
				string[] array;
				if (flag)
				{
					array = new string[collection.Count];
					collection.CopyTo(array, 0);
				}
				else
				{
					array = new string[0];
				}
				return array;
			}
			catch (Exception)
			{
				if (flag)
				{
					throw;
				}
				throw GetGenericSecurityException();
			}
		}

		internal static List<PartialToken> GetPartialTokens(string pipelineRoot)
		{
			PipelineDeploymentState pipelineDeploymentState = GetPipelineDeploymentState(pipelineRoot);
			return pipelineDeploymentState.PartialTokens;
		}

		[SecuritySafeCritical]
		public static Collection<AddInToken> FindAddIns(Type hostViewOfAddIn, PipelineStoreLocation location)
		{
			if (location != 0)
			{
				throw new ArgumentException(Res.InvalidPipelineStoreLocation, "location");
			}
			string appBase = GetAppBase();
			return FindAddInsImpl(hostViewOfAddIn, appBase, false);
		}

		[SecurityCritical]
		public static Collection<AddInToken> FindAddIns(Type hostViewOfAddIn, PipelineStoreLocation location, params string[] addInFolderPaths)
		{
			if (location != 0)
			{
				throw new ArgumentException(Res.InvalidPipelineStoreLocation, "location");
			}
			string appBase = GetAppBase();
			return FindAddInsImpl(hostViewOfAddIn, appBase, demand: false, addInFolderPaths);
		}

		[SecurityCritical]
		public static Collection<AddInToken> FindAddIns(Type hostViewOfAddIn, string pipelineRootFolderPath, params string[] addInFolderPaths)
		{
			return FindAddInsImpl(hostViewOfAddIn, pipelineRootFolderPath, demand: true, addInFolderPaths);
		}

		[SecurityCritical]
		private static Collection<AddInToken> FindAddInsImpl(Type hostViewOfAddIn, string pipelineRootFolderPath, bool demand, params string[] addInFolderPaths)
		{
			if (hostViewOfAddIn == null)
			{
				throw new ArgumentNullException("hostViewOfAddIn");
			}
			if (pipelineRootFolderPath == null)
			{
				throw new ArgumentNullException("pipelineRootFolderPath");
			}
			if (pipelineRootFolderPath.Length == 0)
			{
				throw new ArgumentException(Res.PathCantBeEmpty, "pipelineRootFolderPath");
			}
			WarnIfGenericHostView(hostViewOfAddIn);
			bool flag = Utils.HasFullTrust();
			try
			{
				pipelineRootFolderPath = ValidatePipelineRoot(pipelineRootFolderPath);
				if (demand)
				{
					new FileIOPermission(FileIOPermissionAccess.Read, pipelineRootFolderPath).Demand();
				}
				flag = HasPathDiscovery(pipelineRootFolderPath);
				if (addInFolderPaths != null)
				{
					for (int i = 0; i < addInFolderPaths.Length; i++)
					{
						addInFolderPaths[i] = ValidateAddInPath(addInFolderPaths[i]);
					}
				}
				PipelineDeploymentState pipelineDeploymentState = GetPipelineDeploymentState(pipelineRootFolderPath);
				Collection<AddInToken> collection = new Collection<AddInToken>();
				System.AddIn.MiniReflection.TypeInfo havType = new System.AddIn.MiniReflection.TypeInfo(hostViewOfAddIn);
				List<PartialToken> partialTokens = pipelineDeploymentState.PartialTokens;
				string text = Path.Combine(pipelineRootFolderPath, "AddIns");
				List<string> list = new List<string>();
				list.Add(text);
				if (addInFolderPaths != null)
				{
					foreach (string text2 in addInFolderPaths)
					{
						if (!string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
						{
							list.Add(text2);
						}
					}
				}
				FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, pipelineRootFolderPath);
				fileIOPermission.Assert();
				foreach (string item in list)
				{
					AddInDeploymentState addInDeploymentState = GetAddInDeploymentState(item);
					if (addInDeploymentState == null)
					{
						continue;
					}
					List<AddInToken> list2 = ConnectPipelinesWithAddIns(partialTokens, havType, addInDeploymentState);
					foreach (AddInToken item2 in list2)
					{
						item2.PipelineRootDirectory = pipelineRootFolderPath;
						item2.AddInRootDirectory = item;
						collection.Add(item2);
					}
				}
				return collection;
			}
			catch (Exception)
			{
				if (flag)
				{
					throw;
				}
				throw GetGenericSecurityException();
			}
		}

		private static void WarnIfGenericHostView(Type hostViewOfAddIn)
		{
			if (hostViewOfAddIn.IsGenericType)
			{
				Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, Res.HostViewUnusableBecauseItIsGeneric, new object[1] { hostViewOfAddIn.Name }));
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		[SecurityCritical]
		public static Collection<AddInToken> FindAddIn(Type hostViewOfAddIn, string pipelineRootFolderPath, string addInFilePath, string addInTypeName)
		{
			if (hostViewOfAddIn == null)
			{
				throw new ArgumentNullException("hostViewOfAddIn");
			}
			if (pipelineRootFolderPath == null)
			{
				throw new ArgumentNullException("pipelineRootFolderPath");
			}
			if (pipelineRootFolderPath.Length == 0)
			{
				throw new ArgumentException(Res.PathCantBeEmpty, "pipelineRootFolderPath");
			}
			if (addInFilePath == null)
			{
				throw new ArgumentNullException("addInFilePath");
			}
			if (addInFilePath.Length == 0)
			{
				throw new ArgumentException(Res.PathCantBeEmpty, "addInFilePath");
			}
			if (addInTypeName == null)
			{
				throw new ArgumentNullException("addInTypeName");
			}
			if (addInTypeName.Length == 0)
			{
				throw new ArgumentException(Res.TypeCantBeEmpty, "addInTypeName");
			}
			WarnIfGenericHostView(hostViewOfAddIn);
			bool flag = Utils.HasFullTrust();
			try
			{
				pipelineRootFolderPath = ValidatePipelineRoot(pipelineRootFolderPath);
				new FileIOPermission(FileIOPermissionAccess.Read, pipelineRootFolderPath).Demand();
				string directoryName = Path.GetDirectoryName(addInFilePath);
				ValidateAddInPath(directoryName);
				flag = HasPathDiscovery(pipelineRootFolderPath) && HasPathDiscovery(directoryName);
				Collection<string> collection = new Collection<string>();
				AddIn addIn = DiscoverAddIn(addInFilePath, collection, addInTypeName);
				foreach (string item2 in collection)
				{
					Debugger.Log(0, "AddInStore", item2);
				}
				if (addIn == null)
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Res.TypeNotFound, new object[2] { addInTypeName, addInFilePath }));
				}
				PipelineDeploymentState pipelineDeploymentState = GetPipelineDeploymentState(pipelineRootFolderPath);
				Collection<AddInToken> collection2 = new Collection<AddInToken>();
				foreach (PartialToken partialToken in pipelineDeploymentState.PartialTokens)
				{
					if (Contains(addIn.AddInBaseTypeInfo, partialToken._addinBase.TypeInfo))
					{
						AddInToken item = new AddInToken(partialToken._hostAdapter, partialToken._contract, partialToken._addinAdapter, partialToken._addinBase, addIn);
						collection2.Add(item);
					}
				}
				System.AddIn.MiniReflection.TypeInfo typeInfo = new System.AddIn.MiniReflection.TypeInfo(hostViewOfAddIn);
				for (int num = collection2.Count - 1; num >= 0; num--)
				{
					AddInToken addInToken = collection2[num];
					if (Contains(addInToken.HostAddinViews, typeInfo))
					{
						addInToken.PipelineRootDirectory = pipelineRootFolderPath;
						addInToken.AddInRootDirectory = Path.GetDirectoryName(addInFilePath);
						addInToken.ResolvedHostAddInView = typeInfo;
					}
					else
					{
						collection2.RemoveAt(num);
					}
				}
				return collection2;
			}
			catch (Exception)
			{
				if (flag)
				{
					throw;
				}
				throw GetGenericSecurityException();
			}
		}

		[SecurityCritical]
		private static string ValidateAddInPath(string addInPath)
		{
			if (addInPath == null)
			{
				throw new ArgumentNullException("addInPath");
			}
			string fullPath = GetFullPath(addInPath);
			new FileIOPermission(FileIOPermissionAccess.Read, fullPath).Demand();
			if (!Directory.Exists(fullPath))
			{
				if (HasPathDiscovery(fullPath))
				{
					throw new DirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture, Res.FolderNotFound, new object[1] { addInPath }));
				}
				throw new InvalidPipelineStoreException();
			}
			return fullPath;
		}

		[SecuritySafeCritical]
		private static string ValidatePipelineRoot(string pipelineRoot)
		{
			string fullPath = GetFullPath(pipelineRoot);
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read, fullPath);
			fileIOPermission.Assert();
			if (!Directory.Exists(fullPath))
			{
				if (HasPathDiscovery(fullPath))
				{
					throw new DirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture, Res.FolderNotFound, new object[1] { pipelineRoot }));
				}
				throw new InvalidPipelineStoreException();
			}
			string[] array = new string[4]
			{
				Path.Combine(pipelineRoot, "HostSideAdapters"),
				Path.Combine(pipelineRoot, "Contracts"),
				Path.Combine(pipelineRoot, "AddInSideAdapters"),
				Path.Combine(pipelineRoot, "AddInViews")
			};
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!Directory.Exists(text))
				{
					if (HasPathDiscovery(text))
					{
						throw new AddInSegmentDirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture, Res.PipelineFolderNotFound, new object[1] { text }));
					}
					throw new InvalidPipelineStoreException();
				}
			}
			return fullPath;
		}

		private static PipelineDeploymentState GetPipelineDeploymentState(string pipelineRoot)
		{
			return (PipelineDeploymentState)GetDeploymentState(pipelineRoot, "PipelineSegments.store", PipelineStateReader, BuildPipelineCache);
		}

		private static AddInDeploymentState GetAddInDeploymentState(string addInRoot)
		{
			return (AddInDeploymentState)GetDeploymentState(addInRoot, "AddIns.store", AddInStateReader, BuildAddInCache);
		}

		private static DeploymentState PipelineStateReader(string path, string fileName)
		{
			string storeFileName = Path.Combine(path, fileName);
			return ReadCache<PipelineDeploymentState>(storeFileName, mustExist: true);
		}

		private static DeploymentState AddInStateReader(string path, string fileName)
		{
			string storeFileName = Path.Combine(path, fileName);
			return ReadCache<AddInDeploymentState>(storeFileName, mustExist: false);
		}

		[SecuritySafeCritical]
		private static DeploymentState GetDeploymentState(string path, string storeFileName, Reader reader, Builder stateBuilder)
		{
			DeploymentState deploymentState = null;
			bool flag = false;
			string text = Path.Combine(path, storeFileName);
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read, text);
			fileIOPermission.Assert();
			CacheInfo value;
			lock (StateCache)
			{
				flag = StateCache.TryGetValue(text, out value);
				DateTime creationTime = File.GetCreationTime(text);
				if (flag && creationTime == value.FileTimeStamp)
				{
					deploymentState = value.State;
				}
				else
				{
					StateCache.Remove(path);
				}
			}
			if (deploymentState == null)
			{
				DateTime creationTime2 = File.GetCreationTime(text);
				try
				{
					deploymentState = reader(path, storeFileName);
				}
				catch (SecurityException)
				{
					Collection<string> warnings = new Collection<string>();
					deploymentState = stateBuilder(path, warnings);
				}
				if (deploymentState != null)
				{
					lock (StateCache)
					{
						if (!StateCache.ContainsKey(path))
						{
							value.State = deploymentState;
							value.FileTimeStamp = creationTime2;
							StateCache[text] = value;
						}
					}
				}
			}
			return deploymentState;
		}

		[SecuritySafeCritical]
		private static PipelineDeploymentState BuildPipelineCache(string rootDir, Collection<string> warnings)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, rootDir);
			fileIOPermission.Assert();
			rootDir = Path.GetFullPath(rootDir);
			DateTime now = DateTime.Now;
			PipelineDeploymentState pipelineDeploymentState = new PipelineDeploymentState();
			string path = Path.Combine(rootDir, "HostSideAdapters");
			string path2 = Path.Combine(rootDir, "Contracts");
			string path3 = Path.Combine(rootDir, "AddInSideAdapters");
			string text = Path.Combine(rootDir, "AddInViews");
			string text2 = Path.Combine(rootDir, "AddIns");
			int num = 0;
			string[] files = Directory.GetFiles(path);
			foreach (string text3 in files)
			{
				if (text3.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || text3.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
				{
					DiscoverHostAdapters(text3, pipelineDeploymentState.HostAdapters, rootDir, warnings);
					pipelineDeploymentState.FileCounts[num]++;
				}
			}
			num++;
			string[] files2 = Directory.GetFiles(path2);
			foreach (string text4 in files2)
			{
				if (text4.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || text4.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
				{
					Discover(text4, PipelineComponentType.Contract, pipelineDeploymentState, rootDir, warnings);
					pipelineDeploymentState.FileCounts[num]++;
				}
			}
			num++;
			string[] files3 = Directory.GetFiles(path3);
			foreach (string text5 in files3)
			{
				if (text5.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || text5.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
				{
					Discover(text5, PipelineComponentType.AddInAdapter, pipelineDeploymentState, rootDir, warnings);
					pipelineDeploymentState.FileCounts[num]++;
				}
			}
			num++;
			bool flag = false;
			string[] files4 = Directory.GetFiles(text);
			foreach (string text6 in files4)
			{
				if (text6.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || text6.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
				{
					if (Discover(text6, PipelineComponentType.AddInBase, pipelineDeploymentState, rootDir, warnings))
					{
						flag = true;
					}
					pipelineDeploymentState.FileCounts[num]++;
				}
			}
			if (!flag)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.NoAddInBaseFound, new object[1] { text }));
			}
			pipelineDeploymentState.ConnectPipeline(warnings);
			WriteCache(pipelineDeploymentState, rootDir, "PipelineSegments.store", now);
			return pipelineDeploymentState;
		}

		[SecuritySafeCritical]
		private static AddInDeploymentState BuildAddInCache(string rootDir, Collection<string> warnings)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, rootDir);
			fileIOPermission.Assert();
			rootDir = Path.GetFullPath(rootDir);
			DateTime now = DateTime.Now;
			AddInDeploymentState addInDeploymentState = new AddInDeploymentState();
			try
			{
				string[] directories = Directory.GetDirectories(rootDir);
				foreach (string text in directories)
				{
					int count = addInDeploymentState.AddIns.Count;
					try
					{
						bool flag = false;
						List<AddIn> list = new List<AddIn>();
						int num = 0;
						string[] files = Directory.GetFiles(text);
						foreach (string text2 in files)
						{
							if (IsDllOrExe(text2))
							{
								num++;
								if (DiscoverAddIns(text2, list, rootDir, warnings))
								{
									flag = true;
								}
							}
						}
						addInDeploymentState.AddIns.AddRange(list);
						addInDeploymentState.FileCount += num;
						if (!flag)
						{
							warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.NoAddInFound, new object[1] { text }));
						}
					}
					catch (AddInBaseInAddInFolderException ex)
					{
						warnings.Add(ex.Message);
					}
				}
				WriteCache(addInDeploymentState, rootDir, "AddIns.store", now);
				string[] files2 = Directory.GetFiles(rootDir);
				string text3 = Path.Combine(rootDir, "AddIns.store");
				string[] array = files2;
				foreach (string text4 in array)
				{
					if (!text3.Equals(text4) && IsDllOrExe(text4))
					{
						warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.FileInAddInFolder, new object[1] { text4 }));
					}
				}
				return addInDeploymentState;
			}
			catch (DirectoryNotFoundException)
			{
				return null;
			}
			catch (InvalidPipelineStoreException)
			{
				return null;
			}
		}

		private static bool IsDllOrExe(string file)
		{
			if (!file.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
			{
				return file.EndsWith(".exe", StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		[SecuritySafeCritical]
		internal static bool HasPathDiscovery(string path)
		{
			try
			{
				FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, path);
				fileIOPermission.Demand();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		[SecuritySafeCritical]
		private static void WriteCache(DeploymentState state, string path, string fileName, DateTime timeStamp)
		{
			MemoryStream memoryStream = new MemoryStream();
			using MemoryStream memoryStream2 = new MemoryStream();
			string path2 = Path.Combine(path, fileName);
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.SerializationFormatter));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, path2));
			permissionSet.Assert();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream2, state);
			using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write(1);
			binaryWriter.Write(memoryStream2.Length);
			binaryWriter.Write(memoryStream2.GetBuffer(), 0, (int)memoryStream2.Length);
			for (int i = 0; i < 4; i++)
			{
				try
				{
					using (FileStream fileStream = File.Create(path2))
					{
						fileStream.Write(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
					}
					File.SetCreationTime(path2, timeStamp);
					break;
				}
				catch (IOException e)
				{
					if (Marshal.GetHRForException(e) != -2147024864)
					{
						throw;
					}
					Thread.Sleep(500);
				}
			}
		}

		[SecuritySafeCritical]
		private static T ReadCache<T>(string storeFileName, bool mustExist)
		{
			new SecurityPermission(SecurityPermissionFlag.SerializationFormatter).Demand();
			new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, storeFileName).Assert();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			T result = default(T);
			if (!File.Exists(storeFileName))
			{
				if (mustExist)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.CantFindDeployedAddInsFile, new object[1] { storeFileName }));
				}
				return result;
			}
			for (int i = 0; i < 4; i++)
			{
				try
				{
					using Stream stream = File.OpenRead(storeFileName);
					if (stream.Length < 12)
					{
						throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.DeployedAddInsFileCorrupted, new object[1] { storeFileName }));
					}
					BinaryReader binaryReader = new BinaryReader(stream);
					int num = binaryReader.ReadInt32();
					long num2 = binaryReader.ReadInt64();
					try
					{
						result = (T)binaryFormatter.Deserialize(stream);
						return result;
					}
					catch (Exception innerException)
					{
						throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Res.CantDeserializeData, new object[1] { storeFileName }), innerException);
					}
				}
				catch (IOException e)
				{
					if (Marshal.GetHRForException(e) != -2147024864)
					{
						throw;
					}
					Thread.Sleep(500);
				}
			}
			return result;
		}

		[SecuritySafeCritical]
		internal static string GetAppBase()
		{
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllFiles = FileIOPermissionAccess.PathDiscovery;
			fileIOPermission.Assert();
			return AppDomain.CurrentDomain.BaseDirectory;
		}

		[SecuritySafeCritical]
		private static bool Discover(string assemblyFileName, PipelineComponentType componentType, PipelineDeploymentState state, string rootDir, Collection<string> warnings)
		{
			string appBase = GetAppBase();
			AppDomain appDomain = null;
			InspectionResults inspectionResults;
			try
			{
				appDomain = CreateWorkerDomain(appBase);
				ObjectHandle objectHandle = Activator.CreateInstance(appDomain, typeof(InspectionWorker).Assembly.FullName, typeof(InspectionWorker).FullName);
				InspectionWorker inspectionWorker = (InspectionWorker)objectHandle.Unwrap();
				inspectionResults = inspectionWorker.Inspect(componentType, assemblyFileName, rootDir);
			}
			finally
			{
				if (appDomain != null)
				{
					Utils.UnloadAppDomain(appDomain);
				}
			}
			foreach (string warning in inspectionResults.Warnings)
			{
				warnings.Add(warning);
			}
			List<PipelineComponent> components = inspectionResults.Components;
			if (components.Count > 0)
			{
				switch (componentType)
				{
				case PipelineComponentType.Contract:
					state.Contracts.AddRange(new ContravarianceAdapter<PipelineComponent, ContractComponent>(components));
					break;
				case PipelineComponentType.AddInAdapter:
					state.AddInAdapters.AddRange(new ContravarianceAdapter<PipelineComponent, AddInAdapter>(components));
					break;
				case PipelineComponentType.AddInBase:
					state.AddInBases.AddRange(new ContravarianceAdapter<PipelineComponent, AddInBase>(components));
					break;
				}
				return true;
			}
			return false;
		}

		[SecurityCritical]
		[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
		private static AppDomain CreateWorkerDomain(string appBase)
		{
			return AppDomain.CreateDomain("Add-In Model Discovery worker AD", null, appBase, null, shadowCopyFiles: false);
		}

		private static void DiscoverHostAdapters(string assemblyFileName, List<HostAdapter> container, string rootDir, Collection<string> warnings)
		{
			System.AddIn.MiniReflection.TypeInfo.SetWarnings(warnings);
			int num = 0;
			MiniAssembly miniAssembly = null;
			try
			{
				miniAssembly = new MiniAssembly(assemblyFileName);
				string assemblyLocation = Utils.MakeRelativePath(assemblyFileName, rootDir);
				miniAssembly.DependencyDirs.Add(Path.Combine(rootDir, "Contracts"));
				foreach (System.AddIn.MiniReflection.TypeInfo item in miniAssembly.GetTypesWithAttribute(typeof(HostAdapterAttribute), includePrivate: true))
				{
					HostAdapter hostAdapter = new HostAdapter(item, assemblyLocation);
					if (hostAdapter.Validate(item, warnings))
					{
						container.Add(hostAdapter);
						num++;
					}
				}
			}
			catch (GenericsNotImplementedException)
			{
			}
			catch (Exception ex2)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.InspectingAssemblyThrew, new object[3]
				{
					ex2.GetType().Name,
					ex2.Message,
					assemblyFileName
				}));
			}
			finally
			{
				miniAssembly?.Dispose();
				System.AddIn.MiniReflection.TypeInfo.SetWarnings(null);
			}
			if (num == 0)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.NoAddInModelPartsFound, new object[2]
				{
					PipelineComponentType.HostAdapter,
					assemblyFileName
				}));
			}
		}

		[SecuritySafeCritical]
		private static AddIn DiscoverAddIn(string assemblyPath, Collection<string> warnings, string fullTypeName)
		{
			System.AddIn.MiniReflection.TypeInfo.SetWarnings(warnings);
			MiniAssembly miniAssembly = null;
			try
			{
				string directoryName = Path.GetDirectoryName(assemblyPath);
				FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, directoryName);
				fileIOPermission.Assert();
				string fileName = Path.GetFileName(assemblyPath);
				miniAssembly = new MiniAssembly(assemblyPath);
				int num = fullTypeName.LastIndexOf('.');
				string nameSpace = string.Empty;
				string text;
				if (num > 0)
				{
					text = fullTypeName.Substring(num + 1);
					nameSpace = fullTypeName.Substring(0, num);
				}
				else
				{
					text = fullTypeName;
				}
				System.AddIn.MiniReflection.TypeInfo typeInfo = miniAssembly.FindTypeInfo(text, nameSpace);
				if (typeInfo != null)
				{
					AddIn addIn = new AddIn(typeInfo, assemblyPath, assemblyPath, miniAssembly.FullName);
					addIn.UnlocalizedResourceState.Name = text;
					if (addIn.Validate(typeInfo, warnings))
					{
						return addIn;
					}
				}
			}
			finally
			{
				miniAssembly?.Dispose();
				System.AddIn.MiniReflection.TypeInfo.SetWarnings(null);
			}
			return null;
		}

		private static bool DiscoverAddIns(string assemblyFileName, List<AddIn> container, string rootDir, Collection<string> warnings)
		{
			System.AddIn.MiniReflection.TypeInfo.SetWarnings(warnings);
			int num = 0;
			MiniAssembly miniAssembly = null;
			try
			{
				miniAssembly = new MiniAssembly(assemblyFileName);
				string assemblyLocation = Utils.MakeRelativePath(assemblyFileName, rootDir);
				using (IEnumerator<System.AddIn.MiniReflection.TypeInfo> enumerator = miniAssembly.GetTypesWithAttribute(typeof(AddInBaseAttribute), includePrivate: true).GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						System.AddIn.MiniReflection.TypeInfo current = enumerator.Current;
						throw new AddInBaseInAddInFolderException(string.Format(CultureInfo.CurrentCulture, Res.ComponentInWrongLocation, new object[2] { assemblyFileName, rootDir }));
					}
				}
				foreach (System.AddIn.MiniReflection.TypeInfo item in miniAssembly.GetTypesWithAttribute(typeof(AddInAttribute)))
				{
					AddIn addIn = new AddIn(item, assemblyLocation, assemblyFileName, miniAssembly.FullName);
					if (addIn.Validate(item, warnings))
					{
						container.Add(addIn);
					}
					num++;
				}
			}
			catch (GenericsNotImplementedException)
			{
			}
			catch (AddInBaseInAddInFolderException)
			{
				throw;
			}
			catch (Exception ex3)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.InspectingAssemblyThrew, new object[3]
				{
					ex3.GetType().Name,
					ex3.Message,
					assemblyFileName
				}));
			}
			finally
			{
				miniAssembly?.Dispose();
				System.AddIn.MiniReflection.TypeInfo.SetWarnings(null);
			}
			return num > 0;
		}

		private static List<AddInToken> ConnectPipelinesWithAddIns(List<PartialToken> partialTokens, System.AddIn.MiniReflection.TypeInfo havType, params AddInDeploymentState[] addInStores)
		{
			List<AddInToken> validPipelines = new List<AddInToken>();
			foreach (PartialToken partialToken in partialTokens)
			{
				foreach (AddInDeploymentState addInDeploymentState in addInStores)
				{
					foreach (AddIn addIn in addInDeploymentState.AddIns)
					{
						if (Contains(addIn.AddInBaseTypeInfo, partialToken._addinBase.TypeInfo))
						{
							partialToken._addinBase.ConnectedToNeighbors = true;
							addIn.ConnectedToNeighbors = true;
							if (Contains(partialToken._hostAdapter.HostAddinViews, havType))
							{
								AddInToken addInToken = new AddInToken(partialToken._hostAdapter, partialToken._contract, partialToken._addinAdapter, partialToken._addinBase, addIn);
								addInToken.ResolvedHostAddInView = havType;
								validPipelines.Add(addInToken);
							}
						}
					}
				}
			}
			RemoveDuplicatePipelines(ref validPipelines);
			return validPipelines;
		}

		internal static bool Contains(System.AddIn.MiniReflection.TypeInfo[] array, System.AddIn.MiniReflection.TypeInfo info)
		{
			foreach (System.AddIn.MiniReflection.TypeInfo typeInfo in array)
			{
				if (typeInfo.Equals(info))
				{
					return true;
				}
			}
			return false;
		}

		private static void RemoveDuplicatePipelines(ref List<AddInToken> validPipelines)
		{
			List<AddInToken> list = new List<AddInToken>(validPipelines.Count);
			Dictionary<string, AddInToken> dictionary = new Dictionary<string, AddInToken>(StringComparer.OrdinalIgnoreCase);
			foreach (AddInToken validPipeline in validPipelines)
			{
				if (validPipeline.HasQualificationDataOnPipeline)
				{
					list.Add(validPipeline);
					continue;
				}
				string hostViewId = validPipeline.HostViewId;
				if (!dictionary.TryGetValue(hostViewId, out var value))
				{
					dictionary[hostViewId] = validPipeline;
					continue;
				}
				int num = string.CompareOrdinal(validPipeline._hostAdapter.TypeInfo.AssemblyQualifiedName, value._hostAdapter.TypeInfo.AssemblyQualifiedName);
				if (num < 0)
				{
					continue;
				}
				if (num > 0)
				{
					dictionary[hostViewId] = validPipeline;
					continue;
				}
				num = string.CompareOrdinal(validPipeline._contract.TypeInfo.AssemblyQualifiedName, value._contract.TypeInfo.AssemblyQualifiedName);
				if (num < 0)
				{
					continue;
				}
				if (num > 0)
				{
					dictionary[hostViewId] = validPipeline;
					continue;
				}
				num = string.CompareOrdinal(validPipeline._addinAdapter.TypeInfo.AssemblyQualifiedName, value._addinAdapter.TypeInfo.AssemblyQualifiedName);
				if (num < 0)
				{
					continue;
				}
				if (num > 0)
				{
					dictionary[hostViewId] = validPipeline;
					continue;
				}
				num = string.CompareOrdinal(validPipeline._addinBase.TypeInfo.AssemblyQualifiedName, value._addinBase.TypeInfo.AssemblyQualifiedName);
				if (num >= 0 && num > 0)
				{
					dictionary[hostViewId] = validPipeline;
				}
			}
			foreach (AddInToken value2 in dictionary.Values)
			{
				list.Add(value2);
			}
			validPipelines = list;
		}

		[SecuritySafeCritical]
		private static string GetFullPath(string path)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllFiles = FileIOPermissionAccess.PathDiscovery;
			fileIOPermission.Assert();
			return Path.GetFullPath(path);
		}

		private static SecurityException GetGenericSecurityException()
		{
			return new SecurityException(Res.GenericSecurityExceptionMessage);
		}
	}
	[Serializable]
	internal class AddInBaseInAddInFolderException : Exception
	{
		public AddInBaseInAddInFolderException(string message)
			: base(message)
		{
		}

		public AddInBaseInAddInFolderException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected AddInBaseInAddInFolderException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public AddInBaseInAddInFolderException()
		{
		}
	}
	internal sealed class AddInServer : MarshalByRefObject
	{
		private int _addInAppDomains;

		private volatile bool _startedExitProcess;

		private EventWorker _eventWorker;

		public void Initialize(EventWorker eventWorker)
		{
			_eventWorker = eventWorker;
		}

		[SecuritySafeCritical]
		public AddInServerWorker CreateDomain(AddInToken token, PermissionSet permissionSet)
		{
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.ApplicationBase = Path.GetDirectoryName(token._addin.Location);
			appDomainSetup.ConfigurationFile = token._addin.Location + ".config";
			Assembly assembly = typeof(AddInActivator).Assembly;
			AppDomain appDomain = AppDomain.CreateDomain(token.Name, AppDomain.CurrentDomain.Evidence, appDomainSetup, permissionSet, AddInActivator.CreateStrongName(assembly));
			appDomain.Load(assembly.FullName);
			ObjectHandle objectHandle = Activator.CreateInstance(appDomain, assembly.FullName, typeof(AddInServerWorker).FullName);
			AddInServerWorker addInServerWorker = (AddInServerWorker)objectHandle.Unwrap();
			addInServerWorker.AddInServer = this;
			Interlocked.Increment(ref _addInAppDomains);
			return addInServerWorker;
		}

		public void ExitProcess()
		{
			_startedExitProcess = true;
			Environment.Exit(0);
		}

		public void AddInDomainFinalized()
		{
			long num = Interlocked.Decrement(ref _addInAppDomains);
			if (!_startedExitProcess && num == 0L)
			{
				try
				{
					_eventWorker.SendShutdownMessage();
				}
				catch (RemotingException)
				{
				}
			}
		}

		public override object InitializeLifetimeService()
		{
			return null;
		}
	}
	internal sealed class AddInServerWorker : MarshalByRefObject
	{
		private AddInServer _addInServer;

		public AddInServer AddInServer
		{
			set
			{
				_addInServer = value;
			}
		}

		[SecuritySafeCritical]
		public AddInServerWorker()
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.ControlPrincipal));
			permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
			permissionSet.AddPermission(new ReflectionPermission(PermissionState.Unrestricted));
			permissionSet.Assert();
			RemotingHelper.InitializeClientChannel();
		}

		[SecuritySafeCritical]
		public void SetAppDomainOwner(IContract contract)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlAppDomain).Assert();
			AppDomain.CurrentDomain.SetData("System.AddIn_Owner_Contract", contract);
		}

		public IContract Activate(AddInToken pipeline, out ActivationWorker worker)
		{
			worker = new ActivationWorker(pipeline);
			return worker.Activate();
		}

		public override object InitializeLifetimeService()
		{
			return null;
		}

		[SecurityCritical]
		public void UnloadAppDomain()
		{
			SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlAppDomain);
			securityPermission.Assert();
			AppDomain.Unload(AppDomain.CurrentDomain);
		}

		[SecurityCritical]
		~AddInServerWorker()
		{
			if (_addInServer != null)
			{
				_addInServer.AddInDomainFinalized();
			}
		}
	}
	internal sealed class EventWorker : MarshalByRefObject
	{
		private AddInProcess _process;

		public EventWorker(AddInProcess process)
		{
			_process = process;
		}

		public bool SendShutdownMessage()
		{
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			_process.SendShuttingDown(cancelEventArgs);
			return cancelEventArgs.Cancel;
		}
	}
	[Serializable]
	public sealed class AddInToken : IEnumerable<QualificationDataItem>, IEnumerable
	{
		internal readonly System.AddIn.MiniReflection.TypeInfo[] _hostAddinViews;

		internal readonly HostAdapter _hostAdapter;

		internal readonly ContractComponent _contract;

		internal readonly AddInAdapter _addinAdapter;

		internal readonly AddInBase _addinBase;

		internal readonly AddIn _addin;

		private string _pipelineRootDir;

		private string _addInRootDir;

		private System.AddIn.MiniReflection.TypeInfo _resolvedHostAddinView;

		private IDictionary<AddInSegmentType, IDictionary<string, string>> _qualificationData;

		private List<QualificationDataItem> _qualificationDataItems;

		private static volatile bool _enableDirectConnect;

		public static bool EnableDirectConnect
		{
			get
			{
				return _enableDirectConnect;
			}
			set
			{
				_enableDirectConnect = value;
			}
		}

		public IDictionary<AddInSegmentType, IDictionary<string, string>> QualificationData
		{
			get
			{
				if (_qualificationData == null)
				{
					Dictionary<AddInSegmentType, IDictionary<string, string>> dictionary = new Dictionary<AddInSegmentType, IDictionary<string, string>>();
					dictionary[AddInSegmentType.HostViewOfAddIn] = PipelineComponent.s_emptyDictionary;
					dictionary[AddInSegmentType.HostSideAdapter] = _hostAdapter.QualificationData;
					dictionary[AddInSegmentType.Contract] = _contract.QualificationData;
					dictionary[AddInSegmentType.AddInSideAdapter] = _addinAdapter.QualificationData;
					dictionary[AddInSegmentType.AddInView] = _addinBase.QualificationData;
					dictionary[AddInSegmentType.AddIn] = _addin.QualificationData;
					_qualificationData = new ReadOnlyDictionary<AddInSegmentType, IDictionary<string, string>>(dictionary);
				}
				return _qualificationData;
			}
		}

		internal bool HasQualificationDataOnPipeline
		{
			get
			{
				for (AddInSegmentType addInSegmentType = AddInSegmentType.HostSideAdapter; addInSegmentType <= AddInSegmentType.AddInView; addInSegmentType++)
				{
					IDictionary<string, string> dictionary = QualificationData[addInSegmentType];
					if (dictionary.Count != 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		public string AddInFullName => _addin.FullName;

		internal System.AddIn.MiniReflection.TypeInfo ResolvedHostAddInView
		{
			set
			{
				_resolvedHostAddinView = value;
			}
		}

		internal string PipelineRootDirectory
		{
			get
			{
				return _pipelineRootDir;
			}
			set
			{
				_pipelineRootDir = value;
				_hostAdapter.SetRootDirectory(_pipelineRootDir);
				_contract.SetRootDirectory(_pipelineRootDir);
				_addinAdapter.SetRootDirectory(_pipelineRootDir);
				_addinBase.SetRootDirectory(_pipelineRootDir);
			}
		}

		internal string AddInRootDirectory
		{
			set
			{
				_addInRootDir = value;
				_addin.SetRootDirectory(_addInRootDir);
			}
		}

		public string Name => _addin.AddInName;

		public string Publisher => _addin.Publisher;

		public string Version => _addin.Version;

		public string Description => _addin.Description;

		public AssemblyName AssemblyName => _addin.AssemblyName;

		internal System.AddIn.MiniReflection.TypeInfo[] HostAddinViews => _hostAddinViews;

		internal string HostViewId => _resolvedHostAddinView.FullName + " " + _addin.RelativeLocation + " " + _addin.TypeInfo.FullName;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<QualificationDataItem> GetEnumerator()
		{
			if (_qualificationDataItems == null)
			{
				_qualificationDataItems = new List<QualificationDataItem>();
				for (AddInSegmentType addInSegmentType = AddInSegmentType.HostSideAdapter; addInSegmentType <= AddInSegmentType.AddIn; addInSegmentType++)
				{
					IDictionary<string, string> dictionary = QualificationData[addInSegmentType];
					foreach (KeyValuePair<string, string> item2 in dictionary)
					{
						QualificationDataItem item = new QualificationDataItem(addInSegmentType, item2.Key, item2.Value);
						_qualificationDataItems.Add(item);
					}
				}
			}
			return _qualificationDataItems.GetEnumerator();
		}

		internal AddInToken(HostAdapter hostAdapter, ContractComponent contract, AddInAdapter addinAdapter, AddInBase addinBase, AddIn addin)
		{
			_hostAddinViews = hostAdapter.HostAddinViews;
			_hostAdapter = hostAdapter;
			_contract = contract;
			_addinAdapter = addinAdapter;
			_addinBase = addinBase;
			_addin = addin;
		}

		public override string ToString()
		{
			return _addin.AddInName;
		}

		public override bool Equals(object obj)
		{
			if (obj is AddInToken addInToken)
			{
				return Equals(addInToken);
			}
			return false;
		}

		private bool Equals(AddInToken addInToken)
		{
			if (this == addInToken)
			{
				return true;
			}
			if (_hostAdapter.TypeInfo.AssemblyQualifiedName == addInToken._hostAdapter.TypeInfo.AssemblyQualifiedName && _contract.TypeInfo.AssemblyQualifiedName == addInToken._contract.TypeInfo.AssemblyQualifiedName && _addinAdapter.TypeInfo.AssemblyQualifiedName == addInToken._addinAdapter.TypeInfo.AssemblyQualifiedName && _addinBase.TypeInfo.AssemblyQualifiedName == addInToken._addinBase.TypeInfo.AssemblyQualifiedName && _addin.TypeInfo.AssemblyQualifiedName == addInToken._addin.TypeInfo.AssemblyQualifiedName)
			{
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return _hostAdapter.TypeInfo.GetHashCode() + _contract.TypeInfo.GetHashCode() + _addinAdapter.TypeInfo.GetHashCode() + _addinBase.TypeInfo.GetHashCode() + _addin.TypeInfo.GetHashCode();
		}

		public T Activate<T>(AddInSecurityLevel trustLevel)
		{
			return AddInActivator.Activate<T>(this, trustLevel);
		}

		public T Activate<T>(AddInSecurityLevel trustLevel, string appDomainName)
		{
			return AddInActivator.Activate<T>(this, trustLevel, appDomainName);
		}

		public T Activate<T>(AppDomain target)
		{
			if (target != AppDomain.CurrentDomain && !Utils.HasFullTrust())
			{
				throw new SecurityException(Res.PartialTrustCannotActivate);
			}
			return AddInActivator.Activate<T>(this, target);
		}

		public T Activate<T>(PermissionSet permissions)
		{
			if (permissions == null)
			{
				throw new ArgumentNullException("permissions");
			}
			return AddInActivator.Activate<T>(this, permissions);
		}

		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public T Activate<T>(AddInProcess process, PermissionSet permissionSet)
		{
			return AddInActivator.Activate<T>(this, process, permissionSet);
		}

		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public T Activate<T>(AddInProcess process, AddInSecurityLevel level)
		{
			return AddInActivator.Activate<T>(this, process, level);
		}

		public T Activate<T>(AddInEnvironment environment)
		{
			return AddInActivator.Activate<T>(this, environment);
		}

		internal bool HasDuplicatedAssemblies(string rootDir, Collection<string> warnings)
		{
			PipelineComponent[] array = new PipelineComponent[8] { _contract, _addinAdapter, _addinBase, _addinAdapter, _addinBase, _addin, _contract, _hostAdapter };
			bool result = false;
			for (int i = 0; i < array.Length; i += 2)
			{
				if (ComponentInWrongLocation(array[i], array[i + 1], rootDir, warnings))
				{
					result = true;
				}
			}
			return result;
		}

		private bool ComponentInWrongLocation(PipelineComponent component, PipelineComponent dependentComponent, string rootDir, Collection<string> warnings)
		{
			string path = ((rootDir == null) ? dependentComponent.Location : Path.Combine(rootDir, dependentComponent.Location));
			string fileName = Path.GetFileName(component.Location);
			string directoryName = Path.GetDirectoryName(path);
			if (File.Exists(Path.Combine(directoryName, fileName)))
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.ComponentInWrongLocation, new object[2] { fileName, directoryName }));
				return true;
			}
			return false;
		}
	}
	internal struct ContravarianceAdapter<Base, Derived> : IEnumerable<Derived>, IEnumerable where Derived : Base
	{
		internal struct ContravariantEnumerator : IEnumerator<Derived>, IDisposable, IEnumerator
		{
			private IEnumerator<Base> _enumerator;

			public Derived Current => (Derived)(object)_enumerator.Current;

			object IEnumerator.Current => ((IEnumerator)_enumerator).Current;

			internal ContravariantEnumerator(IEnumerator<Base> enumerator)
			{
				_enumerator = enumerator;
			}

			public bool MoveNext()
			{
				return _enumerator.MoveNext();
			}

			public void Reset()
			{
				_enumerator.Reset();
			}

			public void Dispose()
			{
				_enumerator.Dispose();
			}
		}

		private IEnumerable<Base> _enumerable;

		internal ContravarianceAdapter(IEnumerable<Base> collection)
		{
			_enumerable = collection;
		}

		public IEnumerator<Derived> GetEnumerator()
		{
			return new ContravariantEnumerator(_enumerable.GetEnumerator());
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ContravariantEnumerator(_enumerable.GetEnumerator());
		}
	}
	[Serializable]
	internal abstract class DeploymentState
	{
	}
	[Serializable]
	internal struct InspectionResults
	{
		internal List<PipelineComponent> Components;

		internal Collection<string> Warnings;
	}
	internal sealed class InspectionWorker : MarshalByRefObject
	{
		private string _assemblyFileName;

		private string _pipelineRootDirectory;

		private PipelineComponentType _currentComponentType;

		private static Assembly SystemAddInInReflectionOnlyContext;

		private static Assembly SystemAddInContractsInReflectionOnlyContext;

		static InspectionWorker()
		{
			SystemAddInInReflectionOnlyContext = Assembly.ReflectionOnlyLoad(typeof(AddInStore).Assembly.FullName);
			SystemAddInContractsInReflectionOnlyContext = Assembly.ReflectionOnlyLoad(typeof(IContract).Assembly.FullName);
			PipelineComponent.SetTypesFromReflectionLoaderContext(SystemAddInInReflectionOnlyContext, SystemAddInContractsInReflectionOnlyContext);
		}

		internal Assembly ResolveAssembly(object sender, ResolveEventArgs args)
		{
			string name = args.Name;
			string text = name.Substring(0, name.IndexOf(','));
			if (string.Equals(text, "System.AddIn"))
			{
				return SystemAddInInReflectionOnlyContext;
			}
			if (string.Equals(text, "System.AddIn.Contract"))
			{
				return SystemAddInContractsInReflectionOnlyContext;
			}
			string directoryName = Path.GetDirectoryName(Path.GetDirectoryName(_assemblyFileName));
			if (_currentComponentType == PipelineComponentType.AddIn)
			{
				directoryName = Path.GetDirectoryName(directoryName);
			}
			List<string> list = new List<string>();
			switch (_currentComponentType)
			{
			case PipelineComponentType.HostAdapter:
				list.Add(Path.Combine(directoryName, "Contracts"));
				break;
			case PipelineComponentType.AddInAdapter:
				list.Add(Path.Combine(directoryName, "Contracts"));
				list.Add(Path.Combine(directoryName, "AddInViews"));
				break;
			case PipelineComponentType.AddInBase:
				list.Add(Path.Combine(directoryName, "AddInViews"));
				break;
			}
			List<string> list2 = new List<string>(list.Count * 2);
			foreach (string item in list)
			{
				string text2 = Path.Combine(item, text);
				string text3 = text2 + ".dll";
				if (File.Exists(text3))
				{
					list2.Add(text3);
				}
				else if (File.Exists(text2 + ".exe"))
				{
					list2.Add(text2 + ".exe");
				}
			}
			foreach (string item2 in list2)
			{
				try
				{
					Assembly assembly = Assembly.ReflectionOnlyLoadFrom(item2);
					if (Utils.AssemblyRefEqualsDef(name, assembly.FullName))
					{
						return assembly;
					}
				}
				catch (BadImageFormatException)
				{
				}
			}
			if (!name.Contains("PublicKeyToken=null"))
			{
				try
				{
					return Assembly.ReflectionOnlyLoad(name);
				}
				catch (FileNotFoundException)
				{
				}
				try
				{
					return Assembly.ReflectionOnlyLoad(AppDomain.CurrentDomain.ApplyPolicy(name));
				}
				catch (FileNotFoundException)
				{
				}
			}
			return null;
		}

		[SecuritySafeCritical]
		internal InspectionResults Inspect(PipelineComponentType componentType, string assemblyFileName, string pipelineRootDirectory)
		{
			_assemblyFileName = assemblyFileName;
			_pipelineRootDirectory = pipelineRootDirectory;
			_currentComponentType = componentType;
			ResolveEventHandler value = ResolveAssembly;
			AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += value;
			InspectionResults result = default(InspectionResults);
			result.Components = new List<PipelineComponent>();
			result.Warnings = new Collection<string>();
			string text = null;
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, _pipelineRootDirectory);
			fileIOPermission.Assert();
			Type[] types;
			try
			{
				Assembly assembly = Assembly.ReflectionOnlyLoadFrom(_assemblyFileName);
				types = assembly.GetTypes();
				text = assembly.FullName;
			}
			catch (FileNotFoundException ex)
			{
				result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AssemblyLoadFileNotFound, new object[2] { ex.Message, ex.FileName }));
				return result;
			}
			catch (Exception ex2)
			{
				result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AssemblyLoadThrew, new object[3]
				{
					ex2.GetType().Name,
					ex2.Message,
					_assemblyFileName
				}));
				return result;
			}
			PipelineComponent pipelineComponent = null;
			string assemblyLocation = Utils.MakeRelativePath(_assemblyFileName, _pipelineRootDirectory);
			Type type = null;
			try
			{
				Type[] array = types;
				foreach (Type type2 in array)
				{
					pipelineComponent = null;
					type = type2;
					switch (componentType)
					{
					case PipelineComponentType.Contract:
						if (!Utils.HasCustomAttribute(PipelineComponent.ContractAttributeInReflectionLoaderContext, type2))
						{
							continue;
						}
						pipelineComponent = new ContractComponent(new System.AddIn.MiniReflection.TypeInfo(type2), assemblyLocation);
						break;
					case PipelineComponentType.AddInAdapter:
						if (!Utils.HasCustomAttribute(PipelineComponent.AddInAdapterAttributeInReflectionLoaderContext, type2))
						{
							continue;
						}
						pipelineComponent = new AddInAdapter(new System.AddIn.MiniReflection.TypeInfo(type2), assemblyLocation);
						break;
					case PipelineComponentType.AddInBase:
					{
						if (Utils.HasCustomAttribute(PipelineComponent.AddInAttributeInReflectionLoaderContext, type2))
						{
							result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AddInInAddInViewFolder, new object[2] { type2.Name, _assemblyFileName }));
						}
						if (!Utils.HasCustomAttribute(PipelineComponent.AddInBaseAttributeInReflectionLoaderContext, type2))
						{
							continue;
						}
						System.AddIn.MiniReflection.TypeInfo[] array2 = null;
						CustomAttributeData customAttributeData = Utils.GetCustomAttributeData(PipelineComponent.AddInBaseAttributeInReflectionLoaderContext, type2);
						foreach (CustomAttributeNamedArgument namedArgument in customAttributeData.NamedArguments)
						{
							if (!(namedArgument.MemberInfo.Name == "ActivatableAs"))
							{
								continue;
							}
							ReadOnlyCollection<CustomAttributeTypedArgument> readOnlyCollection = (ReadOnlyCollection<CustomAttributeTypedArgument>)namedArgument.TypedValue.Value;
							array2 = new System.AddIn.MiniReflection.TypeInfo[readOnlyCollection.Count];
							int num = 0;
							foreach (CustomAttributeTypedArgument item in readOnlyCollection)
							{
								array2[num++] = new System.AddIn.MiniReflection.TypeInfo((Type)item.Value);
							}
						}
						pipelineComponent = new AddInBase(new System.AddIn.MiniReflection.TypeInfo(type2), array2, assemblyLocation, text);
						break;
					}
					}
					if (pipelineComponent != null && pipelineComponent.Validate(type2, result.Warnings))
					{
						result.Components.Add(pipelineComponent);
					}
				}
			}
			catch (FileNotFoundException ex3)
			{
				result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.AssemblyLoadFileNotFound, new object[2] { ex3.Message, ex3.FileName }));
				return result;
			}
			catch (NotImplementedException)
			{
				result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.NotImplementedFeatureBadCtorParamOrAssembly, new object[2]
				{
					_assemblyFileName,
					(type == null) ? "" : type.FullName
				}));
				return result;
			}
			catch (Exception ex5)
			{
				result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.InspectingAssemblyThrew, new object[3]
				{
					ex5.GetType().Name,
					ex5.Message,
					_assemblyFileName
				}));
				return result;
			}
			AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= value;
			if (result.Components.Count == 0 && _currentComponentType != PipelineComponentType.AddIn && _currentComponentType != PipelineComponentType.AddInBase)
			{
				result.Warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.NoAddInModelPartsFound, new object[2] { componentType, _assemblyFileName }));
			}
			return result;
		}
	}
	[Serializable]
	public class InvalidPipelineStoreException : Exception
	{
		public InvalidPipelineStoreException(string message)
			: base(message)
		{
		}

		public InvalidPipelineStoreException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected InvalidPipelineStoreException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public InvalidPipelineStoreException()
			: base(Res.InvalidPipelineStoreExceptionMessage)
		{
		}
	}
	[Serializable]
	internal sealed class PartialToken
	{
		internal HostAdapter _hostAdapter;

		internal ContractComponent _contract;

		internal AddInAdapter _addinAdapter;

		internal AddInBase _addinBase;

		internal HostAdapter HostAdapter => _hostAdapter;

		internal string PipelineRootDirectory
		{
			set
			{
				_hostAdapter.SetRootDirectory(value);
				_contract.SetRootDirectory(value);
				_addinAdapter.SetRootDirectory(value);
				_addinBase.SetRootDirectory(value);
			}
		}

		internal PartialToken(HostAdapter hostAdapter, ContractComponent contract, AddInAdapter addinAdapter, AddInBase addinBase)
		{
			_hostAdapter = hostAdapter;
			_contract = contract;
			_addinAdapter = addinAdapter;
			_addinBase = addinBase;
		}
	}
	[Serializable]
	internal sealed class PipelineDeploymentState : DeploymentState
	{
		private List<HostAdapter> _hostAdapters;

		private List<ContractComponent> _contracts;

		private List<AddInAdapter> _addinAdapters;

		private List<AddInBase> _addinBases;

		private List<PartialToken> _partialTokens;

		private List<int> _fileCounts;

		internal List<HostAdapter> HostAdapters => _hostAdapters;

		internal List<ContractComponent> Contracts => _contracts;

		internal List<AddInAdapter> AddInAdapters => _addinAdapters;

		internal List<AddInBase> AddInBases => _addinBases;

		internal List<PartialToken> PartialTokens => _partialTokens;

		internal List<int> FileCounts => _fileCounts;

		internal PipelineDeploymentState()
		{
			_hostAdapters = new List<HostAdapter>();
			_contracts = new List<ContractComponent>();
			_addinAdapters = new List<AddInAdapter>();
			_addinBases = new List<AddInBase>();
			_fileCounts = new List<int>(new int[4]);
		}

		internal void ConnectPipeline(Collection<string> warnings)
		{
			List<PartialToken> list = new List<PartialToken>();
			foreach (HostAdapter hostAdapter in HostAdapters)
			{
				foreach (ContractComponent contract in Contracts)
				{
					if (!hostAdapter.Constructors.Contains(contract.TypeInfo))
					{
						continue;
					}
					hostAdapter.ConnectedToNeighbors = true;
					foreach (AddInAdapter addInAdapter in AddInAdapters)
					{
						if (!addInAdapter.Contracts.Contains(contract.TypeInfo))
						{
							continue;
						}
						contract.ConnectedToNeighbors = true;
						foreach (AddInBase addInBasis in AddInBases)
						{
							if (addInAdapter.CanConnectTo(addInBasis))
							{
								addInAdapter.ConnectedToNeighbors = true;
								addInBasis.ConnectedToNeighbors = true;
								PartialToken item = new PartialToken(hostAdapter, contract, addInAdapter, addInBasis);
								list.Add(item);
							}
						}
					}
				}
			}
			int num = 0;
			num += LookForUnconnectedParts(HostAdapters, warnings);
			num += LookForUnconnectedParts(Contracts, warnings);
			num += LookForUnconnectedParts(AddInAdapters, warnings);
			num += LookForUnconnectedParts(AddInBases, warnings);
			if (num > 0)
			{
				warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.CouldntConnectNInvalidParts, new object[1] { num }));
			}
			_partialTokens = list;
		}

		private static int LookForUnconnectedParts<T>(IEnumerable<T> parts, Collection<string> warnings) where T : PipelineComponent
		{
			int num = 0;
			foreach (T part in parts)
			{
				if (!part.ConnectedToNeighbors)
				{
					warnings.Add(string.Format(CultureInfo.CurrentCulture, Res.CouldntConnectOnePart, new object[1] { part.ToString() }));
					num++;
				}
			}
			return num;
		}
	}
	[Serializable]
	public enum PipelineStoreLocation
	{
		ApplicationBase
	}
	internal static class RemotingHelper
	{
		private static bool CreatedInAD;

		private static readonly object s_lock = new object();

		internal static readonly string s_emptyGuid = Guid.Empty.ToString();

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, Flags = (SecurityPermissionFlag.RemotingConfiguration | SecurityPermissionFlag.Infrastructure))]
		internal static void InitializeClientChannel()
		{
			lock (s_lock)
			{
				if (!CreatedInAD)
				{
					CreatedInAD = true;
					BinaryServerFormatterSinkProvider binaryServerFormatterSinkProvider = new BinaryServerFormatterSinkProvider();
					binaryServerFormatterSinkProvider.TypeFilterLevel = TypeFilterLevel.Full;
					BinaryClientFormatterSinkProvider client = new BinaryClientFormatterSinkProvider();
					IDictionary dictionary = new Hashtable();
					dictionary["name"] = "ClientChannel";
					dictionary["portName"] = Guid.NewGuid().ToString();
					dictionary["typeFilterLevel"] = "Full";
					IChannel chnl = new AddInIpcChannel(dictionary, client, binaryServerFormatterSinkProvider);
					ChannelServices.RegisterChannel(chnl, ensureSecurity: false);
				}
			}
		}

		[SecuritySafeCritical]
		internal static AddInServer GetAddInServer(string guid)
		{
			return (AddInServer)Activator.GetObject(Type.GetType("System.AddIn.Hosting.AddInServer"), "ipc://" + guid + "/AddInServer");
		}
	}
	[Serializable]
	internal static class Utils
	{
		internal static bool HasCustomAttribute(Type attributeType, Type inspectType)
		{
			return GetCustomAttributeData(attributeType, inspectType) != null;
		}

		internal static CustomAttributeData GetCustomAttributeData(Type attributeType, Type inspectType)
		{
			foreach (CustomAttributeData customAttribute in CustomAttributeData.GetCustomAttributes(inspectType))
			{
				if ((object)customAttribute.Constructor.DeclaringType == attributeType)
				{
					return customAttribute;
				}
			}
			return null;
		}

		internal static bool PublicKeyMatches(AssemblyName a1, AssemblyName a2)
		{
			byte[] publicKey = a2.GetPublicKey();
			return PublicKeyMatches(a1, publicKey);
		}

		internal static bool PublicKeyMatches(AssemblyName a1, byte[] publicKeyOrToken)
		{
			if (publicKeyOrToken == null)
			{
				return a1.GetPublicKey() == null;
			}
			byte[] publicKey = a1.GetPublicKey();
			if (publicKey != null && publicKeyOrToken.Length == publicKey.Length)
			{
				for (int i = 0; i < publicKey.Length; i++)
				{
					if (publicKey[i] != publicKeyOrToken[i])
					{
						return false;
					}
				}
				return true;
			}
			byte[] publicKeyToken = a1.GetPublicKeyToken();
			if (publicKeyOrToken.Length == publicKeyToken.Length)
			{
				for (int j = 0; j < publicKeyToken.Length; j++)
				{
					if (publicKeyToken[j] != publicKeyOrToken[j])
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		internal static string PublicKeyToString(byte[] key)
		{
			if (key == null || key.Length == 0)
			{
				return "null";
			}
			StringBuilder stringBuilder = new StringBuilder(key.Length);
			foreach (byte b in key)
			{
				stringBuilder.Append(b.ToString("x2", CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		internal static string MakeRelativePath(string path, string root)
		{
			if (!path.StartsWith(root, StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(Res.MakeRelativePathArgs);
			}
			int num = 0;
			char c = root[root.Length - 1];
			if (c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar)
			{
				num++;
			}
			return path.Substring(root.Length + num);
		}

		internal static bool AssemblyRefEqualsDef(string assemblyRef, string assemblyDef)
		{
			return string.Equals(assemblyRef, assemblyDef);
		}

		internal static bool AssemblyDefEqualsDef(string assemblyDef1, string assemblyDef2)
		{
			return string.Equals(assemblyDef1, assemblyDef2);
		}

		internal static bool FullTypeNameDefEqualsDef(string typeAndAssemblyName1, string typeAndAssemblyName2)
		{
			return string.Equals(typeAndAssemblyName1, typeAndAssemblyName2);
		}

		internal static Assembly FindLoadedAssemblyRef(string assemblyRef)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				if (AssemblyRefEqualsDef(assemblyRef, assembly.FullName))
				{
					return assembly;
				}
			}
			return null;
		}

		internal static Assembly LoadAssemblyFrom(List<string> dirsToLookIn, string assemblyRef)
		{
			int num = assemblyRef.IndexOf(',');
			if (num == -1)
			{
				return null;
			}
			string path = assemblyRef.Substring(0, num);
			List<string> list = new List<string>(dirsToLookIn.Count * 2);
			foreach (string item in dirsToLookIn)
			{
				string text = Path.Combine(item, path);
				string text2 = text + ".dll";
				if (File.Exists(text2))
				{
					list.Add(text2);
				}
				else if (File.Exists(text + ".exe"))
				{
					list.Add(text + ".exe");
				}
			}
			foreach (string item2 in list)
			{
				try
				{
					Assembly assembly = Assembly.LoadFrom(item2);
					if (AssemblyRefEqualsDef(assemblyRef, assembly.FullName))
					{
						return assembly;
					}
				}
				catch (BadImageFormatException)
				{
				}
			}
			return null;
		}

		[SecuritySafeCritical]
		internal static bool HasFullTrust()
		{
			try
			{
				new PermissionSet(PermissionState.Unrestricted).Demand();
				return true;
			}
			catch (SecurityException)
			{
				return false;
			}
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, ControlAppDomain = true)]
		internal static void UnloadAppDomain(AppDomain domain)
		{
			AppDomain.Unload(domain);
		}
	}
}
