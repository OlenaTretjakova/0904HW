using System;

namespace _0904HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magasine magasine = new Magasine("Gross Book", new DateTime(2024, 4, 10), "Description of the magazine", 15000);

            Console.WriteLine();
            Console.WriteLine("Magasin befor to increase the number of people:");
            magasine.ShowMagasine();

            magasine ++;

            Console.WriteLine();
            Console.WriteLine("Magasin after to increase the number of people:");
            magasine.ShowMagasine();

            magasine --;

            Console.WriteLine();
            Console.WriteLine("Magasin after to decrease the number of people:");
            magasine.ShowMagasine();

            Magasine magasine3 = new Magasine("Accounting", new DateTime(2022, 4, 10), "Description of the magazine", 15000);
            Magasine magasine4 = new Magasine("Accounting work", new DateTime(2020, 4, 10), "Description of the magazine", 15000);

            Console.WriteLine();
            Console.WriteLine("Magasin 3:");
            magasine3.ShowMagasine();

            Console.WriteLine();
            Console.WriteLine("Magasin 4:");
            magasine4.ShowMagasine();

            Console.WriteLine();
            Console.Write("Magasine 3 == magasine4 :");
            Console.WriteLine(magasine3 == magasine4);

            Console.WriteLine();
            Console.Write("Magasine 3 != magasine4 :");
            Console.WriteLine(magasine3 != magasine4);

            Console.WriteLine();
            Console.Write("Magasine 3 < magasine4 :");
            Console.WriteLine(magasine3 < magasine4);

            Console.WriteLine();
            Console.Write("Magasine 3 < magasine4 :");
            Console.WriteLine(magasine3 < magasine4);

            Console.WriteLine();
            Console.Write("Magasine3.Equals(magasine4) :");
            Console.WriteLine(magasine3.Equals(magasine4));

            Shop shop1 = new Shop ( "Zarra", 3000 );

            Console.WriteLine();
            Console.WriteLine("Shop 1 :");
            shop1.ShowShop();

            Shop shop2 = new Shop("Mango", 3700);

            Console.WriteLine();
            Console.WriteLine("Shop 2 :");
            shop2.ShowShop();

            shop1++;

            Console.WriteLine();
            Console.WriteLine("Shop 1 :");
            shop1.ShowShop();

            shop2--;

            Console.WriteLine();
            Console.WriteLine("Shop 2 :");
            shop2.ShowShop();

            Console.WriteLine();

            Console.Write($" Shops {shop1._name} == {shop2._name} :");
            Console.WriteLine(shop1 == shop2);
            Console.WriteLine();

            Console.Write($" Shops {shop1._name} != {shop2._name} :");
            Console.WriteLine(shop1 != shop2);
            Console.WriteLine();

            Console.Write($" Shops {shop1._name}.Equals({shop2._name}):");
            Console.WriteLine(shop1.Equals(shop2));
            Console.WriteLine();





            Console.ReadLine();


        }
    }
}
