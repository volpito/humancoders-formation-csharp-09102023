using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;
using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;

List<Armes> enemies = new()
{
    new Espadon(3),
    new Epée(2),
    new Baton(1),
};


// ----------------------------------
Player player = new Player("Gandalf", DateTime.MinValue, new(0,0), new Espadon(3));
Orc enemy = new Orc("KikouLOrc", new Baton(1));

MoteurCombats moteur = new(player, enemy);
moteur.Fight();



/*
Position2D une = new Position2D() { X = 1, Y = 1 };
Position2D secondeUne = new Position2D() { X = 1, Y = 1 };

bool samePosition = une == secondeUne;
Console.WriteLine(samePosition);

Position2DR uneR = new Position2DR(1, 1);
Position2DR uneR2 = new Position2DR(1, 1);
samePosition = uneR == uneR2;
Console.WriteLine(samePosition);

uneR.Deconstruct(out int x, out int y);
*/