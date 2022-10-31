

int givenNumber = 123;
int myNumber=givenNumber
int lastNumber = 0;
int total = 0;

if (givenNumber < 0)
{
    Console.WriteLine("musbet eded daxil edin!");
}
else if (givenNumber == 0)
{
    Console.WriteLine("0");
}
else
{
    while (givenNumber > 0)
    {
        lastNumber = givenNumber % 10; // 3 2
        givenNumber = givenNumber / 10; // 123  12  1
        total = total + lastNumber;  // 3  5  6

    }
    Console.WriteLine("Sum of numbers for " + myNumber + " : " + total); // 6
}