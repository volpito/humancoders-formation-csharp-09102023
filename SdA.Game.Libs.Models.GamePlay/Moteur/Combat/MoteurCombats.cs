using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdA.Game.Libs.Models.GamePlay.Moteur.Combat
{
    /// <summary>
    /// Moteur d'actions lié au combat
    /// </summary>
    public class MoteurCombats
    {
        #region fields
        #endregion

        #region ctor
        public MoteurCombats(Character player, Character enemy)
        {
            Player = (Player)player;
            Enemy = (Enemy)enemy;
        }
        #endregion

        #region Internal Methods
        public void Fight()
        {
            Console.WriteLine($"{Player.NickName} has a {Player.Arme.ToString().Split('.').LastOrDefault()} dealing {Player.Arme.Degats}");
            Console.WriteLine($"{Enemy.Name} has a {Enemy.Arme.ToString().Split('.').LastOrDefault()} dealing {Enemy.Arme.Degats}");

            while (Player.PV.Value != 0 && Enemy.PV.Value != 0)
            {
                Console.WriteLine($"{Player.NickName} is at {Player.PV.Value}");
                Console.WriteLine($"{Enemy.Name} is at {Enemy.PV.Value}");

                Player.Subir(Enemy);
                Enemy.Subir(Player);
            }

            if (Player.PV.Value == 0 && Enemy.PV.Value == 0)
                Console.WriteLine("Match nul !");
            else
                Console.WriteLine($"{(Enemy.PV.Value <= 0 ?
                    $"{Enemy.Name} lost ! GG" :
                    $"You lost :(")}");
        }
        #endregion

        #region Public Methods

        #endregion

        #region Props
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
        #endregion
    }
}
