//*********************************************************************************
//*Практическая работа №11                                                        *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                           *
//* Задание: получение навыков работы с символьными данными и операциями над ними.*
//*********************************************************************************
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Здравствтвуйте");
                Console.WriteLine("Практическая работа № 11");
                string s1 = null;
                Console.Write("Введите текст:");
                s1 = Console.ReadLine(); // Вводим строку
                if (string.IsNullOrWhiteSpace(s1)) throw new Exception("Введена пустая строка");                
                else
                {
                    string reverseStr = ""; // здесь будет наша перевернутая строка
                    for (int i = s1.Length - 1; i >= 0; i--)
                    {
                        reverseStr += s1[i]; // переворачиваем строку
                    }
                    if (s1 == reverseStr)
                        Console.WriteLine("Введенная строка является палиндромом.");
                    else
                        Console.WriteLine("Введенная строка не является палиндромом.");
                }
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка :" + fe.Message);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;                
                Console.WriteLine("Возникла ошибка:" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
