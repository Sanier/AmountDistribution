AmountDistribution.AmountDistr amountDistr = new AmountDistribution.AmountDistr();

Console.WriteLine("Введите тип распределения (ПОСЛ, ПЕРВ, ПРОП)");
string name = Console.ReadLine();

Console.WriteLine("Введите распределяемую сумму");
float summ = MathF.Round(float.Parse(Console.ReadLine(), (System.Globalization.NumberStyles)2));

Console.Write("Введите количество сумм, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число
string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)

for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    strs[i] = Console.ReadLine(); //Заполняем его
}

amountDistr.AmountDistrub(name, summ, strs);