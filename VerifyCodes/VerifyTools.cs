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
                    Color newColor = value > average ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255,

255, 255);
                    userBmp.SetPixel(i, j, newColor);
                }
            }
            return userBmp;
        }



        /// <summary>
        /// 需灰度图
        /// 去除白边
        /// </summary>
        /// <param name="dgGrayValue">灰度背景分界值</param>
        /// <returns></returns>
        public static Bitmap ClearEdge(Bitmap userBmp, int dgGrayValue)
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
        public void ClearEdge(Bitmap bmpobj,int dgGrayValue, int CharsCount)
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


        public static Bitmap getRectBmp(Bitmap srcbmp, Rectangle rect)
        {
            Bitmap bmp = (Bitmap)srcbmp.Clone();

            Rectangle rectc = new Rectangle(rect.X, rect.Y, rect.Width + 1, rect.Height + 1);
            bmp = bmp.Clone(rect, bmp.PixelFormat);
            return bmp;

        }


        /// <summary>
        /// 获取图像区域        提取连通分量法
        /// </summary>
        /// <returns></returns>
        public static Rectangle[] getRegions(Bitmap userBmp, int lside = 1)
        {
            List<List<Point>> list_regions = new List<List<Point>>();
            List<Rectangle> list_bt = new List<Rectangle>();
            Bitmap img = (Bitmap)userBmp.Clone();
            /// <summary>
            /// 分割框位置信息
            /// </summary>
            int[,] regions = null;


            regions = new int[img.Width, img.Height];
            list_regions = new List<List<Point>>();
            int tag = 1;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    regions[i, j] = 0;
                }
            }
            for (var x = 0; x < img.Width; x++)
            {
                for (var y = 0; y < img.Height; y++)
                {
                    Color c;
                    if (((c = img.GetPixel(x, y)) == Color.FromArgb(0, 0, 0)) && regions[x, y] == 0)
                    {
                        list_regions.Add(getneib(img, regions, new Point(x, y), tag));
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
        /// 需要二值化图片
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



        #region 线性处理

        /// <summary>
        /// 霓虹处理
        /// </summary>
        /// <param name="bmpobj"></param>
        /// <returns></returns>
        public static Bitmap neonPic(Bitmap bmpobj)
        {
            Bitmap bmpnew = new Bitmap(bmpobj.Width ,bmpobj.Height );
            for (int i = 0; i < bmpobj.Width-1 ; i++)
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

                    bmpnew.SetPixel(i,j,Color.FromArgb (r,g,b));

                }
            }
            return bmpnew;
        }

        public static Bitmap getBlackPic(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height ; j++)
                {
                    Color c = bmp .GetPixel(i, j);
                    bmp.SetPixel(i, j, c.B == 255 ? Color.White  : Color.Black );
                    //showbmp = VerifyTools.getBig(prebmp, ref mul);
                }
            }
            return bmp;
        }

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

        private static List<Point> getneib(Bitmap img, int[,] regions, Point x, int tag)
        {
            List<Point> list_p = new List<Point>();
            list_p.Add(x);
            regions[x.X, x.Y] = tag;
            bool l = x.X - 1 >= 0, r = x.X + 1 < img.Width, u = x.Y - 1 >= 0, d = x.Y + 1 < img.Height;
            //左列
            if (l)
            {
                if (img.GetPixel(x.X - 1, x.Y) == Color.FromArgb(0, 0, 0) && regions[x.X - 1, x.Y] == 0)
                {
                    list_p.AddRange(getneib(img, regions, new Point(x.X - 1, x.Y), tag));
                }
                if (u)
                {
                    if (img.GetPixel(x.X - 1, x.Y - 1) == Color.FromArgb(0, 0, 0) && regions[x.X - 1, x.Y - 1] == 0)
                    {
                        list_p.AddRange(getneib(img, regions, new Point(x.X - 1, x.Y - 1), tag));
                    }
                }
                if (d)
                {
                    if (img.GetPixel(x.X - 1, x.Y + 1) == Color.FromArgb(0, 0, 0) && regions[x.X - 1, x.Y + 1] == 0)
                    {
                        list_p.AddRange(getneib(img, regions, new Point(x.X - 1, x.Y + 1), tag));
                    }
                }
            }
            //右列
            if (r)
            {
                if (img.GetPixel(x.X + 1, x.Y) == Color.FromArgb(0, 0, 0) && regions[x.X + 1, x.Y] == 0)
                {
                    list_p.AddRange(getneib(img, regions, new Point(x.X + 1, x.Y), tag));
                }
                if (u)
                {
                    if (img.GetPixel(x.X + 1, x.Y - 1) == Color.FromArgb(0, 0, 0) && regions[x.X + 1, x.Y - 1] == 0)
                    {
                        list_p.AddRange(getneib(img, regions, new Point(x.X + 1, x.Y - 1), tag));
                    }
                }
                if (d)
                {
                    if (img.GetPixel(x.X + 1, x.Y + 1) == Color.FromArgb(0, 0, 0) && regions[x.X + 1, x.Y + 1] == 0)
                    {
                        list_p.AddRange(getneib(img, regions, new Point(x.X + 1, x.Y + 1), tag));
                    }
                }
            }
            //中间
            if (u)
            {
                if (img.GetPixel(x.X, x.Y - 1) == Color.FromArgb(0, 0, 0) && regions[x.X, x.Y - 1] == 0)
                {
                    list_p.AddRange(getneib(img, regions, new Point(x.X, x.Y - 1), tag));
                }

            }
            if (d)
            {
                if (img.GetPixel(x.X, x.Y + 1) == Color.FromArgb(0, 0, 0) && regions[x.X, x.Y + 1] == 0)
                {
                    list_p.AddRange(getneib(img, regions, new Point(x.X, x.Y + 1), tag));
                }
            }
            return list_p;
        }


        /// <summary>
        /// 将图像以像素为单位放大指定倍数
        /// </summary>
        /// <param name="img">源图</param>
        /// <param name="mul">倍数</param>
        /// <returns></returns>
        public static Bitmap getBig(Bitmap img, ref int mul, bool lines = true, Rectangle[] rects = null)
        {
            if (mul == -1)
            {
                //700,250
                int wmul = 1;
                int hmul = 1;
                wmul = 700 / img.Width;
                hmul = 350 / img.Height;
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



