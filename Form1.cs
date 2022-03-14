using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch02_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(tbxprice.Text);   //金額
                int year = Convert.ToInt32(tbxyear.Text);   //年數
                double year_percent = Convert.ToDouble(tbxpercent.Text);     //年利率
                double d = Math.Pow((1 + year_percent / 12), year * 12);
                this.price.Text = "1. 貸款金額：" + $"{price}";
                percent.Text = "2. 年利率：" + $"{year_percent}";
                this.year.Text = "3. 年數：" + $"{year}";
                double miniprice = (d * (year_percent / 12)) / (d - 1);

                this.miniprice.Text = "4. 每月應還本息：" + $"{price * miniprice}";
            }
            catch
            {
                tip.Text="請輸入正確的數值";
                tbxprice.Clear();   //清除輸入的內容
                tbxyear.Clear();   //清除輸入的內容
                tbxpercent.Clear();   //清除輸入的內容
            }
            
        }
    }
}
