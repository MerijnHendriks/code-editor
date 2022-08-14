using Avalonia;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Splat;
using System;
using System.Reflection;

namespace Sake
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
            => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            var asm = Assembly.GetExecutingAssembly();
            Locator.CurrentMutable.RegisterViewsForViewModels(asm);
            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
        }
    }
}
