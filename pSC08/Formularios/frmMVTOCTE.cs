using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace pSC08
{
    public partial class frmMVTOCTE : Form
    {
        public frmMVTOCTE()
        {
            InitializeComponent();
            EstiloDataGridView();
        }

        private void frmMVTOCTE_Load(object sender, EventArgs e)
        {

        }

        private void frmMVTOCTE_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void btnCONFACT_Click(object sender, EventArgs e)
        {
            frmVENCTE frm = new frmVENCTE();
            frm.ShowDialog();

            if (frm.seleccionedata == true)
            {
                txtCliente.Text = frm.var1;
                lblNombre.Text = frm.var2;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "ID");
            this.dgv.Columns.Add("Col01", "Nombre");
            this.dgv.Columns.Add("Col02", "Orden");
            this.dgv.Columns.Add("Col03", "Fecha");
            this.dgv.Columns.Add("Col04", "Producto");
            this.dgv.Columns.Add("Col05", "Descripcion");
            this.dgv.Columns.Add("Col06", "Cantidad");
            this.dgv.Columns.Add("Col07", "Descuento");
            this.dgv.Columns.Add("Col08", "Precio");
            this.dgv.Columns.Add("Col09", "T Desc");
            this.dgv.Columns.Add("Col10", "T S Desc");
            this.dgv.Columns.Add("Col11", "T Linea");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 100;
            column = dgv.Columns[02]; column.Width = 100;
            column = dgv.Columns[03]; column.Width = 100;
            column = dgv.Columns[04]; column.Width = 100;
            column = dgv.Columns[05]; column.Width = 100;
            column = dgv.Columns[06]; column.Width = 100;
            column = dgv.Columns[07]; column.Width = 100;
            column = dgv.Columns[08]; column.Width = 100;
            column = dgv.Columns[09]; column.Width = 100;
            column = dgv.Columns[10]; column.Width = 100;
            column = dgv.Columns[11]; column.Width = 100;

            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BuscarData(string numCte)
        {
            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores

            SqlConnection cnx = new SqlConnection(cnn.bd);
            cnx.Open();

            string stQuery = "    SELECT A.CustomerID, " +
                             "           D.CompanyName,  " +
                             "           A.OrderID, " +
                             "           A.OrderDate,  " +
                             "           B.ProductID, " +
                             "           C.ProductName, " +
                             "           B.Quantity, " +
                             "           B.Discount, " +
                             "           B.UnitPrice, " +
                             "           (B.Quantity * B.UnitPrice) * B.Discount AS Descuento, " +
                             "           (B.Quantity * B.UnitPrice) AS Total_Sin_Descuento, " +
                             "           (B.Quantity * B.UnitPrice) -((B.Quantity * B.UnitPrice) * B.Discount) AS Total_Linea " +
                             "      FROM Orders A " +
                             "INNER JOIN [Order Details] B ON A.OrderID    = B.OrderID " +
                             "INNER JOIN Products        C ON B.ProductID  = C.ProductID " +
                             "INNER JOIN Customers       D ON A.CustomerID = D.CustomerID " +
                             "     WHERE A.CustomerID ='" + numCte  +
                             "' ORDER BY A.CustomerID ASC";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            while (rcd.Read())
            {
                dgv.Rows.Add();   // le suma uno al contador del datagridview
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = Convert.ToString(rcd[""]);
                dgv[1, xRows].Value = Convert.ToString(rcd[""]);
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
