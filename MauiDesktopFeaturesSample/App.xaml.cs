namespace MauiDesktopFeaturesSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		var window = base.CreateWindow(activationState);

        const int newWidth = 800;
        const int newHeight = 600;

        window.X = 500;
        window.Y = 200;

        window.Width = newWidth;
        window.Height = newHeight;

        window.MinimumHeight = newHeight;
        window.MinimumWidth = newWidth;

        window.MinimumHeight = newHeight;
        window.MaximumWidth = newWidth;

        return window;
    }
}
