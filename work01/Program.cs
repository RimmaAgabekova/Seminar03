// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int number = 0;
int result = 0;
int numForCalculation = 0;

Console.Write("Введите число: ");
numForCalculation = Convert.ToInt32(Console.ReadLine());
number = numForCalculation;

while(numForCalculation > 0) 
{
    result = (result * 10) + (numForCalculation % 10);
    numForCalculation = numForCalculation / 10;
}

if(result == number)
{
    Console.Write(result + "-> Да");
}
else
{
    Console.Write(result + " -> Нет");
}