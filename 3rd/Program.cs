Console.WriteLine("Enter the number from 1 to 7: ");
try {
    int x = Convert.ToInt32(Console.ReadLine());
    DayOff(x);
} catch {
    Console.WriteLine("I`m asked you to ENTER A NUMBER!!1!");
}

void DayOff(int x) {
    if(x > 0 && x < 6) {
        Console.WriteLine($"The day {x} is a weekday day!");
    } else if (x >= 6 && x <= 7) {
        Console.WriteLine($"{x} is day off!");
    } else {
        Console.WriteLine($"There is no such day {x}");
    }
}