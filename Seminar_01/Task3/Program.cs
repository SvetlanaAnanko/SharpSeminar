// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) {
System.Console.WriteLine("ПН");
}
else if (day == 2) {
System.Console.WriteLine("ВТ");
}
else if (day == 3) {
System.Console.WriteLine("СР");
}
else if (day == 4) {
System.Console.WriteLine("ЧТ");
}
else if (day == 5) {
System.Console.WriteLine("ПТ");
}
else if (day == 6) {
System.Console.WriteLine("СБ");
}
else if (day == 7) {
System.Console.WriteLine("ВС");
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}
