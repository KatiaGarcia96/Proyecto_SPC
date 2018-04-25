using System;
namespace SPC
{
	public partial class Operador_Datos : Gtk.Window
	{
		Gtk.Window Principal;
		public Operador_Datos(Gtk.Window V) :
				base(Gtk.WindowType.Toplevel)
		{
			Principal = V;
			this.Build();
			btn_ok.Clicked += new EventHandler(this.btnOk_Click);
			btn_Cnl.Clicked += new EventHandler(this.btnCnl_Click);

		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			//Guardar Datos

			Principal.Show();
			this.Hide();
		}
		private void btnCnl_Click(object sender, EventArgs e)
		{
			Principal.Show();
			//Cerrar ventana
			this.Hide();
		}
	}
}
