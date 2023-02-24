// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введи пятизначное число: ");
string number = Console.ReadLine();
int l = number.Length;
int number1;
bool isNumber = int.TryParse(number,out number1);
int i = 0;

if (isNumber == true)
{
              if (number1>9999 && number1<100000)
              {

                            while (i<l/2)
                            {
                                         if (number[i] == number[l-1])
                                          { 
                                                       i++;
                                                       l--;
                                                       Console.WriteLine("Число является палиндромом.");
                                          } 
                                          else  Console.WriteLine("Число не является палиндромом.");
                                          break;
                            }
              }
              else Console.WriteLine("Ввенное число не является пятизначным");
}
else Console.WriteLine("Введеное число не является числом");
