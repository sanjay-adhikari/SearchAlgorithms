namespace Common
{
    public static class CommonImplementation
    {
        private static int _target;
        private static readonly int[] arr = { 3, 4, 7, 9, 10, 13, 15, 16, 22, 29, 30, 36, 44, 57, 58, 61, 63, 65 };
        public static int Target { get {
                Random random = new Random();
                int randomIndex = random.Next(0, arr.Length);
                _target = arr[randomIndex];
                Console.WriteLine($"Target: {_target}");
                return _target;
            } 
        }

        public static void DisplayResult(int indx)
        {
            if (indx == -1)
            {
                Console.WriteLine($"{_target} Not Found !!! ");
            }
            else {
                Console.WriteLine($"{_target} found at index {indx}");
            }            

            Console.WriteLine("----------------------------------------------------------------------------------------\n\n");
        }

        public static int[] GetArray
        {
            get
            {
                Display(arr);
                return arr;
            }
        }
        private static void Display(this int[] arr) {
            var str = String.Join(", ", arr);
            Console.WriteLine("Input: " + str); 
        }

        
    }
}