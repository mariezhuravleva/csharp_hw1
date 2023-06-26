/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Enter number from 1 to 7:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) {
    Console.WriteLine("Monday");
}
else if (number == 2) {
    Console.WriteLine("Tuesday");
}
else if (number == 3) {
    Console.WriteLine("Wensday");
}
else if (number == 4) {
    Console.WriteLine("Thursday");
}
else if (number == 5) {
    Console.WriteLine("Friday");
}
else if (number == 6) {
    Console.WriteLine("Saturday");
}
else if (number == 7) {
    Console.WriteLine("Sunday");
} else {
    Console.WriteLine("Error");
}