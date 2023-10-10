namespace SdA.Game.Libs.Models.GamePlay.Enemies;

public class Urukhai : Enemy
{
    public Urukhai(string name) : base(name)
    {
    }

    public override void SeDeplacer()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        char c1 = '\u0008';
        return c1.ToString();
    }
}
