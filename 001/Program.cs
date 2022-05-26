void Palindrom (int n)
{
    int num1 = n/1000;
    int num2 = n%10 *10 + n%100 / 10;
    if (num1 == num2)
    {
        Console.WriteLine ($"{n} -> yes");
    }
    else
    {
        Console.WriteLine ($"{n} -> no");
    }
}
Palindrom (89698);
Palindrom (78342);
Palindrom (45654);