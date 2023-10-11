using SdA.Game.Libs.Models.GamePlay.Moteur.Combat;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SdA.Game.Libs.Models.GamePlay.Characters;

/// <summary>
/// Player qui va jouer et représenter un joueur d'une partie de jeu
/// </summary>
public class Player : Character
{
    #region Fields

    private string nickName = string.Empty;
    private DateTime dateDeNaissance = DateTime.MinValue;

    private List<SessionGame> gameSessions = new();
    #endregion

    #region Constructors
    public Player(DateTime date, Position2DR position, Armes arme) : this(string.Empty, date, position, arme)
    {
        Initialiser(date);
    }

    public Player(string nickName, DateTime date, Position2DR position, Armes arme) : base(position, new(10), new(1), arme)
    {
        NickName = nickName;
    }
    #endregion

    #region Public methods
    #endregion

    #region Internal methods
    private void Initialiser(DateTime dateNaissance)
    {
        DateDeNaissance = dateNaissance;
    }

    protected override void DoSeDeplacer()
    {
        throw new NotImplementedException();
    }

    public override void DoSubir(Character enemy)
    {
        //PV = new PointsDeVie(PV.Value - enemy.Atq.Value);
    }
    #endregion

    #region Properties
    public List<SessionGame> Sessions => gameSessions;

    public string NickName
    {
        get { return nickName; }
        set { nickName = value; }
    }

    // public DateTime DateDeNaissance { get; private set; }
    /// <summary>
    /// Attention, si l'age < 13, ça pète une erreur
    /// </summary>
    /// <exception cref="Exception">Si age < 13</exception>
    public DateTime DateDeNaissance
    {
        get => dateDeNaissance;
        private set
        {
            dateDeNaissance = value;
            if (!AgeValide)
            {
                throw new Exception("Age pas valide");
            }
        }
    }

    public bool AgeValide => Age >= 13;

    //public int Age { get { return (DateTime.Now - this.DateDeNaissance).Days / 365; } }
    public int Age => (DateTime.Now - DateDeNaissance).Days / 365;
    #endregion
}
