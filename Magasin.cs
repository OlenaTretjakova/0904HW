using System;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace _0904HW
{
    internal class Magasine
    {
        public string _name { get; private set; }
        public DateTime _year { get; private set; }
        public string _description { get; private set; }
        public int _numberOfPeople { get; private set; }
        public Magasine(string name, DateTime year, string description, int numberOfPeople)
        {
            _name = name;
            _year = year;
            _description = description;
            _numberOfPeople = numberOfPeople;
        }
        public Magasine() : this("no name", DateTime.Now, "no description", 0)
        {
        }


        public static Magasine operator ++(Magasine magasine)
        {

            magasine._numberOfPeople = 5000 + magasine._numberOfPeople;

            return magasine;
        }

        public static Magasine operator --(Magasine magasine)
        {

            magasine._numberOfPeople = magasine._numberOfPeople - 1000;

            return magasine;
        }

        public static bool operator <(Magasine magasine, Magasine other)
        {
            if (magasine._numberOfPeople < other._numberOfPeople)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Magasine magasine, Magasine other)
        {
            if (magasine._numberOfPeople > other._numberOfPeople)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Magasine magasine, Magasine other)
        {

            if (magasine._name == other._name && magasine._year == other._year &&
                magasine._numberOfPeople == other._numberOfPeople)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool operator !=(Magasine magasine, Magasine other)
        {

            return !(magasine == other);

        }

        public override bool Equals(object obj)
        {
            if (obj is Magasine)
            {
                Magasine other = (Magasine)obj;
                if (_name == other._name && _year == other._year && _numberOfPeople == other._numberOfPeople)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public void ShowMagasine()
        {

            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Year: {_year}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Number of Readers: {_numberOfPeople}");

        }
    }

    public class Shop
    {
        public string _name { get; private set; }
        public int _area { get; private set; }
        public Shop(string name,int area)
        { 
            _name = name;
            _area = area;
        
        }

        public static Shop operator ++(Shop other)
        {
            other._area += 50;
            return other;
        }

        public static Shop operator --(Shop other)
        {
            other._area -= 20;
            return other;
        }

        public static bool  operator ==(Shop shop,Shop other)
        {
            return shop._area == other._area;
        }

        public static bool operator !=(Shop shop, Shop other)
        {
            return !(shop._area == other._area);
        }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                if( obj is Shop )
                {
                    Shop other = (Shop)obj;
                    if (other._area == _area && other._name == _name)
                        return true;
                }
            }
            return false;
        }

        public void ShowShop()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Area: {_area}");
           
        }

    }
}
