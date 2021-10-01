using System;

namespace Въвеждане_на_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double variable;
            double[] nums = new double[3];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Число = ");
                nums[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 1; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        variable = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = variable;
                    }
                }
            }
            Console.Write("\n");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(+nums[i] + "; ");
            }
        }
    }
}
