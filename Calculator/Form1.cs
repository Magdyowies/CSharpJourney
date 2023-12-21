using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ScientificCalculator : Form
    {
        double n1, n2, res;
        string pro;
        public ScientificCalculator()
        {
            InitializeComponent();
        }

        private void pro_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            n1= Convert.ToDouble(lb_result.Text);
            pro=btn.Text;
            if (lb_calculating.Text != null)

            {

                lb_calculating.Text = lb_calculating.Text + pro;
            }
            else { lb_calculating.Text = lb_result.Text+pro; }
            lb_result.Text = "";


            
        
        }

        private void pro_click_special(object sender, EventArgs e)
        {
            Button btn= (Button)sender;
            n1 = Convert.ToDouble(lb_result.Text);
            pro= btn.Text;
            lb_calculating.Text = pro + lb_calculating.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(lb_result.Text);
            switch (pro)
            {
                case "+":
                    res = n1 + n2;
                    lb_result.Text = Convert.ToString(res);

                    break;
                case "-":
                    res = n1 - n2;
                    lb_result.Text = Convert.ToString(res);

                    break;
                case "*":
                    res = n1 * n2;
                    lb_result.Text = Convert.ToString(res);

                    break;
                case "/":
                    res = n1 / n2;
                    lb_result.Text = Convert.ToString(res);

                    break;
                case "%":
                    res = n1 % n2;
                    lb_result.Text = Convert.ToString(res);

                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
            lb_calculating.Text = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lb_result.Text = null;

            lb_calculating.Text = null;
            n1=0;n2 = 0;res = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lb_result.Text == "0")
            {
                lb_result.Text = "";
                lb_result.Text = lb_result.Text + btn.Text;

            }
            else {

                lb_result.Text = lb_result.Text + btn.Text;
           
            
            }
            if (lb_calculating.Text != null)
            {
                lb_calculating.Text = lb_calculating.Text + btn.Text;
            }
            else {
                lb_calculating.Text = lb_result.Text;
            }
            

        }
    }
}
