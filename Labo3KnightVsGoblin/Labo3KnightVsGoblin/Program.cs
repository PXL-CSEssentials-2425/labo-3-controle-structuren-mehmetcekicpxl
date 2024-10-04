
/*
Console.WriteLine("welkome to knight vs goblin!");
Console.WriteLine("----------------------------");
Console.Write("enter knight health : ");
string input = Console.ReadLine();


Random randomNummerGenarator = new Random();//extra

int knightHealth ;
if(int.TryParse(input, out knightHealth))
{
    if(knightHealth<=0 || knightHealth>100)
    {

        Console.WriteLine("invalid number,default value 100 is used .");
        knightHealth = 100;
    }
    
}
else
{
    Console.WriteLine(" je moet een geldig character invullen! (het moet een getal zijn )");
    Console.WriteLine("invalid number,default value 100 is used .");
    knightHealth=100;
    
}
int goblinHealth = randomNummerGenarator.Next(1, 101);

Console.WriteLine($"goblin health : {goblinHealth} ");
Console.WriteLine($"knight health : {knightHealth} ");

int attackKnight = 10;
int attackGoblin = randomNummerGenarator.Next(5 , 16);

Console.WriteLine(" kies een action: ");
Console.WriteLine("1 of A Attack");
Console.WriteLine("2 of H Heal");
string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
    case "A":

        Console.WriteLine($"you attackted the goblin for {attackKnight} damage !");
        break;
    case "2":
    case "H":
        knightHealth += 10;
        Console.WriteLine("you healed yourself for 10 healht points!");
        break;
    default:
        Console.WriteLine(" invalid move ! please choose a valid points ");
        break;
}

if (goblinHealth>0)
{
    knightHealth -= attackGoblin;
    Console.ForegroundColor= ConsoleColor.Yellow;
    Console.WriteLine($"your were attackted by the goblin for {attackGoblin} damage");
    Console.ResetColor();
}



if (knightHealth <= 0) 
{
    Console.WriteLine("the knight has  died!");
}
else
{
    Console.WriteLine($"knight health : {knightHealth} " );

}
if (goblinHealth <= 0) 
{
    Console.WriteLine("the goblin has died!");
}
else
{
    Console.WriteLine($"goblin health : {goblinHealth} ");

}

*/

/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspunten van de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */



using System.Security.Cryptography;

Console.WriteLine("welkome aan knight en goblin spelen ");
Console.WriteLine("-------------------------------------");

Random randomNummerGenarator=new Random();
Console.Write("geef de knight healt in :");
string input =Console.ReadLine();


int knightHealth;
if (int.TryParse(input, out knightHealth))
{
    if (knightHealth < 0 || knightHealth > 100)
    {
        Console.WriteLine("ongeldig getal ingevuld dus gebruik standaard getal  als 100");
        knightHealth = 100;
    }
}
else
{
    Console.WriteLine("ongeldig tekens ingevoerd dus gebruik standaard getal als 100 ");
    knightHealth = 100;
}

Console.WriteLine($"knight health is {knightHealth}");
int goblinHealth = randomNummerGenarator.Next(1, 101);
Console.WriteLine($"goblin health is {goblinHealth}");

//for (int attempts=1; attempts <=4 ; attempts++)
do
{
   // Console.WriteLine($"Ronde {attempts}");
    int attacktKnight = 10;
    int attacktGoblin = randomNummerGenarator.Next(5,16);
    Console.WriteLine("kies een action");
    Console.WriteLine("1 or A om te aanval");
    Console.WriteLine("2 or H om te genezen ");
    string selectedAction = Console.ReadLine();


    switch (selectedAction)
    {
        case "1":
        case "A":
            Console.WriteLine($"je hebt goblin aangevallen voor {attacktKnight} schade ");
            goblinHealth -= 10;
            break;
        case "2":
        case "H":
            Console.WriteLine($"je hebt jezelf genezen voor {attacktKnight} ");
            knightHealth += 10;
            if (knightHealth > 100)
            {
                Console.WriteLine("knight health al op maximum waarde ");
                knightHealth = 100;
            }
            break;
        default:
            Console.WriteLine("je heeft gekozen een ongeldig teken or nummer ");
            break;



    }



    if (goblinHealth <= 0)
    {
        Console.WriteLine("goblin has died ");

    }
    else
    {
        Console.WriteLine($"goblin health : {goblinHealth} ");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"your were attackted by the goblin for {attacktGoblin} damage");
        knightHealth -= attacktGoblin;
        Console.ResetColor();

    }
    if (knightHealth <= 0)
    {
        Console.WriteLine("knight has died ");

    }
    else
    {
        Console.WriteLine($"knight healht : {knightHealth} ");
    }


}while(knightHealth > 0 && goblinHealth>0);


