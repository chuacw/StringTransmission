using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StringTransmission
{
    class Solution
    {
        static StreamReader sr;

        static int ReadNumber()
        {
            StringBuilder sb = new StringBuilder();
            int lNumber = 0; char ch = ' ';

            do
            {
                int i = sr.Read();
                if (i == -1) break;
                ch = Convert.ToChar(i);
            } while (!Char.IsNumber(ch));
            sb.Append(ch);

            do
            {
                int i = sr.Read();
                if (i == -1) break;
                ch = Convert.ToChar(i);
                if (Char.IsNumber(ch)) sb.Append(ch);
            } while (Char.IsNumber(ch));

            lNumber = Convert.ToInt32(sb.ToString());
            return lNumber;
        }

        static void Main(string[] args)
        {
            sr = new StreamReader(Console.OpenStandardInput());
            int T = ReadNumber();
            for (int i = 1; i <= T; i++)
            {
                int N = ReadNumber();
                int K = ReadNumber();

            }
        }
    }
}
