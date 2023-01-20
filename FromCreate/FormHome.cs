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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        Homework01Entities HW = new Homework01Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            FormCreate frm = new FormCreate();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                var teat = from c in HW.Teat2
                           select c;
                dataGridView1.DataSource = teat.ToList();
            }
            else
            {
                var teat = from c in HW.Teat2
                           where c.Account.Contains(textBox1.Text)
                           select c;
                dataGridView1.DataSource = teat.ToList();
            }
        }
    }
}
