using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Public;
using WMPLib;

namespace 彩色连珠
{
    enum EN_BALL_COLOR
    {
        EN_BALL_GRAY = 0,
        EN_BALL_RED,
        EN_BALL_GREEN,
        EN_BALL_BLUE,
        EN_BALL_BROWN,
        EN_BALL_YELLOW,
        EN_BALL_LIGHTBLUE,
        EN_BALL_VIOLET,
        EN_BALL_WHITE,
        EN_BALL_BLACK,
        EN_BALL_DARKORANGE,
        EN_BALL_COLOR_MAX
    }

    public partial class 彩色连珠 : Form
    {
        public 彩色连珠()
        {
            InitializeComponent();
            GameInit();
        }

        private void GameZone_Paint(object sender, PaintEventArgs e)
        {
            DrawChess();                            // 画棋盘
            GetHistoryScore();                      // 读取历史分数
            DrawBalls();                            // 在棋盘上画球
            if (m_bFirstDraw)
            {
                RandomNextColors(true);
                UpdateNextBallColor();
                DrawBalls();                        // 在棋盘上画球
                RandomNextColors(false);
            }

            //if (m_nMoveX != -1 && m_nMoveY != -1)
            //{
            //    ZoomTimer.Enabled = true;
            //}
        }

 

        /// <summary>
        /// 游戏初始化：画棋盘、背景填充、初始化分数、标记球背景
        /// </summary>
        public void GameInit()
        {
            m_nCurScore = 0;
            m_bFirstDraw = true;
            m_nMaxScore = ScoreManager.GetMaxHistoryScore();
            GameZone.BackColor =     m_clsBackColor;                        // 背景初始化为灰色
            MaxScoreLable.Text = "最高分：" + m_nMaxScore;              // 历史最大分数        
            ScoreLable.Text = "分数："  + m_nCurScore;                  // 当前分数
            ZoomTimer.Enabled = false;
            Graphics g = GameZone.CreateGraphics();
            g.Clear(GameZone.BackColor);
        }

        private void UpdateNextBallColor()
        {
            int nCount = m_bFirstDraw ? 5 : 3;
            while (nCount > 0)
            {
                int x = Public.Public.Random(0, m_nRowCount);
                int y = Public.Public.Random(0, m_nRowCount);
                if (balls[x, y] != GameZone.BackColor)
                {
                    continue;
                }

                balls[x, y] = color[nextColorIndex[--nCount]];
            }
        }

        private void DrawBalls()
        {
            for (int i = 0; i < m_nRowCount; i++)
            {
                for (int j = 0; j < m_nRowCount; j++)
                {
                    if (balls[i, j] != GameZone.BackColor && balls[i, j] != Color.Empty)
                    {
                        DrawBall(i,j, balls[i, j]);
                    }
                }
            }
        }

        public void RestartGame()
        {
            GameInit();
            DrawChess();
            RandomNextColors(true);
            UpdateNextBallColor();
            DrawBalls();
            RandomNextColors(false);
        }

        private void RandomNextColors(bool bStart)
        {
            int nCount = bStart ? 5 : 3;
            if (bStart)
            {
                for (int i = 0; i < m_nRowCount; i++)
                {
                    for (int j = 0; j < m_nRowCount; j++)
                    {
                        balls[i, j] = GameZone.BackColor;
                    }
                }
            }

            Graphics graphics = NextPictures.CreateGraphics();
            if (!bStart)
            {
                graphics.Clear(NextPictures.BackColor);
            }

            while (nCount > 0)
            {
                nCount--;
                int c = Public.Public.Random(1, color.Length);
                nextColorIndex[nCount] = c;

                if (!bStart)
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    string bmName = color[nextColorIndex[nCount]].ToString().Substring(7).Replace("]","");
                    Bitmap bitmap = (Bitmap)manager.GetObject(bmName);
                    graphics.DrawImage(bitmap, NextPictures.Width / 3 * nCount, 0, NextPictures.Width / 3, NextPictures.Height);
                }
            }
            graphics.Dispose();
            m_bFirstDraw = bStart;
        }

        private void 彩色连珠_Load(object sender, EventArgs e)
        {

        }

        private void GetHistoryScore()
        {
            if (playerName.Length == 0)
            {
                playerName = defaultplayer;
            }

            m_nMaxScore = ScoreManager.GetHistoryScore(playerName);
        }

        private bool GetHistory()
        {
            string abspath = Application.StartupPath + "//" + m_strHistoryFilename;
            if (!File.Exists(abspath))
            {
                return false;
            }

            Public.IniFile ini = new Public.IniFile(abspath);
            for (int i = 0; i < m_nRowCount; i++)
            {
                for (int j = 0; j < m_nRowCount; j++)
                {
                    string key = m_strKeyName + i + "_" + j;
                    string score = ini.IniReadValue(m_strSectionName, key);
                    if (score.Length > 0)
                    {
                        balls[i,j] = color[Convert.ToInt32(score)];
                    }
                }
            }

            string strScore = ini.IniReadValue(m_strSectionName, "score");
            if (strScore.Length > 0)
            {

            }
            return true;
        }

        private void 重新开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        /// <summary>
        /// 在游戏区中话棋盘
        /// </summary>
        private void DrawChess()
        {
            Graphics g = GameZone.CreateGraphics();
            GameZone.BackColor = m_clsBackColor;    // 背景颜色

            if (m_bFirstDraw)
            {
                g.Clear(GameZone.BackColor);//用背景色清空
            }

            Pen pen = new Pen(Color.BlanchedAlmond);
            int nHeight = GameZone.Height;
            int nWide = GameZone.Width;
            int nPerHeight = nHeight / m_nRowCount;
            int nPerWidth = nWide / m_nRowCount;
            for (int i = 0; i < m_nRowCount; i++)
            {
                Point p1 = new Point(0, i * nPerHeight);
                Point p2 = new Point(nWide, i * nPerHeight);
                g.DrawLine(pen, p1, p2);

                Point p3 = new Point(i * nPerWidth, 0);
                Point p4 = new Point(i * nPerWidth, nHeight);
                g.DrawLine(pen, p3, p4);
            }

            g.Dispose();
        }

        private void DrawBall(int x, int y, Color color,int nDrx = 0)
        {
            Graphics graphics = GameZone.CreateGraphics();
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            Bitmap bitmap = (Bitmap)manager.GetObject(color.ToString().Substring(7).Replace("]", ""));
            if (bitmap != null)
            {
                graphics.DrawImage(bitmap,
                GameZone.Width * x / m_nRowCount + nDrx + 1,
                GameZone.Height * y / m_nRowCount + nDrx + 1,
                GameZone.Width / m_nRowCount - nDrx * 2 - 2,
                GameZone.Height / m_nRowCount - nDrx * 2 - 2);
            }
            graphics.Dispose();
        }

        private void 分享到微博ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));
                bitmap.Save("weibo.png");
                bitmap.Dispose();
            }

            weiboShare wb = new weiboShare("我正在玩#彩色连珠#小游戏，得了" + m_nCurScore + "分，非常好玩哦，你也来玩一下吧……");
            wb.Show();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveProcessButton_Click(object sender, EventArgs e)
        {
        }

        private void 彩色连珠_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void 彩色连珠_MouseLeave(object sender, EventArgs e)
        {

        }


        private void GameZone_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = GameZone.CreateGraphics();
            int x = e.X / (GameZone.Width / m_nRowCount);
            int y = e.Y / (GameZone.Height / m_nRowCount);
            if (m_nLastX != -1 && m_nLastY != -1)
            {
                graphics.DrawRectangle(new Pen(Color.BlanchedAlmond), m_nLastX * (GameZone.Width / m_nRowCount), m_nLastY * (GameZone.Width / m_nRowCount), GameZone.Width / m_nRowCount, GameZone.Height / m_nRowCount);
            }
            graphics.DrawRectangle(new Pen(Color.Red), x * (GameZone.Width / m_nRowCount), y * (GameZone.Width / m_nRowCount), GameZone.Width / m_nRowCount, GameZone.Height / m_nRowCount);
            m_nLastX = x;
            m_nLastY = y;
            graphics.Dispose();
        }

        private void GameZone_MouseLeave(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 播放选中音乐并对球进行缩放或移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameZone_MouseClick(object sender, MouseEventArgs e)
        {
            int width = GameZone.Width / m_nRowCount;
            int height = GameZone.Height / m_nRowCount;
            int x = e.X / width;
            int y = e.Y / height;

            // 如果选择的是空的，则移动到目标地点
            if (balls[x,y] == GameZone.BackColor)
            {
                ZoomTimer.Enabled = false;
                List<Point> path = new List<Point>();
                if (m_nMoveX != -1 && m_nMoveY != -1 && SearchPath(ref path,new Point(x,y),new Point(m_nMoveX,m_nMoveY))) // 有待移动的球
                {
                    balls[x, y] = balls[m_nMoveX, m_nMoveY];
                    balls[m_nMoveX, m_nMoveY] = GameZone.BackColor;
                    ClearRectangle(m_nMoveX,m_nMoveY);
                    m_nMoveX = -1;
                    m_nMoveY = -1;
                    UpdateNextBallColor();                // 先更新next
                    RandomNextColors(false);
                    DrawBalls();

                    if (CheckSucces(x, y))
                    {
                        Forms.SaveScoreForm saveScoreForm = new Forms.SaveScoreForm(m_nCurScore, this);
                        saveScoreForm.Show();

                        ZoomTimer.Enabled = false;
                    }
                }
                return;
            }
            else
            {
                //// 已经选中了一个，则交换
                //if (m_nMoveX != -1 && m_nMoveY != -1)
                //{
                //    Color tmp = balls[m_nMoveX, m_nMoveY];
                //    balls[m_nMoveX, m_nMoveY] = balls[x, y];
                //    balls[x, y] = tmp;
                //    DrawBalls();
                //}

                // 对选中的进行缩放
                ClearRectangle(x, y);
                Bitmap bitmap = (Bitmap)manager.GetObject(balls[x, y].ToString().Substring(7).Replace("]", ""));
                Graphics graphics = GameZone.CreateGraphics();
                graphics.DrawImage(bitmap, x * width + 5, y * height + 5, width - 10, height - 10);
                graphics.Dispose();
                m_nMoveX = x;
                m_nMoveY = y;
                if (CheckSucces(m_nMoveX, m_nMoveY))
                {
                    ZoomTimer.Enabled = false;
                }

                ZoomTimer.Enabled = true;
            }


            
            playAudio("MoveStart.wav");

            if (IsGameOver())
            {
                m_bIsGameOver = true;
            }
        }

        /// <summary>
        /// 寻路：从 src 到 dst 是否存在路径，存在则返回true并将路径存放到 path 中
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool SearchPath(ref List<Point>  path,Point src,Point dst)
        {

            return true;
        }

        private void playAudio(string url)
        {
            wmp.URL = "Music\\" + url;
            wmp.controls.play();
        }

        private void ClearRectangle(int x,int y)
        {
            int width = GameZone.Width / m_nRowCount;
            int height = GameZone.Height / m_nRowCount;
            Graphics graphics = GameZone.CreateGraphics();
            graphics.FillRectangle(new SolidBrush(GameZone.BackColor), x * width + 1, y * height + 1, width - 2, height - 2);
            graphics.Dispose();
        }

        /// <summary>
        /// 定时缩放选定的球
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZommTimerTick(object sender, EventArgs e)
        {
            if (!ZoomTimer.Enabled)
            {
                return;
            }

            if (m_nDirect >= 8)
            {
                ZoomBig();
            }
            else
            {
                ZoomSmall();
            }
        }

        private void ZoomBig()
        {
            ClearRectangle(m_nMoveX, m_nMoveY);
            if (m_nDirect > 0)
            {
                m_nDirect -= 3;
                DrawBall(m_nMoveX,m_nMoveY,balls[m_nMoveX,m_nMoveY], m_nDirect);
            }
        }

        private void ZoomSmall()
        {
            ClearRectangle(m_nMoveX, m_nMoveY);
            m_nDirect += 3;
            DrawBall(m_nMoveX, m_nMoveY, balls[m_nMoveX, m_nMoveY],m_nDirect);
        }

        private bool IsGameOver()
        {
            for (int i = 0; i < m_nRowCount; i++)
            {
                for (int j = 0; j < m_nRowCount; j++)
                {
                    if (balls[i,j] != GameZone.BackColor)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool m_bIsGameOver = false;
        private int m_nMoveX = -1;
        private int m_nMoveY = -1;
        private int m_nDirect = 0;
        private int m_nLastX = -1;   // 上一鼠标位置对应的行
        private int m_nLastY = -1;   // 上一鼠标位置对应的列

        // 背景颜色
        private static Color m_clsBackColor = Color.Gray;

        // 行、列数量
        private const int m_nRowCount = 10;

        // 棋盘额外宽度
        private const int m_nChessExtraWide = 1;

        // 用来标记棋盘中相应坐标是否有球，以及球的颜色
        private Color[,] balls = new Color[m_nRowCount, m_nRowCount];

        // 随机球的颜色合集：第一个时背景色
        public Color[] color = { Color.Gray, Color.Red, Color.Green, Color.Blue, Color.Brown, Color.Yellow, Color.LightBlue, Color.Violet, Color.White, Color.Black, Color.DarkOrange };

        private int[] nextColorIndex = new int[5];   // 下一组球颜色的下表索引       

        // 玩家名
        private string playerName = "";

        // 玩家历史最高分
        private int m_nMaxScore;

        // 当前分数
        private int m_nCurScore;

        // 缺省玩家名
        private static string defaultplayer = "匿名";

        // 历史记录保存文件名
        private static string m_strHistoryFilename = "history.ini";

        // 历史记录section名
        private static string m_strSectionName = "history";

        // key前缀
        private static string m_strKeyName = "ball";

        private static System.Resources.ResourceManager manager =
            new System.Resources.ResourceManager("彩色连珠.Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());

        private bool m_bFirstDraw = true;

        WMPLib.WindowsMediaPlayer wmp = new WindowsMediaPlayer();//播放音频的wmp控件，需先在项目属性的引用的COM里面添加名为Windows Media Player、路径为C:\Windows\System32\wmp.dll引用!

    }

}
