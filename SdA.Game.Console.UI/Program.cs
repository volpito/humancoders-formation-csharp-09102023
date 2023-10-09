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
while (true)
{
    var itemList = new List<string>() { "1.Nouvelle Partie", "2.Continuer", "3.Options", "4.Quitter" };
    for (int i = 0; i < itemList.Count(); i++)
    {
        Console.ForegroundColor = (ConsoleColor)i + 1;
        Console.WriteLine(itemList[i].PadLeft(itemList[i].Length + 2, '='));
    }
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("What option are you choosing ?");

    string maChaine = "1";
    int valeur = int.Parse(maChaine);

    int.TryParse(Console.ReadLine(), out int chosenOpt);

    chosenOpt = chosenOpt - 1;

    Console.WriteLine("You chose {0}", itemList[chosenOpt]);

    if (chosenOpt + 1 == 4)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Not available yet :'(");
    }
}
#endregion

//#region Melvin

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