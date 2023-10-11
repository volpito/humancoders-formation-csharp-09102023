using SdA.Game.Libs.Models.GamePlay.Moteur.Combat;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;

namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

public class Orc : Enemy
{
    public Orc(string name, Armes arme) : base(name, new(0, 0), new Baton(1))
    {
        Arme = arme;
    }

    protected override void DoSeDeplacer()
    {
        Position = new Position2DR(Position.X + 2, Position.Y + 2);
    }

    public override void Attaquer()
    {
        // base.Attaquer();
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        char c1 = '\u0010';
        return c1.ToString();
    }

    public override void DoSubir(Character enemy)
    {
        PV = new PointsDeVie(PV.Value - enemy.Atq.Value);
    }
}
