
// This file has been generated by the GUI designer. Do not modify.
namespace SPC
{
	public partial class Admin_First
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.RadioButton rBtn_Materiales;

		private global::Gtk.RadioButton rBtn_Usuario;

		private global::Gtk.RadioButton rBtn_Maquina;

		private global::Gtk.RadioButton rBtn_Equipo;

		private global::Gtk.RadioButton rBtn_Modificar;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.RadioButton rBtn_Agregar;

		private global::Gtk.RadioButton rBtn_Eliminar;

		private global::Gtk.Button btn_Aceptar;

		private global::Gtk.Button btn_Cancelar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget SPC.Admin_First
			this.Name = "SPC.Admin_First";
			this.Title = global::Mono.Unix.Catalog.GetString("Admin_First");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child SPC.Admin_First.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Materiales = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Materiales"));
			this.rBtn_Materiales.CanFocus = true;
			this.rBtn_Materiales.Name = "rBtn_Materiales";
			this.rBtn_Materiales.Active = false;
			this.rBtn_Materiales.DrawIndicator = true;
			this.rBtn_Materiales.UseUnderline = true;
			this.rBtn_Materiales.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.fixed1.Add(this.rBtn_Materiales);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Materiales]));
			w1.X = 37;
			w1.Y = 105;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Usuario = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Usuarios"));
			this.rBtn_Usuario.CanFocus = true;
			this.rBtn_Usuario.Name = "rBtn_Usuario";
			this.rBtn_Usuario.Active = false;
			this.rBtn_Usuario.DrawIndicator = true;
			this.rBtn_Usuario.UseUnderline = true;
			this.rBtn_Usuario.Group = this.rBtn_Materiales.Group;
			this.fixed1.Add(this.rBtn_Usuario);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Usuario]));
			w2.X = 37;
			w2.Y = 72;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Maquina = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Maquina"));
			this.rBtn_Maquina.CanFocus = true;
			this.rBtn_Maquina.Name = "rBtn_Maquina";
			this.rBtn_Maquina.Active = false;
			this.rBtn_Maquina.DrawIndicator = true;
			this.rBtn_Maquina.UseUnderline = true;
			this.rBtn_Maquina.Group = this.rBtn_Materiales.Group;
			this.fixed1.Add(this.rBtn_Maquina);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Maquina]));
			w3.X = 37;
			w3.Y = 135;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Equipo = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Equipo de Medicion"));
			this.rBtn_Equipo.CanFocus = true;
			this.rBtn_Equipo.Name = "rBtn_Equipo";
			this.rBtn_Equipo.Active = false;
			this.rBtn_Equipo.DrawIndicator = true;
			this.rBtn_Equipo.UseUnderline = true;
			this.rBtn_Equipo.Group = this.rBtn_Materiales.Group;
			this.fixed1.Add(this.rBtn_Equipo);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Equipo]));
			w4.X = 37;
			w4.Y = 167;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Modificar = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Modificar"));
			this.rBtn_Modificar.CanFocus = true;
			this.rBtn_Modificar.Name = "rBtn_Modificar";
			this.rBtn_Modificar.Active = false;
			this.rBtn_Modificar.DrawIndicator = true;
			this.rBtn_Modificar.UseUnderline = true;
			this.rBtn_Modificar.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.fixed1.Add(this.rBtn_Modificar);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Modificar]));
			w5.X = 223;
			w5.Y = 145;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Selecciona la variable:");
			this.fixed1.Add(this.label2);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
			w6.X = 30;
			w6.Y = 43;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Seleccionar la accion:");
			this.fixed1.Add(this.label3);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
			w7.X = 208;
			w7.Y = 49;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Agregar = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Agregar"));
			this.rBtn_Agregar.CanFocus = true;
			this.rBtn_Agregar.Name = "rBtn_Agregar";
			this.rBtn_Agregar.Active = false;
			this.rBtn_Agregar.DrawIndicator = true;
			this.rBtn_Agregar.UseUnderline = true;
			this.rBtn_Agregar.Group = this.rBtn_Modificar.Group;
			this.fixed1.Add(this.rBtn_Agregar);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Agregar]));
			w8.X = 224;
			w8.Y = 79;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.rBtn_Eliminar = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Eliminar"));
			this.rBtn_Eliminar.CanFocus = true;
			this.rBtn_Eliminar.Name = "rBtn_Eliminar";
			this.rBtn_Eliminar.Active = false;
			this.rBtn_Eliminar.DrawIndicator = true;
			this.rBtn_Eliminar.UseUnderline = true;
			this.rBtn_Eliminar.Group = this.rBtn_Modificar.Group;
			this.fixed1.Add(this.rBtn_Eliminar);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.rBtn_Eliminar]));
			w9.X = 226;
			w9.Y = 110;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btn_Aceptar = new global::Gtk.Button();
			this.btn_Aceptar.CanFocus = true;
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.UseUnderline = true;
			this.btn_Aceptar.Label = global::Mono.Unix.Catalog.GetString("Aceptar");
			this.fixed1.Add(this.btn_Aceptar);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btn_Aceptar]));
			w10.X = 367;
			w10.Y = 55;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btn_Cancelar = new global::Gtk.Button();
			this.btn_Cancelar.CanFocus = true;
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.UseUnderline = true;
			this.btn_Cancelar.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.fixed1.Add(this.btn_Cancelar);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btn_Cancelar]));
			w11.X = 365;
			w11.Y = 122;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 553;
			this.DefaultHeight = 356;
			this.Show();
		}
	}
}
