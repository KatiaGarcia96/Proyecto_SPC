using System;
namespace SPC
{
	public partial class Supervisor : Gtk.Window
	{
		public Supervisor() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
	}
}
