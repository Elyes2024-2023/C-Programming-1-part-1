using System;

class Conversion
{
    public static string ConvertToText(object obj)
    {
        // Convert object to text representation
        return obj.ToString();
    }

    public static T ConvertFromText<T>(string text)
    {
        // Convert text to object of type T
        return (T)Convert.ChangeType(text, typeof(T));
    }
}
