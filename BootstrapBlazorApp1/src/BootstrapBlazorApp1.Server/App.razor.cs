using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;

namespace BootstrapBlazorApp1.Server
{
    public partial class App
    {
        [Inject]
        private AuthenticationStateProvider AuthenticationProvider { get; set; }

        [Inject]
        private NavigationManager Navigator { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var state = await AuthenticationProvider.GetAuthenticationStateAsync();
            if (!state.User.Identity.IsAuthenticated)
            {
                Navigator.NavigateTo("/Account/Login");
            }
            else
            {
                await base.OnInitializedAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstRender"></param>
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
    }
}
