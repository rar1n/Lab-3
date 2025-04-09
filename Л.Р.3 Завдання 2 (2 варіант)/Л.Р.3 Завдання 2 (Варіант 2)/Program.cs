using System;
public class Moneta
{
    public int Nominal { get; set; } // Номінал монети
    public int Kilkist { get; set; } // Кількість монет
    public Moneta(int nominal, int kilkist) 
    {
        Nominal = nominal; 
        Kilkist = kilkist; 
    }
    public string MonetaInfo() // Інформація про монету
    {
        return $"Номiнал монети: {Nominal} грн, Кiлькiсть монет: {Kilkist}";  
    }
    public int SumaMonet() // Обчислення суми монет
    {
        return Nominal * Kilkist;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введiть номiнал монети (1, 2, 5, 10 i т.д.): "); // Введення номіналу монети
        int nominal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введiть кiлькiсть монет: "); // Введення кількості монет
        int kilkist = Convert.ToInt32(Console.ReadLine());
        Moneta moneta = new Moneta(nominal, kilkist); 
        Console.WriteLine(moneta.MonetaInfo()); 
        int smonet = moneta.SumaMonet(); 
        Console.WriteLine($"Сума монет: {smonet} грн");
    }
}