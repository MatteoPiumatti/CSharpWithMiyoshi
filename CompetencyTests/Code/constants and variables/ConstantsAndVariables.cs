/*
Matteo Piumatti
date completed:9/25/2022
date started: 9/25/2022
pysudocode: declares 1 bool, 3 int, 3 char, 3 string, 3 double. it checks the cariable test, 
and prints my initials.
Problem: learning how to declare and use variables.





*/
/*
Main();

static int Main()
{
    Console.WriteLine("Hello World!");
    const double c = 3.0e8;
    const double g = 9.8;
    const double h = 6.63e-34; // Plank's constant: constant gives the relationship between the energy of a photon and its frequency
    const double p = 3.1415; //Pi= the realationship between the radius and the circumfrance.
    const double k = 1.38e-23; //Boltzman constant relates the enrgy and temperature of a gas.
    bool test = true;
    if (test == true)
    {
        Console.WriteLine("test is true");
    
    }
    int myAge = 14;
    int myHieght = 165; //cm
    int myWeight = 140; //lbs

    char firstLetterOfMyName = 'M';
    char firstLetterOfLastName = 'P';
    char dot = '.';

    Console.WriteLine("my initials {0}{1}{2}",firstLetterOfMyName,firstLetterOfLastName,dot);

    string favoriteStroke = "freestyle";
    string leastFavoriteStroke = "backstroke";
    string favoritePlaceToVisit = "Hawaii";

    return 0;
*/
{
    /*
 Matteo Piumatti
problem: let user choose min value and max value 
*/


/*
/*
 Matteo Piumatti
problem: create a 6 sided dice and a 12 sided dice that acts like a dice so it outputs numbers 
also create a code that makes a random double ranging from 0.0 to 5.0, and a random capital letter.
pysudo code: for the first 2 it acts like a 6 sided and 12 sided dice and displays a random number to the screen
for the double it print a random number from 0.0 to 5.0
and finally it makes a random capital latter from the alphabet.
start date: 10/4/2022    end date: 10/4/2022
*/
/*
namespace dice_and_random_numbers




{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int min = 1, max = 6;
            int dice1 = min + rng.Next(max - min + 1);
            Console.WriteLine(" 6 sided dice: " + dice1);
            

            
            int min2 = 1, max2 = 12;
            int dice2 = min + rng.Next(max - min + 1);
            Console.WriteLine(" and for the 12 sided dice you got... ... " + dice2 );

           
            double rd = rng.NextDouble()*5;
            double dmax = 5.0;
            Console.WriteLine("and you number from 0.0 to 5.0 is... " + rd);


           
            int charmin = 65;
            int charmax = 90;
            int rn = rng.Next(charmin, charmax);
            Console.WriteLine("and you winning letter is ... ... " + (char)rn);
            
        }
    }
}





*/

/*
Matteo Piumatti
problem: allows user to choose numbers that could change outcomes of certain things


*/



/*
namespace MoreRandomstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            double rd = rng.NextDouble();
            double dmax = 1.0;
            Console.WriteLine("and you number from 0.0 to 1.0 is... " + rd);




            Console.Write(" put a desierd integer: ");
            int intmin;
            intmin = Convert.ToInt32(Console.ReadLine());
            Console.Write(" input an integer: ");
            int intmax = Convert.ToInt32(Console.ReadLine());



            int rna = rng.Next(intmin, intmax);
            Console.WriteLine("your random int from from: " + intmin + " and " + intmax + " is: " +rna);







            double dra = rng.NextDouble();           
            Console.Write(" put a desierd double for min: ");
            double dubmin;
            dubmin = Convert.ToDouble(Console.ReadLine());
            Console.Write(" input an double for max: ");
            double dubmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your random double from " + dubmin + " to" + dubmax + " is " + dra  );


            Console.Write(" put a desierd number for min: ");
            char charmin;
            charmin = Convert.Tochar(Console.ReadLine());
            Console.Write(" input any number for max: ");
            char charmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your random character from " + charmin + " to" + charmax + " is " + cra  );
            char cra = rng.Next(charmin, charmax);







                     







        }
    }
}
*/
/*

namespace MoreRandomstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleperbus = 60;

            Console.WriteLine("choose how many People will go on this trip: ");
            int intmax = Convert.ToInt32(Console.ReadLine());
            b = intmax / peopleperbus;
            Console.WriteLine("these are the amount of buses you need: " + b);
            v = intmax % peopleperbus; //alternative: intmax - b*60
            
            Console.WriteLine("these are the amount of people that will have to ride in vans: " + v)
        }
    }

}


*/


namespace MoreRandomstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many miles have you traveled: " + miles);
             int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" how many hours did you spend: " + hours );
             int gal = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("how many gallons did you use: " + gal);
             mph = hours / miles;
             Console.WriteLine("you are going at around " + mph + " miles per hour" );
             mpg = miles / gal;
             Console.WriteLine("you are using " + mpg  + " miles per gallon"){0:0.0};

        }
    }
}
