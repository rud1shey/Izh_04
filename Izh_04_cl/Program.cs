
namespace Izh_04_cl
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public static int FindMaxValue(int[] array)
        {
            int result = 0;
            foreach (int item in array)
            {
                if (item > result)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
