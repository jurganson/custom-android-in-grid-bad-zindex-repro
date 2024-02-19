using Android.App;
using Android.Runtime;

namespace ProblematicZIndexInGrid.Droid
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}

		protected override MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiApp<App>();

			builder.ConfigureMauiHandlers(handlers =>
			{
				handlers.AddHandler(typeof(Control), typeof(ControlHandler));
			});
			
			return builder.Build();
		}
	}
}
