// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}
int value1;
int value2;
value1 = Prompt("Введите первое число > ");
value2 = Prompt("Введите второе число > ");
if (value1 > value2)
{
    System.Console.WriteLine($"max = {value1}, min = {value2}");
}
else if (value1 < value2)
{
    System.Console.WriteLine($"max = {value2}, min = {value1}");
}
else if (value1 == value2)
{
    System.Console.WriteLine("Они равны");
}