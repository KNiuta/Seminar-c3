/*
Доп. задание №2:
Назовем число интересным, если в нем разность максимальной и минимальной 
цифры равняется средней по РАСПОЛОЖЕНИЮ цифре. Напишите программу, которая
 определяет интересное число или нет. Если число интересное, следует вывести
  – «Число интересное» иначе «Число неинтересное».
-> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
Средняя цифра - цифра(962-6, 23456 - средняя 4)
*/

Console.WriteLine("Введите число с нечетным количестом цифр:");
string number = Console.ReadLine();
int Length = number.Length;
var i=1;
var k=1;
int number1;
bool isNumber = int.TryParse(number,out number1);
if (isNumber == true)     
{  
 var max = int.Parse(number[0].ToString());
 var min = int.Parse(number[0].ToString());
  if (Length%2 == 1)
  {
    while ((i<Length) && (k<Length)) 
      {
        if (max<int.Parse(number[i].ToString())) 
          {
              max = int.Parse(number[i].ToString());
              i++;
          } 
          else max = max;
          if (min>int.Parse(number[k].ToString())) 
          {
            min = int.Parse(number[k].ToString());
            k++;
          }  
          else min = min;
      }
    var s = Length/2;         
    if (max-min == int.Parse(number[s].ToString()))
    {
      Console.WriteLine("Число интересное"); 
    }          
    else
     Console.WriteLine("Число не интересное"); 
  }
  else Console.WriteLine("Число имеем четное количество цифр");
}
else Console.WriteLine("Запись не явлеется числом.");

