using System;

namespace Season
{
    class Program
    {
        //============================времена года перечисления =======================
        public enum Seasons
        {
            Winter,
            Sprin,
            Summer,
            Autumn,
            
        }
        //============================= основной, вывод на консоль ====================
        static void Main(string[] args)
        {
            Console.Write($"Так вы всетаки хотите в отпуск, если да введите номер месяца:");

            int Num = Convert.ToInt32(Console.ReadLine());// ввод номера месяца

            Console.WriteLine($"Заявка принята, время года отпуска "+ Did(Num));// вывод результата
            Console.WriteLine();
        }
        //============================= определение времен года по номеру месяца =========
        static string Did(int Num)
        {
            
            switch (Num)
            {
                case 1:
                case 2:
                case 12:
                    return Convert.ToString(Seasons.Winter);
                    //break;
                case 3:
                case 4:
                case 5:
                    return Convert.ToString(Seasons.Sprin);
                    //break;
                case 6:
                case 7:
                case 8:
                    return Convert.ToString(Seasons.Summer);
                    //break;
                case 9:
                case 10:
                case 11:
                    return Convert.ToString(Seasons.Autumn);
                    //break;
                default:
                    return ("Неверный ввод числа месяца");
                    //break;
            }
            
        }
       
    }

}






