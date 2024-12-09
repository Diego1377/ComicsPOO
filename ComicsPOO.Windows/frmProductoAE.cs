using ComicsPOO.Entidades;
using System.Threading.Tasks;

namespace ComicsPOO.Windows
{
    public partial class frmProductoAE : Form
    {
        private Producto? producto;
        private TipoProducto? tipoProcuto = TipoProducto.Comic;
        public frmProductoAE()
        {
            InitializeComponent();
        }
        public Producto? GetProducto()
        {
            return producto;
        }

        private void DeshabilitarControles()
        {
            txtAltura.Enabled = false;
            txtAutor.Enabled = false;
            txtDescripcion.Enabled = false;
            cboTipo.Enabled = false;
            gbTipo.Enabled = false;
        }

        private void ManejarControles(TipoProducto tipoProducto)
        {
            if (tipoProducto == TipoProducto.Comic)
            {
                MostrarControles(true);
            }
            else
            {
                MostrarControles(false);
            }

        }

        private void MostrarControles(bool v)
        {
            lblAutor.Visible = v;
            txtAutor.Visible = v;
            lblTipo.Visible = v;
            cboTipo.Visible = v;

            lblAltura.Visible = !v;
            txtAltura.Visible = !v;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto()
                {
                    Descipcion = txtDescripcion.Text,
                    Precio = (decimal)nudPrecio.Value,
                    Stock = (int)nudStock.Value
                    
                };

                tipoProcuto = rbtFigurita.Checked ? TipoProducto.Figurita : TipoProducto.Comic;


                if (tipoProcuto == TipoProducto.Figurita)
                {
                    producto = new Figurita();
                }
                else
                {
                    producto = new Comic();
                }

                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
