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
//Console.WriteLine("Hello there");
//Console.WriteLine("How many '=' would you like to input ?");
//var equalSign = Console.ReadLine();
//Int32.TryParse(equalSign, out int eq);
//Console.WriteLine("Also, how many white spaces would you like to input ?");

//var space = Console.ReadLine();
//Int32.TryParse(space, out int sp);

//Console.WriteLine("Cool, let's try it :");

//Console.ForegroundColor = ConsoleColor.DarkYellow;
//if (eq != 0 && sp != 0)
//{
//    for (int i = 0; i <= eq; i++)
//    {
//        Console.Write("=");
//    }
//    for (int i = 0; i <= sp; i++)
//    {
//        Console.Write(" ");
//    }
//    Console.Write("SDA - un jeu Seigneur des Anneaux");
//    for (int i = 0; i <= sp; i++)
//    {
//        Console.Write(" ");
//    }
//    for (int i = 0; i <= eq; i++)
//    {
//        Console.Write("=");
//    }

//    Console.ForegroundColor = ConsoleColor.White;
//}
//else
//    Console.WriteLine("Please try again with numbers smartass");
//#endregion