namespace Base_C_Lesson_3
{
    public class ComplexClass
    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;

        // Конструктор без параметров.
        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаем поля.    
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public ComplexClass(double re, double _im)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = x.im + im;
            y.re = x.re + re;
            return y;
        }
        

        //  Умножение
        public ComplexClass Multi(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        // Вычитание
        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        // Деление
        public ComplexClass Divide(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            double d1 = 0, d1_1 = 0;
            double d2 = x.re * x.re + x.im * x.im;

            d1 = re * x.re + im * x.im;
            d1_1 = re * x.im * -1 + im * x.re;

            y.re = d1 / d2;
            y.im = d1_1 / d2;
            return y;
        }
        


        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set{ if (value != 0) im = value; }
        }

        public double Re
        {
            get { return re; }
            set{ if (value != 0) re = value; }
        }



        public override string ToString()
        {
            // Filters...
            string p = (im < 0) ? "" : "+";
            if (re != 0 && im != 0) return re + p + im + "i";
            else if (re == 0 && im != 0) return im + "i";
            else if (re != 0 && im == 0) return re.ToString();
            else return "0";
        }

        public string getCondition(ComplexClass x, string operand)
        {
            return "(" + this.re + " + " + this.im + "i) " + operand + " (" + x.re + " + " + x.im + "i)";
        }
    }
}
