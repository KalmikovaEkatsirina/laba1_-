using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {

        
        
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
            button5.Click += button5_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculator.inputNumber(e);          

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            Calculator.inputNumber(e);

        }
        public  void button5_Click(object sender, EventArgs e)
        {
            
            Calculator.clearFields(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, comboBox1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator.calculate(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, comboBox1);
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            Calculator.operationNE(textBox1);
        }  

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator.operationNE(textBox2);
        }

       
    }
}
