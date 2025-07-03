
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace FinTrackPro.MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        return builder.Build();
    }
}
