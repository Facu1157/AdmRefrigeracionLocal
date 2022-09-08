namespace cGestionLocal.Methods
{

    public class validaciones
    {

        public static double numeroDouble(String TextBox)
        {
            bool Exitoso = true;
            double nDouble;

            if (TextBox.Contains("."))
                TextBox = TextBox.Replace(".", ",");

            Exitoso = double.TryParse(TextBox, out nDouble);



            if (Exitoso == true)
            { return nDouble; }

            else
            {
                return -1;
            }

        }




    }
}
