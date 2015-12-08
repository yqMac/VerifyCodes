using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerifyCodes
{
    public partial class FormMT : Form
    {
        public FormMT(Bitmap bmp)
        {
            InitializeComponent();
            srcbmp = (Bitmap )bmp.Clone ();
        }

        public Bitmap srcbmp;
        public Bitmap prebmp;
        public Bitmap showbmp;
        public Bitmap workbmp;
        public int mul=-1;
        private void loadPic()
        {
            if(srcbmp !=null)
            {
                prebmp = (Bitmap)srcbmp.Clone();
                mul = -1;
                picBox_small .Image = VerifyTools.getBig(srcbmp, ref mul, 233, 80, false);
                //showbmp  = VerifyTools.getBig(prebmp, ref mul, 560, 250);

            }
        }

        private void FormMT_Load(object sender, EventArgs e)
        {
            loadPic();
        }
    }
}
