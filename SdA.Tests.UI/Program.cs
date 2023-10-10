using SdA.Game.Libs.Models.GamePlay;
using SdA.Game.Libs.Models.GamePlay.Enemies;

List<Enemy> enemies = new()
{
    new Goblin(),
    new Goblin(),
    new Goblin(),
    new Urukhai("Shagrat"),
    new Orc("Boldog")
};

void AfficherEnnemies(List<Enemy> enemies)
{
    foreach (Enemy enemy in enemies)
    {
        Console.WriteLine(enemy.ToString());
    }
}

AfficherEnnemies(enemies);


// ----------------------------------

Position2D une = new Position2D() { X = 1, Y = 1 };
Position2D secondeUne = new Position2D() { X = 1, Y = 1 };

bool samePosition = une == secondeUne;

Position2DR uneR = new Position2DR(1, 1);
Position2DR uneR2 = new Position2DR(1, 1);
samePosition = uneR == uneR2;

uneR.Deconstruct(out int x, out int y);
