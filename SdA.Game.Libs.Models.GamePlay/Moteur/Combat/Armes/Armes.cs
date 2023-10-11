using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes
{
    public class Armes
    {
        #region ctor
        public Armes(int degats)
        {
            Degats = degats;
        }
        #endregion

        #region prop
        public int Degats { get; set; }
        #endregion
    }
}
