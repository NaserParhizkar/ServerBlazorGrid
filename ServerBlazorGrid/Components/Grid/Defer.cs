using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace ServerBlazorGrid.Components.Grid
{
    public class Defer : ComponentBase
    {
        /// <summary>
        /// For internal use only. Do not use.
        /// </summary>
        [Parameter] public RenderFragment? ChildContent { get; set; }

        /// <summary>
        /// For internal use only. Do not use.
        /// </summary>
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddContent(0, ChildContent);
        }
    }
}