namespace Practica_8_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            const double pi = 3.141592;                      //Se declara la constante pi con una igualdad.
            double radio1, area1, volumen1;                  //Se declara todas las variables que vamos a utilizar.
            radio1 = double.Parse(textBox1.Text);             //Se declara que en la caja 1 se escribirá el valor del radio.
            area1 = 4 * pi * radio1 * radio1;                 //Se declara la fórmula para el área.
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);       //Se declara la fórmula para el volumen.
            textBox3.Text = area1.ToString();                  //Se declara que el área resultante se aparezca en la caja 3.
            textBox2.Text = volumen1.ToString();               //Se declara que el volumen resultante se aparezca en la caja 4.
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";                             //Se declara que al apretar el botón "borrar", desaparezcan los valores mostrados en las cajas 1, 2 y 3.
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";                            //Se declara que al apretar el botón "borrar", desaparezcan los valores mostrados en las cajas 4, 5 y 6.
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double base2, area2, altura2;                                //Se declara todas las variables que vamos a utilizar.
            base2 = double.Parse(textBox4.Text);                         //Se declara que la base será la que escribamos en la caja 4.
            altura2 = double.Parse(textBox5.Text);                         //Se declara que la altura será la que escribamos en la caja 5.
            area2 = base2 * altura2 / 2;                                   //Se declara la fórmula para obtener el área del triángulo.

            textBox6.Text = area2.ToString();                     //Se declara que el área resultante se aparezca en la caja 6.

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lado3, area3, volumen3;             //Se declara todas las variables que vamos a utilizar.
            lado3 = double.Parse(textBox7.Text);         //Se decalra que el lado esquivaldrá a lo que se escriba en caja 7.
            volumen3 = Math.Pow(lado3, 3);               //Se declara la fórmula para el volumen.
            area3 = 6 * Math.Pow(lado3, 2);               //Se declara la fórmula para el área.

            textBox8.Text = area3.ToString();                              //Se declara que el área resultante se aparezca en la caja 8.
            textBox9.Text = volumen3.ToString();                            //Se declara que el volumen resultante se aparezca en la caja 9.
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";                      //Se declara que al apretar el botón "borrar", desaparezcan los valores mostrados en las cajas 7, 8 y 9.
            textBox8.Text = " ";
            textBox9.Text = " ";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;                              //Se declara la constante pi con una igualdad.
            double radio4, area4, volumen4, altura4;               //Se declara todas las variables que vamos a utilizar.
            radio4 = double.Parse(textBox10.Text);                 //Se declara que en la caja 10 se escribirá el valor del radio.

            altura4 = double.Parse(textBox11.Text);                   //Se declara que en la caja 11 se escribirá el valor de la altura.
            area4 = 2 * pi * radio4 * altura4 + 2 * pi * Math.Pow(radio4, 2);                //Se declara la fórmula para el área.
            volumen4 = altura4 * pi * Math.Pow(radio4, 2);                                    //Se declara la fórmula para el volumen.

            textBox12.Text = area4.ToString();                         //Se declara que el área resultante se aparezca en la caja 12.
            textBox19.Text = volumen4.ToString();                     //Se declara que el volumen resultante se aparezca en la caja 19.
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text = " ";   //Se declara que al apretar el botón "borrar", desaparezcan los valores mostrados en las cajas 10, 11, 12 y 19.
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox19.Text = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double D, d, area5;                                      //Se declara todas las variables que vamos a utilizar.
            D = double.Parse(textBox13.Text);                        //Se declara que en la caja 13 se escribirá el valor de la diagonal mayor.
            d = double.Parse(textBox14.Text);                  //Se declara que en la caja 13 se escribirá el valor de la diagonal menor.
            area5 = D * d / 2;                                              //Se declara la fórmula para el área.

            textBox15.Text = area5.ToString();       //Se declara que el área resultante se aparezca en la caja 15.

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox13.Text = " ";  //Se declara que al apretar el botón "borrar", desaparezcan los valores mostrados en las cajas 13, 14, y 15.
            textBox14.Text = " ";
            textBox15.Text = " ";
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double lado6, volumen6, area6;                                                   //Se declara todas las variables que vamos a utilizar.
            lado6 = double.Parse(textBox16.Text);                          //Se declara que en la caja 16 se escribirá el valor de el lado.
            volumen6 = Math.Pow(lado6, 3) * Math.Pow(2, (1 / 2)) / 3;                            //Se declara la fórmula para el volumen.
            area6 = 2 * Math.Pow(3, (1 / 2)) * Math.Pow(lado6, 2);                   //Se declara la fórmula para el área.

            textBox17.Text = area6.ToString();                  //Se declara que el área resultante se aparezca en la caja 17.
            textBox18.Text = volumen6.ToString();                 //Se declara que el volumen resultante se aparezca en la caja 18.
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox16.Text = " ";               //Se declara que al apretar el botón "borrar", desaparezcan los valores mostrados en las cajas 16, 17, y 18.
            textBox17.Text = " ";
            textBox18.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();                           //Se declara que al apretar cualquir botón "salir", el programa se cierre.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
