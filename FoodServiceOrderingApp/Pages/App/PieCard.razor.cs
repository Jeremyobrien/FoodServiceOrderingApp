using FoodServiceOrderingApp.Models;
using Microsoft.AspNetCore.Components;

namespace FoodServiceOrderingApp.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
