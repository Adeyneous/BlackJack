using BlackJack.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Components
{
    public class PlayerWinningsViewComponent : ViewComponent
    {
        private readonly IGame _game; // Assuming IGame has the necessary data

        public PlayerWinningsViewComponent(IGame game)
        {
            _game = game;
        }

        public IViewComponentResult Invoke()
        {
            var winnings = _game.Player.TotalWinnings;
            return View("/Views/Shared/Components/PlayerWinnings/Winning.cshtml", winnings);
        }


    }


}
