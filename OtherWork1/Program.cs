using System;
using System.Data;
using System.Data.SqlClient;

namespace OtherWork1
{
    class Program
    {
        static void Main(string[] args)
        {            
            int i = 0;
            string[,] login = new string[100, 2];
            for (int j = 0; j < login.GetLength(0); j++)
            {
                login[j, 0] = "";
            }

            Console.WriteLine("Введите номер дополнительной задачи:");
            Console.WriteLine("1: В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.");
            Console.WriteLine("2: Gрограмма с бесконечным циклом. Дополнение"); 
            int task = Convert.ToInt32(InputString(""));
            Console.Clear();
            switch (task)
            {
                case 1:
                    string secretMessage = "Секретное сообщение";
                    string secretPassword = "Пароль";
                    string password, cycle;
                    int count = 0;
                    do
                    {                       
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
                        Console.WriteLine("В программу добавлены некоторые команды, для просмотра введите Help");
                        cycle = InputString("Введите команду: ");                        
                        switch (cycle)
                        {
                            case "Help":
                                Console.WriteLine("Help – вывести список команд");
                                Console.WriteLine("Clear - Отчистить поле");
                                Console.WriteLine("SetName – Установить имя");
                                Console.WriteLine("SetPassword – Установить пароль");
                                Console.WriteLine("WriteName – вывести имя после ввода пароля");
                                Console.WriteLine("Exit – выход");
                                    break;
                            case "Clear":
                                Console.Clear();
                                break;
                            case "SetName":                                 
                                login[i, 0] = InputString("Введите имя: ");
                                break;
                            case "SetPassword":
                                if (login[i, 0] != "")
                                {
                                    login[i, 1] = InputString("Введите пароль: ");
                                    i++;
                                }
                                else
                                {
                                    Console.WriteLine("Для данной операции установите имя");
                                }
                                break;
                            case "WriteName":
                                password = InputString("Введите пароль: ");
                                for (int j = 0; j <= i; j++)
                                {
                                    if (login[j,1] == password)
                                    {
                                        Console.WriteLine(login[j,0]);
                                        break;
                                    }
                                    if (j == i)
                                    {
                                        Console.WriteLine("Имени с таким паролем несуществует");
                                    }
                                }
                                break;
                            case "AdminHelper":
                                for (int j = 0; j <= i; j++)
                                {
                                    Console.WriteLine($"{login[j,0]} - {login[j, 1]}");
                                }
                                break;

                        }

                        Console.WriteLine();

                    } while (cycle != "Exit");

                    break;
            }

            Console.ReadKey();

            string InputString(string str)
            {
                Console.Write(str);
                return Console.ReadLine();
            }
        }
    }
}
