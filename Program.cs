string[,] mas = new string[2, 3]; Console.WriteLine("Введите данные пользователей");
string a;
Console.WriteLine("Пользователь №1"); 
Console.Write("Имя: ");
mas[0, 0] = Console.ReadLine(); 
Console.Write("Город: ");
mas[0, 1] = Console.ReadLine(); 
mas[0, 2] = Convert.ToString(1);
Console.WriteLine("Пользователь №2");
Console.Write("Имя: ");
mas[1, 0] = Console.ReadLine();
Console.Write("Город: ");
mas[1, 1] = Console.ReadLine();
mas[1, 2] = Convert.ToString(2);
Console.WriteLine("О каком пользователя вывести информацию? 1/2");
a = Console.ReadLine();
if (a == mas[0, 2])
{
    Console.WriteLine($"Информация о пользователе №1:");
    Console.WriteLine($"Имя: {mas[0,0]}");
    Console.WriteLine($"Город: {mas[0, 1]}");
}
else
{
    Console.WriteLine($"Информация о пользователе №2:");
    Console.WriteLine($"Имя: {mas[1, 0]}");
    Console.WriteLine($"Город: {mas[1, 1]}");
}