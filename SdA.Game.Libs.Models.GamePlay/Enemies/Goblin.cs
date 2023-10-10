namespace SdA.Game.Libs.Models.GamePlay.Enemies;

public class Goblin : Enemy
{
    public Goblin() : base(string.Empty)
    {
    }

    public override void SeDeplacer()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        char c1 = '\u0011';
        return c1.ToString();
    }
}
