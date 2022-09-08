using cGestionLocal.Methods;

namespace GestionLocal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_IVA_Click(object sender, EventArgs e)
        {
            string costo;
            bool nConvertido = true;
            double num = 0;
            double IVA;
            double resIVA45;
            double resIVA50;
            double res45;
            double res50;






            //costo = txt_Precio.Text;


            num = validaciones.numeroDouble(txt_Precio.Text);

            if (num == -1)
            {
                MessageBox.Show("*Error* escriba un numero valido");
                Borrar();
            }

            else
            {
                IVA = num * 1.21;
                resIVA45 = IVA * 1.45;

                resIVA50 = IVA * 1.50;

                res45 = num * 1.45;
                res50 = num * 1.50;


                txt_ganancia_45.Text = Convert.ToString(resIVA45);
                txt_ganancia_50.Text = Convert.ToString(resIVA50);
                text_costo_final.Text = Convert.ToString(IVA);

                txt_45_sinIVa.Text = Convert.ToString(res45);
                txt_50_sinIVA.Text = Convert.ToString(res50);

            }

        }

        private void btn_borrarTodo_Click(object sender, EventArgs e)
        {
            Borrar();
        }


        public void Borrar()
        {

            text_costo_final.Text = Convert.ToString("");
            txt_Precio.Text = Convert.ToString("");
            txt_ganancia_45.Text = Convert.ToString("");
            txt_ganancia_50.Text = Convert.ToString("");

            txt_45_sinIVa.Text = Convert.ToString("");
            txt_50_sinIVA.Text = Convert.ToString("");
        }


    }
}
