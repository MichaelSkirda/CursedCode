using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.CurseHelpers
{
    // Maximum cursed name
    internal class IL_LoadManagerController
    {
        internal static Assembly LoadIL(string ilCode)
        {
            ExportToFile(ilCode);
            CompileIL("source_code.il");
            return LoadAssembly("source_code.dll");
        }

        private static void ExportToFile(string ilCode)
        {
            using (StreamWriter writer = new StreamWriter("source_code.il"))
            {
                writer.WriteLine(ilCode);
            }
        }

        private static void CompileIL(string fileName)
        {
            ProcessStartInfo procInfo = new ProcessStartInfo();

            procInfo.FileName = "ilasm.exe";
            procInfo.Arguments = fileName + " /dll";
            procInfo.RedirectStandardOutput = true;

            Process.Start(procInfo)!.WaitForExit();
        }

        private static Assembly LoadAssembly(string fileName)
        {
            using (var stream = new MemoryStream(File.ReadAllBytes(fileName)))
            {
                stream.Seek(0, SeekOrigin.Begin);
                var assembly = AssemblyLoadContext.Default.LoadFromStream(stream);
                return assembly;
            }
        }
    }
}
