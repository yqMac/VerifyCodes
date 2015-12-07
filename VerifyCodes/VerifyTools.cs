using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyCodes
{
    /// <summary>
    /// 图像处理类
    ///                         ★ 主要公开方法：
    /// 1、构造:设置默认bitmap，并自动解决Graphics异常的可能
    /// 2、void GrayByPixels();逐像素方法灰度处理图片
    /// 3、int GetDgGrayValue();取得灰度图前后景的临界值 最大类间方差法 【需灰度图】
    /// 4、void ClearBlock(int,int,int,int );去掉指定宽度的四边框，置白 
    /// 5、void ClearNoise(int,int);指定 灰度背景分界值，指定8邻域像素值，去噪点 【灰度图】
    /// 6、void ConvertTo1Bpp(int?);根据指定 灰度背景分界值，或者默认求平均阈值，二值化处理图片【灰度图】
    /// 7、void ClearEdge(int );根据指定 阀值，去除背景边  【需灰度图】
    /// 8、RectangleF[] getRegions();获取指定连通区域    提取连通量法  【需灰度图、二值化图】
    /// 9、void reversal();翻转图像
    /// 10、void setImg(Bitmap);设置新的图像
    /// 11、void reSet();重置图像
    /// 
    ///                      ★主要公开变量
    /// 1、int       srcShowMul;//原图放大倍数
    /// 2、int       userShowMul;//结果图放大倍数
    /// 3、Bitmap    SrcBmpShow;//以指定倍数像素单位放大的原图
    /// 4、Bitmap    UserBmpShow;//处理结果图                 
    /// 5、RectangleF[]  rects;//分割后的矩形信息           【需灰度图】
    /// 6、bool      drawRect;//是否显示分割框              【需灰度图】
    /// 7、int[,]    regions;//坐标型二位图片像素信息       【需二值化后】
    /// </summary>
    public class VerifyTools
    {

        #region 变量

        /// <summary>
        /// 返回最新的图片
        /// </summary>
        //public Bitmap UserBmpShow
        //{
        //    //get
        //{
        //userMapShow中存放的是当前图像
        //需要更新的情况和程度是
        //改变放大比例---内容不变，大小改变，矩框改变
        //内容改变-----矩框改变

        //if (usershowMulChanged || rectsChanged || rects == null)
        //{
        //    rects = getRegions();

        //    UserShowMul = UserShowMul > 0 ? UserShowMul : 1;
        //    userBmpShow = getBig(userBmp, UserShowMul);

        //    usershowMulChanged = false;
        //    rectsChanged = false;
        //}


        //if (drawRect)
        //{
        //    if (rects.Length == 0)
        //    {
        //        rects = getRegions();
        //    }
        //    Bitmap bmp = (Bitmap)userBmpShow.Clone();
        //    Graphics gbmp = Graphics.FromImage(bmp);
        //    int mul = UserShowMul;
        //    for (int i = 0; i < rects.Length; i++)
        //    {
        //        gbmp.DrawRectangle(new Pen(Color.Blue), rects[i].X * mul, rects[i].Y * mul, rects[i].Width * mul + mul - 1, rects[i].Height * mul + mul - 1);
        //    }
        //    return bmp;
        //}
        //700,250
        //180  h:  50 
        //1800 H:
        //500
        //Console.WriteLine(srcBmp.Width + "  h:  " + srcBmp.Height + " \n  " + userBmpShow.Width + " H:  " + userBmpShow.Height);
        //return userBmpShow;
        //    }
        //}

        /// <summary>
        /// 自动分割信息
        /// </summary>
        //public RectangleF[] rects = null;


        #endregion 变量

        #region 裁剪

        /// <summary>
        /// 边框置白
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <param name="u"></param>
        /// <param name="d"></param>
        public static Bitmap ClearBlock(Bitmap userBmp, int l, int r, int u, int d)
        {

            for (int i = 0; i < userBmp.Width; i++)
            {
                for (int j = 0; j < userBmp.Height; j++)
                {
                    if (i - l < 0 || i + r >= userBmp.Width || j - u < 0 || j + d >= userBmp.Height)
                    {
                        userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            return userBmp;
        }


        #endregion

        #region 颜色处理

        /// <summary>
        /// 灰度转换,逐像素
        /// </summary>
        public static Bitmap GrayByPixels(Bitmap userBmp)
        {
            for (int i = 0; i < userBmp.Height; i++)
            {
                for (int j = 0; j < userBmp.Width; j++)
                {
                    int tmpValue = GetGrayNumColor(userBmp.GetPixel(j, i));
                    userBmp.SetPixel(j, i, Color.FromArgb(tmpValue, tmpValue, tmpValue));
                }
            }
            return userBmp;
        }

        /// <summary>
        /// 翻转图像
        /// </summary>
        public static Bitmap reversal(Bitmap userBmp)
        {

            for (var x = 0; x < userBmp.Width; x++)
            {
                for (var y = 0; y < userBmp.Height; y++)
                {
                    Color tmp = userBmp.GetPixel(x, y);
                    userBmp.SetPixel(x, y, Color.FromArgb(255 - tmp.R, 255 - tmp.G, 255 - tmp.B));

                }
            }
            return userBmp;
        }

        /// <summary>
        /// 获取单色图，
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="type">1单R，2单G,3单B</param>
        /// <returns></returns>
        public static Bitmap getClrBmp(Bitmap bmp, int type)
        {
            Color c;
            int tmpint = -1;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (type == 1) tmpint = c.R;
                    else if (type == 2) tmpint = c.G;
                    else if (type == 3) tmpint = c.B;
                    else return bmp;
                    bmp.SetPixel(i, j, Color.FromArgb(tmpint, tmpint, tmpint));
                }
            }

            return bmp;
        }

        #endregion 颜色处理

        #region 滤波处理

        /// <summary>
        /// 需灰度图
        /// 图像滤波处理
        /// </summary>
        /// <param name="bmp">目标位图</param>
        /// <param name="lbwidth">滤波3*3，5*5，7*7</param>
        /// <param name="type">类型，1中值，2均值</param>
        /// <returns></returns>
        public static Bitmap getLBbmp(Bitmap bmp, int lbwidth, int type = 1)
        {
            int wbwidth = -1;
            switch (lbwidth)
            {
                case 3: wbwidth = 1; break;
                case 5: wbwidth = 2; break;
                case 7: wbwidth = 3; break;
                default: return bmp;
            }
            Bitmap bmpnew = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    List<int> tmpcoint = new List<int>();
                    for (int ii = i - wbwidth; ii < i + wbwidth; ii++)
                    {
                        for (int jj = j - wbwidth; jj < j + wbwidth; jj++)
                        {
                            if (ii < 0 || jj < 0 || ii >= bmp.Width || jj >= bmp.Height)
                            {
                                continue;
                            }
                            tmpcoint.Add(bmp.GetPixel(ii, jj).R);
                        }
                    }
                    int midc = 255;
                    if (type == 1)
                    {
                        midc = getMidColor(tmpcoint);
                    }
                    else
                    {
                        midc = getAveColor(tmpcoint);
                    }
                    bmpnew.SetPixel(i, j, Color.FromArgb(midc, midc, midc));
                }
            }
            return bmpnew;
        }




        #endregion 滤波处理

        #region 二值化

        /// <summary>
        /// 非白变黑
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap getBlackPic(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, c.B == 255 ? Color.White : Color.Black);
                    //showbmp = VerifyTools.getBig(prebmp, ref mul);
                }
            }
            return bmp;
        }

        /// <summary> 
        /// 需灰度图
        /// 图像二值化1：取图片的平均灰度作为阈值，低于该值的全都为0，高于该值的全都为255 
        /// </summary> 
        /// <param name="bmp"></param> 
        /// <returns></returns> 
        public static Bitmap ConvertTo1Bpp(Bitmap userBmp, int fazhi = -1)
        {
            int average = fazhi;
            if (average == -1)
            {
                for (int i = 0; i < userBmp.Width; i++)
                {
                    for (int j = 0; j < userBmp.Height; j++)
                    {
                        Color color = userBmp.GetPixel(i, j);
                        average += color.B;
                    }
                }
                average = (int)average / (userBmp.Width * userBmp.Height);
            }
            for (int i = 0; i < userBmp.Width; i++)
            {
                for (int j = 0; j < userBmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色 
                    Color color = userBmp.GetPixel(i, j);
                    int value = 255 - color.B;
                    Color newColor = value > average ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255, 255, 255);
                    userBmp.SetPixel(i, j, newColor);
                }
            }
            return userBmp;
        }

        /// <summary>
        /// 需要灰度图前提-----整体灰度
        /// 得到灰度图像前景背景的临界值 最大类间方差法
        /// </summary>
        /// <returns>前景背景的临界值</returns>
        public static int GetDgGrayValue(Bitmap userBmp)
        {
            int[] pixelNum = new int[256];           //图象直方图，共256个点
            int n, n1, n2;
            int total;                              //total为总和，累计值
            double m1, m2, sum, csum, fmax, sb;     //sb为类间方差，fmax存储最大方差值
            int k, t, q;
            int threshValue = 1;                      // 阈值
                                                      //生成直方图
            for (int i = 0; i < userBmp.Width; i++)
            {
                for (int j = 0; j < userBmp.Height; j++)
                {
                    //返回各个点的颜色，以RGB表示
                    pixelNum[userBmp.GetPixel(i, j).R]++;            //相应的直方图加1
                }
            }
            //直方图平滑化
            for (k = 0; k <= 255; k++)
            {
                total = 0;
                for (t = -2; t <= 2; t++)              //与附近2个灰度做平滑化，t值应取较小的值
                {
                    q = k + t;
                    if (q < 0)                     //越界处理
                        q = 0;
                    if (q > 255)
                        q = 255;
                    total = total + pixelNum[q];    //total为总和，累计值
                }
                pixelNum[k] = (int)((float)total / 5.0 + 0.5);    //平滑化，左边2个+中间1个+右边2个灰度，共5个，所以总和除以5，后面加0.5是用修正值
            }
            //求阈值
            sum = csum = 0.0;
            n = 0;
            //计算总的图象的点数和质量矩，为后面的计算做准备
            for (k = 0; k <= 255; k++)
            {
                sum += (double)k * (double)pixelNum[k];     //x*f(x)质量矩，也就是每个灰度的值乘以其点数（归一化后为概率），sum为其总和
                n += pixelNum[k];                       //n为图象总的点数，归一化后就是累积概率
            }
            fmax = -1.0;                          //类间方差sb不可能为负，所以fmax初始值为-1不影响计算的进行
            n1 = 0;
            for (k = 0; k < 256; k++)                  //对每个灰度（从0到255）计算一次分割后的类间方差sb
            {
                n1 += pixelNum[k];                //n1为在当前阈值遍前景图象的点数
                if (n1 == 0) { continue; }            //没有分出前景后景
                n2 = n - n1;                        //n2为背景图象的点数
                if (n2 == 0) { break; }               //n2为0表示全部都是后景图象，与n1=0情况类似，之后的遍历不可能使前景点数增加，所以此时可以退出循环
                csum += (double)k * pixelNum[k];    //前景的“灰度的值*其点数”的总和
                m1 = csum / n1;                     //m1为前景的平均灰度
                m2 = (sum - csum) / n2;               //m2为背景的平均灰度
                sb = (double)n1 * (double)n2 * (m1 - m2) * (m1 - m2);   //sb为类间方差
                if (sb > fmax)                  //如果算出的类间方差大于前一次算出的类间方差
                {
                    fmax = sb;                    //fmax始终为最大类间方差（otsu）
                    threshValue = k;              //取最大类间方差时对应的灰度的k就是最佳阈值
                }
            }
            return threshValue;
        }



        #endregion 二值化

        #region 黑白图处理


        /// <summary>
        /// 需要灰度图
        /// 根据前后景临界灰度、杂点周围像素数，去除杂点【置白】，
        /// </summary>
        /// <param name="dgGrayValue">前后景临界灰度</param>
        /// <param name="MaxNearPoints">杂点周围像素数</param>
        public static Bitmap ClearNoise(Bitmap userBmp, int dgGrayValue, int MaxNearPoints)
        {
            Color piexl;
            int nearDots = 0;
            //逐点判断
            for (int i = 0; i < userBmp.Width; i++)
                for (int j = 0; j < userBmp.Height; j++)
                {
                    piexl = userBmp.GetPixel(i, j);
                    if (piexl.R < dgGrayValue)
                    {
                        nearDots = 0;
                        //判断周围8个点是否全为空
                        if (i == 0 || i == userBmp.Width - 1 || j == 0 || j == userBmp.Height - 1)  //边框全去掉
                        {
                            //userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            if (userBmp.GetPixel(i - 1, j - 1).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i, j - 1).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i + 1, j - 1).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i - 1, j).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i + 1, j).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i - 1, j + 1).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i, j + 1).R < dgGrayValue) nearDots++;
                            if (userBmp.GetPixel(i + 1, j + 1).R < dgGrayValue) nearDots++;
                            if (nearDots < MaxNearPoints)
                                userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));   //去掉单点 && 粗细小3邻边点
                        }
                    }
                    else  //背景
                        userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            return userBmp;
        }


        /// <summary>
        /// 需灰度图
        /// 去除白边
        /// </summary>
        /// <param name="dgGrayValue">灰度背景分界值</param>
        /// <returns></returns>
        public static Bitmap ClearEdge(Bitmap userBmp, int dgGrayValue=1)
        {
            int posx1 = userBmp.Width; int posy1 = userBmp.Height;
            int posx2 = 0; int posy2 = 0;
            for (int i = 0; i < userBmp.Height; i++)      //找有效区
            {
                for (int j = 0; j < userBmp.Width; j++)
                {
                    int pixelValue = userBmp.GetPixel(j, i).R;
                    if (pixelValue < dgGrayValue)     //根据灰度值
                    {
                        if (posx1 > j) posx1 = j;
                        if (posy1 > i) posy1 = i;

                        if (posx2 < j) posx2 = j;
                        if (posy2 < i) posy2 = i;
                    };
                };
            };
            //复制新图
            Rectangle cloneRect = new Rectangle(posx1, posy1, posx2 - posx1 + 1, posy2 - posy1 + 1);
            userBmp = userBmp.Clone(cloneRect, userBmp.PixelFormat);
            return userBmp;
        }

        /// <summary>
        /// 得到有效图形并调整为可平均分割的大小
        /// </summary>
        /// <param name="dgGrayValue">灰度背景分界值</param>
        /// <param name="CharsCount">有效字符数</param>
        /// <returns></returns>
        public void ClearEdge(Bitmap bmpobj, int dgGrayValue, int CharsCount)
        {
            int posx1 = bmpobj.Width; int posy1 = bmpobj.Height;
            int posx2 = 0; int posy2 = 0;
            for (int i = 0; i < bmpobj.Height; i++)      //找有效区
            {
                for (int j = 0; j < bmpobj.Width; j++)
                {
                    int pixelValue = bmpobj.GetPixel(j, i).R;
                    if (pixelValue < dgGrayValue)     //根据灰度值
                    {
                        if (posx1 > j) posx1 = j;
                        if (posy1 > i) posy1 = i;

                        if (posx2 < j) posx2 = j;
                        if (posy2 < i) posy2 = i;
                    };
                };
            };
            // 确保能整除
            int Span = CharsCount - (posx2 - posx1 + 1) % CharsCount;   //可整除的差额数
            if (Span < CharsCount)
            {
                int leftSpan = Span / 2;    //分配到左边的空列 ，如span为单数,则右边比左边大1
                if (posx1 > leftSpan)
                    posx1 = posx1 - leftSpan;
                if (posx2 + Span - leftSpan < bmpobj.Width)
                    posx2 = posx2 + Span - leftSpan;
            }
            //复制新图
            Rectangle cloneRect = new Rectangle(posx1, posy1, posx2 - posx1 + 1, posy2 - posy1 + 1);
            bmpobj = bmpobj.Clone(cloneRect, bmpobj.PixelFormat);
        }


        /// <summary>
        /// 取图像骨架－－zhang_suen算法
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static  Bitmap Thinbmp(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            Color c;
            bool[,] b = new bool[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    b[i, j] = c.R == 0;
                }
            }

            b = ZhangSuenThinning(b);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int conint = b[i, j] ? 0 : 255;
                    c = Color.FromArgb(conint, conint, conint);
                    bmp.SetPixel(i, j, c);
                }
            }
            return bmp;
        }

        #region 骨架

        public static bool[,] ZhangSuenThinning(bool[,] s)
        {
            bool[,] temp = s;
            bool even = true;

            for (int a = 1; a < s.GetLength(0) - 1; a++)
            {
                for (int b = 1; b < s.GetLength(1) - 1; b++)
                {
                    if (SuenThinningAlg(a, b, temp, even))
                    {
                        temp[a, b] = false;
                    }
                    even = !even;
                }
            }

            return temp;
        }
        static bool SuenThinningAlg(int x, int y, bool[,] s, bool even)
        {
            bool p2 = s[x, y - 1];
            bool p3 = s[x + 1, y - 1];
            bool p4 = s[x + 1, y];
            bool p5 = s[x + 1, y + 1];
            bool p6 = s[x, y + 1];
            bool p7 = s[x - 1, y + 1];
            bool p8 = s[x - 1, y];
            bool p9 = s[x - 1, y - 1];


            int bp1 = NumberOfNonZeroNeighbors(x, y, s);
            if (bp1 >= 2 && bp1 <= 6)//2nd condition
            {
                if (NumberOfZeroToOneTransitionFromP9(x, y, s) == 1)
                {
                    if (even)
                    {
                        if (!((p2 && p4) && p8))
                        {
                            if (!((p2 && p6) && p8))
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        if (!((p2 && p4) && p6))
                        {
                            if (!((p4 && p6) && p8))
                            {
                                return true;
                            }
                        }
                    }
                }
            }


            return false;
        }
        static int NumberOfZeroToOneTransitionFromP9(int x, int y, bool[,] s)
        {
            bool p2 = s[x, y - 1];
            bool p3 = s[x + 1, y - 1];
            bool p4 = s[x + 1, y];
            bool p5 = s[x + 1, y + 1];
            bool p6 = s[x, y + 1];
            bool p7 = s[x - 1, y + 1];
            bool p8 = s[x - 1, y];
            bool p9 = s[x - 1, y - 1];

            int A = Convert.ToInt32((p2 == false && p3 == true)) + Convert.ToInt32((p3 == false && p4 == true)) +
                     Convert.ToInt32((p4 == false && p5 == true)) + Convert.ToInt32((p5 == false && p6 == true)) +
                     Convert.ToInt32((p6 == false && p7 == true)) + Convert.ToInt32((p7 == false && p8 == true)) +
                     Convert.ToInt32((p8 == false && p9 == true)) + Convert.ToInt32((p9 == false && p2 == true));
            return A;
        }
        static int NumberOfNonZeroNeighbors(int x, int y, bool[,] s)
        {
            int count = 0;
            if (s[x - 1, y])
                count++;
            if (s[x - 1, y + 1])
                count++;
            if (s[x - 1, y - 1])
                count++;
            if (s[x, y + 1])
                count++;
            if (s[x, y - 1])
                count++;
            if (s[x + 1, y])
                count++;
            if (s[x + 1, y + 1])
                count++;
            if (s[x + 1, y - 1])
                count++;
            return count;
        }
        #endregion 骨架

        /// <summary>
        /// 腐蚀---3*3 邻域全1则ij为1，否则为0
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap getErosin(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            bool[,] b = getbmpbin(bmp);
            bool allt = true;
            int tmpx, tmpy;

            //腐蚀运算
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (b[i, j])
                    {
                        allt = true;
                        tmpx = i - 1; tmpy = j - 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i - 1; tmpy = j;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i - 1; tmpy = j + 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i; tmpy = j - 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i; tmpy = j + 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i + 1; tmpy = j - 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i + 1; tmpy = j;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];
                        tmpx = i + 1; tmpy = j + 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt && b[tmpx, tmpy];

                        b[i, j] = allt;
                    }
                }
            }
            bmp = getBinToBmp(bmp, b);
            return bmp;
        }

        /// <summary>
        /// 膨胀－－－３×３邻域,有１则为１,否则为０，Ｓｗｅｌｌ
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap getSwell(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            bool[,] b = getbmpbin(bmp);
            bool allt = true;
            int tmpx, tmpy;

            //腐蚀运算
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (!b[i, j])
                    {
                        allt = false;
                        tmpx = i - 1; tmpy = j - 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i - 1; tmpy = j;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i - 1; tmpy = j + 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i; tmpy = j - 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i; tmpy = j + 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i + 1; tmpy = j - 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i + 1; tmpy = j;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];
                        tmpx = i + 1; tmpy = j + 1;
                        if (tmpy >= 0 && tmpy >= 0 && tmpy < height && tmpx < width) allt = allt || b[tmpx, tmpy];

                        b[i, j] = allt;
                    }
                }
            }
            bmp = getBinToBmp(bmp, b);
            return bmp;
        }


        /// <summary>
        /// 先腐蚀后膨胀的过程称为开运算。用来消除小物体、在纤细点处分离物体、平滑较大物体的边界的同时并不明显改变其面积
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap getOpen(Bitmap bmp)
        {
            bmp = getErosin(bmp);
            bmp = getSwell(bmp);

            return bmp;
        }

        /// <summary>
        /// 先膨胀后腐蚀的过程称为闭运算。用来填充物体内细小空洞、连接邻近物体、平滑其边界的同时并不明显改变其面积
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap getClose(Bitmap bmp)
        {
            bmp = getSwell(bmp);
            bmp = getErosin(bmp);


            return bmp;
        }




        #endregion  黑白图处理

        #region 滤镜

        /// <summary>
        /// 锐化
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public Bitmap SharpenImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel;
            //拉普拉斯模板
            int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    int Index = 0;
                    for (int col = -1; col <= 1; col++)
                    {
                        for (int row = -1; row <= 1; row++)
                        {
                            pixel = lbmp.GetPixel(x + row, y + col); r += pixel.R * Laplacian[Index];
                            g += pixel.G * Laplacian[Index];
                            b += pixel.B * Laplacian[Index];
                            Index++;
                        }
                    }
                    //处理颜色值溢出
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    newlbmp.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }


        /// <summary>
        /// 雾化
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public Bitmap AtomizationImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            System.Random MyRandom = new Random();
            Color pixel;
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int k = MyRandom.Next(123456);
                    //像素块大小
                    int dx = x + k % 19;
                    int dy = y + k % 19;
                    if (dx >= width)
                        dx = width - 1;
                    if (dy >= height)
                        dy = height - 1;
                    pixel = lbmp.GetPixel(dx, dy);
                    newlbmp.SetPixel(x, y, pixel);
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        /// <summary>
        /// 柔化
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public Bitmap SoftenImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel;
            //高斯模板
            int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    int Index = 0;
                    for (int col = -1; col <= 1; col++)
                    {
                        for (int row = -1; row <= 1; row++)
                        {
                            pixel = lbmp.GetPixel(x + row, y + col);
                            r += pixel.R * Gauss[Index];
                            g += pixel.G * Gauss[Index];
                            b += pixel.B * Gauss[Index];
                            Index++;
                        }
                    }
                    r /= 16;
                    g /= 16;
                    b /= 16;
                    //处理颜色值溢出
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    newlbmp.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }

        /// <summary>
        /// 浮雕
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public Bitmap EmbossmentImage(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            Bitmap newbmp = new Bitmap(width, height);

            LockBitmap lbmp = new LockBitmap(bmp);
            LockBitmap newlbmp = new LockBitmap(newbmp);
            lbmp.LockBits();
            newlbmp.LockBits();

            Color pixel1, pixel2;
            for (int x = 0; x < width - 1; x++)
            {
                for (int y = 0; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    pixel1 = lbmp.GetPixel(x, y);
                    pixel2 = lbmp.GetPixel(x + 1, y + 1);
                    r = Math.Abs(pixel1.R - pixel2.R + 128);
                    g = Math.Abs(pixel1.G - pixel2.G + 128);
                    b = Math.Abs(pixel1.B - pixel2.B + 128);
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;
                    newlbmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            lbmp.UnlockBits();
            newlbmp.UnlockBits();
            return newbmp;
        }


        /// <summary>
        /// 霓虹处理
        /// </summary>
        /// <param name="bmpobj"></param>
        /// <returns></returns>
        public static Bitmap neonPic(Bitmap bmpobj)
        {
            Bitmap bmpnew = new Bitmap(bmpobj.Width, bmpobj.Height);
            for (int i = 0; i < bmpobj.Width - 1; i++)
            {
                for (int j = 0; j < bmpobj.Height - 1; j++)
                {
                    int r, g, b;

                    //f(i,j)的RGB分量为(r1, g1, b1), f(i,j+1)为(r2, g2, b2), f(i+1,j)为(r3, g3, b3)
                    Color c1 = bmpobj.GetPixel(i, j);
                    Color c2 = bmpobj.GetPixel(i, j + 1);
                    Color c3 = bmpobj.GetPixel(i + 1, j);
                    //r = 2 * sqrt( (r1 - r2)^2 + (r1 - r3)^2 )
                    r = (int)(2 * (Math.Sqrt(Math.Pow((c1.R - c2.R), 2) + Math.Pow((c1.R - c3.R), 2))));
                    g = (int)(2 * (Math.Sqrt(Math.Pow((c1.G - c2.G), 2) + Math.Pow((c1.G - c3.G), 2))));
                    b = (int)(2 * (Math.Sqrt(Math.Pow((c1.B - c2.B), 2) + Math.Pow((c1.B - c3.B), 2))));


                    if(r>=0 && r<=255 && g>=0 && g<=255 && b >=0 && b<=255)
                    bmpnew.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            }
            return bmpnew;
        }




        #endregion 滤镜

        #region HU不变矩 特征码提取和匹配相似度
        //#################################################################################//
        //public static  double[] M = new double[7];        //HU不变矩

         /// <summary>
         /// 获取二值化图像的体征吗
         /// </summary>
         /// <param name="img"></param>
         /// <returns></returns>
        public static  double [] HuMoment(Bitmap  img)
        { 
              double[] M = new double[7];
            PointBitmap pbp = new PointBitmap(img );
            pbp.LockBits();

            int bmpWidth = pbp.Width ;
            int bmpHeight = pbp.Height ;
            int bmpStep = pbp.Depth ;
            //int bmpChannels = img->nChannels;
            //uchar* pBmpBuf = (uchar*)img->imageData;

            double m00 = 0, m11 = 0, m20 = 0, m02 = 0, m30 = 0, m03 = 0, m12 = 0, m21 = 0;  //中心矩 
            double x0 = 0, y0 = 0;    //计算中心距时所使用的临时变量（x-x'） 
            double u20 = 0, u02 = 0, u11 = 0, u30 = 0, u03 = 0, u12 = 0, u21 = 0;//规范化后的中心矩
                                                                                 //double M[7];    //HU不变矩 
            double t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0;//临时变量， 
                                                          //double Center_x=0,Center_y=0;//重心 
            int Center_x = 0, Center_y = 0;//重心 
            int i, j;            //循环变量

            //  获得图像的区域重心(普通矩)
            double s10 = 0, s01 = 0, s00 = 0;  //0阶矩和1阶矩  
            for (j = 0; j < bmpHeight; j++)//y
            {
                for (i = 0; i < bmpWidth; i++)//x
                {
                    s10 += i;// * pBmpBuf[j * bmpStep + i];
                    s01 += j;// * pBmpBuf[j * bmpStep + i];
                    s00 += 1;// pBmpBuf[j * bmpStep + i];
                }
            }
            Center_x = (int)(s10 / s00 + 0.5);
            Center_y = (int)(s01 / s00 + 0.5);

            //  计算二阶、三阶矩(中心矩)
            m00 = s00;
            //// 11 20 02 21+ 21- 12+ 12- 30+ 30- 03+ 02-
            for (j = 0; j < bmpHeight; j++)
            {
                for (i = 0; i < bmpWidth; i++)//x 
                {
                    //白色tiao
                    if (pbp.GetPixel(i, j).R == 255) continue;
                    x0 = (i - Center_x);
                    y0 = (j - Center_y);
                    m11 += x0 * y0;// * pBmpBuf[j * bmpStep + i];
                    m20 += x0 * x0;// * pBmpBuf[j * bmpStep + i];
                    m02 += y0 * y0;// * pBmpBuf[j * bmpStep + i];
                    m03 += y0 * y0 * y0;// * pBmpBuf[j * bmpStep + i];
                    m30 += x0 * x0 * x0;// * pBmpBuf[j * bmpStep + i];
                    m12 += x0 * y0 * y0;// * pBmpBuf[j * bmpStep + i];
                    m21 += x0 * x0 * y0;// * pBmpBuf[j * bmpStep + i];
                }
            }

            //  计算规范化后的中心矩: mij/pow(m00,((i+j+2)/2)
            u20 = m20 / Math.Pow(m00, 2);
            u02 = m02 / Math.Pow(m00, 2);
            u11 = m11 / Math.Pow(m00, 2);
            u30 = m30 / Math.Pow(m00, 2.5);
            u03 = m03 / Math.Pow(m00, 2.5);
            u12 = m12 / Math.Pow(m00, 2.5);
            u21 = m21 / Math.Pow(m00, 2.5);

            //  计算中间变量
            t1 = (u20 - u02);
            t2 = (u30 - 3 * u12);
            t3 = (3 * u21 - u03);
            t4 = (u30 + u12);
            t5 = (u21 + u03);

            //  计算不变矩 
            M[0] = u20 + u02;
            M[1] = t1 * t1 + 4 * u11 * u11;
            M[2] = t2 * t2 + t3 * t3;
            M[3] = t4 * t4 + t5 * t5;
            M[4] = t2 * t4 * (t4 * t4 - 3 * t5 * t5) + t3 * t5 * (3 * t4 * t4 - t5 * t5);
            M[5] = t1 * (t4 * t4 - t5 * t5) + 4 * u11 * t4 * t5;
            M[6] = t3 * t4 * (t4 * t4 - 3 * t5 * t5) - t2 * t5 * (3 * t4 * t4 - t5 * t5);
            pbp.UnlockBits();
            return M;
        }
        /// <summary>
        /// 获取两个特征码的相似度
        /// </summary>
        /// <returns></returns>
        public static double getDbR(double []Sa,double []Ta)
        {

            //  计算相似度1
            double dbR = 0; //相似度
            double dSigmaST = 0;
            double dSigmaS = 0;
            double dSigmaT = 0;
            double temp = 0;
            {
                for (int i = 0; i <7; i++)
                {
                    temp = Math .Abs (Sa[i] * Ta[i]);
                    dSigmaST += temp;
                    dSigmaS += Math.Pow (Sa[i], 2);
                    dSigmaT += Math.Pow (Ta[i], 2);
                }
            }
            dbR = dSigmaST / (Math.Sqrt (dSigmaS) * Math.Sqrt (dSigmaT));
            return dbR;
        }

        #endregion HU不变矩

        /// <summary>
        /// 二值化图片 取得数组
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        private static  bool [,] getbmpbin(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            Color c;
            bool[,] b = new bool[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    b[i, j] = c.R == 0;
                }
            }
            return b;
        }

        /// <summary>
        /// 对位图使用数组 改变
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="b"></param>
        private static  Bitmap   getBinToBmp(Bitmap bmp,bool [,] b)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int conint = b[i, j] ? 0 : 255;
                    c = Color.FromArgb(conint, conint, conint);
                    bmp.SetPixel(i, j, c);
                }
            }
            return bmp;
        }

        /// <summary>
        /// 平均分割图片
        /// </summary>
        /// <param name="RowNum">水平上分割数</param>
        /// <param name="ColNum">垂直上分割数</param>
        /// <returns>分割好的图片数组</returns>
        public Bitmap[] GetSplitPics(Bitmap bmpobj,int RowNum, int ColNum)
        {
            if (RowNum == 0 || ColNum == 0)
                return null;
            int singW = bmpobj.Width / RowNum;
            int singH = bmpobj.Height / ColNum;
            Bitmap[] PicArray = new Bitmap[RowNum * ColNum];

            Rectangle cloneRect;
            for (int i = 0; i < ColNum; i++)      //找有效区
            {
                for (int j = 0; j < RowNum; j++)
                {
                    cloneRect = new Rectangle(j * singW, i * singH, singW, singH);
                    PicArray[i * RowNum + j] = bmpobj.Clone(cloneRect, bmpobj.PixelFormat);//复制小块图
                }
            }
            return PicArray;
        }


        /// <summary>
        /// 取位图内部分
        /// </summary>
        /// <param name="srcbmp"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Bitmap getRectBmp(Bitmap srcbmp, Rectangle rect)
        {
            Bitmap bmp = (Bitmap)srcbmp.Clone();
            if (rect.Height >srcbmp .Height || rect.Width >srcbmp.Width)
            {
                return bmp;
            }

            Rectangle rectc = new Rectangle(rect.X, rect.Y, rect.Width + 1, rect.Height + 1);
            bmp = bmp.Clone(rect, bmp.PixelFormat);
            return bmp;

        }

        #region 图像轮廓提取

        /// <summary>
        /// 获取图像区域        提取连通分量法-种子法
        /// </summary>
        /// <returns></returns>
        public static Rectangle[] getRegions(Bitmap userBmp, int lside = 1)
        {
            List<List<Point>> list_regions = new List<List<Point>>();
            List<Rectangle> list_bt = new List<Rectangle>();
            int width = userBmp.Width;
            int heigth = userBmp.Height;
            //Bitmap img = (Bitmap)userBmp.Clone();
            /// <summary>
            /// 分割框位置信息
            /// </summary>
            int[,] regions = null;
            int[,] imgp = new int[width, heigth];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    imgp[i, j] = userBmp.GetPixel(i, j).R;
                }
            }

            regions = new int[width, heigth];
            list_regions = new List<List<Point>>();
            int tag = 1;

            for (var x = 0; x <width ; x++)
            {
                for (var y = 0; y < heigth ; y++)
                {
                    if(imgp [x,y]==0 && regions [x ,y] == 0)
                    {
                        list_regions.Add(getneib(imgp, regions, new Point(x, y), tag));
                        tag++;
                    }
              
                }
            }
            foreach (List<Point> item in list_regions)
            {
                Point left, right;
                left = item[0];
                right = item[0];

                foreach (Point p in item)
                {
                    if (left.X > p.X)
                    {
                        left.X = p.X;
                    }
                    if (left.Y > p.Y)
                    {
                        left.Y = p.Y;
                    }
                    if (right.X < p.X)
                    {
                        right.X = p.X;
                    }
                    if (right.Y < p.Y)
                    {
                        right.Y = p.Y;
                    }
                }
                int h = right.Y - left.Y + 1;
                int w = right.X - left.X + 1;
                if (w > lside && h > lside)
                    list_bt.Add(new Rectangle(left, new Size(w, h)));
            }
            return list_bt.ToArray();
        }

        /// <summary>
        /// two-pass法/四邻域
        /// </summary>
        /// <param name="userBmp"></param>
        /// <param name="lside"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Rectangle[] getRegions(Bitmap userBmp,int linyu=8,int lside=1,bool n=true)
        {
            List<List<Point>> list_regions = new List<List<Point>>();
            Dictionary<int, List<Point>> dic_tag_region = new Dictionary<int, List<Point>>();
            List<Rectangle> list_bt = new List<Rectangle>();
            int width = userBmp.Width;
            int height = userBmp.Height;
            Dictionary<int, int > dic_tagLink = new Dictionary<int, int >();
            //Bitmap img = (Bitmap)userBmp.Clone();
            /// <summary>
            /// 分割框位置信息
            /// </summary>
            int[,] regions_tags = null;
            int[,] imgp = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    imgp[i, j] = userBmp.GetPixel(i, j).R;
                }
            }

            regions_tags = new int[width, height];
            list_regions = new List<List<Point>>();
            int tag = 1;
            ///第一遍
            int nerbSmall = -1;
            for (var y = 0; y < height ; y++)
            {
                for (var x = 0; x < width ; x++)
                {
                    nerbSmall = -1;

                    if (imgp[x, y] == 0 )
                    {
                        List<int> list_nertags = new List<int>();
                        
                        //左邻域
                        int tmpx = x - 1, tmpy = y;
                        if (tmpx >= 0 && imgp[tmpx , tmpy ] == 0 && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                        //上邻域
                        tmpx = x; tmpy = y - 1;
                        if (tmpy >= 0 && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                    
                        
                        //下邻域
                        tmpx = x; tmpy = y + 1;
                        if (tmpy < height  && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                        //右邻域
                        tmpx = x+1; tmpy = y;
                        if (tmpx < width  && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                        //如果八邻域
                        if(linyu == 8)
                        {
                            //左上邻域
                            tmpx = x -1 ; tmpy = y-1;
                            if (tmpx >0&&tmpy >0 && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                            //右上邻域
                            tmpx = x + 1; tmpy = y - 1;
                            if (tmpx <width  && tmpy > 0 && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                            //左下邻域
                            tmpx = x - 1; tmpy = y +1;
                            if (tmpx > 0 && tmpy<height  && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                            //右下邻域
                            tmpx = x + 1; tmpy = y + 1;
                            if (tmpx <width  && tmpy <height  && imgp[tmpx, tmpy] == 0 && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                        }
                        if (list_nertags.Count == 0)
                        {
                            tag++;
                            regions_tags[x, y] = tag;
                            dic_tagLink.Add(tag, tag);
                        }
                        else
                        {
                            list_nertags.Sort();
                            regions_tags[x, y] = list_nertags[0];
                            int last = list_nertags[0];
                            for (int i = 1; i < list_nertags.Count; i++)
                            {
                                if (dic_tagLink[list_nertags[i]] > dic_tagLink[last])
                                {
                                    dic_tagLink[list_nertags[i]] = dic_tagLink[last];
                                }
                                else if (dic_tagLink[list_nertags[i]] < dic_tagLink[last])
                                {
                                    dic_tagLink[last] = dic_tagLink[list_nertags[i]];
                                }
                            }

                        }
                        
                        //if(nerbSmall == -1)
                        //{
                        //    tag++;
                        //    regions_tags[x, y] = tag;
                        //}
                        //else
                        //{
                        //    regions_tags[x, y] = nerbSmall ;
                        //}
                        //list_regions.Add(getneib(imgp, regions_tags, new Point(x, y), tag));
                        //tag++;
                    }

                }
            }
            //第二遍
            for (int y = 0; y < height ; y++)
            {
                for (int x = 0; x < width ; x++)
                {
                    if(regions_tags[x, y] > 0)
                    {
                        regions_tags[x, y] = dic_tagLink[regions_tags[x,y] ];
                        //提取区域
                        int tmptag = regions_tags[x, y];
                        if (dic_tag_region.ContainsKey(tmptag))
                        {
                            dic_tag_region[tmptag].Add(new Point(x, y));
                        }
                        else
                        {

                            dic_tag_region.Add(tmptag, new List<Point>() { new Point(x, y) });
                        }
                    }
                }
            }
            //提取区域
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        if (regions_tags[x, y] > 0)
            //        {
            //            int tmptag = regions_tags[x, y];
            //            if(dic_tag_region .ContainsKey (tmptag))
            //            {
            //                dic_tag_region[tmptag].Add(new Point (x,y));
            //            }else
            //            {
                            
            //                dic_tag_region.Add(tmptag ,new List<Point>() { new Point (x,y)});
            //            }
            //            //regions_tags[x, y] = dic_tagLink[regions_tags[x, y]];
            //        }
            //    }
            //}

            foreach (List<Point> item in dic_tag_region .Values )
            {
                Point left, right;
                left = item[0];
                right = item[0];

                foreach (Point p in item)
                {
                    if (left.X > p.X)
                    {
                        left.X = p.X;
                    }
                    if (left.Y > p.Y)
                    {
                        left.Y = p.Y;
                    }
                    if (right.X < p.X)
                    {
                        right.X = p.X;
                    }
                    if (right.Y < p.Y)
                    {
                        right.Y = p.Y;
                    }
                }
                int h = right.Y - left.Y + 1;
                int w = right.X - left.X + 1;
                if (w > lside && h > lside)
                    list_bt.Add(new Rectangle(left, new Size(w, h)));
            }
            return list_bt.ToArray();
        }


        /// <summary>
        /// two-pass法/四邻域
        /// </summary>
        /// <param name="userBmp"></param>
        /// <param name="lside"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Rectangle[] getFillbmp(Bitmap userBmp, int linyu = 4, int lside = 1, bool n = true,int fillindex=1)
        {
            List<List<Point>> list_regions = new List<List<Point>>();
            Dictionary<int, List<Point>> dic_tag_region = new Dictionary<int, List<Point>>();
            List<Rectangle> list_bt = new List<Rectangle>();
            int width = userBmp.Width;
            int height = userBmp.Height;
            Dictionary<int, int> dic_tagLink = new Dictionary<int, int>();
            //Bitmap img = (Bitmap)userBmp.Clone();
            /// <summary>
            /// 分割框位置信息
            /// </summary>
            int[,] regions_tags = null;
            int[,] imgp = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    imgp[i, j] = userBmp.GetPixel(i, j).R;
                }
            }

            regions_tags = new int[width, height];
            list_regions = new List<List<Point>>();


            int pixel = 255;
            int tag = 1;
            ///第一遍
            int nerbSmall = -1;
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    nerbSmall = -1;

                    if (imgp[x, y] == pixel)
                    {
                        List<int> list_nertags = new List<int>();

                        //左邻域
                        int tmpx = x - 1, tmpy = y;
                        if (tmpx >= 0 && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                        //上邻域
                        tmpx = x; tmpy = y - 1;
                        if (tmpy >= 0 && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }


                        //下邻域
                        tmpx = x; tmpy = y + 1;
                        if (tmpy < height && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                        //右邻域
                        tmpx = x + 1; tmpy = y;
                        if (tmpx < width && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                        {
                            list_nertags.Add(regions_tags[tmpx, tmpy]);
                        }
                        //如果八邻域
                        if (linyu == 8)
                        {
                            //左上邻域
                            tmpx = x - 1; tmpy = y - 1;
                            if (tmpx > 0 && tmpy > 0 && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                            //右上邻域
                            tmpx = x + 1; tmpy = y - 1;
                            if (tmpx < width && tmpy > 0 && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                            //左下邻域
                            tmpx = x - 1; tmpy = y + 1;
                            if (tmpx > 0 && tmpy < height && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                            //右下邻域
                            tmpx = x + 1; tmpy = y + 1;
                            if (tmpx < width && tmpy < height && imgp[tmpx, tmpy] == pixel && regions_tags[tmpx, tmpy] != 0)
                            {
                                list_nertags.Add(regions_tags[tmpx, tmpy]);
                            }
                        }
                        if (list_nertags.Count == 0)
                        {
                            tag++;
                            regions_tags[x, y] = tag;
                            dic_tagLink.Add(tag, tag);
                        }
                        else
                        {
                            list_nertags.Sort();
                            regions_tags[x, y] = list_nertags[0];
                            int last = list_nertags[0];
                            for (int i = 1; i < list_nertags.Count; i++)
                            {
                                if (dic_tagLink[list_nertags[i]] > dic_tagLink[last])
                                {
                                    dic_tagLink[list_nertags[i]] = dic_tagLink[last];
                                }
                                else if (dic_tagLink[list_nertags[i]] < dic_tagLink[last])
                                {
                                    dic_tagLink[last] = dic_tagLink[list_nertags[i]];
                                }
                            }

                        }
                    }

                }
            }
            //第二遍
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (regions_tags[x, y] > 0)
                    {
                        regions_tags[x, y] = dic_tagLink[regions_tags[x, y]];
                        //提取区域
                        int tmptag = regions_tags[x, y];
                        if (dic_tag_region.ContainsKey(tmptag))
                        {
                            dic_tag_region[tmptag].Add(new Point(x, y));
                        }
                        else
                        {

                            dic_tag_region.Add(tmptag, new List<Point>() { new Point(x, y) });
                        }
                    }
                }
            }
            int index = 0;
            foreach (List<Point> item in dic_tag_region.Values)
            {
                Point left, right;
                left = item[0];
                right = item[0];

                foreach (Point p in item)
                {
                    if(index ==fillindex)
                    {
                        userBmp.SetPixel(p.X ,p.Y ,Color.Red );
                    }
                    if (left.X > p.X)
                    {
                        left.X = p.X;
                    }
                    if (left.Y > p.Y)
                    {
                        left.Y = p.Y;
                    }
                    if (right.X < p.X)
                    {
                        right.X = p.X;
                    }
                    if (right.Y < p.Y)
                    {
                        right.Y = p.Y;
                    }
                }
                index++;
                int h = right.Y - left.Y + 1;
                int w = right.X - left.X + 1;
                if (w > lside && h > lside)
                    list_bt.Add(new Rectangle(left, new Size(w, h)));
            }
            return list_bt.ToArray();
        }

        #endregion 图像轮廓提取

        public static void getClearLine(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            int[,] imgp = new int[width, height];
            int offset = -1;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    imgp[i, j] = bmp.GetPixel(i, j).R==0?1:0;
                    if (offset ==-1&&imgp[i, j] == 1)
                    {
                        offset = i;
                    }
                }
            }

            int[] b = new int[width ];

            genLine(bmp ,offset ,imgp ,b ,0);

        }

        public static void  genLine( Bitmap bmp ,int offset,int[,]a,int[]b,int n)
        {
            int threshold = 20;
            int M = bmp.Width;
            int N = bmp.Height;

            if (n < offset)
            {
                b[n] = -1;
                genLine(bmp ,offset ,a,b ,n + 1);
            }
            if (n == M  )
            {
                //for (int i = 0; i < M; i++)
                //{
                //    System.out.print(this.b[i] + " ");

                //}
                //System.out.println("");
            }
            //开始,首列处理
            if (n == offset)
            {
                for (int j = 0; j < N; j++)
                {
                    if (a[offset,j] == 1)
                    {
                       b[offset] = j;
                       // bmp.SetPixel(n ,j ,Color.Red );
                       genLine(bmp,offset,a,b,n + 1);
                    }
                }
            }

            
            if (n > 0 && n < M)
            {
                int hasMore = 0;

                //左边的是有的，且左边的在位图内 且  当前位 是黑色
                if (b[n - 1] > 0 && b[n - 1] < N && a[n,b[n - 1]] == 1)
                {

                    b[n] = b[n - 1];
                    hasMore = 1;
                    //bmp.SetPixel(n, b [n -1], Color.Red);
                    genLine(bmp, offset, a, b, n + 1);
                }
                else
                {
                    if (b[n - 1] > 0 && a[n,b[n - 1] - 1] == 1)
                    {
                       // bmp.SetPixel(n, b[n - 1]-1, Color.Red);
                        b[n] = b[n - 1] - 1;
                        hasMore = 1;
                        genLine(bmp, offset, a, b, n + 1);
                    }
                    if (b[n - 1] <N - 1 && a[n,b[n - 1] + 1] == 1)
                    {
                        //bmp.SetPixel(n, b[n - 1]+1, Color.Red);
                        b[n] = b[n - 1] + 1;
                        hasMore = 1;
                        genLine(bmp, offset, a, b, n + 1);
                    }
                }
                if (n -offset > threshold && hasMore == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (b[i] > 0)
                        {
                            bmp.SetPixel(i, b[i], Color.FromArgb(255, 255, 255));
                            //bmp .SetPixel (b[i], i, Color.FromArgb (255,255,255));
                        }
                    }
                }
            }else if(n - offset > threshold)
            {
                for (int i = 0; i < n; i++)
                {
                    if (b[i] > 0)
                    {
                        bmp.SetPixel(i, b [i], Color.FromArgb(255, 255, 255));
                    }
                }
            }

        }



        public static void getRightrever(Bitmap bmp)
        {

        }

   
        /// <summary>
        /// 需要二值化图片
        /// 获取二值化图片的特征码字符串
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static string getFeatureCode(Bitmap bmp)
        {
            StringBuilder strb = new StringBuilder();

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color c = bmp.GetPixel(j, i);
                    //255白色
                    if (c.R == 255)
                    {
                        strb.Append("0");
                    }
                    else
                    {
                        strb.Append("1");
                    }
                }
            }


            return strb.ToString();
        }

    

        /// <summary>
        /// 线性滤镜处理
        /// </summary>
        /// <param name="bmp">目标位图</param>
        /// <param name="type">处理类型，1腐蚀，2锐化，3细化</param>
        /// <param name="param">参数：腐蚀灰度|锐化程度。取值[0,1]。值越大锐化程度越高|细化灰度</param>
        /// <returns></returns>
        public static Bitmap lineFilter(Bitmap bmp,int type,double param)
        {
            switch (type)
            {
                case 1:
                    ErosionPic(bmp ,(int )param ,0,null );
                    break;
                case 2:
                    Sharpen(bmp ,(float )param );
                    break;
                case 3:
                    ThiningPic(bmp ,(int)param );
                    break;
                default:
                    return bmp ;
                    break;
            }

            return bmp;
        }


        /// <summary>
        /// 填充
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap getFill(Bitmap bmp)
        {

            int width = bmp.Width;
            int height = bmp.Height;

            // private static List<Point> getneib(Bitmap img, int[,] regions, Point x, int tag,bool findblack=true )
            int[,] regions = new int[width, height];
            List<Point> list_white = new List<Point>();

            //最外层空白置tag1
            //regions = new int[img.Width, img.Height];
            // list_regions = new List<List<Point>>();
            int[,] imgp = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    imgp[i, j] = bmp.GetPixel(i, j).R;
                }
            }
            int tag = 1;
            for (var x = 0; x < width; x++)
            {
                if (imgp[x, 0] == 255 && regions[x, 0] == 0)
                {
                    list_white.AddRange(getneib(imgp, regions, new Point(x, 0), 1, false));
                }
                if (imgp[x, height - 1] == 255 && regions[x, height - 1] == 0)
                {
                    list_white.AddRange(getneib(imgp, regions, new Point(x, bmp.Height - 1), 1, false));
                }

            }
            for (var y = 0; y < height; y++)
            {
                if (imgp[0, y] == 255 && regions[0, y] == 0)
                {
                    list_white.AddRange(getneib(imgp, regions, new Point(0, y), 1, false));
                }
                if (imgp[width - 1, y] == 255 && regions[width - 1, y] == 0)
                {
                    list_white.AddRange(getneib(imgp, regions, new Point(width - 1, y), 1, false));
                }


            }
            tag++;
            foreach (Point item in list_white)
            {
                bmp.SetPixel(item.X, item.Y, Color.Red);
            }
            return bmp;
        }


        #region 线性处理

    

        /// <summary>
        /// 该函数用于对图像进行腐蚀运算。结构元素为水平方向或垂直方向的三个点，
        /// 中间点位于原点；或者由用户自己定义3×3的结构元素。
        /// </summary>
        /// <param name="dgGrayValue">前后景临界值</param>
        /// <param name="nMode">腐蚀方式：0表示水平方向，1垂直方向，2自定义结构元素。</param>
        /// <param name="structure"> 自定义的3×3结构元素</param>
        public static  void ErosionPic(Bitmap bmpobj,int dgGrayValue, int nMode, bool[,] structure)
        {
            int lWidth = bmpobj.Width;
            int lHeight = bmpobj.Height;
            Bitmap newBmp = new Bitmap(lWidth, lHeight);

            int i, j, n, m;            //循环变量

            if (nMode == 0)
            {
                //使用水平方向的结构元素进行腐蚀
                // 由于使用1×3的结构元素，为防止越界，所以不处理最左边和最右边
                // 的两列像素
                for (j = 0; j < lHeight; j++)
                {
                    for (i = 1; i < lWidth - 1; i++)
                    {
                        //目标图像中的当前点先赋成黑色
                        newBmp.SetPixel(i, j, Color.Black);

                        //如果源图像中当前点自身或者左右有一个点不是黑色，
                        //则将目标图像中的当前点赋成白色
                        if (bmpobj.GetPixel(i - 1, j).R > dgGrayValue ||
                           bmpobj.GetPixel(i, j).R > dgGrayValue ||
                           bmpobj.GetPixel(i + 1, j).R > dgGrayValue)
                            newBmp.SetPixel(i, j, Color.White);
                    }
                }
            }
            else if (nMode == 1)
            {
                //使用垂真方向的结构元素进行腐蚀
                // 由于使用3×1的结构元素，为防止越界，所以不处理最上边和最下边
                // 的两行像素
                for (j = 1; j < lHeight - 1; j++)
                {
                    for (i = 0; i < lWidth; i++)
                    {
                        //目标图像中的当前点先赋成黑色
                        newBmp.SetPixel(i, j, Color.Black);

                        //如果源图像中当前点自身或者左右有一个点不是黑色，
                        //则将目标图像中的当前点赋成白色
                        if (bmpobj.GetPixel(i, j - 1).R > dgGrayValue ||
                           bmpobj.GetPixel(i, j).R > dgGrayValue ||
                            bmpobj.GetPixel(i, j + 1).R > dgGrayValue)
                            newBmp.SetPixel(i, j, Color.White);
                    }
                }
            }
            else
            {
                if (structure.Length != 9)  //检查自定义结构
                    return;
                //使用自定义的结构元素进行腐蚀
                // 由于使用3×3的结构元素，为防止越界，所以不处理最左边和最右边
                // 的两列像素和最上边和最下边的两列像素
                for (j = 1; j < lHeight - 1; j++)
                {
                    for (i = 1; i < lWidth - 1; i++)
                    {
                        //目标图像中的当前点先赋成黑色
                        newBmp.SetPixel(i, j, Color.Black);
                        //如果原图像中对应结构元素中为黑色的那些点中有一个不是黑色，
                        //则将目标图像中的当前点赋成白色
                        for (m = 0; m < 3; m++)
                        {
                            for (n = 0; n < 3; n++)
                            {
                                if (!structure[m, n])
                                    continue;
                                if (bmpobj.GetPixel(i + m - 1, j + n - 1).R > dgGrayValue)
                                {
                                    newBmp.SetPixel(i, j, Color.White);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            bmpobj = newBmp;
        }

        /// <summary>
        /// 该函数用于对图像进行细化运算。要求目标图像为灰度图像
        /// </summary>
        /// <param name="dgGrayValue"></param>
        public static  void ThiningPic(Bitmap bmpobj,int dgGrayValue)
        {
            int lWidth = bmpobj.Width;
            int lHeight = bmpobj.Height;
            //   Bitmap newBmp = new Bitmap(lWidth, lHeight);

            bool bModified;            //脏标记    
            int i, j, n, m;            //循环变量

            //四个条件
            bool bCondition1;
            bool bCondition2;
            bool bCondition3;
            bool bCondition4;

            int nCount;    //计数器    
            int[,] neighbour = new int[5, 5];    //5×5相邻区域像素值

            bModified = true;
            while (bModified)
            {
                bModified = false;

                //由于使用5×5的结构元素，为防止越界，所以不处理外围的几行和几列像素
                for (j = 2; j < lHeight - 2; j++)
                {
                    for (i = 2; i < lWidth - 2; i++)
                    {
                        bCondition1 = false;
                        bCondition2 = false;
                        bCondition3 = false;
                        bCondition4 = false;

                        if (bmpobj.GetPixel(i, j).R > dgGrayValue)
                        {
                            if (bmpobj.GetPixel(i, j).R < 255)
                                bmpobj.SetPixel(i, j, Color.White);
                            continue;
                        }

                        //获得当前点相邻的5×5区域内像素值，白色用0代表，黑色用1代表
                        for (m = 0; m < 5; m++)
                        {
                            for (n = 0; n < 5; n++)
                            {
                                neighbour[m, n] = bmpobj.GetPixel(i + m - 2, j + n - 2).R < dgGrayValue ? 1 : 0;
                            }
                        }

                        //逐个判断条件。
                        //判断2<=NZ(P1)<=6
                        nCount = neighbour[1, 1] + neighbour[1, 2] + neighbour[1, 3]
                               + neighbour[2, 1] + neighbour[2, 3] +
                                +neighbour[3, 1] + neighbour[3, 2] + neighbour[3, 3];
                        if (nCount >= 2 && nCount <= 6)
                        {
                            bCondition1 = true;
                        }

                        //判断Z0(P1)=1
                        nCount = 0;
                        if (neighbour[1, 2] == 0 && neighbour[1, 1] == 1)
                            nCount++;
                        if (neighbour[1, 1] == 0 && neighbour[2, 1] == 1)
                            nCount++;
                        if (neighbour[2, 1] == 0 && neighbour[3, 1] == 1)
                            nCount++;
                        if (neighbour[3, 1] == 0 && neighbour[3, 2] == 1)
                            nCount++;
                        if (neighbour[3, 2] == 0 && neighbour[3, 3] == 1)
                            nCount++;
                        if (neighbour[3, 3] == 0 && neighbour[2, 3] == 1)
                            nCount++;
                        if (neighbour[2, 3] == 0 && neighbour[1, 3] == 1)
                            nCount++;
                        if (neighbour[1, 3] == 0 && neighbour[1, 2] == 1)
                            nCount++;
                        if (nCount == 1)
                            bCondition2 = true;

                        //判断P2*P4*P8=0 or Z0(p2)!=1
                        if (neighbour[1, 2] * neighbour[2, 1] * neighbour[2, 3] == 0)
                        {
                            bCondition3 = true;
                        }
                        else
                        {
                            nCount = 0;
                            if (neighbour[0, 2] == 0 && neighbour[0, 1] == 1)
                                nCount++;
                            if (neighbour[0, 1] == 0 && neighbour[1, 1] == 1)
                                nCount++;
                            if (neighbour[1, 1] == 0 && neighbour[2, 1] == 1)
                                nCount++;
                            if (neighbour[2, 1] == 0 && neighbour[2, 2] == 1)
                                nCount++;
                            if (neighbour[2, 2] == 0 && neighbour[2, 3] == 1)
                                nCount++;
                            if (neighbour[2, 3] == 0 && neighbour[1, 3] == 1)
                                nCount++;
                            if (neighbour[1, 3] == 0 && neighbour[0, 3] == 1)
                                nCount++;
                            if (neighbour[0, 3] == 0 && neighbour[0, 2] == 1)
                                nCount++;
                            if (nCount != 1)
                                bCondition3 = true;
                        }

                        //判断P2*P4*P6=0 or Z0(p4)!=1
                        if (neighbour[1, 2] * neighbour[2, 1] * neighbour[3, 2] == 0)
                        {
                            bCondition4 = true;
                        }
                        else
                        {
                            nCount = 0;
                            if (neighbour[1, 1] == 0 && neighbour[1, 0] == 1)
                                nCount++;
                            if (neighbour[1, 0] == 0 && neighbour[2, 0] == 1)
                                nCount++;
                            if (neighbour[2, 0] == 0 && neighbour[3, 0] == 1)
                                nCount++;
                            if (neighbour[3, 0] == 0 && neighbour[3, 1] == 1)
                                nCount++;
                            if (neighbour[3, 1] == 0 && neighbour[3, 2] == 1)
                                nCount++;
                            if (neighbour[3, 2] == 0 && neighbour[2, 2] == 1)
                                nCount++;
                            if (neighbour[2, 2] == 0 && neighbour[1, 2] == 1)
                                nCount++;
                            if (neighbour[1, 2] == 0 && neighbour[1, 1] == 1)
                                nCount++;
                            if (nCount != 1)
                                bCondition4 = true;
                        }

                        if (bCondition1 && bCondition2 && bCondition3 && bCondition4)
                        {
                            bmpobj.SetPixel(i, j, Color.White);
                            bModified = true;
                        }
                        else
                        {
                            bmpobj.SetPixel(i, j, Color.Black);
                        }
                    }
                }
            }
            // 复制细化后的图像
            //    bmpobj = newBmp;
        }

        /// <summary>
        /// 锐化要启用不安全代码编译
        /// </summary>
        /// <param name="val">锐化程度。取值[0,1]。值越大锐化程度越高</param>
        /// <returns>锐化后的图像</returns>
        public static  void Sharpen(Bitmap bmpobj,float val)
        {
            int w = bmpobj.Width;
            int h = bmpobj.Height;
            Bitmap bmpRtn = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            BitmapData srcData = bmpobj.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData dstData = bmpRtn.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* pIn = (byte*)srcData.Scan0.ToPointer();
                byte* pOut = (byte*)dstData.Scan0.ToPointer();
                int stride = srcData.Stride;
                byte* p;

                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        //取周围9点的值。位于边缘上的点不做改变。
                        if (x == 0 || x == w - 1 || y == 0 || y == h - 1)
                        {
                            //不做
                            pOut[0] = pIn[0];
                            pOut[1] = pIn[1];
                            pOut[2] = pIn[2];
                        }
                        else
                        {
                            int r1, r2, r3, r4, r5, r6, r7, r8, r0;
                            int g1, g2, g3, g4, g5, g6, g7, g8, g0;
                            int b1, b2, b3, b4, b5, b6, b7, b8, b0;

                            float vR, vG, vB;

                            //左上
                            p = pIn - stride - 3;
                            r1 = p[2];
                            g1 = p[1];
                            b1 = p[0];

                            //正上
                            p = pIn - stride;
                            r2 = p[2];
                            g2 = p[1];
                            b2 = p[0];

                            //右上
                            p = pIn - stride + 3;
                            r3 = p[2];
                            g3 = p[1];
                            b3 = p[0];

                            //左侧
                            p = pIn - 3;
                            r4 = p[2];
                            g4 = p[1];
                            b4 = p[0];

                            //右侧
                            p = pIn + 3;
                            r5 = p[2];
                            g5 = p[1];
                            b5 = p[0];

                            //右下
                            p = pIn + stride - 3;
                            r6 = p[2];
                            g6 = p[1];
                            b6 = p[0];

                            //正下
                            p = pIn + stride;
                            r7 = p[2];
                            g7 = p[1];
                            b7 = p[0];

                            //右下
                            p = pIn + stride + 3;
                            r8 = p[2];
                            g8 = p[1];
                            b8 = p[0];

                            //自己
                            p = pIn;
                            r0 = p[2];
                            g0 = p[1];
                            b0 = p[0];

                            vR = (float)r0 - (float)(r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8) / 8;
                            vG = (float)g0 - (float)(g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8) / 8;
                            vB = (float)b0 - (float)(b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8) / 8;

                            vR = r0 + vR * val;
                            vG = g0 + vG * val;
                            vB = b0 + vB * val;

                            if (vR > 0)
                            {
                                vR = Math.Min(255, vR);
                            }
                            else
                            {
                                vR = Math.Max(0, vR);
                            }

                            if (vG > 0)
                            {
                                vG = Math.Min(255, vG);
                            }
                            else
                            {
                                vG = Math.Max(0, vG);
                            }

                            if (vB > 0)
                            {
                                vB = Math.Min(255, vB);
                            }
                            else
                            {
                                vB = Math.Max(0, vB);
                            }

                            pOut[0] = (byte)vB;
                            pOut[1] = (byte)vG;
                            pOut[2] = (byte)vR;
                        }
                        pIn += 3;
                        pOut += 3;
                    }// end of x
                    pIn += srcData.Stride - w * 3;
                    pOut += srcData.Stride - w * 3;
                } // end of y
            }
            bmpobj.UnlockBits(srcData);
            bmpRtn.UnlockBits(dstData);
            bmpobj = bmpRtn;
        }

        #endregion 



        #region 内部处理

        private static int getMidColor(List<int> listcoint)
        {
            int[] cons = listcoint.ToArray();
            int tmp = -1;
            bool doublecon = (cons.Length % 2 == 0);
            for (int i = 0; i <= cons.Length / 2; i++)
            {
                for (int j = i + 1; j < cons.Length; j++)
                {
                    if (cons[i] > cons[j])
                    {
                        tmp = cons[i];
                        cons[i] = cons[j];
                        cons[j] = tmp;
                    }
                }
            }
            if (doublecon)
            {
                tmp = cons[cons.Length / 2] + cons[cons.Length / 2 - 1];
                tmp = tmp / 2;
            }
            else
            {
                tmp = cons[cons.Length / 2];
            }
            return tmp;
        }

        private static int getAveColor(List<int> listcoint)
        {
            int[] cons = listcoint.ToArray();
            int sum = cons.Sum();
            sum = sum / cons.Length;
            return sum;
        }

        /// <summary>
        /// 种子法
        /// </summary>
        /// <param name="img"></param>
        /// <param name="regions"></param>
        /// <param name="x"></param>
        /// <param name="tag"></param>
        /// <param name="findblack"></param>
        /// <returns></returns>
        private static List<Point> getneib(int [,] img, int[,] regions, Point x, int tag,bool findblack=true )
        {
            List<Point> list_pretocheck = new List<Point>();
            List<Point> list_p = new List<Point>();
            list_p.Add(x);
            regions[x.X, x.Y] = tag;
            int coint = findblack ? 0 : 255;
            int width = img.GetLength (0);
            int height = img.GetLength(1);
            bool l = x.X - 1 >= 0, r = x.X + 1 < width, u = x.Y - 1 >= 0, d = x.Y + 1 < height;
            //左列
            if (l)
            {
                if (img[x.X - 1, x.Y] == coint  && regions[x.X - 1, x.Y] == 0)
                {
                    list_pretocheck.Add(new Point(x.X - 1, x.Y ));
                }
                if (u)
                {
                    if (img[x.X - 1, x.Y - 1] == coint && regions[x.X - 1, x.Y - 1] == 0)
                    {
                        list_pretocheck.Add(new Point(x.X - 1, x.Y - 1));
                    }
                }
                if (d)
                {
                    if (img[x.X - 1, x.Y + 1]== coint && regions[x.X - 1, x.Y + 1] == 0)
                    {
                        list_pretocheck.Add(new Point(x.X - 1, x.Y + 1));
                    }
                }
            }
            //右列
            if (r)
            {
                if (img[x.X + 1, x.Y] == coint && regions[x.X + 1, x.Y] == 0)
                {
                    list_pretocheck.Add(new Point(x.X + 1, x.Y  ));
                }
                if (u)
                {
                    if (img[x.X + 1, x.Y - 1] == coint && regions[x.X + 1, x.Y - 1] == 0)
                    {
                        list_pretocheck.Add(new Point(x.X + 1, x.Y - 1));
                    }
                }
                if (d)
                {
                    if (img[x.X + 1, x.Y + 1] == coint && regions[x.X + 1, x.Y + 1] == 0)
                    {
                        list_pretocheck.Add(new Point(x.X+1, x.Y + 1));
                    }
                }
            }
            //中间
            if (u)
            {
                if (img[x.X, x.Y - 1] == coint && regions[x.X, x.Y - 1] == 0)
                {
                    list_pretocheck.Add(new Point(x.X, x.Y - 1));
                }

            }
            if (d)
            {
                if (img[x.X, x.Y + 1] == coint && regions[x.X, x.Y + 1] == 0)
                {
                    list_pretocheck.Add(new Point (x.X ,x.Y +1));
                }
            }
            for (int i = 0; i < list_pretocheck .Count ; i++)
            {
                list_p.AddRange(getneib(img, regions, list_pretocheck [i], tag, findblack));
            }
            return list_p;
        }




        /// <summary>
        /// 将图像以像素为单位放大指定倍数
        /// </summary>
        /// <param name="img">源图</param>
        /// <param name="mul">倍数</param>
        /// <returns></returns>
        public static Bitmap getBig(Bitmap img, ref int mul,int widthmax,int heightmax, bool lines = true, Rectangle[] rects = null)
        {
            if (mul == -1)
            {
                //700,250
                //557, 216
                int wmul = 1;
                int hmul = 1;
                wmul = widthmax / img.Width;
                hmul = heightmax / img.Height;
                mul = wmul > hmul ? hmul : wmul;
            }
            Bitmap bigimg = new Bitmap(img.Width * mul, img.Height * mul);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color s = img.GetPixel(i, j);
                    int x = i * mul;
                    int y = j * mul;
                    for (int ii = 0; ii < mul; ii++)
                    {
                        for (int jj = 0; jj < mul; jj++)
                        {
                            bigimg.SetPixel(x + ii, y + jj, s);
                        }
                    }
                }
            }
            Graphics gbmp = Graphics.FromImage(bigimg);

            //网格笔
            Pen penline = new Pen(Color.Black);
            if (lines)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    gbmp.DrawLine(penline, i * mul, 0, i * mul, bigimg.Height);
                }
                for (int j = 0; j < img.Height; j++)
                {
                    gbmp.DrawLine(penline, 0, j * mul, bigimg.Width, j * mul);
                }
            }
            //分割笔
            if (rects != null)
            {
                for (int i = 0; i < rects.Length; i++)
                {
                    gbmp.DrawRectangle(new Pen(Color.Blue, 2), rects[i].X * mul, rects[i].Y * mul, rects[i].Width * mul - 1, rects[i].Height * mul - 1);
                }
            }
            return bigimg;
        }


        public static Bitmap getSmall(Bitmap img, int mul)
        {
            //180;70-----9060
            Bitmap bigimg = new Bitmap(img.Width / mul, img.Height / mul);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color s = img.GetPixel(i, j);
                    int x = i * mul;
                    int y = j * mul;
                    for (int ii = 0; ii < mul; ii++)
                    {
                        for (int jj = 0; jj < mul; jj++)
                        {
                            bigimg.SetPixel(x + ii, y + jj, s);
                        }
                    }
                }
            }
            return bigimg;
        }

        /// <summary>
        /// 根据RGB，计算灰度值
        /// </summary>
        /// <param name="posClr">Color值</param>
        /// <returns>灰度值，整型</returns>
        private static int GetGrayNumColor(System.Drawing.Color posClr)
        {
            return (posClr.R * 19595 + posClr.G * 38469 + posClr.B * 7472) >> 16;
        }


        /// <summary>
        /// 会产生graphics异常的PixelFormat
        /// </summary>
        private PixelFormat[] indexedPixelFormats = { PixelFormat.Undefined, PixelFormat.DontCare,
                                PixelFormat.Format16bppArgb1555, PixelFormat.Format1bppIndexed, PixelFormat.Format4bppIndexed,
                                PixelFormat.Format8bppIndexed
                                };


        /// <summary>
        /// 判断图片的PixelFormat 是否在 引发异常的 PixelFormat 之中
        /// </summary>
        /// <param name="imgPixelFormat">原图片的PixelFormat</param>
        /// <returns></returns>
        private bool IsPixelFormatIndexed(PixelFormat imgPixelFormat)
        {
            foreach (PixelFormat pf in indexedPixelFormats)
            {
                if (pf.Equals(imgPixelFormat)) return true;
            }

            return false;
        }

        #endregion
    }
}



