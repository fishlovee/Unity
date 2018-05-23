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
    class CheckHelp
    {
        static public Point[] GetList(Point p,int x,int y,int n)
        {
            int nMid = n / 2;
            Point[] lst = new Point[n];
            for (int i = 0; i <  n ; i++)
            {
                if (p.X + (i - nMid) * x > 9 || p.X + (i - nMid) * x < 0)
                {
                    lst[i] = new Point(-1, -1);
                    continue;
                }

                if (p.Y + (i - nMid) *y > 9 || p.Y + (i - nMid) * y  < 0)
                {
                    lst[i] = new Point(-1, -1);
                    continue;
                }

                lst[i] = new Point(p.X + (i - nMid)* x, p.Y + (i-nMid) * y);
            }

            return lst;
        }
    }

    public partial class 彩色连珠 : Form
    {
        /// <summary>
        /// 判断在该位置的棋子是否可以成功消除
        /// 如果在横竖、对角线的某一条上存在相同颜色且连续的五个棋子则认为可以消除，白色棋子可以当做任意颜色
        /// 
        /// </summary>
        /// <param name="x">棋子横坐标</param>
        /// <param name="y">棋子纵坐标</param>
        /// <returns></returns>
        private bool CheckSucces(int x,int y)
        {
            if (balls[x,y] == GameZone.BackColor)
            {
                return false;
            }

            // 获取四个方向上的球：坐标xy的左右四个
            int xbeg = x - 4 > 0 ? x - 4 : 0;
            int xend = x + 4 > 9 ? (m_nRowCount - 1) : x + 4;

            int ybeg = y - 4 > 0 ? y - 4 : 0;
            int yend = y + 4 > 9 ? (m_nRowCount - 1) : y + 4;
            Point[][] res = new Point[4][];
            Point startpoint = new Point(x, y);
            res[0] = CheckHelp.GetList(startpoint, 1, 0, 9);
            res[1] = CheckHelp.GetList(startpoint, 0, 1, 9);
            res[2] = CheckHelp.GetList(startpoint, 1, 1, 9);
            res[3] = CheckHelp.GetList(startpoint, -1, -1, 9);


            Color targetColor = balls[x, y];
            List<List<Point>> eraseList = new List<List<Point>>();
            for (int i = 0; i < 4; i++)
            {
                int nCount = 1;
                Color rightColor = targetColor;
                Color leftColor = targetColor;
                List<Point> lst = new List<Point>();
                lst.Add(new Point(x,y));
                for (int j = 5; j < 9; j++)
                {
                    if (res[i][j].X == -1 || res[i][j].Y == -1)
                    {
                        break;
                    }

                    if (balls[res[i][j].X, res[i][j].Y] != GameZone.BackColor && 
                        (balls[res[i][j].X, res[i][j].Y] == rightColor || balls[res[i][j].X, res[i][j].Y] == Color.White|| rightColor == Color.White)
                        )
                    {
                        if (rightColor == Color.White)
                        {
                            rightColor = balls[res[i][j].X, res[i][j].Y];
                        }
                        lst.Add(new Point(res[i][j].X, res[i][j].Y));
                        nCount++;
                    }
                    else
                        break;
                }

                // 不等说明中心点是白色
                if ( rightColor != targetColor)
                {
                    if (nCount >= 5)
                    {
                        leftColor = rightColor;
                    }
                    else if (leftColor != rightColor)
                    {
                        if (res[i][3].X != -1 && res[i][3].Y != -1 && balls[res[i][3].X, res[i][3].Y] != rightColor)
                        {
                            nCount = 1;
                            lst.Clear();
                            lst.Add(new Point(x,y));
                        }
                    }
                }

                for (int k = 3; k >= 0;--k)
                {
                    if (res[i][k].X == -1 || res[i][k].Y == -1)
                    {
                        break;
                    }

                    if (balls[res[i][k].X, res[i][k].Y] != GameZone.BackColor &&
                       ( balls[res[i][k].X, res[i][k].Y] == leftColor || balls[res[i][k].X, res[i][k].Y] == Color.White || leftColor == Color.White)
                       )
                    {
                        if (leftColor == Color.White)
                        {
                            leftColor = balls[res[i][k].X, res[i][k].Y];
                        }
                        lst.Add(new Point(res[i][k].X, res[i][k].Y));
                        nCount++;
                    }
                    else
                        break;
                }

                if (lst.Count >= 5)
                {
                    eraseList.Add(lst);
                }
            }

            foreach (var item in eraseList)
            {
                foreach (var point in item)
                {
                    ClearRectangle(point.X, point.Y);
                    balls[point.X, point.Y] = GameZone.BackColor;
                    
                }
                if (item.Count >= 5)
                {
                    m_nCurScore += (item.Count - 4) * 10;
                    ScoreLable.Text = "分数：" + m_nCurScore;
                }
            }
            DrawBalls();
            return eraseList.Count > 0;
        }
    }
}
