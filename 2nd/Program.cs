try {
    Console.WriteLine("Enter the integer number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    ThirdDigit(x);
} catch {
    Console.WriteLine("Try again!");
}

void ThirdDigit(int x) {
    string number = x.ToString();
    if(number.Length >= 3) {
        Console.WriteLine(number[2]);
    } else {
        Console.WriteLine("No third digit!");
    }    
}
