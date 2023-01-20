using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromCreate
{
    public partial class ImageTest : Form
    {
        public ImageTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image apple;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //宣告openFileDialog1

            openFileDialog1.Filter = "All Files|*.*";
            //設定可以開啟的檔案格式

            openFileDialog1.ShowDialog(); //SHOW出圖片囉


            apple = new Bitmap(openFileDialog1.FileName);
            //讓蘋果得到秀出圖片的資訊

            this.pictureBox1.Image = apple;
            //顯示apple在pictureBox1的框架內
        }
    }
}
