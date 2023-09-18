using labshar1;
using System.Security.Cryptography.X509Certificates;

int i = 1;
while (i == 1)
{
    Console.WriteLine("\nВведите номер задания для выполнения\n1. Вычисление по формулам\n2. Вычисление радиуса вписанной окружности треугольника по координатам его вершин\n3. Вычисление модуля\n4. Времена года\n5. Выход из программы");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num){
    case 1:
        Console.WriteLine("Начало первого задания\n");
        var obj1 = new FirstNum();
        obj1.InputXYZ();
        obj1.Calculate();
        obj1.ShowCalc();
        Console.WriteLine("Конец первого задания\n");
    break;
    case 2:
        Console.WriteLine("Начало второго задания\n");
        var obj2 = new SecondNum();
        obj2.InputTrianglePoints();
        obj2.CalculateInnerCircleRadius();
        obj2.ShowCalculate();
        Console.WriteLine("Конец второго задания\n");
    break;
        case 3:
            Console.WriteLine("Начало выполнения третьего задания\n");
            var obj3 = new TherdNum(20);
            obj3.CalcAbs();
            obj3.ShowAbs();
            Console.WriteLine("Конец выполнения третьего задания\n");
            break;
        case 4:
            Console.WriteLine("Начало выполнения четвертого задания\n");
            string EyarTime;
            Console.WriteLine("Введите время года\n");
            EyarTime = Console.ReadLine();
            switch (EyarTime)
            {
                case "Весна":
                    Console.WriteLine("Весна = тепло");
                    break;
                case "Лето":
                    Console.WriteLine("Лето = жарко");
                    break;
                case "Осень":
                    Console.WriteLine("Осень = холодно");
                    break;
                case "Зима":
                    Console.WriteLine("Зима = очень холодно");
                    break;

            }
            Console.WriteLine("Конец выполнения четвертого задания\n");
            break;
        case 5:
            Console.WriteLine("Завершение работы программы.\n Досивдания");
            i = 0;
            break;
}
}