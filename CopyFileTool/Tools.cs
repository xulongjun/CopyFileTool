using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Tools
    {
        public static void CopyAllFiles(string sourceDirectory, string targetDirectory)
        {
            // Copy all the files in the current directory
            foreach (string file in Directory.GetFiles(sourceDirectory))
            {
                string fileName = Path.GetFileName(file);
                string target = Path.Combine(targetDirectory, fileName);

                if (File.Exists(target))
                {
                    File.Copy(file, target, true);
                }
                else
                {
                    File.Copy(file, target);
                }
            }

            // Recursively copy files in all subdirectories
            foreach (string directory in Directory.GetDirectories(sourceDirectory))
            {
                string directoryName = Path.GetFileName(directory);
                string targetSubDirectory = Path.Combine(targetDirectory, directoryName);
                if(!Directory.Exists(targetSubDirectory))
                {
                    Directory.CreateDirectory(targetSubDirectory);
                }
                CopyAllFiles(directory, targetSubDirectory);
            }
        }

        public static void CopyOneFile(string source, string target)
        {
            var targetDirectory = Path.GetDirectoryName(target);

            if (targetDirectory != null && !Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            if (File.Exists(target))
            {
                File.Copy(source, target, true);
            }
            else
            {
                File.Copy(source, target);
            }
        }
    }
}
