using System;

namespace Answers
{
    public static class OneB
    {
       public static string ExI(string text)
       {//i
            return text.Substring(0, text.Length / 2);

       }

        public static bool ExII(string text)
        {//ii
            return (text[0] == 'a' && text[text.Length] == 'z');
        }

        public static string ExIII(string text)
        {//iii
            return text.Trim();
        }
    }

}
