using System;
namespace SPC
{
	public partial class Admin_First : Gtk.Window
	{
		Gtk.Window Principal;
		public Admin_First(Gtk.Window V) :
				base(Gtk.WindowType.Toplevel)
		{
			Principal = V;
			this.Build();

			btn_Cancelar.Clicked += new EventHandler(this.btnCancelar_Click);
		}


		public void btnCancelar_Click(object sender, EventArgs e)
		{
			Principal.Show();
			//Cerrar ventana
			this.Hide();
		}
	}
}
