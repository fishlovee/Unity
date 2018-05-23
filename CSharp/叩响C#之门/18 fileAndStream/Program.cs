using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _18_fileAndStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"D:\weikai\nutbak");
            string workingDir = Directory.GetCurrentDirectory();
            //string[] dirs = Directory.GetDirectories(workingDir);
            //Console.WriteLine("当前工作目录：{0}，子目录：", workingDir);
            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //string[] files = Directory.GetFiles(workingDir);
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //string machineName = Environment.MachineName;
            //string OsVersion = Environment.OSVersion.VersionString;
            //Console.WriteLine(machineName + "*" + OsVersion);
            ////Environment.FailFast(machineName);

            //string d = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string p = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //string m = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            //string f = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            //Console.WriteLine("我的文档：" + d);
            //Console.WriteLine("我的图片：" + p);
            //Console.WriteLine("我的音乐：" + m);
            //Console.WriteLine("我的收藏：" + f);

            FileStream fileStream = new FileStream(workingDir + @"\lua学习\Lua学习笔记\lua内置对象.md", FileMode.Open,FileAccess.Read);
            FileStream fileCopy = new FileStream(workingDir + @"\lua学习\Lua学习笔记\lua_copy.md", FileMode.CreateNew, FileAccess.Write);
            int readbyte = -1;
            while ( (readbyte = fileStream.ReadByte()) != -1)
            {
                fileCopy.WriteByte(Convert.ToByte(readbyte));
            }



            fileStream.Close();
            fileCopy.Close();
            Console.ReadKey();
        }
    }
}
