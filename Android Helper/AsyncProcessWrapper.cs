using System; 
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Helper
{
    class AsyncProcessWrapper
    {
        public string Output { get; set; }

        public bool CreateADBProcess(string args)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.Arguments = args;
            proc.StartInfo.WorkingDirectory = "D:\\AndroidSDK\\platform-tools";
            proc.StartInfo.FileName = "adb.exe";
            proc.Start();

            do 
            {
                System.Threading.Thread.Sleep(500);
            } while(!proc.HasExited);

            proc.Dispose();

            return true;
        }

        public List<string> GetOutput()
        {
            List<String> outputList = new List<String>(); 

            foreach (string output in outputList) {
                if (output.Length.Equals(0)) {
                }
            }
            return outputList;
        }
    }
}
