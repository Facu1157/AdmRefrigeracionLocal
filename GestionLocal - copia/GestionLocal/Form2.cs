using cGestionLocal.Methods;

namespace GestionLocal
{



    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Caclcular_caños_res_Click(object sender, EventArgs e)
        {
            //1/4 1/2 3/8 5/8
            double[] peso_gr_mt = new double[] { 126, 266, 200, 333 };
            double[] precio = new double[4];



            double precio_kg;


            bool nConvertido = true;


            // precio_kg = txt_precio_kg.Text;

            precio_kg = validaciones.numeroDouble(txt_precio_kg.Text);
            //nConvertido = double.TryParse(precio_kg, out num);

            if (precio_kg == -1)
            {
                MessageBox.Show("*Error* escriba un numero valido");
                Borrar();

            }

            else
            {
                for (int i = 0; i < precio.Length; i++)
                {
                    precio[i] = peso_gr_mt[i] * precio_kg / 1000;
                }
                txt_res_1_4.Text = Convert.ToString(precio[0]);
                txt_res_1_2.Text = Convert.ToString(precio[1]);
                txt_res_3_8.Text = Convert.ToString(precio[2]);
                txt_res_5_8.Text = Convert.ToString(precio[3]);
            }
        }

        private void btn_borrarTodo_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        public void Borrar()
        {


            txt_precio_kg.Text = Convert.ToString("");
            txt_res_1_4.Text = "";
            txt_res_1_2.Text = "";
            txt_res_3_8.Text = "";
            txt_res_5_8.Text = "";
        }


    }
}
