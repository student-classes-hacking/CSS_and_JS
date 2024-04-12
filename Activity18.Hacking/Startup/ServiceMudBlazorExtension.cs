using MudBlazor.Services;

namespace Activity18.Hacking.Startup;

public static class ServiceMudBlazorExtension
{
    // Require Instalation Next Nugget Package: Auth0.OidcClient.Core
    // Require Instalation Next Nugget Package: MudBlazor
    
    // global using MudBlazor;

    /* look at index.html for Adding font, style and script references:
       <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet" />
       <link href="_content/MudBlazor/MudBlazor.min.css" rel="stylesheet" />

       <script src="_content/MudBlazor/MudBlazor.min.js"></script>
    */
    /* Add Next Components in MainLayout.razor:
                                    <MudThemeProvider />
                                    <MudDialogProvider />
                                    <MudSnackbarProvider />
    */
    public static IServiceCollection AddMudBlazorLibrary(this IServiceCollection services) => services.AddMudServices();
}