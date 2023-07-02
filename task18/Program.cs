/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void ShowCoordinates(int Quarter)
{
    if (Quarter == 1) {
        Console.WriteLine("X > 0, Y > 0");
    }
    else if (Quarter == 2) {
        Console.WriteLine("X < 0, Y > 0");
    }
    else if (Quarter == 3) {
        Console.WriteLine("X < 0, Y < 0");
    }
    else if (Quarter == 4) {
        Console.WriteLine("X > 0, Y > 0");
    }
    else
    {
        Console.WriteLine("No such quarter.");
    }
}

Console.WriteLine("Enter quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());

ShowCoordinates(quarter);