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

            void Circle(string pas, string secret)
            {
                int count = 1;
                while (pas != "exit")
                {
                    if (count == 3)
                    {
                        Console.WriteLine(secret);
                    }
                    else
                    {
                        count++;
                    }
                    pas = InputString("Введите пароль: ");
                }
            }

            //Задание 1. В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.
            string password = InputString("Введите пароль: "), secretString = "Секретное сообщение!";
            Circle(password, secretString);

            Console.ReadKey();
        }
    }
}
