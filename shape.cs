using System;

namespace Geometry_Calculator
{
    public partial class Form1 : Form
    {
        private double trianglebase;
        private double base1;
        private double base2;
        private double rectanglelength;
        private double parallelogrambase;
        private double pi = 3.1415926535897931;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parallelogram_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter the base of the Parallelogram";
            
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter The Radius:";
            
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter the length of the Rectangle";
            
        }

        private void Trapezoid_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter base 1 of the Trapezoid";
            
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter the base of the Triangle";
            
        }

        private void Square_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter The Side Length";
            
        }

        private void b5_Click_1(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "5";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "5";
            }
        }

        private void b6_Click_1(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "6";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "6";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "0";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "0";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "1";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "2";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "3";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "4";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "4";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "7";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "8";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "9";
            }
            else
            {
                ResultBox.Text = ResultBox.Text + "9";
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            textBox1.Text = "Area Calculator: Select a Shape!";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "Enter The Side Length")
            {
                double side = Convert.ToDouble(ResultBox.Text);
                textBox1.Text = "The Area of the Square is:";
                ResultBox.Text = Convert.ToString(side * side);
            }
            else if(textBox1.Text == "Enter the base of the Triangle")
            {
                trianglebase = Convert.ToDouble(ResultBox.Text);
                ResultBox.Text = "";
                textBox1.Text = "Enter the height of the Triangle";

                
            }
            else if (textBox1.Text == "Enter the height of the Triangle")
            {
                
                
                double triangleheight = Convert.ToDouble(ResultBox.Text);

                textBox1.Text = "The Area of the Triangle is";

                ResultBox.Text = Convert.ToString((trianglebase * triangleheight) / 2);
            }


            else if (textBox1.Text == "Enter base 1 of the Trapezoid")
            {
                base1 = Convert.ToDouble(ResultBox.Text);
                ResultBox.Text = "";
                textBox1.Text = "Enter base 2 of the Trapezoid";


            }
            else if (textBox1.Text == "Enter base 2 of the Trapezoid")
            {


                base2 = Convert.ToDouble(ResultBox.Text);

                

                ResultBox.Text = "";

                textBox1.Text = "Enter the height of the Trapezoid";
            }
            else if(textBox1.Text == "Enter the height of the Trapezoid")
            {
                double height = Convert.ToDouble(ResultBox.Text);
                textBox1.Text = "The Area Of The Trapezoid is";
                ResultBox.Text = Convert.ToString(((base1 + base2) / 2) * height);
            }
            else if (textBox1.Text == "Enter the length of the Rectangle")
            {
                rectanglelength = Convert.ToDouble(ResultBox.Text);
                ResultBox.Text = "";
                textBox1.Text = "Enter the width of the Rectangle";


            }
            else if (textBox1.Text == "Enter the width of the Rectangle")
            {


                double rectanglewidth = Convert.ToDouble(ResultBox.Text);

                textBox1.Text = "The Area of the Rectangle is";

                ResultBox.Text = Convert.ToString(rectanglewidth*rectanglelength);
            }
            else if (textBox1.Text == "Enter the base of the Parallelogram")
            {
                parallelogrambase = Convert.ToDouble(ResultBox.Text);
                ResultBox.Text = "";
                textBox1.Text = "Enter the height of the Parallelogram";


            }
            else if (textBox1.Text == "Enter the height of the Parallelogram")
            {


                double parallelogramheight = Convert.ToDouble(ResultBox.Text);

                textBox1.Text = "The Area of the Parallelogram is";

                ResultBox.Text = Convert.ToString(parallelogrambase*parallelogramheight);
            }
            else if (textBox1.Text == "Enter The Radius:")
            {
                double radius = Convert.ToDouble(ResultBox.Text);
                textBox1.Text = "The Area of the Circle is:";
                ResultBox.Text = Convert.ToString((radius*radius)*pi);
            }
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            ResultBox.Text = ResultBox.Text + ".";
        }

        private void bsep_Click(object sender, EventArgs e)
        {
            ResultBox.Text = ResultBox.Text + "/";
        }
    }
}
