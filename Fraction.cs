using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_FractionGUI
{
    public class Fraction
    {
        private double numerator;
        private double denominator;
        int N;

        public Fraction(double numerator, double denominator) {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        //Вывод
        public string Print()
        {
            string OutMessege = "";
            if (this.denominator != 0)
            {
                this.N = 0;
                if ((Math.Abs(this.numerator) == this.denominator))
                {
                    N++;
                    OutMessege = $"{this.N}";
                }
                if ((Math.Abs(this.numerator) < this.denominator)) {
                    OutMessege = string.Format("{0}/{1}",this.numerator,this.denominator);
                }
                while (this.numerator > this.denominator) {
                    this.numerator = this.numerator - this.denominator;
                    N++;
                    if (this.numerator == this.denominator) {
                        this.N++;
                    }
                    OutMessege = string.Format("{0} {1}/{2}",this.N,this.numerator, this.denominator);
                }
                if (this.numerator < 0) {
                    while (Math.Abs(this.numerator) > this.denominator)
                    {
                        this.numerator = this.numerator + this.denominator;
                        this.N--;
                        if (Math.Abs(this.numerator) == this.denominator)
                        {
                            this.N--;
                        }
                        OutMessege = string.Format("{0} {1}/{2}", this.N, Math.Abs(this.numerator), this.denominator);
                    }
                }
            }
            return OutMessege;
        }
        //НОД
        public double NOD()
        {
            double num1 = Math.Abs(this.numerator);
            double num2 = Math.Abs(this.denominator);
            try
            {
                while (num2 != 0)
                {
                    var t = num2;
                    num2 = num1 % num2;
                    num1 = t;
                }

            }
            catch (DivideByZeroException) { }
            return num1;
        }
        //Мат операции
        //Сложение
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            var numeratorNew = (fraction1.numerator * fraction2.denominator) + (fraction1.denominator * fraction2.numerator);
            var denominatoNew = (fraction1.denominator * fraction2.denominator);
            var fractionNew = new Fraction(numeratorNew, denominatoNew);
            return fractionNew;
        }
        //Вычитание 
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            var numeratorNew = (fraction1.numerator * fraction2.denominator) - (fraction2.numerator * fraction1.denominator);
            var denominatoNew = (fraction1.denominator * fraction2.denominator);
            var fractionNew = new Fraction(numeratorNew, denominatoNew);
            return fractionNew;
        }
        //Умножение
        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            var numeratorNew = (fraction1.numerator * fraction2.numerator);
            var denominatoNew = (fraction1.denominator * fraction2.denominator);
            var fractionNew = new Fraction(numeratorNew, denominatoNew);
            return fractionNew;
        }
        //Деление
        public static Fraction operator  /(Fraction fraction1, Fraction fraction2)
        {
            var numeratorNew = (fraction1.numerator * fraction2.denominator);
            var denominatoNew = (fraction1.denominator * fraction2.numerator);
            var fractionNew = new Fraction(numeratorNew, denominatoNew);
            return fractionNew;
        }
        //Сокращение
        public void Reduction()
        {
            try
            {
                var nod = NOD();
                this.numerator = this.numerator / nod;
                this.denominator = this.denominator / nod;
            }
            catch (DivideByZeroException) {}
        }
        //Сравнение
        public static string Compar(Fraction fraction1, Fraction fraction2)
        {
            string OutMessege = "";
            try
            {
                if ((fraction1.numerator / fraction1.denominator) > (fraction2.numerator / fraction2.denominator))
                {
                    OutMessege = string.Format("{0}/{1} > {2}/{3}", fraction1.numerator, fraction1.denominator, fraction2.numerator, fraction2.denominator);
                }
                if ((fraction1.numerator / fraction1.denominator) < (fraction2.numerator / fraction2.denominator))
                {
                    OutMessege = string.Format("{0}/{1} < {2}/{3}", fraction1.numerator, fraction1.denominator, fraction2.numerator, fraction2.denominator);
                }
                if ((fraction1.numerator / fraction1.denominator) == (fraction2.numerator / fraction2.denominator))
                {
                    OutMessege = string.Format("{0}/{1} = {2}/{3}", fraction1.numerator, fraction1.denominator, fraction2.numerator, fraction2.denominator);
                }

            }
            catch (DivideByZeroException) {}
            return OutMessege;
        }
    }
}
