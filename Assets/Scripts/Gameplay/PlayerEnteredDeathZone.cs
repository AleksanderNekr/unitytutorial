using Core;
using Mechanics;

namespace Gameplay
{
    /// <summary>
    ///     Fired when a player enters a trigger with a DeathZone component.
    /// </summary>
    public class PlayerEnteredDeathZone : Simulation.Event<PlayerEnteredDeathZone>
    {
        public DeathZone deathzone;

        protected override void Execute()
        {
            Simulation.Schedule<PlayerDeath>();
        }
    }
}