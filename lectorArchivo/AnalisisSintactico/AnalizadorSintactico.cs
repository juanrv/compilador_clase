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

        public ComponenteLexico Analizar(bool depurar)
        {
            AnaLex = new AnalizadorLexico();
            TrazaDerivacion = new StringBuilder();
            Avanzar();
            Expresion(0);
            if (depurar)
            {
                MessageBox.Show(TrazaDerivacion.ToString());
            }

            return Componente;
        }
        private void Expresion(int jerarquia)
        {
            TrazarEntrada("<Expresion>", jerarquia);
            Termino(jerarquia+1);
            ExpresionPrima(jerarquia+1);
            TrazarSalida("</Expresion>", jerarquia);
        }
        private void ExpresionPrima(int jerarquia)
        {
            TrazarEntrada("<ExpresionPrima>", jerarquia);
            if (Categoria.SUMA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(jerarquia+1);
            }
            else if (Categoria.RESTA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(jerarquia+1);
            }
            TrazarSalida("</ExpresionPrima>", jerarquia);

        }
        private void Termino(int jerarquia)
        {
            TrazarEntrada("<Termino>", jerarquia);
            Factor(jerarquia + 1);
            TerminoPrima(jerarquia + 1);
            TrazarSalida("</Termino>", jerarquia);
        }
        private void TerminoPrima(int jerarquia)
        {
            TrazarEntrada("<TerminoPrima>", jerarquia);
            if (Categoria.MULTIPLICACION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino(jerarquia + 1);
            }
            else if (Categoria.DIVISION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino(jerarquia + 1);
            }
            TrazarSalida("</TerminoPrima>", jerarquia);

        }
        private void Factor(int jerarquia)
        {
            TrazarEntrada("<Factor>", jerarquia);
            if (Categoria.NUMERO_ENTERO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_DECIMAL.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(jerarquia + 1);

                if (Categoria.PARENTESIS_CIERRA.Equals(Componente.ObtenerCategoria()))
                {
                    Avanzar();
                }
                else
                {
                    String Causa = "Se esperaba un parentesis que se cierra y se recibio " + Componente.ObtenerCategoria();
                    String falla = "Parentesis desequilibrado";
                    String Solucion = "Asegurese que los parentesis que se abran, tambien se cierren";

                    Error Error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), falla, Causa, Solucion);
                    ManejadorErrores.Reportar(Error);

                }
            }
            else
            {
                String Causa = "Se esperaba un entero, un decimal o parentesis que abre " + Componente.ObtenerCategoria();
                String falla = "Componente lexico recibido no permitido segun las reglas de formacion de lenguaje";
                String Solucion = "Asegurese que en esta posicion existe un entero, decimal o parentesis que abre";

                Error Error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), falla, Causa, Solucion);
                ManejadorErrores.Reportar(Error);
                throw new Exception("se ha presentado un error de tipo stopper dentro del proceso de compilacion. Por favor revise la consola de errores...");

                //Generar Erros Sintactico
            }
            TrazarSalida("</Factor>", jerarquia);


        }
        private void Avanzar()
        {
            Componente = AnaLex.Analizar();
        }
        private void TrazarEntrada(string NombreRegla, int jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(jerarquia));
            TrazaDerivacion.Append(NombreRegla).Append("(").Append(Componente.ObtenerCategoria()).Append(")");
            TrazaDerivacion.Append(Environment.NewLine);

        }
        private void TrazarSalida(string NombreRegla, int jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(jerarquia));
            TrazaDerivacion.Append(NombreRegla);
            TrazaDerivacion.Append(Environment.NewLine);

        }
    
        private string FormarCadenaEspaciosBlanco(int jerarquia)
        {
            String EspaciosBlanco = "";
            for (int i = 1; i<=jerarquia * 2; i++)
            {
                EspaciosBlanco = EspaciosBlanco + " | ";
            }
            return EspaciosBlanco;
        }
    }
}
