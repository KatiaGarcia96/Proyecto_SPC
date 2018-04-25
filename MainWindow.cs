using System;
using System.Threading;
using Gtk;
using Oracle.ManagedDataAccess.Client;

public partial class MainWindow : Gtk.Window
{
    const string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=spcproject.cxmd6kjxslqw.us-west-1.rds.amazonaws.com)(PORT=1521)) (CONNECT_DATA=(SERVICE_NAME=ORCL))); User Id=kyann;Password=Gakd0132;";
    OracleConnection connection = new OracleConnection(connectionString);
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
        Connectar();
		btn_ok.Clicked += new EventHandler(this.btnOk_Click);
		btn_Salir.Clicked += new EventHandler(this.btnCnl_Click);


	}

    public void Connectar()
    {
        
        connection.Open();
        Console.Write("Abierto");
  
    }

	public void btnOk_Click(object sender, EventArgs e)
	{
		//Buscar usuario en la base de datos




		//Checar permisos del usuario para saber que pantalla abrir

		var text = E_usr.Text;


			if (text == "adm")
			{

				SPC.Admin_First Ventana = new SPC.Admin_First(this);
				Ventana.Show();
				E_usr.Text = "";
				entry4.Text = "";
				this.Hide();
			}
			else if (text == "op")
			{
				SPC.Operador_Informacion Ventana = new SPC.Operador_Informacion(this);
				Ventana.Show();
				E_usr.Text = "";
				entry4.Text = "";
				this.Hide();
			}
			else if (text == "ing")
			{
				SPC.Supervisor Ventana = new SPC.Supervisor();
				Ventana.Show();
				E_usr.Text = "";
				entry4.Text = "";
				this.Hide();
			}
			//Esconder la pantalla;
			else {
				E_usr.Text = "Error";
				entry4.Text = "";
			}
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
        connection.Close();
		Application.Quit();
		a.RetVal = true;
	}
	public void btnCnl_Click(object sender, EventArgs e)
	{
		//Agregar la ventana de segurida
        connection.Close();
		Application.Quit();

	}
}
