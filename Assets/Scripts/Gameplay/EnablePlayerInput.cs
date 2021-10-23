using Core;
using Model;

namespace Gameplay
{
    /// <summary>
    ///     This event is fired when user input should be enabled.
    /// </summary>
    public class EnablePlayerInput : Simulation.Event<EnablePlayerInput>
    {
        private readonly PlatformerModel _model = Simulation.GetModel<PlatformerModel>();

        protected override void Execute()
        {
            var player = _model.player;
            player.controlEnabled = true;
        }
    }
}