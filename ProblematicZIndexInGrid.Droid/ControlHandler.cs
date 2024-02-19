using Microsoft.Maui.Handlers;

namespace ProblematicZIndexInGrid.Droid
{
	public class ControlHandler : ViewHandler<Control, ControlAndroid>
	{
		public ControlHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper) { }

		private static PropertyMapper<Control, ControlHandler> PropertyMapper = new(ViewMapper);
		public ControlHandler() : base(PropertyMapper) { }

		protected override ControlAndroid CreatePlatformView()
		{
			return new ControlAndroid(MauiContext.Context);
		}
	}
}
