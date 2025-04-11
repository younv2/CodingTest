using System.Text;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        StringBuilder stringBuilder = new StringBuilder();
        string[] t = phrase.Split(' ');
        for(int i = 0; i < t.Length;i++)
        {
            t[i] = UpperFirstChar(t[i]);
            stringBuilder.Append(t[i]+ " ");
        }
        stringBuilder.Remove(phrase.Length, 1);
        return stringBuilder.ToString();
    }
    public static string UpperFirstChar(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return null;
        }

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}