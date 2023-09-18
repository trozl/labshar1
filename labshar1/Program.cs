using labshar1;
using System.Security.Cryptography.X509Certificates;

int i = 1;
while (i == 1)
{
    Console.WriteLine("Введите номер задания для выполнения\n1. Вычисление по формулам\n2. Вычисление радиуса вписанной окружности треугольника по координатам его вершин\n3. Вычисление модуля\n4. Времена года\n5. Выход из программы");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num){
    case 1:
        Console.WriteLine("Начало первого задания");
        var obj1 = new FirstNum();
        obj1.InputXYZ();
        obj1.Calculate();
        obj1.ShowCalc();
        Console.WriteLine("Конец первого задания");
    break;
    case 2:
        Console.WriteLine("Начало второго задания");
        var obj2 = new SecondNum();
        obj2.InputTrianglePoints();
        obj2.CalculateInnerCircleRadius();
        obj2.ShowCalculate();
        Console.WriteLine("Конец второго задания");
    break;
        case 3:
            Console.WriteLine("W.I.P");
            break;
        case 4:
            Console.WriteLine("W.I.P");
            break;
        case 5:
            Console.WriteLine("Завершение работы программы.\n Досивдания");
            i = 0;
            break;
}
}