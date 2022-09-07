try {
    Console.WriteLine("Enter the integer number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    ThirdDigitStr(x);
    ThirdDigit(x);
} catch {
    Console.WriteLine("Try again!");
}

void ThirdDigitStr(int x) {
    string number = x.ToString();
    if(number.Length >= 3) {
        Console.WriteLine(number[2]);
    } else {
        Console.WriteLine("No third digit!");
    }    
}

void ThirdDigit(int x) {
    while(x >= 1000) {
        x = x/10;
    }
    if(x > 99) {
        Console.WriteLine(x % 10);
    } else {
        Console.WriteLine("No third digit!");
    }
}