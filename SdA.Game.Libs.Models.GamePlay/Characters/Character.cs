using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat;
using SdA.Game.Libs.Models.GamePlay.Moteur.Combat.Armes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdA.Game.Libs.Models.GamePlay.Characters
{
    /// <summary>
    /// classe parente des enemies et du player
    /// </summary>
    public abstract class Character
    {
        #region Ctor
        public Character(Position2DR positionDefaut, PointsDeVie pv, PointsDAttaque atq, Armes arme )
        {
            Position = positionDefaut;
            PV = pv;
            Atq = atq;
            Arme = arme;
        }
        public Character(int x, int y, int pv, int atq, Armes arme) : this(new(x,y), new (pv), new(atq), arme)
        {

        }
        public Character() : this(new(0, 0), new(10), new(1), null)
        {

        }
        #endregion

        #region Internal methods
        protected abstract void DoSeDeplacer();
        public abstract void DoSubir(Character enemy);
        #endregion

        #region public methods
        public void SeDeplacer(Position2DR position)
        {
            if (Position == null) return;
            Position = position;
            this.DoSeDeplacer();
        }

        public void Subir(Character enemy)
        {
            if (enemy == null) return;

            PV = new PointsDeVie(PV.Value - (enemy.Atq.Value + enemy.Arme.Degats));

            this.DoSubir(enemy);
        }
        #endregion

        #region Prop
        public Position2DR Position { get; protected set; }
        public PointsDeVie PV { get; protected set; }
        public PointsDAttaque Atq { get; protected set; }
        public Armes Arme { get; set; }
        #endregion
    }
}
