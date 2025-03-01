namespace calculadora
{
    public partial class Form1 : Form
    {
        private double numero1, numero2, resultado;
        private int operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";   
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";        
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = 1;
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnSubstracao_Click(object sender, EventArgs e)
        {
            operacao = 2;
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao = 3;
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = 4;
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox1.Text);
         
            switch(operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    //resultado = numero1 / numero2;
                    //break;
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                    {
                        textBox1.Text = "ERRO!!!!!";
                        return;
                    }
                    break;                  

            }
            textBox1.Text = resultado.ToString();



        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            textBox1.Clear();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text+".";
        }
    }
}


