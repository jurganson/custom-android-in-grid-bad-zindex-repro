using Android.Content;
using Android.Widget;
using Microsoft.Maui.Platform;
using Color = Android.Graphics.Color;

namespace ProblematicZIndexInGrid.Droid
{
	public class ControlAndroid : MauiScrollView
	{
		private LinearLayout TableViewContainer;

		public ControlAndroid(Context context) : base(context)
		{
			TableViewContainer = new LinearLayout(Context);
			TableViewContainer.Orientation = Orientation.Vertical;
			TableViewContainer.LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
			AddView(TableViewContainer);
			Populate(context);
		}

		public void Populate(Context context)
		{
			for (var i = 0; i < 100; i++)
			{
				TableViewContainer.AddView(new CellAndroid(context));
			}
		}
	}

	class CellAndroid : LinearLayout
	{
		public CellAndroid(Context? context) : base(context)
		{
			Orientation = Orientation.Horizontal;
			LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
			SetBackgroundColor(Color.DarkSlateBlue);

			var label = new TextView(context);
			label.Text = "Test: " + Guid.NewGuid();
			
			AddView(label);
		}
	}
}
