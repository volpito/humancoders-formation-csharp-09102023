using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

/// <summary>
/// 
/// </summary>
public abstract class Enemy : Character
{
    #region Constructors
    public Enemy(string name, Position2DR position, Armes arme) : base(position, new(10), new(1), arme)
    {
        Name = name;
    }
    #endregion

    #region Public methods
    protected override void DoSeDeplacer()
    {
        throw new NotImplementedException();
    }

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
