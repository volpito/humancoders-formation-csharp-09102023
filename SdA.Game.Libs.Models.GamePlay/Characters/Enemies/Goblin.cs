using SdA.Game.Libs.Models.GamePlay.Moteur.Combat;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;

namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

public class Goblin : Enemy
{
    public Goblin(string name, Armes arme) : base(name, new(0, 0), new Baton(1))
    {
        Arme = arme;
    }
    public override string ToString()
    {
        char c1 = '\u0011';
        return c1.ToString();
    }

    protected override void DoSeDeplacer()
    {
        Position = new Position2DR(Position.X + 2, Position.Y + 2);
        Console.WriteLine($"Ma nouvelle position : {Position.X}{Position.Y}");
    }

    public override void DoSubir(Character enemy)
    {
        //PV = new PointsDeVie(PV.Value - enemy.Atq.Value);
    }
}
