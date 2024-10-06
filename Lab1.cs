using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabIVT1
{
    internal class Lab1
    {
        public void task1()
        {
            /*
             * Реализовать программно присвоение целочисленной переменной d первой 
цифры из дробной части положительного вещественного числа х. Например, 
для х = 27.3198 значение d будет равно 3
            */


            double x = 27.3198; // Пример числа
            string xStr = x.ToString(); // Преобразуем число в строку

            Console.WriteLine($"Указанное число {xStr}");

            int decimalPointIndex = xStr.IndexOf(','); // Находим индекс десятичной точки
            if (decimalPointIndex != -1 && decimalPointIndex + 1 < xStr.Length) // Проверяем, что есть дробная часть
            {
                char firstDigitOfFraction = xStr[decimalPointIndex + 1]; // Извлекаем первую цифру дробной части
                int d = (int)firstDigitOfFraction; // Преобразуем в целое число
                Console.WriteLine(d); // Вывод результата
            }
            else
            {
                Console.WriteLine("У числа нет дробной части.");
            }
        }

        public void task2()
        {
            /*
             * 
             Написать программу, которая определяет полное количество часов и минут 
суток, которые прошли к моменту текущей секунды суток. Например, если 
секунд прошло 11111, то часов прошло 3, а минут – 5 (11111=3*3600+5*60+11).
            */


            // Ввод количества секунд
            Console.Write("Введите количество секунд: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            // Вычисляем количество часов
            int hours = totalSeconds / 3600;
            // Вычисляем количество минут
            int minutes = (totalSeconds % 3600) / 60;

            // Выводим результат
            Console.WriteLine($"Часы: {hours}, Минуты: {minutes}");
        }

        public void task3()
        {
            /*
             * Написать программу, которая определяет угол в градусах между 
положением часовой стрелки в начале суток и ее положением в h часов, m
минут и s секунд (0 ≤ h ≤ 11; 0 ≤ m, s ≤ 59).
            */

            // Ввод времени
            Console.Write("Введите часы (0-11): ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Введите минуты (0-59): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите секунды (0-59): ");
            int s = int.Parse(Console.ReadLine());

            // Проверка на корректность ввода
            if (h < 0 || h > 11 || m < 0 || m > 59 || s < 0 || s > 59)
            {
                Console.WriteLine("Некорректный ввод времени.");
                return;
            }

            // Вычисляем угол
            double hourAngle = (h % 12) * 30 + (m / 60.0) * 30 + (s / 3600.0) * 30;
            // 30 градусов на час

            // В этом случае мы просто используем 30° за каждый час, и дополнительный угол за минуты и секунды

            // Угол между стрелками
            hourAngle = hourAngle % 360;

            // Выводим результат
            Console.WriteLine($"Угол между положением часовой стрелки и началом суток: {hourAngle}°");
        }

        public void task4()
        {
            /*
             * Реализовать программно обмен значениями для двух целых переменных без 
использования дополнительных переменных.
            */

            int a = 5;
            int b = 10;

            Console.WriteLine($"До обмена: a = {a}, b = {b}");

            a = a + b; // Суммируем
            b = a - b; // Получаем значение a
            a = a - b; // Получаем значение b

            Console.WriteLine($"После обмена: a = {a}, b = {b}");
        }

        public void task5()
        {
            /*
             * Написать программу, которая предлагает пользователю ввести длины 2 
катетов прямоугольного треугольника и затем по этим данным вычисляет и 
выводит на экран площадь и периметр треугольника.
            */

            // Ввод длины катетов
            Console.Write("Введите длину первого катета (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите длину второго катета (b): ");
            double b = double.Parse(Console.ReadLine());

            // Вычисление площади
            double area = (a * b) / 2;

            // Вычисление гипотенузы
            double c = Math.Sqrt(a * a + b * b);

            // Вычисление периметра
            double perimeter = a + b + c;

            // Вывод результатов
            Console.WriteLine($"Площадь треугольника: {area}");
            Console.WriteLine($"Периметр треугольника: {perimeter}");
        }

        public void task6()
        {
            /*
             * Написать программу, которая находит произведение цифр заданного 
четырехзначного числа. Например, для числа «1234» ответ будет 1*2*3*4=24.
            */

            // Ввод четырехзначного числа
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            // Проверка на четырехзначность
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Ошибка: число должно быть четырехзначным.");
                return;
            }

            // Переменная для хранения произведения цифр
            int product = 1;

            // Вычисление произведения цифр
            while (number > 0)
            {
                product *= number % 10; // Умножаем последнюю цифру
                number /= 10; // Убираем последнюю цифру
            }

            // Вывод результата
            Console.WriteLine($"Произведение цифр: {product}");
        }

        public void task7()
        {
            /*
             * Написать программу, которая записывает введенное трехзначное число в 
обратном порядке в переменную reversed и выводит ее на экран. Например, 
при вводе числа «362» будет выведено строкой ниже число «263»
            */


            // Ввод трехзначного числа
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            // Проверка на трехзначность
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число должно быть трехзначным.");
                return;
            }

            // Преобразуем число в строку для обращения
            string reversed = number.ToString()[2].ToString() + number.ToString()[1] + number.ToString()[0];

            // Вывод результата
            Console.WriteLine($"Обратное число: {reversed}");
        }

        public void task8()
        {
            /*
             * Ввести с клавиатуры действительное число х. Пользуясь только операциями 
умножения, сложения и вычитания, вычислить:
3x^4 – 5х^3 + 2х^2 – x + 7 при этом использовать не более четырех умножений и четырех сложений / 
вычитаний.
            */
            // Ввод действительного числа
            Console.Write("Введите действительное число x: ");
            double x = double.Parse(Console.ReadLine());

            // Вычисление x^2, x^3 и x^4 с минимальным количеством операций
            double x2 = x * x; // 1 умножение
            double x3 = x2 * x; // 2 умножение
            double x4 = x3 * x; // 3 умножение

            // Теперь вычисляем значение многочлена
            double result = 3 * x4 - 5 * x3 + 2 * x2 - x + 7; // 4 умножения

            // Вывод результата
            Console.WriteLine($"Результат: {result}");
        }

        public void task9()
        {
            /*
             Написать программу для решения системы уравнений (коэффициенты a, b, c
ввести с клавиатуры, определитель системы не должен быть равен 0): 
a1x + b1y + с1z = d1
a2x + b2y + с2z = d2
a3x + b3y + с3z = d3
            */

            // Ввод коэффициентов
            Console.Write("Введите a1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите c1: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Введите d1: ");
            double d1 = double.Parse(Console.ReadLine());

            Console.Write("Введите a2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("Введите c2: ");
            double c2 = double.Parse(Console.ReadLine());
            Console.Write("Введите d2: ");
            double d2 = double.Parse(Console.ReadLine());

            Console.Write("Введите a3: ");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("Введите b3: ");
            double b3 = double.Parse(Console.ReadLine());
            Console.Write("Введите c3: ");
            double c3 = double.Parse(Console.ReadLine());
            Console.Write("Введите d3: ");
            double d3 = double.Parse(Console.ReadLine());

            // Вычисление определителя D
            double D = a1 * (b2 * c3 - b3 * c2) -
                        b1 * (a2 * c3 - a3 * c2) +
                        c1 * (a2 * b3 - a3 * b2);

            // Проверка на равенство нулю
            if (D == 0)
            {
                Console.WriteLine("Определитель системы равен 0. Система не имеет единственного решения.");
                return;
            }

            // Вычисление определителей Dx, Dy, Dz
            double Dx = d1 * (b2 * c3 - b3 * c2) -
                        b1 * (d2 * c3 - d3 * c2) +
                        c1 * (d2 * b3 - d3 * b2);

            double Dy = a1 * (d2 * c3 - d3 * c2) -
                        d1 * (a2 * c3 - a3 * c2) +
                        c1 * (a2 * b3 - a3 * b2);

            double Dz = a1 * (b2 * d3 - b3 * d2) -
                        b1 * (a2 * d3 - a3 * d2) +
                        d1 * (a2 * b3 - a3 * b2);

            // Нахождение x, y, z
            double x = Dx / D;
            double y = Dy / D;
            double z = Dz / D;

            Console.WriteLine("\nСистема уравнений:");
            Console.WriteLine($"{a1,5}x + {b1,5}y + {c1,5}z = {d1,5}");
            Console.WriteLine($"{a2,5}x + {b2,5}y + {c2,5}z = {d2,5}");
            Console.WriteLine($"{a3,5}x + {b3,5}y + {c3,5}z = {d3,5}");

            // Вывод результатов
            Console.WriteLine($"Решение системы: x = {x}, y = {y}, z = {z}");
        }

        public void calc()
        {
            double arg1 = 0; //a
            double arg2 = 0; //b
            double agregator = 0; //c

            int operation = 0;

            Console.WriteLine("Введите Аргумент 1");
            arg1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Аргумент 2");
            arg2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("0 - сумма");
            Console.WriteLine("1 - разность");
            Console.WriteLine("2 - умножение");
            Console.WriteLine("3 - деление");

            while (true)
            {
                operation = int.Parse(Console.ReadLine());


                if (operation >= 0 && operation <= 3)
                {
                    break;

                }

                Console.WriteLine("Вы ввели неверный код операции!");
            }

            Console.WriteLine("Всё хорошо!");

            switch (operation)
            {
                default:
                case 0:
                    agregator = arg1 + arg2;
                    break;
                case 1:
                    agregator = arg1 - arg2;
                    break;
                case 2:
                    agregator = arg1 * arg2;
                    break;
                case 3:

                    if (arg2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        break;
                    }

                    agregator = arg1 / arg2;
                    break;
            }


            Console.WriteLine($"Результат работы калькулятора = {agregator}");
        }

        private void PrintRow(string[] row)
        {
            foreach (var cell in row)
            {
                Console.Write($"| {cell,-22} ");
            }
            Console.WriteLine("|");
        }

        private void PrintSeparator(int columns)
        {
            for (int i = 0; i < columns; i++)
            {
                Console.Write("+------------------------");
            }
            Console.WriteLine("+");
        }

        enum Group
        {
            Х = 0,
            У = 1,
            С = 2
        }

        struct Book
        {
            public string author { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public Group grup { get; set; }
        }


        public void task10v4()
        {
            // Размеры таблицы
            int rows = 3;
            int columns = 4;

            Book[] books = new Book[rows];

            string[] authors = new string[] { "Сенкевич", "Ландау", "Дойль" };
            string[] titles = new string[] { "Потоп", "Механика", "Сумчатые" };
            int[] years = new int[] { 1978, 1989, 1990 };
            Group[] groups = new Group[] { Group.Х, Group.У, Group.С };

          
            for (int i = 0; i < rows ; i++)
            {
                books[i] = new Book();
                books[i].author = authors[i];
                books[i].title = titles[i];
                books[i].year = years[i];
                books[i].grup = groups[i];
            }

            string[] headers = { "Автор книги", "Название", "Год выпуска", "Группа" };
            PrintSeparator(columns);
            Console.WriteLine($"| {"Каталог книги", -98}|");
            PrintSeparator(columns);
            // Создаем и заполняем таблицу данными
            string[,] table = new string[rows, columns];
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    switch(j)
                    {
                        case 0:
                            table[i, j] = books[i].author; break;
                        case 1:
                            table[i, j] = books[i].title; break;
                        case 2:
                            table[i, j] = books[i].year.ToString(); break;
                        case 3:
                            table[i, j] = books[i].grup.ToString(); break;
                    }
                    
                }
            }

            // Выводим заголовки
            PrintRow(headers);
            PrintSeparator(columns);

            // Выводим строки таблицы
            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[columns];
                for (int j = 0; j < columns; j++)
                {
                    row[j] = table[i, j];
                }
                PrintRow(row);
                PrintSeparator(columns);
            }
            Console.WriteLine($"| {"Перечисляемый тип: Х - художественная литература; У - учебная лит-ра; С - справочная лит-ра",-98}|");
            PrintSeparator(columns);
        }
        public void task11v6()
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            double z = double.Parse(Console.ReadLine());

            double a = (2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2));

            double b = 1 + (Math.Pow(z, 2) / (3 + Math.Pow(z, 2) / 5));

            Console.WriteLine($"Результат А={a} B={b}");

        }
    }
}
