using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_4eck
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            int temp;
            char[,] arr = { { 'q','w','e','r','t','y','u','i','o','p' },
                            { 'a','s','d','f','g','h','j','k','l','a' },
                            { 'z','x','c','v','b','n','m','z','x','c' } };

            temp = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < temp; i++)
            {
                char[] c = new char[2];
                c = Console.ReadLine().ToCharArray();

                int temp1 = -1, temp2 = -2;

                for (int j = 0; j < 3; j++)
                    for (int g = 0; g < 10; g++)
                        if (arr[j, g] == c[0]) temp1 = j;

                for (int j = 0; j < 3; j++)
                    for (int g = 0; g < 10; g++)
                        if (arr[j, g] == c[1]) temp2 = j;

                if (temp1 == temp2) output += "Yes\n";
                else if (temp1 != temp2) output += "No\n";

            }

            Console.Write(output);
            Console.ReadKey();

        }
    }
}
