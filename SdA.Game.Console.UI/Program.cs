using SdA.Game.Consoles.UI;
using System.Globalization;

Console.WriteLine("{0}", System.Threading.Thread.CurrentThread.CurrentCulture.Name);

//System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.ForegroundColor = ConsoleColor.DarkYellow;

// string uneStringJusteCommeCa = null;

//Console.WriteLine(uneStringJusteCommeCa);

string title = "SDA - un jeu Seigneur des anneaux";
string melvin = " bonjour !";
string coucou = " plop !";
string test = "Hello";

title = title.PadLeft(title.Length + 5, ' ');
title = title.PadRight(title.Length + 5, ' ');

title = title.PadLeft(title.Length + 5, '=');
title = title.PadRight(title.Length + 5, '=');

// title = string.Format("{0} - {1}", title, DateTime.Now);
Console.WriteLine("{0} - {1}", title, DateTime.Now);

//Console.WriteLine("=====      SDA - un jeu Seigneur des anneaux     =======");
Console.ForegroundColor = ConsoleColor.White;

#region Menu principal du jeu
// int choice = 0;

string[] menu = { "Nouvelle partie", "Charger une partie", "Options", "Quitter" };

#region 2. Etape avant classes
//void DisplayMenu(string[] options)
//{

//    Console.ForegroundColor = ConsoleColor.DarkYellow;
//    for (int i = 0; i < options.Length; i++)
//    {
//        Console.WriteLine("{0} {1} {2}", "==", i, options[i]);
//    }
//    Console.ForegroundColor = ConsoleColor.White;
//}

////void DisplayMenu()
////{

////}

//bool GetChoice(string[] options, out int choice) // le out force l'affectation dans cette méthode
//{
//    //choice = 2;

//    string saisieChoix = Console.ReadLine();

//    if (int.TryParse(saisieChoix, out choice))
//    {
//        if (choice >= 0 && choice < options.Length)
//        {
//            Console.WriteLine("Vous avez choisi l'option: {0}", options[choice]);
//            if (choice == options.Length - 1)
//            {
//                System.Environment.Exit(1);
//            }

//            return true;
//        }
//        else
//        {
//            Console.WriteLine("L'option doit être comprise entre 0 et {0}", options.Length - 1);
//            return false;
//        }
//    }
//    try
//    {
//        choice = Convert.ToInt32(Console.ReadLine());
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Entrez un nombre, recommencez!");
//        return false;
//    }

//    return false;
//}
#endregion

Menu myMenu = new();
var myMenu2 = new Menu();

while (true)
{
    int choice = 0;

    myMenu.Display(menu);
    if (myMenu.GetChoice(menu, out choice))
    {
        Console.WriteLine(choice);

        ChoixMenu choixMenu = (ChoixMenu)choice;

        switch (choixMenu)
        {
            case ChoixMenu.NouvellePartie:
                {
                    DemarrerNouvellePartie();
                }; break;

            case ChoixMenu.ChargerPartie:
                {
                    ChargerPartie();
                }
                break;

            case ChoixMenu.Options:
                {
                    AfficherOptions();
                }
                break;

            default:
                {
                }
                break;
        }
    }
}
#endregion

#region Gestion des choix de l'utilisateur
void DemarrerNouvellePartie()
{
    Console.WriteLine("C'est partie !");

    #region Etape 1
    DetectionAgeJoueur();
    #endregion

    #region Etape 2
    AfficherRaces();
    var race = RecupererRaceChoisie();
    #endregion

    #region Etape 3
    string nickName = RecupererNickName();
    #endregion
}

string? RecupererNickName()
{
    Console.WriteLine("Tu choisis quoi comme nom de joueur ?");
    return Console.ReadLine();
}

Race RecupererRaceChoisie()
{
    Race race = Race.Elfe;

    Console.WriteLine("Tu choisis quoi comme race ?");
    string? raceSaisie = Console.ReadLine();

    if (!string.IsNullOrEmpty(raceSaisie)) // type guard
    {
        int raceId = int.Parse(raceSaisie);
        race = (Race)raceId;
    }

    return race;
}

void AfficherRaces()
{
    // Enum.GetNames(typeof(Race));
    var list = Enum.GetNames<Race>();

    foreach (var raceString in list)
    {
        if (Enum.TryParse<Race>(raceString, out Race race))
        {
            Console.WriteLine("{0} - {1}", (int)race, raceString);
        }

    }
}

void DetectionAgeJoueur()
{
    bool ageValide = false;

    Console.WriteLine("Ta date de naissance, steuplai ?");
    var dateSaisieString = Console.ReadLine();

    if (dateSaisieString == null)
    {
        System.Environment.Exit(-1);
    }

    if (DateTime.TryParse(dateSaisieString, out DateTime dateValide))
    {
        TimeSpan duree = DateTime.Now - dateValide;
        // uint.MaxValue
        int nbYears = duree.Days / 365;

        //Console.WriteLine("Tu es né le {0}, tu as donc {1}", dateValide.ToString("dddd dd MMMM yyyy"), nbYears.ToString("#00"));
        Console.WriteLine($"Tu es né le {dateValide.ToString("dddd dd MMMM yyyy", new CultureInfo("fr-FR"))}, tu as donc {nbYears.ToString("#00")}");

        ageValide = true;
        if (nbYears < 13)
        {
            ageValide = false;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Oulla lal c'est pas bien, tu n'as pas le droit de joueur");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    if (!ageValide)
    {
        System.Environment.Exit(-1);
    }
}

void ChargerPartie()
{
    Console.WriteLine("Choisissez la partie à jouer");
}

void AfficherOptions()
{
    Dictionary<string, string> lesDeveloppeurs = new()
    {
        { "Melvin", "Développeur C#" },
        { "Jonathan", "Développeur C#" },
        { "Maxime", "Développeur C#" },
        { "Evan", "Formateur C#" }
    };

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    foreach (var item in lesDeveloppeurs)
    {
        Console.WriteLine("{0} => {1}", item.Key, item.Value);
    }
    Console.ForegroundColor = ConsoleColor.White;
}
#endregion

// #region Melvin

//int egalGameTitle = title.Count(c => c == '=');
//int spaceGameTitle = title.Count(c => c == ' ');

//Console.WriteLine($"Egal count = {egalGameTitle} and space count = {spaceGameTitle}");

//#endregion

//// Console.ReadLine();

//#region Jonathan

//Console.ForegroundColor = ConsoleColor.DarkYellow;

//int spaceNumber = 0, equalNumber = 0;
//Console.WriteLine("Entez le nombre d'espace: ");
//spaceNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Entez le nombre de egal: ");
//equalNumber = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < equalNumber; i++)
//{
//    Console.Write("=");
//}

//for (int i = 0; i < spaceNumber; i++)
//{
//    Console.Write(" ");
//}
//Console.Write("SDA - un jeu Seigneur des anneaux");

//for (int i = 0; i < spaceNumber; i++)
//{
//    Console.Write(" ");
//}

//for (int i = 0; i < equalNumber; i++)
//{
//    Console.Write("=");
//}

//Console.ForegroundColor = ConsoleColor.White;

//#endregion 


//#region maxime
/////

//#endregion

