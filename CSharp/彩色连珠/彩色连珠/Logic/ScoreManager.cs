using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Public;

// https://support.office.com/zh-cn/article/适用于-Windows-的-OneDrive-桌面应用程序-850703dd-ea56-4c7a-bff5-6c2e4da227cf

namespace 彩色连珠
{
    class ScoreInfo
    {
        public string Name
        {
            get;
            set; 
        }
        public int Score
        {
            get;set;
        }

        override public string ToString()
        {
            return string.Format(Name + ":" + Score);
        }
    }
    /// <summary>
    /// 分数管理，每次启动读取指定文件，不存在则创建，得分后写入 
    /// </summary>
    class ScoreManager
    {
        // 分数记录文件名
        private const string filename = "scores.dat";

        // 保存进度文件：只保存最近一次的，如果没有保存则清空
        private const string historyFileName = "history.dat";

        public static int GetHistoryScore(string name)
        {
            int nScore = 0;
            string abspath = Application.StartupPath + "\\" + filename;
            Public.IniFile ini = new IniFile(abspath);
            string strScore = ini.IniReadValue("score", name);
            if (strScore.Length > 0)
            {
                nScore = Convert.ToInt32(strScore);
            }
            return nScore;
        }

        public static int GetMaxHistoryScore()
        {
            return GetHistoryScore("max");
        }

        public static bool WriteScore(string name,int nscore)
        {
            string abspath = Application.StartupPath + "\\" + filename;
            Public.IniFile ini = new IniFile(abspath);
            string history = ini.IniReadValue("score",name);
            string maxHistory = ini.IniReadValue("max", name);
            int nHistory = 0;
            int nMax = 0;
            if (history.Length != 0)
            {
                nHistory = Convert.ToInt32(history);
            }

            if (maxHistory.Length > 0)
            {
                nMax = Convert.ToInt32(maxHistory);
            }

            if (nscore > nMax)
            {
                ini.IniWriteValue("max", name, nscore.ToString());
            }

            if (nHistory < nscore)
            {
                ini.IniWriteValue("score", name, nscore.ToString());
            }
            return true;
        }

        /// <summary>
        /// 获取历史最大分数
        /// </summary>
        /// <returns></returns>
        public static bool GetHistoryScore()
        {
            string abspath = Application.StartupPath + "\\" + filename;
            FileStream fs = new FileStream(abspath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sreader = new StreamReader(fs);
            string source = sreader.ReadToEnd();
            //string dst = DeCodeBase64(source);
            string dst = source;
            string[] lines = dst.Split(Environment.NewLine.ToCharArray());
            List<ScoreInfo> lst = new List<ScoreInfo> { };
            foreach (var item in lines)
            {
                if (item.Length == 0)
                {
                    continue;
                }
                string name = item.Substring(0,item.IndexOf(":"));
                int index = item.IndexOf(":");
                int score = Convert.ToInt32(item.Substring(index + 1));
                lst.Add(new ScoreInfo { Name = name, Score = score });
            }

            lst.Sort((x,y)=> { return y.Score - x.Score; });
            fs.Seek(0, SeekOrigin.Begin);
            StreamWriter swriter = new StreamWriter(fs);
            
            foreach (var item in lst)
            {
                swriter.Write(item);
            }
            sreader.Close();
            return true;
        }

        /// <summary>
        /// 写分
        /// </summary>
        /// <returns></returns>
        //public static bool WriteScore(int score,string name)
        //{
        //    string absPath = Application.StartupPath + "\\" + filename;
        //    FileStream fs = new FileStream(absPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    StreamReader sreader = new StreamReader(fs);
        //    string txt = sreader.ReadToEnd();
            
        //    //string dst = DeCodeBase64(txt);
        //    string dst = txt;
        //    dst = name + ":" + score + Environment.NewLine;
        //    //dst = EnCodeBase64(dst);
        //    string[] lines = dst.Split(Environment.NewLine.ToCharArray());
            
        //    StreamWriter swriter = new StreamWriter(fs);
        //    foreach (var item in lines)
        //    {
        //        if (item.Length == 0)
        //        {
        //            continue;
        //        }

        //        swriter.Write(item + Environment.NewLine);
        //    }
        //    swriter.Close();
        //    return true;
        //}

        /// <summary>
        /// 保存当前进度，为重玩提供数据
        /// </summary>
        /// <returns></returns>
        public static bool WriteGameHistory()
        {
            return true;
        }


        /// <summary>
        /// 清空重玩数据
        /// </summary>
        /// <returns></returns>
        public static bool ClearGameHistory()
        {
            return true;
        }

        /// <summary>
        /// 读取历史数据，为恢复提供数据
        /// </summary>
        /// <returns></returns>
        public static bool ReadGameHistory()
        {
            return true;
        }


        /// <summary>
        /// base64解密
        /// </summary>
        /// <param name="encode"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private static string DeCodeBase64(Encoding encode, string result)
        {
            string decode = "";
            try
            {
                byte[] bytes = Convert.FromBase64String(result);
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }

        /// <summary>
        /// base64加密
        /// </summary>
        /// <param name="encodeType"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        private static string EnCodeBase64(Encoding encodeType, string source)
        {
            string encode = string.Empty;
            byte[] bytes = encodeType.GetBytes(source);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = source;
            }
            return encode;
        }

        private static string DeCodeBase64(string source)
        {
            return DeCodeBase64(Encoding.UTF8, source);
        }

        private static string EnCodeBase64(string source)
        {
            return EnCodeBase64(Encoding.UTF8, source);
        }
    }
}
