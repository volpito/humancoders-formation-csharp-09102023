using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdA.Game.Libs.Models.GamePlay.Moteur.Combat
{
    /// <summary>
    /// Record des points d'attaques des Characters
    /// </summary>
    public record PointsDAttaque
    {
        public int Value { get; init; } // Property to hold an integer value

        public PointsDAttaque(int atq)
        {
            Value = atq;
        }
    }
    // ValueObject
}
