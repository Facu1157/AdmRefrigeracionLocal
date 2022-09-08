using cGestionLocal.Methods;

namespace GestionLocal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Calcular_IVA_Click(object sender, EventArgs e)
        {
            //String kg_garrafa = txt_kg_garrafa.Text;
            double KG_garrafa = 0;

            double Precio;

            double costo_final;

            double garrafa45, garrafa50;


            Precio = validaciones.numeroDouble(txt_Precio.Text);
            KG_garrafa = validaciones.numeroDouble(txt_kg_garrafa.Text);

            if (Precio == -1 || KG_garrafa == -1)
            {
                MessageBox.Show("*Error* escriba un numero valido");
                Borrar();
            }

            else
            {
                costo_final = Precio * 1.21;
                garrafa45 = costo_final * 1.45;
                garrafa50 = costo_final * 1.50;
                text_costo_final.Text = $"{costo_final}";


                KG_garrafa = KG_garrafa - 1;//1kg de perdida por las mangueras
                txt_costoKG.Text = $"{costo_final / KG_garrafa}";
                txt_ganancia_45.Text = $"{garrafa45}";
                txt_ganancia50.Text = $"{garrafa50}";
                txt_45.Text = $"{garrafa45 / KG_garrafa}";//kg suelto
                txt_50.Text = $"{garrafa50 / KG_garrafa}";






            }
        }

        public void Borrar()
        {
            txt_kg_garrafa.Text = "";
            txt_Precio.Text = "";
            text_costo_final.Text = "";
            txt_costoKG.Text = "";
            txt_ganancia_45.Text = "";
            txt_ganancia50.Text = "";
            txt_45.Text = "";
            txt_50.Text = "";

        }

    }
}
