class FirstNum
{
    protected double x, y, z;
    private double a, b;
    public void InputXYZ()
    {
        Console.WriteLine("Введите x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z:");
        z = Convert.ToDouble(Console.ReadLine());
    }
    public void Calculate()
    {
        a = (3 + Math.Pow(Math.E, 2) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(z))));
        b = 1+Math.Abs(y-x)+((Math.Pow((y-x),2))/2)+((Math.Pow((x-y),2))/3);
    }
    public void ShowCalc()
    {
        Console.WriteLine($"При x = {x} y = {y} z = {z}");
        Console.WriteLine($"a = {a} и b = {b}");
    }

};
