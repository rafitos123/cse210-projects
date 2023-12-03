using System;

class Program
{
    static void Main(string[] args)
    {
        //Order1
        Adress firstAdress = new Adress("Rua Graciliano Ramos", "Mogi Mirim","São Paulo","Brazil");
        Costumer firstCostumer = new Costumer("Rafael", firstAdress);
        List<Product> products1 = new List<Product>();
        Product firstProduct = new Product("Xbox One", "M850", 950, 2);
        products1.Add(firstProduct);
        Product secondProduct = new Product("Samsung A54", "MS89", 1200, 1);
        products1.Add(secondProduct);
        Order firstOrder = new Order(products1, firstCostumer);
        Console.WriteLine(firstOrder.GetPacking());;
        Console.WriteLine(firstOrder.GetShipping());
        Console.WriteLine($"Total: ${firstOrder.GetTotal()}");

        Console.WriteLine();
        
        //Order2
        Adress SecondAdress = new Adress("Street 105", "New York","New York","USA");
        Costumer SecondCostumer = new Costumer("Rafael", SecondAdress);
        List<Product> products2 = new List<Product>();
        Product ThirdProduct = new Product("Iphone X", "P29", 845, 3);
        products2.Add(ThirdProduct);
        Product FourthProduct = new Product("Iphone 15", "SS29", 1900, 2);
        products2.Add(FourthProduct);
        Order secondOrder = new Order(products2, SecondCostumer);
        Console.WriteLine(secondOrder.GetPacking());;
        Console.WriteLine(secondOrder.GetShipping());
        Console.WriteLine($"Total: ${secondOrder.GetTotal()}");

    }
}