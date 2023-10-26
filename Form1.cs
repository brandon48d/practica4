namespace practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se declaran las variables
            int a, b, c, d;
            //se guarda el valor en la variable asignada
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);
            //se escribe el valor de la variable en el campo de texto
            textBox5.Text = d.ToString();
            textBox6.Text = c.ToString();
            textBox7.Text = b.ToString();
            textBox8.Text = a.ToString();
        }
    }
}