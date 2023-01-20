using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Homework01Entities HW = new Homework01Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            var t = from c in HW.Teat2
                    select c;

            dataGridView1.DataSource= t.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var date = new DateTime(1996, 08, 05);
            Teat2 teat= new Teat2();
            teat.Account = "bbb@yahoo.com";
            teat.Password= "b123456";
            teat.Datetime = date;
            
            HW.Teat2.Add(teat);
            HW.SaveChanges();
        }
    }
}
