namespace Int_Supi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescA = new System.Windows.Forms.TextBox();
            this.txt_DescP = new System.Windows.Forms.TextBox();
            this.editar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.Datagrits = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrits)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 452);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtModID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDescA);
            this.tabPage1.Controls.Add(this.txt_DescP);
            this.tabPage1.Controls.Add(this.editar);
            this.tabPage1.Controls.Add(this.borrar);
            this.tabPage1.Controls.Add(this.agregar);
            this.tabPage1.Controls.Add(this.Datagrits);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1221, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion de la actividad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion del problema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescA
            // 
            this.txtDescA.Location = new System.Drawing.Point(1050, 237);
            this.txtDescA.Name = "txtDescA";
            this.txtDescA.Size = new System.Drawing.Size(100, 20);
            this.txtDescA.TabIndex = 6;
            this.txtDescA.TextChanged += new System.EventHandler(this.txtDescA_TextChanged);
            // 
            // txt_DescP
            // 
            this.txt_DescP.Location = new System.Drawing.Point(1050, 182);
            this.txt_DescP.Name = "txt_DescP";
            this.txt_DescP.Size = new System.Drawing.Size(100, 20);
            this.txt_DescP.TabIndex = 5;
            this.txt_DescP.TextChanged += new System.EventHandler(this.txt_DescP_TextChanged);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(1027, 367);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 35);
            this.editar.TabIndex = 4;
            this.editar.Text = "Editar Modificacion";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(1110, 368);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 36);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "Borrar Modificacion";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(942, 367);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(79, 37);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Modificacion";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // Datagrits
            // 
            this.Datagrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrits.Location = new System.Drawing.Point(7, 6);
            this.Datagrits.Name = "Datagrits";
            this.Datagrits.Size = new System.Drawing.Size(775, 356);
            this.Datagrits.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Modificaciones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1221, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modificacion_ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtModID
            // 
            this.txtModID.Location = new System.Drawing.Point(1050, 123);
            this.txtModID.Name = "txtModID";
            this.txtModID.Size = new System.Drawing.Size(100, 20);
            this.txtModID.TabIndex = 9;
            this.txtModID.TextChanged += new System.EventHandler(this.txtModID_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Datagrits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescA;
        private System.Windows.Forms.TextBox txt_DescP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModID;
    }
}

