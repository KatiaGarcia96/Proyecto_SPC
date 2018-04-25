
// This file has been generated by the GUI designer. Do not modify.
namespace SPC
{
	public partial class Operador_Informacion
	{
		private global::Gtk.Fixed fixed3;

		private global::Gtk.Entry E_Mach;

		private global::Gtk.Entry E_Tool;

		private global::Gtk.Entry E_Mat;

		private global::Gtk.Label L_Mach;

		private global::Gtk.Label L_Mat;

		private global::Gtk.Label L_Tool;

		private global::Gtk.Button btn_Ok;

		private global::Gtk.Button btn_Cnl;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget SPC.Operador_Informacion
			this.Name = "SPC.Operador_Informacion";
			this.Title = global::Mono.Unix.Catalog.GetString("Informacion para medir");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child SPC.Operador_Informacion.Gtk.Container+ContainerChild
			this.fixed3 = new global::Gtk.Fixed();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.E_Mach = new global::Gtk.Entry();
			this.E_Mach.WidthRequest = 247;
			this.E_Mach.CanFocus = true;
			this.E_Mach.Name = "E_Mach";
			this.E_Mach.IsEditable = true;
			this.E_Mach.InvisibleChar = '●';
			this.fixed3.Add(this.E_Mach);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.E_Mach]));
			w1.X = 54;
			w1.Y = 65;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.E_Tool = new global::Gtk.Entry();
			this.E_Tool.WidthRequest = 247;
			this.E_Tool.CanFocus = true;
			this.E_Tool.Name = "E_Tool";
			this.E_Tool.IsEditable = true;
			this.E_Tool.InvisibleChar = '●';
			this.fixed3.Add(this.E_Tool);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.E_Tool]));
			w2.X = 54;
			w2.Y = 125;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.E_Mat = new global::Gtk.Entry();
			this.E_Mat.WidthRequest = 247;
			this.E_Mat.CanFocus = true;
			this.E_Mat.Name = "E_Mat";
			this.E_Mat.IsEditable = true;
			this.E_Mat.InvisibleChar = '●';
			this.fixed3.Add(this.E_Mat);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.E_Mat]));
			w3.X = 54;
			w3.Y = 185;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.L_Mach = new global::Gtk.Label();
			this.L_Mach.Name = "L_Mach";
			this.L_Mach.LabelProp = global::Mono.Unix.Catalog.GetString("No. Maquina:");
			this.fixed3.Add(this.L_Mach);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.L_Mach]));
			w4.X = 54;
			w4.Y = 45;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.L_Mat = new global::Gtk.Label();
			this.L_Mat.Name = "L_Mat";
			this.L_Mat.LabelProp = global::Mono.Unix.Catalog.GetString("No. Material:");
			this.fixed3.Add(this.L_Mat);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.L_Mat]));
			w5.X = 54;
			w5.Y = 165;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.L_Tool = new global::Gtk.Label();
			this.L_Tool.Name = "L_Tool";
			this.L_Tool.LabelProp = global::Mono.Unix.Catalog.GetString("No. Herramienta de medicion:");
			this.fixed3.Add(this.L_Tool);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.L_Tool]));
			w6.X = 54;
			w6.Y = 105;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.btn_Ok = new global::Gtk.Button();
			this.btn_Ok.WidthRequest = 100;
			this.btn_Ok.CanFocus = true;
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.UseUnderline = true;
			this.btn_Ok.Label = global::Mono.Unix.Catalog.GetString("Aceptar");
			this.fixed3.Add(this.btn_Ok);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.btn_Ok]));
			w7.X = 54;
			w7.Y = 240;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.btn_Cnl = new global::Gtk.Button();
			this.btn_Cnl.WidthRequest = 100;
			this.btn_Cnl.CanFocus = true;
			this.btn_Cnl.Name = "btn_Cnl";
			this.btn_Cnl.UseUnderline = true;
			this.btn_Cnl.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.fixed3.Add(this.btn_Cnl);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.btn_Cnl]));
			w8.X = 200;
			w8.Y = 240;
			this.Add(this.fixed3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 360;
			this.DefaultHeight = 315;
			this.Show();
		}
	}
}
