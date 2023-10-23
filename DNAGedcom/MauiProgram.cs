using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Platform;

namespace DNAGedcom
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>() .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            builder.Services.AddMauiBlazorWebView();

            #if DEBUG
		    builder.Services.AddBlazorWebViewDeveloperTools();
		    builder.Logging.AddDebug();
            #endif

            #if WINDOWS10_0_17763_0_OR_GREATER
            builder.ConfigureLifecycleEvents(events =>
            {
                events.AddWindows(wndLifeCycleBuilder =>
                {
                    wndLifeCycleBuilder.OnWindowCreated(window =>
                    {
                        window.Title = "DNA Gedcom";
                        window.ExtendsContentIntoTitleBar = false;
                        window.GetAppWindow().TitleBar.ExtendsContentIntoTitleBar = true;
                        window.GetAppWindow().TitleBar.ButtonForegroundColor = Windows.UI.Color.FromArgb(255, 0, 0, 0);
                        window.GetAppWindow().TitleBar.ButtonHoverBackgroundColor = Windows.UI.Color.FromArgb(20, 0, 0, 0);
                        window.GetAppWindow().TitleBar.ButtonHoverForegroundColor = Windows.UI.Color.FromArgb(255, 0, 0, 0);
                        window.GetAppWindow().TitleBar.ButtonBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
                    });
                });
            });
            #endif

            return builder.Build();
        }
    }
}