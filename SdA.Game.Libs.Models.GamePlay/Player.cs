namespace SdA.Game.Libs.Models.GamePlay;

/// <summary>
/// Player qui va jouer et représenter un joueur d'une partie de jeu
/// </summary>
public class Player
{
    #region Fields

    private string nickName = string.Empty;
    private DateTime dateDeNaissance = DateTime.MinValue;
    #endregion

    #region Constructors
    public Player()
    {

    }
    #endregion

    #region Public methods
    public void Initialisation(DateTime dateNaissance)
    {
        this.DateDeNaissance = dateNaissance;
    }
    #endregion

    #region Internal methods

    #endregion

    #region Properties
    public string NickName
    {
        get { return this.nickName; }
        set { this.nickName = value; }
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
            this.dateDeNaissance = value;
            if (!this.AgeValide)
            {
                throw new Exception("Age pas valide");
            }
        }
    }

    public bool AgeValide => this.Age >= 13;

    //public int Age { get { return (DateTime.Now - this.DateDeNaissance).Days / 365; } }
    public int Age => (DateTime.Now - this.DateDeNaissance).Days / 365;
    #endregion
}
