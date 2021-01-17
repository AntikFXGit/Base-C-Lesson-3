namespace Base_C_Lesson_3
{
    struct Complex
    {
        public double im;
        public double re;

        // Конструктор
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }


        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        // Вычитание
        /*
         * Разностью двух комплексных чисел z1=a1+b1i и z2=a2+b2i называется комплексное число z=z1−z2, 
         * действительная и мнимая части которого есть разностью действительных и мнимых частей чисел z1 и z2
            соответственно:
            z=(a1−a2)+(b1−b2)i
         */
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

       // Деление
        public Complex Divide(Complex x)
        {
            Complex y;
            double d1 = 0, d1_1 = 0;
            double d2 = x.re * x.re + x.im * x.im;
            
            d1 = re * x.re + im * x.im;
            d1_1 = re * x.im * -1 + im * x.re;

            y.re = d1 / d2;
            y.im = d1_1 / d2;
            return y;
        }


        public override string ToString()
        {
            // Filters...
            string p = (im < 0) ? "" : "+";
            if(re != 0 && im != 0) return re + p + im + "i";
            else if (re == 0 && im != 0) return im + "i";
            else if (re != 0 && im == 0) return re.ToString();
            else return "0";
        }

        public string getCondition(Complex x, string operand)
        {
            return "(" + this.re + " + " + this.im + "i) " + operand + " (" + x.re + " + " + x.im + "i)";
        }

    }

}