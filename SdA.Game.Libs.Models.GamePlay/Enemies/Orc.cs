namespace SdA.Game.Libs.Models.GamePlay.Enemies;

public class Orc : Enemy
{
    public Orc(string name) : base(name)
    {
    }

    public override void SeDeplacer()
    {
        throw new NotImplementedException();
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
}
