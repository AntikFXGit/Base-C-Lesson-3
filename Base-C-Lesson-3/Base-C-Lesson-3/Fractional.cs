using System;
namespace Base_C_Lesson_3
{
    public class Fractional
    {

        double ch = 0, zn = 0; // числитель, знаменатель
        double res = 0; // результат вычисления

        // Конструкторы
        public Fractional()
        {
        }
        public Fractional(double ch, double zn)
        {
            if(ch!=0) this.ch = ch; else throw new Exception("Числитель не может быть равен 0.");
            if (zn != 0) this.zn = zn; else throw new Exception("Знаменатель не может быть равен 0.");
        }

        // Свойства
        public double Ch
        {
            get { return ch; }
            set { if (value != 0) ch = value; }
        }

        public double Zn
        {
            get { return zn; }
            set { if (value != 0) zn = value; }
        }

        public double Res
        {
            get { return res; }
        }


        // Метод сложения
        public Fractional Plus(Fractional x)
        {
            Fractional y = new Fractional();
            
            // Проверка , одинаковый ли знаменатель?
            if(zn == x.zn)
            {
                y.ch = ch + x.ch;
                y.zn = zn;
            } 
            // Приводим к общему знаменателю
            else
            {
                y.ch = ch * x.zn + x.ch * zn;
                y.zn = zn * x.zn;
            }
            y.res = Math.Round(y.ch / y.zn, 2);
            return y;
        }

        // Метод вычитания
        public Fractional Minus(Fractional x)
        {
            Fractional y = new Fractional();

            // Проверка , одинаковый ли знаменатель?
            if (zn == x.zn)
            {
                y.ch = ch - x.ch;
                y.zn = zn;
            }
            // Приводим к общему знаменателю
            else
            {
                y.ch = ch * x.zn - x.ch * zn;
                y.zn = zn * x.zn;
            }
            y.res = Math.Round(y.ch / y.zn, 2);
            return y;
        }


        // Метод умножения
        public Fractional Multi(Fractional x)
        {
            Fractional y = new Fractional();
            y.ch = ch * x.ch;
            y.zn = zn * x.zn;
            y.res = Math.Round(y.ch / y.zn, 2);
            return y;
        }

        // Метод деления
        public Fractional Divide(Fractional x)
        {
            Fractional y = new Fractional();
            y.ch = ch * x.zn;
            y.zn = zn * x.ch;
            y.res = Math.Round(y.ch / y.zn, 2);
            return y;
        }



        public string getCondition(Fractional x, string operand)
        {
            return this.ch + "/" + this.zn + " " + operand + " " + x.ch + "/" + x.zn;
        }


    }
}