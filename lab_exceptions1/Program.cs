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
            StringBuilder bad_data = new StringBuilder();
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
                catch (FileNotFoundException)
                {
                    no_file.Append($"{i}.txt\t");
                }
                catch (FormatException)
                {
                    bad_data.Append($"{i}.txt\t");
                }
                catch (OverflowException)
                {
                    overflow.Append($"{i}.txt\t");
                }
            }
            try
            {
                File.WriteAllText("no_file.txt", no_file.ToString());
                File.WriteAllText("bad_data.txt", bad_data.ToString());
                File.WriteAllText("overflow.txt", overflow.ToString());
            }
            catch
            {
                new Exception("File can't be created/overwrited");
            }
            Console.WriteLine($"res = {result / count}");
        }
    }
}