class Task2Codes
{

    
    static void Main(String[] args)
    {
        int number=1;
        int sum=0;
        int mean = 0;
        int i = 0;
    
        while (number < 10)
        {
            
            if (number / 2 == 0) 

            {
                i++; // 1 2 3 4
                sum = sum + number; //  2  6 12 20

                mean = sum / i;  // 2  3  4  5
            }
            number++; // 2 4 6 8 -
        }

        Console.WriteLine("mean " +  mean); // 5

    }

}
