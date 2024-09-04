using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TIlldelar ett namn till stirng utan ett värde 
            String input;
            // Args används för att ta emot argument, args.lenght talar om hur många argument det är 
            // Knappningen nedan kollar så att det finns minst ett "argument" i args så den inte är tom
            if (args.Length > 0)
            {
                //Tilldelar ett värde ifall det finns ett argument och då förs värdet av första argumentet (args[0]) över till input
                input = args[0];
            }
            else
            {
                // Om de inte skriver in en sträng/argument i args som tilldelas till input skrivs detta meddelandet ut 
                Console.WriteLine("Skriv in en sträng");
                //Vi läser vad användaren skrivit och lagrar det i input
                input = Console.ReadLine();
            }

            // Regex-mönster som söker efter ett tal som börjar och slutar på samma siffra 
            // \\b (Starten) visar vart mönstret börjar och slutar och det är till för att hitta hela tal 
            // (\\d) (Första siffran)är till för att representera en siffra (0-9) och parantesen lagrar den som en grupp för att användas senare
            // (\\d*) (Mitten av talet) noll eller flera siffror som kan följa efter första siffran (\\d). 
            // \\1 (slutet kopplat till d) Sista siffran som måste matcha den första (\\d) därav hade vi paranteser för att referera tillbaks
            // \\b (Avslut) Detta är slutgräns för att stänga mönstret och markera slutet av talet
            String siffermönster = "\\b(\\d)(\\d*)\\1\\b";
            // Regex är för att söka efter mönster,med new Regex skapar vi ett nytt regex-objekt baserat på mönstret i (siffermönster)
            Regex sökerMönster = new Regex(siffermönster);
            // Hittar matchningar utifrån mönstret på (siffermönster) från input och resultatet lagras i MatchCollection
            MatchCollection matchaMönster = sökerMönster.Matches(input);

            // Lagrar vi summan av matchningarna och börjar från 0, long för att det kan förekomma stora/långa heltal.
            long lagrarMönster = 0;

            // En loop som går igenom varje matchning enligt (siffermönster) för varje matchning sker följande 
            foreach (Match match in matchaMönster);
            {
                // markeras med röd så vi ser matchningen tydligare
                Console.ForegroundColor = ConsoleColor.Red;

                // Skriver ut en text innan det matchande talet kommer 
                Console.Write(input.Substring(0, match.Index));

                // Här kommer det matchande talet markeras med röd efter texten 
                Console.Write(match.Value);

                // Återsätller till den gamla färgen till resten av texten då bara matchande enligt (siffermönster) ska varqa röd
                Console.ResetColor();

                // Skriver ut texten som kommer efter det matchande talet med den vanliga färgen och gåt till nästa rad
                Console.WriteLine(input.Substring(match.Index + match.Lenght));
                

              






                    
            }




           
        }
    }
}
