﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int shop = int.Parse(numericUpDown1.Text); //ช้อปช่วยชาติ
            int karsuks1 = int.Parse(numericUpDown2.Text);//สินค้าการศึกและกีฬา
            int book = int.Parse(numericUpDown3.Text);//หนังสือ
            int otop = int.Parse(numericUpDown4.Text); //otop
            int mueang1 = int.Parse(numericUpDown5.Text);//หลัก
            int mueang2 = int.Parse(numericUpDown6.Text);//รอง
            int home = int.Parse(numericUpDown7.Text);//บ้าน
            int car = int.Parse(numericUpDown8.Text);//รถ
            int tot = int.Parse(textBox4.Text);//รายได้พึงประเมิน
            int total;//รายได้สุทธิ
            int tax;//ภาษีที่ลดหย่อนได้
            int i = 0;
            int j = 0;

            if ((mueang1 + mueang2) < 20000) //หลักกับรองบวกกับไม่เกิน2หมื่อน
            {
                i = (mueang1 + mueang2);
            }
            else if ((mueang1 + mueang2) > 20001) //ถ้าเกิน2เหทือนเดิม
            {
                i = 20000; //ลดหย่อนได้
            }
            if ((home + car) < 100000)//รถกับบ้านกับไม่เกิน1แสน
            {
                j = (home + car);
            }
            else if ((home + car) > 100001)
            {
                j = 100000;
            }

            tax = shop + karsuks1 + book + otop + i + j; //ภาษีที่ลดหย่อนได้
            Program.grop5 = tax;
            textBox5.Text = tax.ToString();

            total = tot - tax;
            textBox6.Text = total.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            total = Program.income;
            textBox4.Text = total.ToString();
        }
    }
}
