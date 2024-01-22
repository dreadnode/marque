using System;
using System.CodeDom;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Workflow.ComponentModel.Compiler;
using System.Xml;

[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: AssemblyTitle("Microsoft.Workflow.Compiler.exe")]
[assembly: AssemblyDescription("Microsoft.Workflow.Compiler.exe")]
[assembly: AssemblyDefaultAlias("Microsoft.Workflow.Compiler.exe")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("4.8.9032.0")]
[assembly: AssemblyInformationalVersion("4.8.9032.0")]
[assembly: SatelliteContractVersion("4.0.0.0")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile("f:\\dd\\tools\\devdiv\\35MSSharedLib1024.snk")]
[assembly: AssemblySignatureKey("002400000c80000014010000060200000024000052534131000800000100010085aad0bef0688d1b994a0d78e1fd29fc24ac34ed3d3ac3fb9b3d0c48386ba834aa880035060a8848b2d8adf58e670ed20914be3681a891c9c8c01eef2ab22872547c39be00af0e6c72485d7cfd1a51df8947d36ceba9989106b58abe79e6a3e71a01ed6bdc867012883e0b1a4d35b1b5eeed6df21e401bb0c22f2246ccb69979dc9e61eef262832ed0f2064853725a75485fa8a3efb7e027319c86dec03dc3b1bca2b5081bab52a627b9917450dfad534799e1c7af58683bdfa135f1518ff1ea60e90d7b993a6c87fd3dd93408e35d1296f9a7f9a97c5db56c0f3cc25ad11e9777f94d138b3cea53b9a8331c2e6dcb8d2ea94e18bf1163ff112a22dbd92d429a", "8913ef869646d14971df222c210018ab394cfe63f8eb9b4d894c0dda7368cfb69df15d049b347f8a8b9205cdcc3d6bd6690f0bd24b3da3179feb8c03f410703027c7844ff654997e38015dfc97222c15061af2a1d3fe91775b9dd4b8ede64d3d59816270a9520e393c8e60619b80d40fc1dc4f12b5aa0c2df20d02ea32960851")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.System32 | DllImportSearchPath.AssemblyDirectory)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("4.0.0.0")]
[module: UnverifiableCode]
internal static class WrapperSR
{
	private static ResourceManager resources;

	internal const string InvalidAssemblyHeader = "InvalidAssemblyHeader";

	internal const string InvalidArgumentsToMain = "InvalidArgumentsToMain";

	private static ResourceManager Resources
	{
		get
		{
			if (resources == null)
			{
				resources = new ResourceManager("Microsoft.Workflow.Compiler.StringResources", Assembly.GetExecutingAssembly());
			}
			return resources;
		}
	}

	private static CultureInfo Culture => null;

	internal static string GetString(string name, params object[] args)
	{
		return GetString(Culture, name, args);
	}

	internal static string GetString(CultureInfo culture, string name, params object[] args)
	{
		string @string = Resources.GetString(name, culture);
		if (args != null && args.Length != 0)
		{
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	internal static string GetString(string name)
	{
		return GetString(Culture, name);
	}

	internal static string GetString(CultureInfo culture, string name)
	{
		return Resources.GetString(name, culture);
	}
}
namespace Microsoft.Workflow.Compiler;

internal class Program
{
	private static void Main(string[] args)
	{
		if (args == null || args.Length != 2)
		{
			throw new ArgumentException(WrapperSR.GetString("InvalidArgumentsToMain"), "args");
		}
		CompilerInput compilerInput = ReadCompilerInput(args[0]);
		WorkflowCompilerResults results = new WorkflowCompiler().Compile(MultiTargetingInfo.MultiTargetingUtilities.RenormalizeReferencedAssemblies(compilerInput.Parameters), compilerInput.Files);
		WriteCompilerOutput(args[1], results);
	}

	private static CompilerInput ReadCompilerInput(string path)
	{
		CompilerInput compilerInput = null;
		using Stream input = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		XmlReader reader = XmlReader.Create(input);
		return (CompilerInput)new DataContractSerializer(typeof(CompilerInput)).ReadObject(reader);
	}

	private static void WriteCompilerOutput(string path, WorkflowCompilerResults results)
	{
		using Stream output = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Indent = true;
		using XmlWriter writer = XmlWriter.Create(output, xmlWriterSettings);
		NetDataContractSerializer netDataContractSerializer = new NetDataContractSerializer();
		SurrogateSelector surrogateSelector = new SurrogateSelector();
		surrogateSelector.AddSurrogate(typeof(MemberAttributes), netDataContractSerializer.Context, new CompilerResultsSurrogate());
		((IFormatter)netDataContractSerializer).SurrogateSelector = surrogateSelector;
		netDataContractSerializer.WriteObject(writer, results);
	}
}
[Obsolete("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
public sealed class CompilerWrapper
{
	private static string compilerPath;

	private WorkflowCompilerResults results;

	private static string CompilerPath
	{
		get
		{
			if (compilerPath == null)
			{
				compilerPath = $"{RuntimeEnvironment.GetRuntimeDirectory()}\\Microsoft.Workflow.Compiler.exe";
			}
			return compilerPath;
		}
	}

	public WorkflowCompilerResults Compile(WorkflowCompilerParameters parameters, params string[] files)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (files == null)
		{
			throw new ArgumentNullException("files");
		}
		if (EnvironmentExtension.Is64BitOS() && EnvironmentExtension.IsWowProcess())
		{
			if (Has64bitAssembliesInReferences(parameters))
			{
				CompileInSeparateProcess(parameters, files);
			}
			else
			{
				CompileInSameProcess(parameters, files);
			}
		}
		else
		{
			CompileInSameProcess(parameters, files);
		}
		return results;
	}

	private static bool Has64bitAssembliesInReferences(WorkflowCompilerParameters parameters)
	{
		for (int i = 0; i < parameters.ReferencedAssemblies.Count; i++)
		{
			if (PEHeader.Is64BitRequiredExecutable(parameters.ReferencedAssemblies[i]))
			{
				return true;
			}
		}
		return false;
	}

	private void CompileInSameProcess(WorkflowCompilerParameters parameters, string[] files)
	{
		results = new WorkflowCompiler().Compile(parameters, files);
	}

	private void CompileInSeparateProcess(WorkflowCompilerParameters parameters, string[] files)
	{
		string text = SerializeInputToWrapper(parameters, files);
		string tempFileName = Path.GetTempFileName();
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(CompilerPath);
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.ErrorDialog = false;
			processStartInfo.Arguments = $"\"{text}\" \"{tempFileName}\"";
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
			process.WaitForExit();
			results = DeserializeWrapperOutput(tempFileName);
		}
		finally
		{
			File.Delete(text);
			File.Delete(tempFileName);
		}
	}

	private static string SerializeInputToWrapper(WorkflowCompilerParameters parameters, string[] files)
	{
		string tempFileName = Path.GetTempFileName();
		using Stream output = new FileStream(tempFileName, FileMode.Create, FileAccess.Write, FileShare.Read);
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Indent = true;
		using XmlWriter writer = XmlWriter.Create(output, xmlWriterSettings);
		CompilerInput graph = new CompilerInput(MultiTargetingInfo.MultiTargetingUtilities.NormalizeReferencedAssemblies(parameters), files);
		new DataContractSerializer(typeof(CompilerInput)).WriteObject(writer, graph);
		return tempFileName;
	}

	private static WorkflowCompilerResults DeserializeWrapperOutput(string fileName)
	{
		using Stream input = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		using XmlReader reader = XmlReader.Create(input);
		NetDataContractSerializer netDataContractSerializer = new NetDataContractSerializer();
		SurrogateSelector surrogateSelector = new SurrogateSelector();
		surrogateSelector.AddSurrogate(typeof(MemberAttributes), netDataContractSerializer.Context, new CompilerResultsSurrogate());
		((IFormatter)netDataContractSerializer).SurrogateSelector = surrogateSelector;
		return (WorkflowCompilerResults)netDataContractSerializer.ReadObject(reader);
	}
}
internal static class PEHeader
{
	private static class ReadHelper
	{
		public unsafe static T ReadFromStream<T>(Stream source) where T : class, new()
		{
			fixed (byte* ptr = ReadBufferFromStream(source, Marshal.SizeOf(typeof(T))))
			{
				return (T)Marshal.PtrToStructure((IntPtr)ptr, typeof(T));
			}
		}

		private static byte[] ReadBufferFromStream(Stream source, int bufferSize)
		{
			byte[] array = new byte[bufferSize];
			source.Read(array, 0, bufferSize);
			return array;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	private class IMAGE_DOS_HEADER
	{
		public ushort e_magic;

		public ushort e_cblp;

		public ushort e_cp;

		public ushort e_crlc;

		public ushort e_cparhdr;

		public ushort e_minalloc;

		public ushort e_maxalloc;

		public ushort e_ss;

		public ushort e_sp;

		public ushort e_csum;

		public ushort e_ip;

		public ushort e_cs;

		public ushort e_lfarlc;

		public ushort e_ovno;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] e_res1;

		public ushort e_oemid;

		public ushort e_oeminfo;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] e_res2;

		public int e_lfanew;
	}

	private struct IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	private struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	private struct IMAGE_OPTIONAL_HEADER32
	{
		public ushort Magic;

		public byte MajorLinkerVersion;

		public byte MinorLinkerVersion;

		public uint SizeOfCode;

		public uint SizeOfInitializedData;

		public uint SizeOfUninitializedData;

		public uint AddressOfEntryPoint;

		public uint BaseOfCode;

		public uint BaseOfData;

		public uint ImageBase;

		public uint SectionAlignment;

		public uint FileAlignment;

		public ushort MajorOperatingSystemVersion;

		public ushort MinorOperatingSystemVersion;

		public ushort MajorImageVersion;

		public ushort MinorImageVersion;

		public ushort MajorSubsystemVersion;

		public ushort MinorSubsystemVersion;

		public uint Win32VersionValue;

		public uint SizeOfImage;

		public uint SizeOfHeaders;

		public uint CheckSum;

		public ushort Subsystem;

		public ushort DllCharacteristics;

		public uint SizeOfStackReserve;

		public uint SizeOfStackCommit;

		public uint SizeOfHeapReserve;

		public uint SizeOfHeapCommit;

		public uint LoaderFlags;

		public uint NumberOfRvaAndSizes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public IMAGE_DATA_DIRECTORY[] DataDirectory;
	}

	[StructLayout(LayoutKind.Sequential)]
	private class IMAGE_NT_HEADERS
	{
		public uint Signature;

		public IMAGE_FILE_HEADER FileHeader;

		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}

	private const ushort IMAGE_DOS_SIGNATURE = 23117;

	private const uint IMAGE_NT_SIGNATURE = 17744u;

	private const ushort IMAGE_FILE_MACHINE_IA64 = 512;

	private const ushort IMAGE_FILE_MACHINE_AMD64 = 34404;

	public static bool Is64BitRequiredExecutable(string path)
	{
		using Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		IMAGE_DOS_HEADER iMAGE_DOS_HEADER = ReadHelper.ReadFromStream<IMAGE_DOS_HEADER>(stream);
		if (iMAGE_DOS_HEADER.e_magic != 23117)
		{
			throw new InvalidDataException(WrapperSR.GetString("InvalidAssemblyHeader", path));
		}
		stream.Position = iMAGE_DOS_HEADER.e_lfanew;
		IMAGE_NT_HEADERS iMAGE_NT_HEADERS = ReadHelper.ReadFromStream<IMAGE_NT_HEADERS>(stream);
		if (iMAGE_NT_HEADERS.Signature != 17744)
		{
			throw new InvalidDataException(WrapperSR.GetString("InvalidAssemblyHeader", path));
		}
		ushort machine = iMAGE_NT_HEADERS.FileHeader.Machine;
		if (machine == 512 || machine == 34404)
		{
			return true;
		}
		return false;
	}
}
internal static class EnvironmentExtension
{
	private static bool? is64BitOS;

	private static bool? isWowProcess;

	public static bool Is64BitOS()
	{
		if (!is64BitOS.HasValue)
		{
			is64BitOS = CheckIf64BitOS();
		}
		return is64BitOS.Value;
	}

	public static bool IsWowProcess()
	{
		if (!isWowProcess.HasValue)
		{
			isWowProcess = CheckIfWowProcess();
		}
		return isWowProcess.Value;
	}

	private static bool CheckIf64BitOS()
	{
		return Environment.Is64BitOperatingSystem;
	}

	private static bool CheckIfWowProcess()
	{
		if (Is64BitOS())
		{
			return !Environment.Is64BitProcess;
		}
		return false;
	}
}
[DataContract]
internal class CompilerInput
{
	[DataMember]
	private readonly WorkflowCompilerParameters parameters;

	[DataMember]
	private readonly string[] files;

	public WorkflowCompilerParameters Parameters => parameters;

	public string[] Files => files;

	public CompilerInput(WorkflowCompilerParameters parameters, string[] files)
	{
		this.parameters = parameters;
		this.files = files;
	}
}
[Serializable]
internal struct SerializableMemberAttributes
{
	private int memberAttributes;

	public SerializableMemberAttributes(MemberAttributes memberAttributes)
	{
		this.memberAttributes = Convert.ToInt32(memberAttributes);
	}

	public MemberAttributes ToMemberAttributes()
	{
		return (MemberAttributes)memberAttributes;
	}
}
internal class CompilerResultsSurrogate : ISerializationSurrogate
{
	[SecurityCritical]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		info.AddValue("SerializableMemberAttributes", new SerializableMemberAttributes((MemberAttributes)obj));
	}

	[SecurityCritical]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		return ((SerializableMemberAttributes)info.GetValue("SerializableMemberAttributes", typeof(SerializableMemberAttributes))).ToMemberAttributes();
	}
}
