int[] arr = { 121, -121 };
foreach (var i in arr)
{
    Console.WriteLine(IsPalindrome(i));
}

bool IsPalindrome(int x)
{
    string s = x.ToString();
    for (int i = 0; i < s.Length/2; i++)
    {
        if (s[i] != s[s.Length - 1 - i]) return false;
    }
    return true;
}