using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationRule
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //定义全局变量
        Random rdm = new Random();
        int num_1, num_2, result, input, WorkNum = 1;//乘数1，乘数2，结果，输入的结果，题号数

        private void one_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "1";
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "2";
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "3";
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "4";
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "5";
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "6";
        }
        
        private void seven_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "7";
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "8";
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "9";
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text += "0";
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //改变全局变量的值（生成第一组随机数）
            num_1 = rdm.Next(1, 9);
            num_2 = rdm.Next(1, 9);
            result = num_1 * num_2;

            //把int数字转成String显示出来
            num_1_lbl.Text = num_1.ToString();
            num_2_lbl.Text = num_2.ToString();

            WorkNum_lbl.Text = "题数 " + WorkNum.ToString();

        }

        private void NewWork_btn_Click(object sender, EventArgs e)
        {
            //生成新的一组随机数
            num_1 = rdm.Next(1, 9);
            num_2 = rdm.Next(1, 9);
            result = num_1 * num_2;

            num_1_lbl.Text = num_1.ToString();
            num_2_lbl.Text = num_2.ToString();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                input = int.Parse(input_textbox.Text);
                if (input == result)
                {
                    MessageBox.Show("正确！","提示");

                    //生成新的一组随机数
                    num_1 = rdm.Next(1, 9);
                    num_2 = rdm.Next(1, 9);
                    result = num_1 * num_2;

                    num_1_lbl.Text = num_1.ToString();
                    num_2_lbl.Text = num_2.ToString();

                    //题数加一再显示出来
                    WorkNum++;
                    WorkNum_lbl.Text = "题数 " + WorkNum.ToString();

                    input_textbox.Text = "";
                }
                else if(input != result)//只有if(input != result)会发生错误
                {
                    MessageBox.Show("错误！\n\n"+num_1+"×"+num_2+"="+result,"提示");

                    input_textbox.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("您的输入有误或为空，请检查核对后重新输入","提示");

                input_textbox.Text = "";
            }
        }
    }
}
