
using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

Random random = new Random();

List<Character> list = new() 
{
    new Orc("Orc"),
    new Urukhai("U"),
    new Goblin(),
};

Console.WriteLine("avant");

list.ForEach(charac =>
{
    Console.WriteLine($"{charac.Position.X} / {charac.Position.Y}");
});

list.ForEach(charac =>
{
    charac.SeDeplacer(new(random.Next(0,10), random.Next(0,10)));
});
Console.WriteLine("apres");

list.ForEach(charac =>
{
    Console.WriteLine($"{charac.Position.X} / {charac.Position.Y}");
});