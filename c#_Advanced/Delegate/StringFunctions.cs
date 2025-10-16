namespace Delegate;

public static class StringFunctions
{
    public static int GetCountOfUppercaseLetters(string str)
    {
        return str.Count(char.IsUpper);
    }

    public static int GetCountOfLowercaseLetters(string str)
    {
        return str.Count(char.IsLower);
    }
}