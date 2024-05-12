using NCalc;
namespace الة_حاسبة
{
    public partial class Form1 : Form
    {
        string operation = "";
        // double result = 0;
        double x;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button17_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (isoperation == true)
            {

                textBox1.Clear();

            }
            isoperation = false;

            textBox1.Text = textBox1.Text + but.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (but.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + but.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + but.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            x = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + "" + operation;
            textBox1.Clear();
            //result = double.Parse(textBox1.Text);
            isoperation = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        textBox2.Text = "";
                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        textBox2.Text = "";
                    }
                    break;
                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        textBox2.Text = "";
                    }
                    break;
                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        textBox2.Text = "";
                    }
                    break;
                case "%":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x % y).ToString();
                        textBox2.Text = "";
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            textBox2.Clear();
        }
    }
}
