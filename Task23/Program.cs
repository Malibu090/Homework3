// Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
void TablePOW3(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow = count * count * count;
        Console.WriteLine(pow + " ");
        count++;
    }
    Console.WriteLine();
}

TablePOW3("Введите число N: ");