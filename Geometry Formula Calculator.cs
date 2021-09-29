using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamProjectShapesCodeTesting
{
    public partial class GeometryCalculator : Form
    {
        public GeometryCalculator()
        {
            InitializeComponent();
        }

        string shapeName = "";

        private void CalcButton_Click(object sender, EventArgs e)
        {

            label7.Text = shapeName;
            if (calcButton.Text == "Calculate")
            {
                label7.Text = shapeName;
                ClearTextBoxes();
                shapeName = ShapeUserChoice();
                whatToShow(shapeName); 
                calcButton.Text = "Answer";
                
            }
            else
            {
                label7.Text = shapeName;
                startCalculations(shapeName);
                calcButton.Text = "Calculate";               

            }
            
            
        }

        private void ClearTextBoxes()
        {
            textBoxOne.Text = "";
            textBoxTwo.Text = "";
            textBoxThree.Text = "";
            textBoxFour.Text = "";
            textBoxFive.Text = "";
        }

        private void SetVisibleFalse()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBoxOne.Visible = false;
            textBoxTwo.Visible = false;
            textBoxThree.Visible = false;
            textBoxFour.Visible = false;
            textBoxFive.Visible = false;
            areaTextbox.Text = "";
            perimeterTextbox.Text = "";
            label7.Text = "";
        }

        private void whatToShow(string WooptyWoo)
        {
            if (WooptyWoo == "rectangle")
            {
                label1.Visible = true;
                label1.Text = "L";
                label2.Visible = true;
                label2.Text = "W";
                textBoxOne.Visible = true;
                textBoxTwo.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/rectangle11.jpg");
            }
            if (WooptyWoo == "square")
            {
                label1.Visible = true;
                label1.Text = "S";
                textBoxOne.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/Square1.jpg");
            }
            if (WooptyWoo == "parallelogram")
            {
                label1.Visible = true;
                label1.Text = "A";
                label2.Visible = true;
                label2.Text = "B";
                label3.Visible = true;
                label3.Text = "H";
                textBoxOne.Visible = true;
                textBoxTwo.Visible = true;
                textBoxThree.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/Parallelogram.gif");
            }
            if (WooptyWoo == "rhombus")
            {
                label1.Visible = true;
                label1.Text = "B";
                label2.Visible = true;
                label2.Text = "H";
                textBoxOne.Visible = true;
                textBoxTwo.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/Rhombus.gif");
            }
            if (WooptyWoo == "triangle")
            {
                label1.Visible = true;
                label1.Text = "A";
                label2.Visible = true;
                label2.Text = "B";
                label3.Visible = true;
                label3.Text = "C";
                label4.Visible = true;
                label4.Text = "H";
                textBoxOne.Visible = true;
                textBoxTwo.Visible = true;
                textBoxThree.Visible = true;
                textBoxFour.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/Triangle.gif");
            }
            if (WooptyWoo == "trapezoid")
            {
                label1.Visible = true;
                label1.Text = "A";
                label2.Visible = true;
                label2.Text = "B";
                label3.Visible = true;
                label3.Text = "C";
                label4.Visible = true;
                label4.Text = "D";
                label5.Visible = true;
                label5.Text = "H";
                textBoxOne.Visible = true;
                textBoxTwo.Visible = true;
                textBoxThree.Visible = true;
                textBoxFour.Visible = true;
                textBoxFive.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/Trapezoid.gif");
            }
            if (WooptyWoo == "circle")
            {
                label1.Visible = true;
                label1.Text = "R";
                textBoxOne.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:/C#/AreaPerimeterCalculator/Circle.gif");
            }
        }

        private string ShapeUserChoice()
        {
            string shapeName = "JoyIsNothingWithoutPain";

            if (rectangleradioButton2.Checked)
            {
                shapeName = "rectangle";
            }
            if (squareradioButton3.Checked)
            {
                shapeName = "square";
            }
            if (parallelogramRadiobutton.Checked)
            {
                shapeName = "parallelogram";
            }
            if (rhombusradioButton5.Checked)
            {
                shapeName = "rhombus";
            }
            if (trianleRB.Checked)
            {
                shapeName = "triangle";
            }
            if (trapezoidRB.Checked)
            {
                shapeName = "trapezoid";
            }
            if (circleradioButton1.Checked)
            {
                shapeName = "circle";
            }
            label7.Text = shapeName;
            SetVisibleFalse();
            return shapeName;
        }

        private void Result(List<float> list)
        {
            if (perimeterRB.Checked)
            {
                perimeterTextbox.Text = Convert.ToString(list[0]);
            }
            else if (areaRB.Checked)
            {
                areaTextbox.Text = Convert.ToString(list[1]);
            }
            else
            {
                perimeterTextbox.Text = Convert.ToString(list[0]);
                areaTextbox.Text = Convert.ToString(list[1]);
            }
        }

        private void startCalculations(string shapeName)
        {
            if (shapeName == "rectangle")
            {
                float l = 0;
                float w = 0;

                while (true)
                {
                    try
                    {
                        l = Convert.ToSingle(textBoxOne.Text);
                        w = Convert.ToSingle(textBoxTwo.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (l != 0 && w != 0)
                    {
                        List<float> list = rectangle(l, w);
                        Result(list);
                        break;
                    }
                }


            }
            
            if (shapeName == "square")
            {
                float s = 0;
               
                while (true)
                {
                    try
                    {
                        s = Convert.ToSingle(textBoxOne.Text);
                        
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (s != 0)
                    {
                        List<float> list = square(s);
                        Result(list);
                        break;
                    }
                }
            }
            if (shapeName == "parallelogram")
            {
                float a = 0;
                float b = 0;
                float h = 0;
                while (true)
                {
                    try
                    {
                        a = Convert.ToSingle(textBoxOne.Text);
                        b = Convert.ToSingle(textBoxTwo.Text);
                        h = Convert.ToSingle(textBoxThree.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (a != 0 && b != 0 && h != 0)
                    {
                        List<float> list = parallelogram(a, b, h);
                        Result(list);
                        break;
                    }
                }
            }
            if (shapeName == "rhombus")
            {
                float b = 0;
                float h = 0;
                while (true)
                {
                    try
                    {
                        b = Convert.ToSingle(textBoxOne.Text);
                        h = Convert.ToSingle(textBoxTwo.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (b != 0 && h != 0)
                    {
                        List<float> list = rhombus(b, h);
                        Result(list);
                        break;
                    }
                }
            }
            if (shapeName == "triangle")
            {
                float a = 0;
                float b = 0;
                float c = 0;
                float h = 0;
                while (true)
                {
                    try
                    {
                        a = Convert.ToSingle(textBoxOne.Text);
                        b = Convert.ToSingle(textBoxTwo.Text);
                        c = Convert.ToSingle(textBoxThree.Text);
                        h = Convert.ToSingle(textBoxFour.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (a != 0 && b != 0 && c != 0 && h != 0)
                    {
                        List<float> list = triangle(a, b, c, h);
                        Result(list);
                        break;
                    }
                }
            }
            if (shapeName == "trapezoid")
            {
                float a = 0;
                float b = 0;
                float c = 0;
                float d = 0;
                float h = 0;
                while (true)
                {
                    try
                    {
                        a = Convert.ToSingle(textBoxOne.Text);
                        b = Convert.ToSingle(textBoxTwo.Text);
                        c = Convert.ToSingle(textBoxThree.Text);
                        d = Convert.ToSingle(textBoxFour.Text);
                        h = Convert.ToSingle(textBoxFive.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (a != 0 && b != 0 && c != 0 && h != 0)
                    {
                        List<float> list = trapezoid(a, b, c, d, h);
                        Result(list);
                        break;
                    }
                }
            }
            if (shapeName == "circle")
            {
                float r = 0;
                while (true)
                {
                    try
                    {
                        r = Convert.ToSingle(textBoxOne.Text);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter valid numbers.");
                        break;
                    }

                    if (r != 0)
                    {
                        List<float> list = circle(r);
                        Result(list);
                        break;
                    }
                }
            }
        }

        private List<float> rectangle(float L, float w)
        {
            List<float> list = new List<float>();
            float perimeter = L + L + w + w;
            float area = L * w;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }
        private List<float> square(float s)
        {
            List<float> list = new List<float>();
            float perimeter = s * 4;
            float area = s * s;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }
        private List<float> parallelogram(float a, float b, float h)
        {
            List<float> list = new List<float>();
            float perimeter = a + a + b + b;
            float area = b * h;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }
        private List<float> rhombus(float b, float h)
        {
            List<float> list = new List<float>();
            float perimeter = b * 4;
            float area = b * h;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }
        private List<float> triangle(float a, float b, float c, float h)
        {
            List<float> list = new List<float>();
            float perimeter = a + b + c;
            float area = (b * h) / 2;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }
        private List<float> trapezoid(float a, float b, float c, float d, float h)
        {
            List<float> list = new List<float>();
            float perimeter = a + b + c + d;
            float area = ((a + b) / 2) * h;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }
        private List<float> circle(float r)
        {
            List<float> list = new List<float>();
            double powR = Math.Pow(r, 2);
            float perimeter = 2 * 3.141592653589793238462643f * r;
            float area = r * r * 3.141592653589793238462643f;
            list.Add(perimeter);
            list.Add(area);
            return list;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            SetVisibleFalse();
        }

       



        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            

            try
            {
                decimal x = Convert.ToDecimal(txtboxX.Text);
                decimal y = Convert.ToDecimal(txtboxY.Text);
                result = (x / y) * 100;
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            txtpercentresult.Text = Convert.ToString(result);
        }










        private void GeometryCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtboxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblY_Click(object sender, EventArgs e)
        {

        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void percentagelbl_Click(object sender, EventArgs e)
        {

        }

        private void txtpercentresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatePercentrb_CheckedChanged(object sender, EventArgs e)
        {
            if (calculatePercentrb.Checked)
            {
                lblY.Visible = true;
                labelX.Visible = true;
                percentagelbl.Visible = true;
                calculatebtn.Visible = true;
                txtboxX.Visible = true;
                txtboxY.Visible = true;
                txtpercentresult.Visible = true;
            }
        }
    }
}
