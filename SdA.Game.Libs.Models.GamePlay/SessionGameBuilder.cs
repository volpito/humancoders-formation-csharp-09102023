using SdA.Game.Libs.Models.GamePlay.Characters;

namespace SdA.Game.Libs.Models.GamePlay
{
    /// <summary>
    /// Construit un game et valide les champs avant construction
    /// </summary>
    public class SessionGameBuilder
    {
        #region Constructors
        public SessionGameBuilder(Player player)
        {
            this.CurrentPlayer = player;
        }
        #endregion

        #region Public methods
        public SessionGame Build()
        {
            if (this.CurrentPlayer == null)
            {
                throw new Exception("Player vide");
            }

            var session = new SessionGame(this.CurrentPlayer);
            this.CurrentPlayer.Sessions.Add(session);

            return session;
        }
        #endregion

        #region Properties
        public Player CurrentPlayer { get; init; }
        #endregion
    }
}
