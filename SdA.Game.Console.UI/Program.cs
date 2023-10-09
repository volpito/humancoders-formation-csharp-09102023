using SdA.Game.Consoles.UI;

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

        switch (choice)
        {
            default:
                break;
        }
    }
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

