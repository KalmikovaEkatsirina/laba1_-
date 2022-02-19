using System;
using System.Windows.Forms;

namespace calc
{
    public static class Calculator
    {

        public static void operationNE(TextBox textBox)
        {

            if (textBox.Text == "")
            {
                MessageBox.Show("Введите значение");
            }
            else
            {
                int number;
                number = Convert.ToInt32(textBox.Text);
                textBox.Text = Convert.ToString(~number);
            }
        }

        public static void inputNumber(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45) // цифры , клавиша BackSpace и минус
            {
                e.Handled = true;
            }
        }

        public static void clearFields(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, ComboBox cb)
        {
            if (tb1.Text == "" && tb2.Text == "" && tb3.Text == "" && tb4.Text == "" && tb5.Text == "" && tb6.Text == "" && cb.Text == "")
            {
                MessageBox.Show("Все поля очищены");
            }
            else
            {
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
                tb4.Text = "";
                tb5.Text = "";
                tb6.Text = "";
                cb.Text = "";
            }


        }
        public static void calculate(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, ComboBox cb)
        {
            if (tb1.Text == "" || tb2.Text == "")
            {
                MessageBox.Show("Введите недостающее(ие) значение(я)");

            }
            else if (cb.Text == "")
            {
                MessageBox.Show("Выберите операцию");
            }

            else
            {
                int a, b;
                a = Convert.ToInt32(tb1.Text);
                b = Convert.ToInt32(tb1.Text);

                switch (cb.Text)
                {
                    case "И":
                        tb3.Text = Convert.ToString(a & b);
                        tb4.Text = Convert.ToString(a & b, 2);
                        tb5.Text = Convert.ToString(a & b, 8);
                        tb6.Text = Convert.ToString(a & b, 16);
                        break;
                    case "ИЛИ":
                        tb3.Text = Convert.ToString(a | b);
                        tb4.Text = Convert.ToString(a | b, 2);
                        tb5.Text = Convert.ToString(a | b, 8);
                        tb6.Text = Convert.ToString(a | b, 16);
                        break;

                    case "Исключающее ИЛИ":
                        tb3.Text = Convert.ToString(a ^ b);
                        tb4.Text = Convert.ToString(a ^ b, 2);
                        tb5.Text = Convert.ToString(a ^ b, 8);
                        tb6.Text = Convert.ToString(a ^ b, 16);
                        break;
                }
            }
        }
    }
}
