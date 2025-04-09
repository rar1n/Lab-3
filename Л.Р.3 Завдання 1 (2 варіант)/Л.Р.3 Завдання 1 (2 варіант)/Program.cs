using System;
public class Square
{
    public double DovzhinaKvadrata { get; set; }  
    public Square(double dovzhinaKvadrata) 
    {
        DovzhinaKvadrata = dovzhinaKvadrata; 
    }
    public double Diagonal() // Знаходження діагоналі квадрата
    {
        return Math.Sqrt(2) * DovzhinaKvadrata;
    }
    public double Perimetr() // Знаходження периметра квадрата
    {
        return 4 * DovzhinaKvadrata;
    }
    public double Ploshcha() // Знаходження площі квадрата
    {
        return Math.Pow(DovzhinaKvadrata, 2); 
    }
    public void Result() // Виведення результатів
    {
        Console.WriteLine($"Сторона квадрата: {DovzhinaKvadrata} "); 
        Console.WriteLine($"Дiагональ квадрата: {Diagonal():F2} "); 
        Console.WriteLine($"Периметр квадрата: {Perimetr():F2} ");
        Console.WriteLine($"Площа квадрата: {Ploshcha():F2} ");
    }
}
public class Program 
{
    public static void Main() 
    {
        Console.WriteLine("Введiть довжину сторони квадрата: "); 
        double dovzhinaKvadrata = Convert.ToDouble(Console.ReadLine()); 
        Square kvadrat = new Square(dovzhinaKvadrata);
        kvadrat.Result();
    }
}