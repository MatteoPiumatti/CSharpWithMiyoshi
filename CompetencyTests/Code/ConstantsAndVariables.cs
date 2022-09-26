/*
Matteo Piumatti
date completed:9/25/2022
date started: 9/25/2022
pysudocode: declares 1 bool, 3 int, 3 char, 3 string, 3 double. it checks the cariable test, 
and prints my initials.
Problem: learning how to declare and use variables.





*/



int main()
{
    Console.WriteLine("Hello World!");
    const double c = 3.0e8;
    const double g = 9.8;
    const double h = 6.63e-34; // Plank's constant: constant gives the relationship between the energy of a photon and its frequency
    const double p = 3.1415; //Pi= the realationship between the radius and the circumfrance.
    const double k = 1.38e-23; //Boltzman constant relates the enrgy and temperature of a gas.
    bool test = true;
    {
        Console.WriteLine("speed of light",c);
        Console.WriteLine("acc of gravity",g);
        Console.WriteLine("planks constant",h);
        Console.WriteLine("Pi",p);
        Console.WriteLine("boltzman constant",k);
    }
    if (test == true)
    {
        Console.WriteLine("test is true");
    
    }
    int myAge = 14;
    int myHieght = 165; //cm
    int myWeight = 140; //lbs
    {
        Console.WriteLine("my age",myAge);
        Console.WriteLine("my hieght in cm",myHieght);
        Console.WriteLine("my weight in pounds",myWeight);
    }

    char firstLetterOfMyName = 'M';
    char firstLetterOfLastName = 'P';
    char dot = '.';

    Console.WriteLine("my initials {0}{1}{2}",firstLetterOfMyName,firstLetterOfLastName,dot);



    string favoriteStroke = "freestyle";
    string leastFavoriteStroke = "backstroke";
    string favoritePlaceToVisit = "Hawaii";

    Console.WriteLine("my favorite swimming stroke",favoriteStroke);
    Console.WriteLine("my least favorite stroke")



}