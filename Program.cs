

/* 1 */
 for (int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
} 

/* 2 */
for (int i = 1; i < 101; i++)
 {
    if (i%3==0 && i%5==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i%5==0)
    {
          Console.WriteLine("Buzz");
    }
    else if (i%3==0)
    {
          Console.WriteLine("Fizz");
    }
    else
    {
        
     Console.WriteLine(i);
    }
} 

/* 3 */
int j =1;
while (j< 101)
{
    if (j%3==0 && j%5==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (j%5==0)
    {
          Console.WriteLine("Buzz");
    }
    else if (j%3==0)
    {
          Console.WriteLine("Fizz");
    }
    else
    {
        
     Console.WriteLine(j);
    }

    j++;
}