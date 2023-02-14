namespace New_4_3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, -6, 9, 0, 2, 1, -4 };
            int quantity = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    quantity++;
                }
            }
            Console.Write("Количество положительных чисел в массиве: " + quantity);

        }
    }
}