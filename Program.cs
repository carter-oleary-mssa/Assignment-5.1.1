int[] arr = { 121, -121, 56765, 11111112 };
foreach (var i in arr)
{
    Console.WriteLine(IsPalindrome(i));
}

bool IsPalindrome(int x)
{
    if(x < 0) return false;
    int len = 1;
    int temp = x;
    while(temp > 10)
    {
        temp /= 10;
        len++;
    }
    temp = x;
    for(int i = 0; i < len/2; i++)
    {
        int divisor = (int)Math.Pow(10, len - 1 - i);
        if (temp % 10 != (x/divisor)%10) return false;
        temp /= 10;
    }
    return true;
}