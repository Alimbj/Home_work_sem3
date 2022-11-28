// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Denis!");


// Домашнее задание №19 Палиндром ли?
/* Console.WriteLine("Введите число");
String numbers = Console.ReadLine();
String verify = "";
for (int i = numbers.Length - 1; i >= 0; i--)
    verify += numbers[i];
Console.WriteLine(verify == numbers);
*/


//Домашнее задание №21 Расстояние между заданными координатами, в трехмерном пространстве
/* Console.WriteLine("Введите 6 чисел: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
*/


//Домашнее задание №23 Перебираем все кубы от 1 до N
/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int j = 1; j <= N; j++)
    Console.Write($"{Math.Pow(j, 3)} ");
*/


//Дополнительное задание, было интересно и многое узнал в процессе!!!Спасибо)
/* int max = 0;
var O = new List<int> {};
Console.WriteLine("Введите число кустов: ");
int N = int.Parse(Console.ReadLine());
int i;
for (i = 1; i <= N; i++){
    Console.WriteLine("Введите число ягод: ");
    int n = int.Parse(Console.ReadLine());
    O.Add(n);   // Добавляем в пустой список введенные числа n
}
foreach (int element in O)  //Выведем элементы созданного списка
{
    Console.WriteLine($" На этом кустике {element} ягод!");
}
int count;
for (int j = 0; j <= N-1; j++){
    if (j == 0)
        count = (O[N-1] + O[j] + O[j+1]);
    else if (j == N-1)
        count = (O[j-1] + O[j] + O[0]);
    else
        count = (O[j-1] + O[j] + O[j+1]);
    if (max < count)
        max = count;
}
Console.WriteLine($"Наибольший сбор равен {max} ягод");
*/



