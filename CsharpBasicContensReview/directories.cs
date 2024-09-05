using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld {
    internal class directories {
        public static void directories_test() {
            string folderName = "diretorio";
            string subFolderName = "subDiretorio";
            string subFolderWithStaticDdirectory = "subStaticDiretory";

            DirectoryInfo directoryInfoSubfolder = new DirectoryInfo(subFolderName);

            if (!Directory.Exists(subFolderName) || !directoryInfoSubfolder.Exists) {
                Directory.CreateDirectory(subFolderWithStaticDdirectory);
                directoryInfoSubfolder.Create();
                Directory.CreateDirectory(folderName);
                directoryInfoSubfolder.MoveTo($"{folderName}//{subFolderName}");
                Directory.Move(subFolderWithStaticDdirectory, @$"{folderName}\{subFolderWithStaticDdirectory}");
            }
            var name = directoryInfoSubfolder.Name;
            var parent = directoryInfoSubfolder.Parent;
            var root = directoryInfoSubfolder.Root;
            var full = directoryInfoSubfolder.FullName;
            var exist = directoryInfoSubfolder.Exists;

            foreach (var direc in Directory.GetDirectories(folderName)) {
                Console.WriteLine(direc);


            }
            Directory.Delete(@$"{folderName}\{subFolderWithStaticDdirectory}");
            directoryInfoSubfolder.Delete(true);

            #region Files

            string file = @$"{folderName}\text.txt";
            if (!File.Exists(file)) {
                File.CreateText(file);
            }

            FileInfo fileInfo = new FileInfo(file);

            Console.WriteLine($" name: {fileInfo.Name}, length: {fileInfo.Length}, acess: {fileInfo.LastWriteTime} ");
            #endregion

        }

    }
}
