//-----------------------------Задача 21-------------------------------
//---------Показать расстояние между точками в 3D пространстве---------
//---------------------------------------------------------------------

// int coordXpointA;
// int coordYpointA;
// int coordZpointA;

// int coordXpointB;
// int coordYpointB;
// int coordZpointB;                                                          //Первый вариант, это просто немного измененный вариант с семинара

// double lengthAB;

// try                                                                                         
// {
//     //считывает координаты точек А и В
//     void readDataOfPoint()
//     {
//         Console.WriteLine("Введите координату Х точки А");
//         coordXpointA = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите координату Y точки А");
//         coordYpointA = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите координату Z точки А");
//         coordZpointA = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите координату Х точки B");
//         coordXpointB = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите координату Y точки B");
//         coordYpointB = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите координату Z точки B");
//         coordZpointB = int.Parse(Console.ReadLine());
//     }

//     //вычисляет расстояние между точками А и В
//     void calculateLength()
//     {
//         lengthAB = Math.Sqrt(Math.Pow((coordXpointA - coordXpointB), 2) + Math.Pow((coordYpointA - coordYpointB), 2) + Math.Pow((coordZpointA - coordZpointB), 2));
//     }
    
//     readDataOfPoint();
//     calculateLength();

//     Console.WriteLine(lengthAB);
// }
// catch(Exception)
// {
//     Console.WriteLine("Это не число или оно слишком большое, или слишком маленькое");
// }

//-------------------------------------------------------------------------------------------------------------------------------

//A (3,6,8); B (2,1,-7)

try                                                                                             //Второй вариант
{
Console.WriteLine("Введите координаты в данном формате: A (3,6,8); B (2,1,-7)");

string inputLine = Console.ReadLine();

int[,] readPoints()
{
    //достаем из введенной строки нужные координаты точки А
    string coordPointA = inputLine.Substring(0, inputLine.IndexOf(")"));
    coordPointA = coordPointA.Substring(coordPointA.IndexOf("(") + 1);

    //Из полученных координат для точки А достаем значение координат XYZ
    int coordXA = int.Parse(coordPointA.Substring(0, coordPointA.IndexOf(",")));

    int coordYA = int.Parse(coordPointA.Substring(coordPointA.IndexOf(",") + 1, ((coordPointA.LastIndexOf(",") - 1) - coordPointA.IndexOf(","))));

    int coordZA = int.Parse(coordPointA.Substring(coordPointA.LastIndexOf(",") + 1));

    //достаем из введенной строки нужные координаты точки В
    string coordPointB = inputLine.Substring(inputLine.LastIndexOf("(") + 1);
    coordPointB = coordPointB.Substring(0, coordPointB.LastIndexOf(")"));

    //Из полученных координат для точки В достаем значение координат XYZ
    int coordXB = int.Parse(coordPointB.Substring(0, coordPointB.IndexOf(",")));

    int coordYB = int.Parse(coordPointB.Substring(coordPointB.IndexOf(",") + 1, ((coordPointB.LastIndexOf(",") - 1) - coordPointB.IndexOf(","))));

    int coordZB = int.Parse(coordPointB.Substring(coordPointB.LastIndexOf(",") + 1));

    //Вставляем в массив координаты точек
    int[,] arrayOut = new int[2, 3];
    arrayOut[0, 0] = coordXA;
    arrayOut[0, 1] = coordYA;
    arrayOut[0, 2] = coordZA;
    arrayOut[1, 0] = coordXB;
    arrayOut[1, 1] = coordYB;
    arrayOut[1, 2] = coordZB;

    return arrayOut;
}

void calculateLength(int[,] coords)
{
    //Считаем расстояние между точек в 3D пространстве
    double distance3D = Math.Sqrt(Math.Pow((coords[0, 0] - coords[1, 0]), 2) + Math.Pow((coords[0, 1] - coords[1, 1]), 2) + Math.Pow((coords[0, 2] - coords[1, 2]), 2));
    
    Console.WriteLine("Расстояние между точками в 3D пространстве равно: " + distance3D);
}

//Это двумерный массив
int[,] arrayPoint = readPoints();

calculateLength(arrayPoint);
}
catch
{
    Console.WriteLine("Формат координат введен неправильно");
}

//-------------------------------------------------------------------------------------------------------------------------------