using System;
using System.Text;

namespace lab_exceptions1
{
    class Program
    {
        public static void Main()
        {
            int result = 0;
            int count = 0;
            StringBuilder no_file = new StringBuilder();
            StringBuilder no_data = new StringBuilder();
            StringBuilder overflow = new StringBuilder();
            for (int i = 10; i < 30; i++)
            {
                try
                {
                    string[] input = File.ReadAllLines($"{i}.txt");
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    checked
                    {
                        result += a * b;
                    }
                    count++;
                }
                
            }
        }
    }
}