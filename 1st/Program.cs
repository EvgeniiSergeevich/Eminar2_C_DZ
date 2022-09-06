try {
    Console.WriteLine("Enter a three-digit number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Digit(x));

} catch {
    Console.WriteLine("ENTER THE INTEGER NUMBER!!1");
}
int Digit(int x) {
    int d = (x - x % 10 - (x / 100) * 100) / 10;
    return d;
}
