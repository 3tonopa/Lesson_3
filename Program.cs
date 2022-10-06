using System;

namespace Lesson_3//Д/З Урок 3. Стрелков Максим.
{

    class Complex
    {

        #region Public Methods

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re + complex.Re;
            c._im = _im + complex._im;
            return c;
        }



        /// <summary>
        /// Перегрузка оператора +, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }
        public static Complex operator -(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
        }
        public static Complex operator *(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re * complex2.Re, Im = complex1.Im * complex2.Im };
        }

        public override string ToString()
        {
            return $"{_re} {_im}i";
        }

        #endregion

        #region Constructors

        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
        }

        #endregion

        #region Fields

        private double _re;
        private double _im;

        #endregion

        #region Properties

        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }

        #endregion
    }
    
    class Program
    {
        #region Menu
        static void MainMenu() //Главное меню.

        {

            Console.Clear();
            bool flag = true;

            while (flag)

            {
                Console.WriteLine("Задача №1,Нажмите  [1]");
                Console.WriteLine("Задача №2,Нажмите  [2]");
                Console.WriteLine("Для выхода нажмите [0]" +
                "                  ");

                Console.WriteLine();
                Console.Write("Выбор: ");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 0:
                        Console.WriteLine("Выход");
                        flag = false;
                        break;

                    case 1:
                        Console.WriteLine("Выполнение Задачи №1");
                        Task1();
                        break;

                    case 2:
                        Console.WriteLine("Выполнение Задачи №2");
                        Task2();
                        break;

                }

                if (num > 2 && true)

                {
                    Console.WriteLine("Вы ввели неправильный номер, нажмите Enter и повторите попытку.");
                    Console.ReadKey();
                    MainMenu();

                }

                if (false)
                { }

                break;

            }
        }
        #endregion

        static void Main(string[] args)


        {


            Console.Clear();

            MainMenu();


        }

        #region Task1
        static void Task1()//"Задача №1.С клавиатуры вводятся числа, пока не будет введён 0.Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

        {


            Console.Clear();
            Console.WriteLine("Задача №1");
            int summa = 0;
            int number;

            do
            {

                Console.Write("Введите любое число: ");
                if (int.TryParse(Console.ReadLine(), out number)) ;


                else
                {
                    Console.WriteLine("Вы ввели некорректное число, нажмите Enter для возврата в основное меню.");
                    Console.ReadKey();
                    MainMenu();
                }


                if (number > 0 && number % 2 == 1)
                    summa += number;



            } while (number != 0);
            Console.WriteLine("Сумма всех нечётных чисел: " + summa);
            Console.WriteLine("Нажмите ENTER для выхода в основное меню.");
            Console.ReadKey();
            MainMenu();
        }
        #endregion

        #region Task2
        static void Task2() //Задача №2) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

        { 
            Complex complex1 = new Complex(5, -2);
            Complex complex2 = new Complex(-1, 3);

            bool flag = true;

            while (flag)

            {
                Console.Clear();
                Console.WriteLine($"Комплексные числа {complex1} и {complex2}");
                Console.WriteLine("Задача №1, СЛОЖЕНИЕ  - Нажмите  [1]");
                Console.WriteLine("Задача №2, ВЫЧИТАНИЕ - Нажмите  [2]");
                Console.WriteLine("Задача №3, УМНОЖЕНИЕ - Нажмите  [3]");
                Console.WriteLine("Для выхода нажмите              [0]" +
                "                  ");
                Console.WriteLine();
                Console.Write("Выбор: ");
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 0:
                        Console.WriteLine("Выход");
                        flag = false;
                        break;

                    case 1:
                        Console.WriteLine("Выполнение Задачи №1");
                        Console.WriteLine($"Результат сложения комплексных чисел {complex1 + complex2}");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("Выполнение Задачи №2");
                        Console.WriteLine($"Результат вычитания комплексных чисел {complex1 - complex2}");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Выполнение Задачи №3");
                        Console.WriteLine($"Результат умножения комплексных чисел {complex1 * complex2}");
                        Console.ReadKey();
                        break;
                }

                if (num > 3 && true)

                {
                    Console.WriteLine("Вы ввели неправильный номер, нажмите Enter и повторите попытку.");
                    Console.ReadKey();
                }
            }
            MainMenu();
            #endregion
        }
    } 
    
}

    





