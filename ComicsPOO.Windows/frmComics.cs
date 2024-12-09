using ComicsPOO.Datos;
using ComicsPOO.Entidades;
using ComicsPOO.Windows.Helpers;
using System.Text;

namespace ComicsPOO.Windows
{
    public partial class frmComics : Form
    {
        private Comiqueria? comiqueria;
        public frmComics()
        {
            InitializeComponent();
        }

        private Comiqueria GetComiqueria()
        {
            return comiqueria;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmProductoAE frm = new frmProductoAE() { Text = "Nuevo Producto" };
            DialogResult = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;
            Producto? producto = frm.GetProducto();
            if (producto == null) return;
            try
            {
                var resultado = comiqueria!.AgregarProducto(producto);
                if (resultado.exito)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Préstamo agregado");                             
                    sb.AppendLine(resultado.mensaje);
                    MessageBox.Show(sb.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //GridHelper.MostrarDatosEnGrilla<Producto>(comiqueria!.GetProducto(TipoProducto.Todos)!, dgvDatos);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("producto rechazado");
                    sb.AppendLine(resultado.mensaje);
                    MessageBox.Show(sb.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("joder que pasó!!!");
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
