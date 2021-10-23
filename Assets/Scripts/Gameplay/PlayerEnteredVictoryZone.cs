using Core;
using Mechanics;
using Model;
using UnityEngine;

namespace Gameplay
{
    /// <summary>
    ///     This event is triggered when the player character enters a trigger with a VictoryZone component.
    /// </summary>
    public class PlayerEnteredVictoryZone : Simulation.Event<PlayerEnteredVictoryZone>
    {
        private static readonly int Victory = Animator.StringToHash("victory");
        private readonly PlatformerModel _model = Simulation.GetModel<PlatformerModel>();
        public VictoryZone victoryZone;

        protected override void Execute()
        {
            _model.player.animator.SetTrigger(Victory);
            _model.player.controlEnabled = false;
        }
    }
}