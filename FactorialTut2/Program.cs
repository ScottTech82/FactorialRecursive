Console.WriteLine("Factorial with Recursion");

//Factorial Recursively

int target = 6;
int product = Factorial(target);

int Factorial(int nbr)
    {
        if (nbr == 1)
        {
            return 1;
        }
        return nbr * Factorial(nbr - 1);
    }

//Factorial Loop not recursive

//int FactorialLoop(int nbr)
//    {
//        int product = 1;
//
//        for(int i = 1; i <= target; i++)
//    {
//        product *= i;
//    }
//        return product;
//    }

    Console.WriteLine($"{target}! is {product}");
}
