namespace SdA.Game.Libs.Models.GamePlay.Enemies;

/// <summary>
/// 
/// </summary>
public abstract class Enemy // Non instanciable
{
    #region Constructors
    public Enemy(string name)
    {
        Name = name;
    }
    #endregion

    #region Public methods
    public abstract void SeDeplacer();

    public virtual void Attaquer()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "X";
    }
    #endregion

    #region Properties
    public string Name { get; init; }
    #endregion
}
