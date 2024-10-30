namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "  Abcd12 @abc   ";

            //password.Replace('b','a');
            //password.Substring(0, 8);
            //Console.WriteLine(Replace(password, 'a', 'd'));
            //password.Trim();
            //Console.WriteLine(Substring(password,0,5));
            //Console.WriteLine(Substring(password,0));
            Console.WriteLine(Trim(password)+"test");
            Console.WriteLine(ValidatePassword(Trim(password)));


        }
        #region task1
        static bool ValidatePassword(string password)
        {

            /*1. ValidatePassword(string password) - 
             * methodunuz olur, parameter olaraq qebul etdiyi stringin uzunlugu minimum 8,
             * böyük hərflə başlamalı, tərkibində minimum 1 rəqəm olmalı və minimum 1 karakter 
             * (hərf və ya rəqəm olmayan: misal  ?, !, @)
             * olmalıdır. Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır.*/
            bool result = true;
            if (password.Length < 8) result = false;
            if (!Char.IsUpper(password[0])) result = false;
            bool isDigit = false;
            bool isPunctuation = false;
            foreach (char c in password)
            {

                if (Char.IsDigit(c))
                {
                    isDigit = true;
                    break;
                }
            }
            if (!isDigit) result = false;
            foreach (char c in password)
            {
                if (Char.IsPunctuation(c))
                {
                    isPunctuation = true;
                    break;
                }
            }
            if (!isPunctuation) result = false;
            return result;
        }
        #endregion

        #region task2

        /*2. String`in Replace(), Substring(),Trim() methodlarını custom şəkildə yazmaq. 
         * Yəni sizin custom yazdığınız methodlarla stringin methodları eyni işi görməlidir.*/
        static string Replace(string input, char oldChar, char newChar)
        {
            string output = "";
            int i = 0;
            foreach (char c in input)
            {
                if (c == oldChar)
                {
                    output += newChar;
                    continue;
                }
                output += c;
                i++;
            }

            return output;
        }

        static string Substring(string input, int startIndex, int length)
        {
            string output = "";
            for (int i = startIndex; i < startIndex + length; i++)
            {
                output += input[i];
            }
            return output;
        }

        static string Substring(string input, int startIndex)
        {
            string output = "";
            for (int i = startIndex; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }

        static string TrimStart(string input)
        {
            string output = "";
            bool noSpace = false;

            foreach (char c in input)
            {
                if (c == ' ' && !noSpace)
                {
                    continue;
                }
                noSpace = true;
                output += c;
            }
            return output;
        }

        static string TrimEnd(string input)
        {
            int endIndex = input.Length - 1;
            while(endIndex >= 0 && input[endIndex]==' ')
            {
                endIndex--;
            } 

            return Substring(input,0,endIndex);
        }

        static string Trim(string input)
        {
            string output = TrimEnd(TrimStart(input));
            return output;
        }

        #endregion

    }
}
