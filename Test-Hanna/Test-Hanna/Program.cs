using System;
using System.Linq;


namespace TestHanna
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //01.md
            NumberOne.myName();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //02.md
            NumberTwo.birthday();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //03.md
            NumberThree.countString();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //04.md
            string[] censoredWords = { "imperdiet", "dolor", "duo" };
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            NumberFour.Censor(censoredWords, paragraph);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //05.md
            NumberFive.isEven();
            NumberFive.isOdd();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //06.md
            NumberSix.grade();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //07.md
            NumberSeven.celciusToFahrenheit(0);
            NumberSeven.fahrenheitToCelcius(50);
            NumberSeven.celciusToKelvin(100);
            NumberSeven.kelvinToCelcius(375);
            NumberSeven.kelvinToFahrenheit(375);
            NumberSeven.fahrenheitToKelvin(12);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //08.md
            NumberEight.isLeapYear();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //09.md
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            NumberNine.timeZoneDiff(jakarta, london);
            NumberNine.timeZoneDiff(cairo, chicago);
            NumberNine.timeZoneDiff(cairo, bali);
            NumberNine.timeZoneDiff(denver, jakarta);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //10.md
            NumberTen.Sum(1, 6);
            NumberTen.Multiply(2, 6);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //11.md
            NumberEleven.sumArray();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //12.md
            NumberTwelve.upperCase("hello world");
            NumberTwelve.upperCase("welcome to the world");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //13.md
            NumberThirteen.countWords("Hello");
            NumberThirteen.countWords("Hello World");
            NumberThirteen.countWords("Lorem ipsum dolor sit amet");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //14.md
            NumberFourteen.isPalindrome("ipsum");
            NumberFourteen.isPalindrome("malam");
            NumberFourteen.isPalindrome("tidur");
            NumberFourteen.isPalindrome("kasur rusak");
            NumberFourteen.isPalindrome("ibu ratna antar ubi");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //15.md
            NumberFifteen.Mirror("--vv");
            NumberFifteen.Mirror("..ww");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //16.md
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };
            NumberSixteen.indexFinder(fruits, "Jeruk");
            NumberSixteen.indexFinder(fruits, "Pepaya");
            NumberSixteen.indexFinder(fruits, "Markisa");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //17.md
            NumberSeventeen.Loop();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //18.md
            NumberEighteen.findMax();
            NumberEighteen.findMin();
            NumberEighteen.findAverage();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //19.md
            NumberNineteen.Sort();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //20.md
            NumberTwenty item = new NumberTwenty();
            item.name = "Indomie Goreng";
            item.price = 3500;
            item.onSale = true;
            Console.WriteLine(item.print());

        }
    }
}

class NumberOne
{
    public static void myName()
    {
        Console.WriteLine("Input your name: ");

        string name = Console.ReadLine();

        Console.WriteLine("Hello, my name is " + name);
    }
}

class NumberTwo
{
    public static void birthday()
    {
        int year = 365;
        int days = 115;

        int counting = year - days;

        Console.WriteLine($"{counting} days remaining to my next birthday");

    }
}

class NumberThree
{
    public static void countString()
    {
        string word1 = "Hello World";
        string word2 = "Hello Universe";

        string w1 = word1.Replace(" ", "");
        string w2 = word2.Replace(" ", "");

        int oneLength = w1.Length;
        int twoLength = w2.Length;

        Console.WriteLine($"'{word1}' have {oneLength} characters");
        Console.WriteLine($"'{word2}' have {twoLength} characters");
    }
}

class NumberFour
{
    public static void Censor(string[] censored, string paragraph)
    { 
        for (int i=0; i < censored.Length; i++)
        {
            string x = "";
            for ( int j=0; j < censored[i].Length; j++)
            {
                x += "*";
            }

            paragraph = paragraph.Replace(censored[i], x);
        }

        Console.WriteLine(paragraph);
    }
}

class NumberFive
{
    public static void isEven()
    {
        int i;

        Console.WriteLine("Enter Even Number: ");

        i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public static void isOdd()
    {
        int i;

        Console.WriteLine("Enter Odd Number: ");

        i = int.Parse(Console.ReadLine());
        if (i % 2 != 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

class NumberSix
{
    public static void grade()
    {
        int i;

        Console.WriteLine("Input the grade: ");

        i = int.Parse(Console.ReadLine());
        if ( i >= 90)
        {
            Console.WriteLine("A");
        } else if (i >= 80 || i >= 89)
        {
            Console.WriteLine("B");
        } else if (i >= 70 || i >= 79)
        {
            Console.WriteLine("C");
        } else if (i >= 60 || i >= 69)
        {
            Console.WriteLine("D");
        } else
        {
            Console.WriteLine("E");
        }
    }
}

class NumberSeven
{
    public static void celciusToFahrenheit(int c)
    {
        int f;
        f = (c * 9) / 5 + 32;

        Console.WriteLine($"Temperature in Fahrenheit is {f}");
    }

    public static void fahrenheitToCelcius(int f)
    {
        int c;
        c = (f - 32) * 5 / 9;

        Console.WriteLine($"Temperature in Celcius is {c}");
    }

    public static void celciusToKelvin(double c)
    {
        double k;
        k = (c + 273.15);

        Console.WriteLine($"Temperature in Kelvin is {k}");
    }

    public static void kelvinToCelcius(double k)
    {
        double c;
        c = (k - 273.15);

        Console.WriteLine($"Temperature in Celcius is {c}");
    }

    public static void kelvinToFahrenheit(double k)
    {
        double f;
        f = (k - 273.15) * 9 / 5 + 32;

        Console.WriteLine($"Temperature in Fahrenheit is {f}");
    }

    public static void fahrenheitToKelvin(double f)
    {
        double k;
        k = (f - 32) * 5 / 9 + 273.15;

        Console.WriteLine($"Temperature in Kelvin is {k}");
    }
}

class NumberEight
{
    public static void isLeapYear()
    {
        Console.WriteLine("Enter Year : ");
        int y = int.Parse(Console.ReadLine());

        if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

class NumberNine
{
    public static void timeZoneDiff(Tuple<string, int> Kota1, Tuple<string, int> Kota2)
    {
        if (Kota1.Item2 > Kota2.Item2)
        {
            var distance = Kota1.Item2 - Kota2.Item2;
            Console.WriteLine($"{Kota1.Item1} {distance} hours ahead of {Kota2.Item1}");
        }
        else if (Kota1.Item2 < Kota2.Item2)
        {
            var distance = Kota2.Item2 - Kota1.Item2;
            Console.WriteLine($"{Kota1.Item1} {distance} hours behind of {Kota2.Item1}");
        }


    }
}

class NumberTen
{
    public static void Sum(int a, int b)
    {
        int sum;

        sum = (a + b);
        Console.WriteLine(sum);
    }

    public static void Substract(int a, int b)
    {
        int sub;

        sub = (a - b);
        Console.WriteLine(sub);
    }

    public static void Multiply(int a, int b)
    {
        int mul;

        mul = (a * b);
        Console.WriteLine(mul);
    }

    public static void Divide(int a, int b)
    {
        int div;

        div = (a / b);
        Console.WriteLine(div);
    }
}

class NumberEleven
{
    public static void sumArray()
    {
        int[] i = {1,5,8,3};
        int sum = 0;

        foreach (var item in i)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}

class NumberTwelve
{
    public static void upperCase(string upper)
    {
        string newUpper = upper.ToUpper();
        Console.WriteLine(newUpper);
    }
}

class NumberThirteen
{
    public static void countWords(string words)
    {
        int text, a;

        a = 0;
        text = 1;

        while (a <= words.Length - 1)
        {
            if (words[a]==' ' || words[a]=='\n')
            {
                text++;
            }

            a++;
        }

        Console.WriteLine(text);
    }
}

class NumberFourteen
{
    public static void isPalindrome(string pal)
    {
        string rev;
        char[] word = pal.ToCharArray();
        Array.Reverse(word);

        rev = new string(word);
        bool palindrom = pal.Equals(rev, StringComparison.OrdinalIgnoreCase);
        if (palindrom == true)
        {
            Console.WriteLine("true");
        } else
        {
            Console.WriteLine("false");
        }
    }
}

class NumberFifteen
{
    public static void Mirror(string word)
    {
        
        char[] arr = word.ToCharArray();
        Array.Reverse(arr);

        string mirror = word + new string(arr); 

        Console.WriteLine(mirror);

    }
}

class NumberSixteen
{
    public static void indexFinder(string[] array, string x)
    {
        int index = Array.IndexOf(array, x);
        Console.WriteLine(index);
    }
}

class NumberSeventeen
{
    public static void Loop()
    {
        for (int i=1; i <= 1000; i++)
        {
            if (i % 100 == 0)
            {
                Console.WriteLine($"{i}. Baz");
            } else if (i % 20 == 0)
            {
                Console.WriteLine($"{i}. Bar");
            } else if (i % 5 == 0)
            {
                Console.WriteLine($"{i}. Foo");
            } else
            {
                Console.WriteLine(i);
            }
        }
    }
}

class NumberEighteen
{
    public static void findMax()
    {
        int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

        Console.WriteLine(numbers.Max());
    }

    public static void findMin()
    {
        int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

        Console.WriteLine(numbers.Min());
    }

    public static void findAverage()
    {
        int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

        Console.WriteLine(numbers.Average());
    }

}

class NumberNineteen
{
    public static void Sort()
    {
        int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45 };
    Array.Sort(points);

        foreach (int i in points)
        {
            Console.Write($"{i} ");
        }
    }
}

class NumberTwenty
{
        public string name;
        public double price;
        public bool onSale;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool OnSale
        {
            get { return onSale; }
            set { onSale = value; }
        }

        public string print()
        {
            if (onSale == true)
            {
                double sale = 0.2 * price;
                double newprice = price - sale; 
                return ($"{name} {newprice}");
            } else {
                return ($"{name} {price}");
            }

        }
}