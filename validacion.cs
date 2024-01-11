using System;

namespace Recursos_Humanos
{
    class validacion
    {
        public Boolean validarTexto(int e)
        {
            if ((e < 65 || e > 90) &&
                (e < 97 || e > 122) &&
                e != 32 && e != 8 && e != 209 && e != 241)
            { return true; }
            else
            { return false; }
        }

        public Boolean validarNumero(int e)
        {
            if ((e < 48 || e > 57) &&
                e != 8 && e != 13)
            { return true; }
            else
            { return false; }
        }

        public Boolean validarDecimal(int e)
        {
            if ((e < 48 || e > 57) &&
                e != 8 && e != 46)
            { return true; }
            else
            { return false; }
        }


        public Boolean validarMoneda(int e, String cadena)
        {
            int h = cadena.IndexOf(".");//ubica la posicion de un punto decimal en la cadena
            if ((e < 48 || e > 57) && e != 8 && e != 46)
            { return true; }
            else
            {
                if (e == 46)//si es punto decimal 
                {
                    if (cadena.Length == 0)//no puede empezar por punto
                    { return true; }
                    else//solo una vez debe estar un punto decimal
                    {
                        if (h > -1)//si la posición del punto decimal es menor a 0 no hay punto decimal aún
                        { return true; }
                        else
                        { return false; }
                    }
                }
                else//si es un digito (numero)
                {
                    if (h >= 0 && e != 8)//si la ubicación del punto de decimal es mayor o igual a cero y la tecla es un numero
                    {
                        String g = cadena.Substring(h); //subcadena desde el punto decimal hacia la derecha
                        int l = g.Length;//longitud de la subcadena
                        if (l > 2)//si es mayor a 2 es porque esta màs de 2 decimales
                        { return true; }
                        else
                        { return false; }
                    }
                    else
                    { return false; }
                }
            }
        }


        public String validarCedula(String Cedula)
        {
            String mensaje = "";
            int digito = 0;//para c/digito de la cedula
            int suma = 0;//para la suma de todos los digitos

            if (Cedula.Length > 1)
            {
                if (Cedula.Length < 10)
                {
                    mensaje = "La cedula debe tener 10 digitos\n";
                }
                if (Convert.ToInt16(Cedula.Substring(0, 2)) < 1 ||
                    Convert.ToInt16(Cedula.Substring(0, 2)) > 24)
                {
                    mensaje = mensaje + "Los dos primeros digitos son incorrectos\n";
                }
                if (Cedula.Length == 10)
                {
                    for (int x = 0; x < 10; x = x + 1)
                    {
                        digito = int.Parse(Cedula.Substring(x, 1));
                        if ((x + 1) % 2 == 1)//verifica si es impar
                        {
                            digito = digito * 2;
                            if (digito > 9)
                            {
                                digito = digito - 9;
                            }
                        }
                        suma = suma + digito;
                    }
                    if (suma % 10 != 0)
                    {
                        mensaje = mensaje + "numeración invalida de cédula";
                    }
                }
            }
            if (mensaje == "")
            { return "Cédula válida"; }
            else
            { return mensaje; }
        }
    }
}

