Console.WriteLine("Введите количество программистов: ");
try {
    int x = Convert.ToInt32(Console.ReadLine());
    NumberOfProgrammers(x);
} catch {
    Console.WriteLine("Количество программистов должно быть целым положительным числом!!1");
}

void NumberOfProgrammers(int x) {
    string programmer = "программист";

    if (x % 100 == 11 || x % 100 == 12 || x % 100 == 13 || x % 100 == 14){
        Console.WriteLine(x + " " + programmer + "ов");
    } 
    else if(x % 10 == 1) {
        Console.WriteLine(x + " " + programmer);
    } 
    else if (x % 10 == 2 || x % 10 == 3 || x % 10 == 4) {
        Console.WriteLine(x + " " + programmer + "а");
    }  else {
        Console.WriteLine(x + " " + programmer + "ов");
    }
}
