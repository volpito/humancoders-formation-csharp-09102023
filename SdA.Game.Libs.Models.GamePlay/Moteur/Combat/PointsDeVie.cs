using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdA.Game.Libs.Models.GamePlay.Moteur.Combat
{
    /// <summary>
    /// Record de points de vie en combat
    /// </summary>
    public record PointsDeVie
    {
        public int Value { get; init; } // Property to hold an integer value

        public PointsDeVie(int pv)
        {
            Value = pv;
        }
    }// ValueObject
}
