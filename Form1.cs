namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string opr;
        double oparand1, oparand2, result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(textBox1.Text);
            opr = "+";
            textBox1.Clear();
        }
        //equal button code
        private void button17_Click(object sender, EventArgs e)
        {
            oparand2 = Convert.ToDouble(textBox1.Text);
            switch (opr)
            {
                case "+":
                    result = oparand1 + oparand2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = oparand1 - oparand2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "*":
                    result = oparand1 * oparand2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "/":
                    if (oparand2 == 0)
                    {
                        textBox1.Text = "0.0";
                        break;
                    }
                    else
                    {
                        result = oparand1 / oparand2;
                        textBox1.Text = Convert.ToString(result);
                        break;
                    }





            }
        }
        //multiply button coding
        private void button15_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(textBox1.Text);
            opr = "*";
            textBox1.Clear();
        }
        //minus button coding
        private void button16_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(textBox1.Text);
            opr = "-";
            textBox1.Clear();
        }
        //divide button coding
        private void button18_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(textBox1.Text);
            opr = "/";
            textBox1.Clear();
        }
    }
}
