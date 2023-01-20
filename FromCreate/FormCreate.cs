using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Create;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace FromCreate
{
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }
        Homework01Entities HW = new Homework01Entities();
        System.Drawing.Image ima;
        private void button1_Click(object sender, EventArgs e)
        {
            CreateSql sql = new CreateSql();
            if (!Regex.IsMatch(txbAccount.Text, "^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$"))
            {
                lbAccount.Text = "請輸入正確信箱格式";
                txbAccount.Clear();
                return;
            }
            if (!Regex.IsMatch(txbPassword.Text, "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,12}$"))
            {
                lbPassword.Text = "請輸入正確密碼格式";
                txbPassword.Clear();
                return;
            }

            Teat2 teat2 = new Teat2();
            teat2.Account = txbAccount.Text;
            teat2.Password = txbPassword.Text;
            teat2.Datetime = dateTimePicker1.Value;
            teat2.Image = sql.ImageToBytes(pictureBox1.Image);

            HW.Teat2.Add(teat2);
            HW.SaveChanges();
            txbAccount.Clear();
            txbPassword.Clear();
            MessageBox.Show("創建成功");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "All Files|*.*";

            openFileDialog1.ShowDialog();

            ima = new Bitmap(openFileDialog1.FileName);

            this.pictureBox1.Image = ima;

        }
    }
}
