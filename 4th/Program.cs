Console.WriteLine("Enter the number: ");
try {
    int x = Convert.ToInt32(Console.ReadLine());
    RemoveDigit(x);
} catch {
    Console.WriteLine("I`m asked you to enter NUMBER!!11!");
}

void RemoveDigit(int x) {
    string s = Convert.ToString(x);
    if(s.Length > 1) {
        s = s.Remove(1, 1);
        Console.WriteLine(s);
    } else {
        Console.WriteLine("There is no second digit!");
    }    
}
