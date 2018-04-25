using System;
namespace SPC
{
	public partial class Operador_Informacion : Gtk.Window
	{
		Gtk.Window Principal;
		public Operador_Informacion(Gtk.Window V) :
				base(Gtk.WindowType.Toplevel)
		{
			Principal = V;
			this.Build();
			btn_Ok.Clicked += new EventHandler(this.btnOk_Click);
			btn_Cnl.Clicked += new EventHandler(this.btnCnl_Click);

		}

		public void btnOk_Click(object sender, EventArgs e)
		{
			//Declaracion de las variables
			var Material = E_Mat.Text;
			var Maquina = E_Mach.Text;
			var Equipo = E_Tool.Text;
			//Buscar info en la base de datos

			//Checar todos los campos llenos, si no mandar mensaje
			if (Material != "" && Maquina != "" && Equipo != "")
			{
				SPC.Operador_Datos Ventana = new SPC.Operador_Datos(Principal);
				Ventana.Show();
				//Esconder la pantalla;
				this.Hide();
			}
		}
		public void btnCnl_Click(object sender, EventArgs e)
		{
			Principal.Show();
			//Cerrar ventana
			this.Hide();
		}
	}
}
