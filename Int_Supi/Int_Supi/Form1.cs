using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_Supi
{
    public partial class Form1 : Form
    {
        OracleConnection con = null;
        public Form1()
        {
            this.SetConnection();
            InitializeComponent();

        }
        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT MODIFICACION_ID DESCRIPCION_PROBLEMA DESCRIPCION_ACTIVIDAD FROM KYANN.MODIFICACIONES";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Datagrits.ItemSource = dt.DefaultView;
            dr.Close();
        }
        private void SetConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectStrings["name of conectionstring"].ConnectiongString;
            con = new OracleConnection(ConnectionString);
            try {
                con.Open();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.updateDataGrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AUD(String sql_stmt, int state)
        {
            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Modificacion agregada exitosamente!";
                    cmd.Parameters.Add("MODIFICACION_ID", OracleDbType.Integer, 6).Value = Int32.Parse(txtModID.Text);
                    cmd.Parameters.Add("DESCRIPCION_ACTIVIDAD", OracleDbType.Varchar2, 200).Value = txtDescA.Text;
                    cmd.Parameters.Add("DESCRIPCION_PROBLEMA", OracleDbType.Varchar2, 200).Value = txt_DescP.Text;
                    break;
                case 1:
                    msg = "Modificacion corregida!";
                    cmd.Parameters.Add("DESCRIPCION_ACTIVIDAD", OracleDbType.Varchar2, 200).Value = txtDescA.Text;
                    cmd.Parameters.Add("DESCRIPCION_PROBLEMA", OracleDbType.Varchar2, 200).Value = txt_DescP.Text;
                    break;
                case 2:
                    msg = "Modificacion eliminada exitosamente!";
                    cmd.Parameters.Add("MODIFICACION_ID", OracleDbType.Integer, 6).Value = Int32.Parse(txtModID.Text);
                    break;

               
            }
            try
            {
                int r = cmd.ExecuteNonQuery();
                if (r < 0)
                {
                    MessageBox.Show(msg);
                    this.updateDataGrid();
                }
            }
            catch (Exception expe) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO KYANN.MODIFICACION(DESCRIPCION_ACTIVIDAD, DESCRIPCION_PROBLEMA)" +
                "VALUES(:DESCRIPCION_ACTIVIDAD, :DESCRIPCION_PROBLEMA)";
            this.AUD(sql, 0);
            
        }

        private void editar_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE KYANN.MODIFICACION SET MODIFICACION_ID = :MODIFICACION_ID, DESCRIPCION_ACTIVIDAD = :DESCRIPCION_ACTIVIDAD, DESCRIPCION_PROBLEMA = :DESCRICION_PROBLEMA";
            this.AUD(sql, 1);
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            String sql = "DELETE FROM KYANN.MODIFICACION " + "WHERE MODIFICACION_ID = :MODIFICACION_ID";
            this.AUD(sql, 2);
        }


        private void txtDescA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DescP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtModID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
