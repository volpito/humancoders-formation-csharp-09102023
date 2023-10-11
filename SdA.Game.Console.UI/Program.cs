using SdA.Game.Libs.Models.GamePlay;
using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.UI;
using System.Globalization;

Console.WriteLine("{0}", System.Threading.Thread.CurrentThread.CurrentCulture.Name);

//System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.ForegroundColor = ConsoleColor.DarkYellow;

string title = "SDA - un jeu Seigneur des anneaux";

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

Menu myMenu = new();

while (true)
{
    myMenu.Display(menu);
    if (myMenu.GetChoice(menu, out int choice))
    {
        Console.WriteLine(choice);

        SdA.Game.Libs.Models.UI.ChoixMenu choixMenu = (SdA.Game.Libs.Models.UI.ChoixMenu)choice;

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
    var player = DetectionAgeJoueur();
    #endregion

    #region Etape 2
    AfficherRaces();
    var race = RecupererRaceChoisie();
    #endregion

    #region Etape 3
    player.NickName = RecupererNickName() ?? "Gandalf";
    #endregion

    #region Etape 4
    var sessionBuilder = new SessionGameBuilder(player);
    var session = sessionBuilder.Build();

    session.Start();
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

Player? DetectionAgeJoueur()
{
    Player? player = null;

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
        int nbYears = duree.Days / 365;

        Console.WriteLine($"Tu es né le {dateValide.ToString("dddd dd MMMM yyyy", new CultureInfo("fr-FR"))}, tu as donc {nbYears.ToString("#00")}");

        ageValide = true;
        if (nbYears < 13)
        {
            ageValide = false;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Oulla lal c'est pas bien, tu n'as pas le droit de joueur");
            Console.ForegroundColor = ConsoleColor.White;
        }

        player = new Player(dateValide);
    }

    if (!ageValide)
    {
        System.Environment.Exit(-1);
    }

    return player;
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

