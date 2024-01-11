using Microsoft.AspNetCore.Mvc;
using BlackJack.Models; // Adjust namespace based on where Hand is defined

public class HandViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(Hand hand)
    {
        return View("~/Views/Shared/Components/Hands/Hand.cshtml", hand);
    }
}


