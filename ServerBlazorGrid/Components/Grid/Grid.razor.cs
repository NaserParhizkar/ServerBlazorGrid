using Microsoft.AspNetCore.Components;
using System;

namespace ServerBlazorGrid.Components.Grid
{
    [CascadingTypeParameter(nameof(TItem))]
    public partial class Grid<TItem>
    {
        public Grid()
        {
            _columns = new();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
