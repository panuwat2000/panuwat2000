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
    public partial class UserControl1 : UserControl
    {
        double allpay;
        string vat;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox10.Text = Program.income.ToString(); 
            textBox9.Text = (Program.grop1 + Program.grop2 + Program.grop3 + Program.grop4 + Program.grop5).ToString(); //ภาษีที่สดหย่อน
            textBox8.Text = (Program.income - (Program.grop1 + Program.grop2 + Program.grop3 + Program.grop4 + Program.grop5)).ToString();
            double net = int.Parse(textBox8.Text);

            if (net >= 0 && net < 150000)
            {
                allpay = 0; //ค่าผลลัพธ  //เปรียบค่าบรรได เปรียบเทียบค่าว่าภาษีกี่ %
                vat = "0%";
            }
            else if (net > 150000 && net <= 300000)
            {
                allpay = net* 0.05;
                vat = "5%";
            }
            else if (net > 300000 && net <= 500000)
            {
                allpay = net  * 0.1 ; // 10/100
                vat = "10%";
            }
            else if (net > 500000 && net <= 750000)
            {
                allpay = net * 0.15 ;
                vat = "15%";
            }
            else if (net > 750000 && net <= 1000000)
            {
                allpay = net * 0.2 ;
                vat = "20%";
            }
            else if (net > 1000000 && net <= 2000000)
            {
                allpay = net * 0.25;
                vat = "25%";
            }
            else if (net > 2000000 && net <= 5000000)
            {
                allpay = net * 0.3 ;
                vat = "30%";
            }
            else if (net > 5000000)
            {
                allpay = net * 0.35  ;
                vat = "35%";
            }
            textBox7.Text = vat;
            textBox6.Text = allpay.ToString();
        }
    }
}
