void Zadacha41()
{

    //Пользователь вводит с клавиатуры M чисел. 
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 3
    Console.WriteLine("Сколько чисел хотите ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (number > 0) count++;
    }
    Console.WriteLine($"Было введено {count} больше нуля");
}

void Zadacha43()
{
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (0,2; 0,4)

int k1 = 5;
int b1 = 2;
int k2 = 9;
int b2 = 4;

if (k1 == k2)
{
    Console.WriteLine("Нет точки пересечения, прямые параллельны");
}
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    double y2 = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения А ({Math.Round(x, 2)},{Math.Round(y)})");
    Console.WriteLine($"Координаты точки пересечения А ({Math.Round(x, 2)},{Math.Round(y2)})");
}


}




//Zadacha41();
Zadacha43();