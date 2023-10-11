using SdA.Game.Libs.Models.GamePlay.Moteur.Combat;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;

namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

public class Urukhai : Enemy
{
    public Urukhai(string name, Armes arme) : base(name, new(0, 0), new Espadon(3))
    {
        Arme = arme;
    }

    protected override void DoSeDeplacer()
    {
        Position = new Position2DR(Position.X + 2, Position.Y + 2);
        Console.WriteLine($"Ma nouvelle position : {Position.X}{Position.Y}");
    }

    public override string ToString()
    {
        char c1 = '\u0008';
        return c1.ToString();
    }

    public override void DoSubir(Character enemy)
    {
        PV = new PointsDeVie(PV.Value - enemy.Atq.Value);
    }
}
