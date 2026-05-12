using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_2026
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] number = new int[10];
                number[0] = 1 ;
                number[1] = 2 ;
                MessageBox.Show(number[10].ToString());
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                int sum = a+b;
                label3.Text = sum.ToString();
            }catch(System.FormatException ex)
            {
                MessageBox.Show(ex.Message+"輸入的不可以是標點符號，請輸入整數");
            }catch(IndexOutOfRangeException ex) 
            {
                MessageBox.Show(ex.Message+"宣告陣列爆掉了");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"輸入有問題，但我不知道哪裡錯了");
            }
        }
    }
}
