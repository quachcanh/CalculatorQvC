using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhCalculator
{
    public partial class fMain : Form
    {

        Double giatri = 0;
        string pheptinh = "";
        bool check = false; // Check xem có nhập đủ giá trị hay chưa?
        public fMain()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {

            if ((txtManHinh.Text == "0") || (check))
                txtManHinh.Clear();

            check = false;
            Button b = (Button)sender;
            if(b.Text == ".")
            {
                if (!txtManHinh.Text.Contains("."))
                {
                    txtManHinh.Text = txtManHinh.Text + b.Text;
                }
            }
            else
            {
                txtManHinh.Text = txtManHinh.Text + b.Text;
            }
            

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(giatri != 0)
            {
                btnDauBang.PerformClick();
                check = true;
                pheptinh = b.Text;
                label1.Text = giatri + " " + pheptinh;
            }
            else
            {
                pheptinh = b.Text;
                giatri = Double.Parse(txtManHinh.Text);
                check = true;
                label1.Text = giatri + " " + pheptinh;
            }
            

        }


        private void btnDauBang_Click(object sender, EventArgs e)
        {

            
            label1.Text = "";
            switch (pheptinh)
            {
                case "+":
                    txtManHinh.Text = (giatri + Double.Parse(txtManHinh.Text)).ToString();
                    break;
                case "-":
                    txtManHinh.Text = (giatri - Double.Parse(txtManHinh.Text)).ToString();
                    break;
                case "*":
                    txtManHinh.Text = (giatri * Double.Parse(txtManHinh.Text)).ToString();
                    break;
                case "/":
                    txtManHinh.Text = (giatri / Double.Parse(txtManHinh.Text)).ToString();
                    break;
                default:
                    break;
            }
            giatri = Int32.Parse(txtManHinh.Text);
            pheptinh = "";
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";
            giatri = 0;
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnDauCong.PerformClick();
                    break;
                case "-":
                    btnDauTru.PerformClick();
                    break;
                case "*":
                    btnDauNhan.PerformClick();
                    break;
                case "/":
                    btnDauChia.PerformClick();
                    break;
                case "=":
                    btnDauBang.PerformClick();
                    break;
                case ".":
                    btnDauCham.PerformClick();
                    break;
                case "ENTER":
                    btnDauBang.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
