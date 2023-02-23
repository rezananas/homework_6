/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
k1 * x + b1 = k2 * x + b2
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double Promt (string message)   // Ввод чисел
{
    System.Console.Write (message);
    double result = Convert.ToDouble (Console.ReadLine ());
    return result;
}

double [] InputLineData (int numberOfLine)  // Ввод данных по прямой
{
    double [] lineData = new double [2];
    lineData [COEFFICIENT] = Promt ($"Введите коэффициент для {numberOfLine} прямой: ");
    lineData [CONSTANT] = Promt ($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}

double [] lineData1 = InputLineData (LINE1);
double [] lineData2 = InputLineData (LINE2);

double [] FindCoords (double [] lineData1, double [] lineData2)  // Поиск координат
{
    double [] coord = new double [2];
    coord [X_COORD] = (lineData2 [CONSTANT] - lineData1 [CONSTANT]) / (lineData1 [COEFFICIENT] - lineData2 [COEFFICIENT]);
    coord [Y_COORD] = lineData1 [COEFFICIENT] * coord [X_COORD] + lineData1 [CONSTANT];
    return coord;
}

bool ValidateLines (double [] lineData1, double [] lineData2) // Проверка, что прямые не совпадают и не параллельны
{
    if (lineData1 [COEFFICIENT] == lineData2 [COEFFICIENT])
    {
        if (lineData1 [CONSTANT] == lineData2 [CONSTANT])
        {
            Console.WriteLine ("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine ("Прямые параллельны");
            return false;
        }
    }
    return true;
}

if (ValidateLines (lineData1, lineData2))
{
    double [] coord = FindCoords (lineData1, lineData2);
    Console.WriteLine ($"Координаты точки пересечения двух прямых равны ({coord [X_COORD]}, {coord [Y_COORD]})");
}