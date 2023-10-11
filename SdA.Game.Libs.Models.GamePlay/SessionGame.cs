using SdA.Game.Libs.Models.GamePlay.Characters;

namespace SdA.Game.Libs.Models.GamePlay
{
    /// <summary>
    /// Session de jeu d'un player
    /// </summary>
    public class SessionGame
    {
        #region Constructors
        public SessionGame(Player player) : this(DateTime.Now, player)
        {
        }

        public SessionGame(DateTime dateDebut, Player player)
        {
            this.Player = player;
            this.DateDebut = dateDebut;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Démarre le jeu
        /// </summary>
        public void Start()
        {
            this.DateDebut = DateTime.Now;
            this.State = SessionState.Started;
        }

        public void Finish()
        {
            this.DateFin = DateTime.Now;
            this.State = SessionState.Finished;
        }
        #endregion

        #region Properties
        public DateTime DateDebut { get; private set; }
        public DateTime DateFin { get; private set; }

        public Player Player { get; init; }

        public SessionState State { get; private set; }
        #endregion
    }
}
