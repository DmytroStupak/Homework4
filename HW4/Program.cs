namespace HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            bool rightNum = false;
            while (!rightNum)
            {
                Console.WriteLine("Enter the dimension of the array. The number must be an integer greater than zero");
                rightNum = int.TryParse(Console.ReadLine(), out n);
            }

            Task1(n);
        }

        public static void Task1(int n)
        {
            if (n > 0)
            {
                int[] arr = new int[n];
                int el = 0;
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = random.Next(1, 27);

                    if (arr[i] % 2 == 0)
                    {
                        el++;
                    }
                }

                Console.WriteLine();
                int[] arr1 = new int[el];
                int[] arr2 = new int[n - el];
                int count1 = 0;
                int count2 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arr1[count1] = arr[i];
                        count1++;
                    }
                    else
                    {
                        arr2[count2] = arr[i];
                        count2++;
                    }
                }

                foreach (var item in NumToChar(arr1).Arr)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
                foreach (var item in NumToChar(arr2).Arr)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
                if (NumToChar(arr1).Count > NumToChar(arr2).Count)
                {
                    Console.Write($"First array has more uppercase letters - {NumToChar(arr1).Count}");
                }

                if (NumToChar(arr2).Count > NumToChar(arr1).Count)
                {
                    Console.Write($"Second array has more uppercase letters - {NumToChar(arr2).Count}");
                }

                if (NumToChar(arr2).Count == NumToChar(arr1).Count)
                {
                    Console.WriteLine();
                    Console.WriteLine("Arrays with the same number of uppercase letters");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Array size cannot be negative or zero");
            }
        }

        public static (char[] Arr, int Count) NumToChar(int[] arr)
        {
            char[] res = new char[arr.Length];
            char[] let = new char[27];
            int count = 0;
            for (int i = 1; i < 27; i++)
            {
                let[i] = Convert.ToChar(i + 96);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < let.Length; j++)
                {
                    if (arr[i] == j)
                    {
                        if (arr[i] == 1 || arr[i] == 5 || arr[i] == 9 || arr[i] == 4 || arr[i] == 8 || arr[i] == 10)
                        {
                            res[i] = char.ToUpper(let[j]);
                            count++;
                        }
                        else
                        {
                            res[i] = let[j];
                        }
                    }
                }
            }

            return (Arr: res, Count: count);
        }
    }
}