int coordXpointA;
int coordYpointA;
int coordXpointB;
int coordYpointB;
double lengthAB;

//считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату Х точки А");
    coordXpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х точки B");
    coordXpointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYpointB = int.Parse(Console.ReadLine());
}

//вычисляет расстояние между точками А и В
void calculateLength()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXpointA - coordXpointB), 2) + Math.Pow((coordYpointA - coordYpointB), 2));
}

readDataOfPoint();
calculateLength();

Console.WriteLine(lengthAB);