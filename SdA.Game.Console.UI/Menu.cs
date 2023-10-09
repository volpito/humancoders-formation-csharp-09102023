namespace SdA.Game.Consoles.UI;

/// <summary>
/// Menu principal du jeu
/// 
/// <see cref="HttpClient"/>
/// </summary>
public class Menu
{
    private Dictionary<string, string> options = new Dictionary<string, string>() { { "Nouvelle partie", "test" }, { "Charger une partie", "..." } };

    /// <summary>
    /// 
    /// </summary>
    /// <param name="options">Liste à minima d'un élement</param>
    /// <exception cref="Exception">Génère une exception si pas d'élements dans la liste</exception>
    public void Display(string[] options)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine("{0} {1} {2}", "==", i, options[i]);
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void Display()
    {
        Display(null);
        // TODO: 09102023, à finir plus tard
    }

    // V1public bool GetChoice(string[] options, out int choice) // le out force l'affectation dans cette méthode
    public bool GetChoice(string[] options, out int choice) // le out force l'affectation dans cette méthode
    {
        string saisieChoix = Console.ReadLine();

        if (int.TryParse(saisieChoix, out choice))
        {
            if (choice >= 0 && choice < options.Length)
            {
                Console.WriteLine("Vous avez choisi l'option: {0}", options[choice]);
                if (choice == options.Length - 1)
                {
                    System.Environment.Exit(1);
                }

                return true;
            }
            else
            {
                Console.WriteLine("L'option doit être comprise entre 0 et {0}", options.Length - 1);
                return false;
            }
        }
        try
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Entrez un nombre, recommencez!");
            return false;
        }

        return false;
    }
}
