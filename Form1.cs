namespace Práctica__8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetButton5());
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Triángulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.14592;
            double area1, radio1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            textBox2.Text = area1.ToString();
            textBox3.Text = volumen1.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Rombo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
       
        }
    private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            double area1, base1, altura1;
            base1 = double.Parse(textBox4.Text);
            altura1 = double.Parse(textBox5.text);
            area1 = altura1 * base1 / 2;
         
            textBox6.Text = area1.ToString();
           
        }
    }
}