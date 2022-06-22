using System;

namespace OtherWork1
{
    class Program
    {
        static void Main(string[] args)
        {  
            string InputString(string str)
            {
                Console.Write(str);
                return Console.ReadLine();
            }

            Console.WriteLine("Введите номер дополнительной задачи:");
            Console.WriteLine("1: В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.");
            Console.WriteLine("2: Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается.");
            int task = Convert.ToInt32(InputString(""));
            switch (task)
            {
                case 1:
                    string secretMessage = "Секретное сообщение";
                    string secretPassword = "Пароль";
                    string password, cycle;
                    int count = 0;
                    do
                    {
                        Console.Clear();
                        if (count > 0)
                        {
                            Console.WriteLine("Пароль неверный!");
                        }
                        Console.WriteLine(secretMessage);
                        password = InputString("Введите пароль: ");
                        count++;
                        if (count == 3)
                        {
                            Console.WriteLine("Вы исчерпали попытки, попробуйте в другой раз");
                            break;
                        }
                    } while (password != secretPassword);
                    if (password == secretPassword)
                    {
                        Console.WriteLine("Пароль принят");
                    }
                    break;
                case 2:                   
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Вы не пройдёте дальше, пока не введете exit");
                        cycle = InputString("Введите строку: ");
                    } while (cycle != "exit");
                    Console.WriteLine("Вы справились");

                    break;
            }

            Console.ReadKey();
        }
    }
}
