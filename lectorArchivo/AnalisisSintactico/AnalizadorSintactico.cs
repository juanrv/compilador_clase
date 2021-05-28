using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using lectorArchivo.Analizador;
using lectorArchivo.GestorErrores;
using System.Windows.Forms;

namespace lectorArchivo.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private ComponenteLexico Componente;
        private AnalizadorLexico AnaLex;
        private StringBuilder TrazaDerivacion;
        private Stack<double> Pila = new Stack<double>();

        public Dictionary<string, object> Analizar(bool Depurar)
        {
            AnaLex = new AnalizadorLexico();
            TrazaDerivacion = new StringBuilder();
            Avanzar();
            Expresion(0);

            if (Depurar)
            {
                Console.Write(TrazaDerivacion.ToString());
                MessageBox.Show(TrazaDerivacion.ToString());

            }

            Dictionary<string, object> Resultado = new Dictionary<string, object>();
            Resultado.Add("COMPONENTE", Componente);
            Resultado.Add("PILA", Pila);
            return Resultado;
        }

        private void Expresion(int Jerarquia)
        {

            TrazarEntrada("<Expresion>", Jerarquia);

            Termino(Jerarquia + 1);
            ExpresionPrima(Jerarquia + 1);

            TrazarSalida("</Expresion>", Jerarquia);
        }


        private void ExpresionSinTerminoFactor(int Jerarquia)
        {
            TrazarEntrada("<Expresion>", Jerarquia);

            TerminoSinFactor(Jerarquia + 1);
            ExpresionPrima(Jerarquia + 1);

            TrazarSalida("</Expresion>", Jerarquia);
        }

        private void ExpresionPrima(int Jerarquia)
        {
            TrazarEntrada("<ExpresionPrima>", Jerarquia);

            if (Categoria.SUMA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino(Jerarquia + 1);

                double derecho = Pila.Pop();
                TrazarPop(Jerarquia, derecho);

                double izquierdo = Pila.Pop();
                TrazarPop(Jerarquia, izquierdo);

                double Valor = izquierdo + derecho;
                TrazarSalida(izquierdo + " + " + derecho + " = " + Valor, Jerarquia);
                Pila.Push(Valor);
                TrazarPush(Jerarquia, Valor);
                ExpresionSinTerminoFactor(Jerarquia + 1);
            }
            else if (Categoria.RESTA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino(Jerarquia + 1);

                double derecho = Pila.Pop();
                TrazarPop(Jerarquia, derecho);

                double izquierdo = Pila.Pop();
                TrazarPop(Jerarquia, izquierdo);

                double Valor = izquierdo - derecho;
                TrazarSalida(izquierdo + " - " + derecho + " = " + Valor, Jerarquia);
                Pila.Push(Valor);
                TrazarPush(Jerarquia, Valor);
                ExpresionSinTerminoFactor(Jerarquia + 1);
            }

            TrazarSalida("</ExpresionPrima>", Jerarquia);
        }

        private void Termino(int Jerarquia)
        {
            TrazarEntrada("<Termino>", Jerarquia);
            Factor(Jerarquia + 1);
            TerminoPrima(Jerarquia + 1);
            TrazarSalida("</Termino>", Jerarquia);
        }

        private void TerminoSinFactor(int Jerarquia)
        {
            TrazarEntrada("<Termino>", Jerarquia);
            TerminoPrima(Jerarquia + 1);
            TrazarSalida("</Termino>", Jerarquia);
        }

        private void TerminoPrima(int Jerarquia)
        {
            TrazarEntrada("<TerminoPrima>", Jerarquia);

            if (Categoria.MULTIPLICACION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Factor(Jerarquia + 1);

                double derecho = Pila.Pop();
                TrazarPop(Jerarquia, derecho);

                double izquierdo = Pila.Pop();
                TrazarPop(Jerarquia, izquierdo);

                double Valor = izquierdo * derecho;
                TrazarSalida(izquierdo + " * " + derecho + " = " + Valor, Jerarquia);
                Pila.Push(Valor);
                TrazarPush(Jerarquia, Valor);
                TerminoSinFactor(Jerarquia + 1);
            }
            else if (Categoria.DIVISION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Factor(Jerarquia + 1);

                double derecho = Pila.Pop();
                TrazarPop(Jerarquia, derecho);

                double izquierdo = Pila.Pop();
                TrazarPop(Jerarquia, izquierdo);

                if (derecho == 0)
                {
                    derecho = 1;

                    String Causa = "No es posible llevar a cabo una división por cero " + Componente.ObtenerCategoria();
                    String Falla = "Divisor cero.";
                    String Solucion = "Asegúrese que el divisor sea diferente de cero.";

                    Error error = Error.CrearErrorSemantico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion);
                    ManejadorErrores.Reportar(error);
                }
                double Valor = izquierdo / derecho;
                TrazarSalida(izquierdo + " / " + derecho + " = " + Valor, Jerarquia);
                Pila.Push(izquierdo / derecho);
                TrazarPush(Jerarquia, Valor);
                TerminoSinFactor(Jerarquia + 1);
            }

            TrazarSalida("</TerminoPrima>", Jerarquia);
        }

        private void Factor(int Jerarquia)
        {
            TrazarEntrada("<Factor>", Jerarquia);
            if (Categoria.NUMERO_ENTERO.Equals(Componente.ObtenerCategoria()))
            {
                double Valor = Convert.ToDouble(Componente.ObtenerLexema());
                Pila.Push(Convert.ToDouble(Componente.ObtenerLexema()));
                TrazarPush(Jerarquia, Valor);
                Avanzar();
            }
            else if (Categoria.NUMERO_DECIMAL.Equals(Componente.ObtenerCategoria()))
            {
                double Valor = Convert.ToDouble(Componente.ObtenerCategoria());
                Pila.Push(Convert.ToDouble(Componente.ObtenerLexema()));
                TrazarPush(Jerarquia, Valor);
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(Jerarquia + 1);

                if (Categoria.PARENTESIS_CIERRA.Equals(Componente.ObtenerCategoria()))
                {
                    Avanzar();
                }
                else
                {
                    String Causa = "Se esperaba un paréntesis que cierra y se recibió " + Componente.ObtenerCategoria();
                    String Falla = "Parentesis desequilibrados";
                    String Solucion = "Asegurese que los errores que abran, también se cierren.";

                    Error error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion);
                    ManejadorErrores.Reportar(error);
                }
            }
            else
            {
                String Causa = "Se esperaba un número entero o número decimal o paréntesis que abre  y se recibió " + Componente.ObtenerCategoria();
                String Falla = "Componente léxico recibido no permitido según als reglas de fromación del lenguaje.";
                String Solucion = "Asegurese que en esta posición existe un número entero, nuúmero decimal o paréntesis que abre..";

                Error error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion);
                ManejadorErrores.Reportar(error);

                throw new Exception("se ha presentado un error de tipo stopper dentro del proceso de compilación. Por favor revise la consola de comando.");
            }
            TrazarSalida("</Factor>", Jerarquia);
        }

        private void Avanzar()
        {
            Componente = AnaLex.Analizar();
        }

        private void TrazarEntrada(String NombreRegla, int Jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(Jerarquia));
            TrazaDerivacion.Append(NombreRegla)
                .Append("(").Append(Componente.ObtenerCategoria()).Append(")");
            TrazaDerivacion.Append(Environment.NewLine);
        }

        private void TrazarSalida(String NombreRegla, int Jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(Jerarquia));
            TrazaDerivacion.Append(NombreRegla);
            TrazaDerivacion.Append(Environment.NewLine);
        }

        private void TrazarPush(int Jerarquia, double Valor)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(Jerarquia));
            TrazaDerivacion.Append("PUSH -> ").Append(Valor);
            TrazaDerivacion.Append(Environment.NewLine);
        }

        private void TrazarPop(int Jerarquia, double Valor)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(Jerarquia));
            TrazaDerivacion.Append("POP -> ").Append(Valor);
            TrazaDerivacion.Append(Environment.NewLine);
        }

        private String FormarCadenaEspaciosBlanco(int Jerarquia)
        {
            String EspaciosBlanco = "";

            for (int indice = 1; indice <= Jerarquia * 2; indice++)
            {
                EspaciosBlanco = EspaciosBlanco + " ";
            }

            return EspaciosBlanco;
        }
    }
}
