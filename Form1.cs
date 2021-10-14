using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_FractionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Код
        private void Calculate()
        {
            try
            {
                label2.Text = "";
                textResult.Clear();
                // считали значения с полей для ввода и сконвертили в числа
                var firstNumerator = double.Parse(textNumerator1.Text);
                var firstDenominator = double.Parse(textDenominator1.Text);
                var secondNumerator = double.Parse(textNumerator2.Text);
                var secondDenominator = double.Parse(textDenominator2.Text);
                if ((firstNumerator < 0) && (firstDenominator < 0)) {
                    firstNumerator = Math.Abs(firstNumerator);
                    firstDenominator = Math.Abs(firstDenominator);
                }
                if ((secondNumerator < 0) && (secondDenominator < 0))
                {
                    secondNumerator = Math.Abs(secondNumerator);
                    secondDenominator = Math.Abs(secondDenominator);
                }
                if (firstDenominator < 0) {
                    firstDenominator = Math.Abs(firstDenominator);
                    firstNumerator = -1 * firstNumerator;
                }
                if (secondDenominator < 0)
                {
                    secondDenominator = Math.Abs(secondDenominator);
                    secondNumerator = -1 * secondNumerator;
                }
                if (firstDenominator == 0)
                {
                    label2.Text = "На 0 делить нельзя!";
                }
                if (secondDenominator == 0)
                {
                    label2.Text = "На 0 делить нельзя!";
                }
                // на основании значений создали экземпляры нашего класса 
                var firstFraction = new Fraction(firstNumerator, firstDenominator);
                    var secondFraction = new Fraction(secondNumerator, secondDenominator);

                    Fraction fracResult;
                    // сложили две дроби
                    switch (cmbOperation.Text)
                    {
                        case "+":
                        // если плюсик выбрали, то складываем
                        fracResult = firstFraction + secondFraction;
                        fracResult.Reduction();
                        textResult.Text = fracResult.Print();
                        break;
                        case "-":
                            fracResult = firstFraction - secondFraction;
                            fracResult.Reduction();
                            textResult.Text = fracResult.Print();
                            break;
                        case "*":
                            fracResult = firstFraction * secondFraction;
                            fracResult.Reduction();
                            textResult.Text = fracResult.Print();
                            break;
                        case "/":
                            fracResult = firstFraction / secondFraction;
                            fracResult.Reduction();
                            textResult.Text = fracResult.Print();
                            break;
                        case "<>":
                            textResult.Text = Fraction.Compar(firstFraction, secondFraction);
                            break;
                        default:
                            fracResult = new Fraction(1, 1);
                        label2.Text = "Выберете что-то из списка!";
                            break;
                    }
            }
            catch (FormatException)
            {
                label2.Text = "Заплнены не все поля\nИли введена не цифра!";
            }
        }

        private void textNumerator1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильная дробь, задаваемая числителем и знаменателем." +
                            "\n • Сложение" +
                            "\n • Вычитание" +
                            "\n • Умножение" +
                            "\n • Деление двух дробей" +
                            "\n • Сокращение дроби" +
                            "\n • Сравнение двух дробей");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNumerator1.Clear();
            textDenominator1.Clear();
            textNumerator2.Clear();
            textDenominator2.Clear();
            textResult.Clear();
        }
    }
}
