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
    class VerifyCode
    {
        public VerifyCode(Bitmap bgm)
        {
            //防止Graphics操作异常
            if (IsPixelFormatIndexed(bgm.PixelFormat))
            {
                Bitmap img = new Bitmap(bgm.Width, bgm.Height, PixelFormat.Format32bppArgb);
                using (Graphics g1 = Graphics.FromImage(img ))
                {
                    g1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    g1.DrawImage(bgm , 0, 0);
                }
                bgm = img;
            }
            this.srcBmp = (Bitmap )bgm.Clone();
            //this.SrcBmpShow = (Bitmap)bgm.Clone();
            this.userBmp = (Bitmap)bgm.Clone();
            //this.userBmpShow = (Bitmap)bgm.Clone();
        }

        #region 变量
        /// <summary>
        /// 原始备份图片
        /// </summary>
        private Bitmap srcBmp = null;
    
        public Bitmap SrcBmpShow
        {
            get
            {
                srcShowMul = srcShowMul > 0 ? srcShowMul : 1;
                return getBig (srcBmp ,srcShowMul );
            }
        }

        public Bitmap UserBmpShow
        {
            get
            {
                userShowMul = userShowMul > 0 ? userShowMul : 1;
                Bitmap bmp = getBig(userBmp, userShowMul);
       
                if(drawRect)
                {
                    if (rectsChanged||rects ==null )
                    {
                        rects = getRegions();
                    }
                    Graphics gbmp = Graphics.FromImage(bmp);
                    int mul = userShowMul;
                    for (int i = 0; i < rects.Length; i++)
                    {
                        gbmp.DrawRectangle(new Pen(Color.Blue), rects[i].X * mul, rects[i].Y * mul, rects[i].Width * mul + mul - 1, rects[i].Height * mul + mul - 1);
                    }
                }
                return bmp ;
            }
        }

        /// <summary>
        /// 自动分割信息
        /// </summary>
        public RectangleF[] rects = null;

        /// <summary>
        /// 图像变化，需要重新分割
        /// </summary>
        private bool rectsChanged = true;

        /// <summary>
        /// 操作图片
        /// </summary>
        private Bitmap userBmp = null;

     

        /// <summary>
        /// 原始显示比例
        /// </summary>
        public  int srcShowMul = 1;
        /// <summary>
        /// 操作显示比例
        /// </summary>
        public int userShowMul = 10;

        /// <summary>
        /// 显示分割框
        /// </summary>
        public  bool drawRect = false;

        /// <summary>
        /// 分割框位置信息
        /// </summary>
        public int[,] regions = null;


        #endregion 变量

        public void SetImg(Bitmap bmg)
        {
            this.srcBmp = (Bitmap)bmg.Clone();
            this.reSet();
        }

        /// <summary>
        /// 灰度转换,逐像素
        /// </summary>
        public void GrayByPixels()
        {
            rectsChanged = true;
            for (int i = 0; i < userBmp .Height; i++)
            {
                for (int j = 0; j < userBmp.Width; j++)
                {
                    int tmpValue = GetGrayNumColor(userBmp.GetPixel(j, i));
                    userBmp.SetPixel(j, i, Color.FromArgb(tmpValue, tmpValue, tmpValue));
                }
            }
        }

        /// <summary>
        /// 需要灰度图前提
        /// 得到灰度图像前景背景的临界值 最大类间方差法
        /// </summary>
        /// <returns>前景背景的临界值</returns>
        public int GetDgGrayValue()
        {
            int[] pixelNum = new int[256];           //图象直方图，共256个点
            int n, n1, n2;
            int total;                              //total为总和，累计值
            double m1, m2, sum, csum, fmax, sb;     //sb为类间方差，fmax存储最大方差值
            int k, t, q;
            int threshValue = 1;                      // 阈值
            //生成直方图
            for (int i = 0; i < userBmp .Width; i++)
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
        public void ClearBlock(int l,int r,int u,int d)
        {
            rectsChanged = true;
            for (int i = 0; i < userBmp.Width ; i++)
            {
                for (int j = 0; j < userBmp.Height ; j++)
                {
                    if(i-l <0||i+r >=userBmp.Width ||j -u <0||j+d >=userBmp.Height)
                    {
                        userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
        }

        /// <summary>
        /// 需要灰度图
        /// 根据前后景临界灰度、杂点周围像素数，去除杂点【置白】，
        /// </summary>
        /// <param name="dgGrayValue">前后景临界灰度</param>
        /// <param name="MaxNearPoints">杂点周围像素数</param>
        public void ClearNoise(int dgGrayValue, int MaxNearPoints)
        {
            rectsChanged = true;
            Color piexl;
            int nearDots = 0;
            //逐点判断
            for (int i = 0; i < userBmp .Width; i++)
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
                        }

                        if (nearDots < MaxNearPoints)
                            userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));   //去掉单点 && 粗细小3邻边点
                    }
                    else  //背景
                        userBmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
        }


        /// <summary> 
        /// 需灰度图
        /// 图像二值化1：取图片的平均灰度作为阈值，低于该值的全都为0，高于该值的全都为255 
        /// </summary> 
        /// <param name="bmp"></param> 
        /// <returns></returns> 
        public void ConvertTo1Bpp(int fazhi = -1)
        {
            rectsChanged = true;
            Bitmap bmp = userBmp ;
            int average = fazhi;
            if (average == -1)
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        average += color.B;
                    }
                }
                average = (int)average / (bmp.Width * bmp.Height);
            }
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色 
                    Color color = bmp.GetPixel(i, j);
                    int value = 255 - color.B;
                    Color newColor = value > average ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255,

255, 255);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            userBmp = bmp;
        }



        /// <summary>
        /// 需灰度图
        /// 去除白边
        /// </summary>
        /// <param name="dgGrayValue">灰度背景分界值</param>
        /// <returns></returns>
        public void ClearEdge(int dgGrayValue)
        {
            rectsChanged = true;
            int posx1 = userBmp .Width; int posy1 = userBmp.Height;
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
        }


       
       
        /// <summary>
        /// 获取图像区域        提取连通分量法
        /// </summary>
        /// <returns></returns>
        public RectangleF[] getRegions()
        {
            List<List<Point>> regions = new List<List<Point>>();
            List<RectangleF> list_bt = new List<RectangleF>();
            Bitmap img = (Bitmap)this.userBmp.Clone();
            this.regions = new int[img.Width, img.Height];
            regions = new List<List<Point>>();
            int tag = 1;
            for (var x = 0; x < img.Width; x++)
            {
                for (var y = 0; y < img.Height; y++)
                {
                    Color c;
                    if (((c = img.GetPixel(x, y)) == Color.FromArgb(0, 0, 0)) && this.regions[x, y] == 0)
                    {
                        regions.Add(getneib(img, new Point(x, y), tag));
                        tag++;
                    }
                }
            }
            foreach (List<Point> item in regions)
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
                int h = right.Y - left.Y;
                int w = right.X - left.X;
                list_bt.Add(new RectangleF(left, new Size(w, h)));
            }
            return list_bt.ToArray();
        }

        /// <summary>
        /// 翻转图像
        /// </summary>
        public void reversal()
        {
            rectsChanged = true;
            for (var x = 0; x < userBmp .Width; x++)
            {
                for (var y = 0; y < userBmp.Height; y++)
                {
                    Color tmp = userBmp.GetPixel(x, y);
                    userBmp.SetPixel(x, y, Color.FromArgb(255 - tmp.R, 255 - tmp.G, 255 - tmp.B));

                }
            }
        }


        /// <summary>
        /// 重置图像
        /// </summary>
        public void reSet()
        {
            this.userBmp = (Bitmap)srcBmp .Clone();
        }



        #region 内部处理

        private List<Point> getneib(Bitmap img, Point x, int tag)
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
                    list_p.AddRange(getneib(img, new Point(x.X - 1, x.Y), tag));
                }
                if (u)
                {
                    if (img.GetPixel(x.X - 1, x.Y - 1) == Color.FromArgb(0, 0, 0) && regions[x.X - 1, x.Y - 1] == 0)
                    {
                        list_p.AddRange(getneib(img, new Point(x.X - 1, x.Y - 1), tag));
                    }
                }
                if (d)
                {
                    if (img.GetPixel(x.X - 1, x.Y + 1) == Color.FromArgb(0, 0, 0) && regions[x.X - 1, x.Y + 1] == 0)
                    {
                        list_p.AddRange(getneib(img, new Point(x.X - 1, x.Y + 1), tag));
                    }
                }
            }
            //右列
            if (r)
            {
                if (img.GetPixel(x.X + 1, x.Y) == Color.FromArgb(0, 0, 0) && regions[x.X + 1, x.Y] == 0)
                {
                    list_p.AddRange(getneib(img, new Point(x.X + 1, x.Y), tag));
                }
                if (u)
                {
                    if (img.GetPixel(x.X + 1, x.Y - 1) == Color.FromArgb(0, 0, 0) && regions[x.X + 1, x.Y - 1] == 0)
                    {
                        list_p.AddRange(getneib(img, new Point(x.X + 1, x.Y - 1), tag));
                    }
                }
                if (d)
                {
                    if (img.GetPixel(x.X + 1, x.Y + 1) == Color.FromArgb(0, 0, 0) && regions[x.X + 1, x.Y + 1] == 0)
                    {
                        list_p.AddRange(getneib(img, new Point(x.X + 1, x.Y + 1), tag));
                    }
                }
            }
            //中间
            if (u)
            {
                if (img.GetPixel(x.X, x.Y - 1) == Color.FromArgb(0, 0, 0) && regions[x.X, x.Y - 1] == 0)
                {
                    list_p.AddRange(getneib(img, new Point(x.X, x.Y - 1), tag));
                }

            }
            if (d)
            {
                if (img.GetPixel(x.X, x.Y + 1) == Color.FromArgb(0, 0, 0) && regions[x.X, x.Y + 1] == 0)
                {
                    list_p.AddRange(getneib(img, new Point(x.X, x.Y + 1), tag));
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
        private Bitmap getBig( Bitmap img, int mul)
        {       
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
            return bigimg;
        }

        /// <summary>
        /// 根据RGB，计算灰度值
        /// </summary>
        /// <param name="posClr">Color值</param>
        /// <returns>灰度值，整型</returns>
        private int GetGrayNumColor(System.Drawing.Color posClr)
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
