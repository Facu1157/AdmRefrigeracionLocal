namespace GestionLocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form FormularioActivo = null;
        private void abrirPanelHijo(Form formularioHijo)//recive al formulario activo
        {

            if (FormularioActivo != null)//Si Hay algo abierto, lo cierra
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;// sin bordes
            formularioHijo.Dock = DockStyle.Fill;//ocupa todo el contenedor
            pnl_Contenedor.Controls.Add(formularioHijo);//agrego el hijo a la vista del contenedor
            pnl_Contenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();// en caso de logo (?
            formularioHijo.Show();

        }

        private void btn_caños_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form2());
        }

        private void btn_precio_IVA_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form3());
        }

        private void btn_gases_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form4());
        }
    }
}