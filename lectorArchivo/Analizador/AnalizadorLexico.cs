using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using lectorArchivo.Tablas;
using lectorArchivo.GestorErrores;
namespace lectorArchivo.Analizador
{
    public class AnalizadorLexico
    {
        private int Puntero;
        private int NumeroLineaActual;
        private Linea LineaActual;
        private String CaracterActual = "????";
        private String Lexema = "";
        private int EstadoActual;
        private bool ContinuarAnalisis;
        private ComponenteLexico Componente;
       


        public AnalizadorLexico()
        {
            NumeroLineaActual = 0;
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            NumeroLineaActual++;
            LineaActual = Cache.obtenerCache().ObtenerLinea(NumeroLineaActual);
            NumeroLineaActual = LineaActual.ObtenerNumeroLinea();
            InicializarPuntero();
        }

        private void InicializarPuntero()
        {
            Puntero = 1;
        }
        private void DevolverPuntero()
        {
            if (Puntero > 1)
            {
                Puntero--;
            }
        }

        private void AdelantarPuntero()
        {
            Puntero++;
        }

        private void LeerSiguienteCaracter()
        {
            if (LineaActual.EsFinArchivo())
            {
                CaracterActual = LineaActual.ObtenerContenido();
            }
            else if (Puntero > LineaActual.ObtenerContenido().Length)
            {
                CaracterActual = "@FL@";
                AdelantarPuntero();
            }
            else
            {
                CaracterActual = LineaActual.ObtenerContenido().Substring(Puntero - 1, 1);
                AdelantarPuntero();
            }
        }

        private void FormarComponente()
        {
            Lexema = Lexema + CaracterActual;
        }

        private void ResetearLexema()
        {
            Lexema = "";
        }
        private void DevorarEspaciosBlanco()
        {
            String blanco = " ";
            while (CaracterActual.Equals(blanco))
            {
                LeerSiguienteCaracter();
            }
        }

        private void Resetear()
        {
            CaracterActual = "";
            ResetearLexema();
            ContinuarAnalisis = true;
            EstadoActual = 0;
            Componente = null;
        }

        public ComponenteLexico Analizar()
        {
            Resetear();
            while (ContinuarAnalisis)
            {
                if (EstadoActual == 0)
                {
                    EstadoCero();
                }
                else if (EstadoActual == 1)
                {
                    EstadoUno();
                }
                else if (EstadoActual == 2)
                {
                    EstadoDos();
                }
                else if (EstadoActual == 3)
                {
                    EstadoTres();
                }
                else if (EstadoActual == 4)
                {
                    EstadoCuatro();
                }
                else if (EstadoActual == 5)
                {
                    EstadoCinco();
                }
                else if (EstadoActual == 6)
                {
                    EstadoSeis();
                }
                else if (EstadoActual == 7)
                {
                    EstadoSiete();
                }
                else if (EstadoActual == 8)
                {
                    EstadoOcho();
                }
                else if (EstadoActual == 9)
                {
                    EstadoNueve();
                }
                else if (EstadoActual == 10)
                {
                    EstadoDiez();
                }
                else if (EstadoActual == 11)
                {
                    EstadoOnce();
                }
                else if (EstadoActual == 12)
                {
                    EstadoDoce();
                }
                else if (EstadoActual == 13)
                {
                    EstadoTrece();
                }
                else if (EstadoActual == 14)
                {
                    EstadoCatorce();
                }
                else if (EstadoActual == 15)
                {
                    EstadoQuince();
                }
                else if (EstadoActual == 16)
                {
                    EstadoDieciseis();
                }
                else if (EstadoActual == 17)
                {
                    EstadoDiecisiete();
                }
                else if (EstadoActual == 18)
                {
                    EstadoDieciocho();
                }
                else if (EstadoActual == 19)
                {
                    EstadoDiecinueve();
                }
                else if (EstadoActual == 20)
                {
                    EstodoVeinte();
                }
                else if (EstadoActual == 21)
                {
                    EstadoVeintiuno();
                }
                else if (EstadoActual == 22)
                {
                    EstadoVeintidos();
                }
                else if (EstadoActual == 23)
                {
                    EstadoVeintitres();
                }
                else if (EstadoActual == 24)
                {
                    EstadoVeinticuatro();
                }
                else if (EstadoActual == 25)
                {
                    EstadoVeinticinco();
                }
                else if (EstadoActual == 26)
                {
                    EstadoVeintiseis();
                }
                else if (EstadoActual == 27)
                {
                    EstadoVeintisiete();
                }
                else if (EstadoActual == 28)
                {
                    EstadoVeintiocho();
                }
                else if (EstadoActual == 29)
                {
                    EstadoVeintinueve();
                }
                else if (EstadoActual == 30)
                {
                    EstadoTreinta();
                }
                else if (EstadoActual == 31)
                {
                    EstadoTreintaiuno();
                }
                else if (EstadoActual == 32)
                {
                    EstadoTreintaidos();
                }
                else if (EstadoActual == 33)
                {
                    EstadoTreintaitres();
                }
                else if (EstadoActual == 34)
                {
                    EstadoTreintaicuatro();
                }
                else if (EstadoActual == 35)
                {
                    EstadoTreintaicinco();
                }
                else if (EstadoActual == 36)
                {
                    EstadoTreintaiseis();
                }
                else if (EstadoActual == 37)
                {
                    EstadoTreintaisiete();
                }

            }

            return TablaMaestra.SincronizarTabla(Componente);
        }


        private void EstadoCero()
        {
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            if (EsLetra() || EsSignoPesos() || EsGuinBajo())
            {
                EstadoActual = 4;
                FormarComponente();
            }
            else if (EsDigito())
            {
                EstadoActual = 1;
                FormarComponente();
            }
            else if (EsSuma())
            {
                EstadoActual = 5;
                FormarComponente();
            }
            else if (EsResta())
            {
                EstadoActual = 6;
                FormarComponente();
            }
            else if (EsMultiplicacion())
            {
                EstadoActual = 7;
                FormarComponente();
            }
            else if (EsDivision())
            {
                EstadoActual = 8;
                FormarComponente();
            }
            else if (EsPorcentaje())
            {
                EstadoActual = 9;
                FormarComponente();
            }
            else if (EsParentesisInicial())
            {
                EstadoActual = 10;
                FormarComponente();
            }
            else if (EsParentesisFinal())
            {
                EstadoActual = 11;
                FormarComponente();
            }
            else if (EsIgual())
            {
                EstadoActual = 19;
                FormarComponente();
            }
            else if (EsMenorQue())
            {
                EstadoActual = 20;
                FormarComponente();
            }
            else if (EsMayorQue())
            {
                EstadoActual = 21;
                FormarComponente();
            }
            else if (EsFinLInea())
            {
                EstadoActual = 13;
            }
            else if (EsAdmiracion())
            {
                EstadoActual = 30;
                FormarComponente();
            }
            else if (EsDosPuntos())
            {
                EstadoActual = 22;
                FormarComponente();
            }
            else if (LineaActual.EsFinArchivo())
            {
                EstadoActual = 12;
            }
            else 
            {
                EstadoActual = 18;
            }
            
        }
        private void EstadoUno()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 1;
                FormarComponente();
            }
            else if (EsComa())
            {
                EstadoActual = 2;
                FormarComponente();
            }
            else
            {
                EstadoActual = 14;
            }
        }
        private void EstadoDos()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 3;
                FormarComponente();
            }
            else
            {
                EstadoActual = 17;
            }
        }
        private void EstadoTres()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 3;
                FormarComponente();
            }
            else
            {
                EstadoActual = 15;
            }
        }
        private void EstadoCuatro()
        {
            LeerSiguienteCaracter();
            if (EsLetra() || EsSignoPesos() || EsGuinBajo())
            {
                EstadoActual = 4;
                FormarComponente();
            }
            else
            {
                EstadoActual = 16;
            }
        }
        private void EstadoCinco()
        {
            
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.SUMA, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);


        }
        private void EstadoSeis()
        {

            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.RESTA, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);


        }
        private void EstadoSiete()
        {

            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MULTIPLICACION, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);


        }
        private void EstadoOcho()
        {
            LeerSiguienteCaracter();
            if (EsMultiplicacion())
            {
                EstadoActual = 34;
                FormarComponente();

            }
            else if (EsDivision())
            {
                EstadoActual = 36;
                FormarComponente();
            }
            else
            {
                EstadoActual = 13;
            }

        }
        private void EstadoNueve()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MODULO, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoDiez()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.PARENTESIS_ABRE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoOnce()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.PARENTESIS_CIERRA, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoDoce()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.FIN_DE_ARCHIVO, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoTrece()
        {
            CargarNuevaLinea();
            Resetear();
        }
        private void EstadoCatorce()
        {
            DevolverPuntero();
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_ENTERO, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
            ContinuarAnalisis = false;
        }
        private void EstadoQuince()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_DECIMAL, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoDieciseis()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            CrearComponente(Lexema, Categoria.IDENTIFICADOR, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);

        }
        private void EstadoDiecisiete()
        {
            
            ContinuarAnalisis = false;
            DevolverPuntero();
            String Causa = "Se esperaba un dígito y se recibió" + CaracterActual;
            String falla = "Número decimal no valido";
            String Solucion = "NUMERO DECIMAL";

            Error Error = Error.CrearErrorLexico(Lexema, Categoria.NUMERO_DECIMAL, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1, falla, Causa, Solucion);
            ManejadorErrores.Reportar(Error);
            CrearComponenteDummy("1,0", Error.ObtenerCategoria(), Error.ObtenerNumeroLinea(), Error.ObetenerPosicionInicial(), Error.ObtenerPosicionFinal());
            

        }
        private void EstadoDieciocho()
        {
            ContinuarAnalisis = false;
            String Causa = "Se esperaba un caracter valido dentro del lenguaje y se recibio " + CaracterActual;
            String falla = "Caracter no reconocido por el lenguaje";
            String Solucion = "Asegurarse que el caracter sea valido";
            Error Error = Error.CrearErrorLexico(Lexema, Categoria.NUMERO_DECIMAL, NumeroLineaActual, Puntero
                 - Lexema.Length, Puntero - 1, falla, Causa, Solucion);
            ManejadorErrores.Reportar(Error);

            throw new Exception("se ha presentado un error de tipo stopper dentro del proceso de compilacion. Por favor revise la consola de errores...");
        }
        private void EstadoDiecinueve()
        {

            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.IGUAL_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstodoVeinte()
        {
            LeerSiguienteCaracter();
            if (EsMayorQue())
            {
                EstadoActual = 23;
                FormarComponente();
            }
            else if (EsIgual())
            {
                EstadoActual = 24;
                FormarComponente();
            }
            else
            {
                EstadoActual = 25;
            }
        }
        private void EstadoVeintiuno()
        {
            LeerSiguienteCaracter();
            if (EsIgual())
            {
                EstadoActual = 26;
                FormarComponente();
            }
            else
            {
                EstadoActual = 27;
            }
        }
        private void EstadoVeintidos()
        {
            LeerSiguienteCaracter();
            if (EsIgual())
            {
                EstadoActual = 28;
                FormarComponente();
            }
            else
            {
                EstadoActual = 29;
            }
        }
        private void EstadoVeintitres()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoVeinticuatro()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MENOR_O_IGUAL_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoVeinticinco()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MENOR_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoVeintiseis()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MAYOR_O_IGUAL_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoVeintisiete()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MAYOR_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoVeintiocho()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.ASIGNACION, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoVeintinueve()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            String Causa = "Se esperaba un igual y se recibió" + CaracterActual;
            String falla = "Asignación no válida";
            String Solucion = "ASIGNACION";
            Error Error = Error.CrearErrorLexico(Lexema, Categoria.ASIGNACION, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1, falla, Causa, Solucion);
            ManejadorErrores.Reportar(Error);
            CrearComponenteDummy(":=", Error.ObtenerCategoria(), Error.ObtenerNumeroLinea(), Error.ObetenerPosicionInicial(), Error.ObtenerPosicionFinal());

        }
        private void EstadoTreinta()
        {
            LeerSiguienteCaracter();
            if (EsIgual())
            {
                EstadoActual = 31;
                FormarComponente();
            }
            else
            {
                EstadoActual = 32;
            }
        }
        private void EstadoTreintaiuno()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoTreintaidos()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            String Causa = "Se esperaba un igual y se recibió" + CaracterActual;
            String falla = "Asignación no válida";
            String Solucion = "DIFERENTE QUE";
            Error Error = Error.CrearErrorLexico(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1, falla, Causa, Solucion);
            ManejadorErrores.Reportar(Error);
            CrearComponenteDummy("!=", Error.ObtenerCategoria(), Error.ObtenerNumeroLinea(), Error.ObetenerPosicionInicial(), Error.ObtenerPosicionFinal());

        }
        private void EstadoTreintaitres()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.DIVISION, NumeroLineaActual, Puntero - Lexema.Length, Puntero - 1);
        }
        private void EstadoTreintaicuatro()
        {
            LeerSiguienteCaracter();
            if (!EsMultiplicacion())
            {
                FormarComponente();
                EstadoActual = 35;
            }
            else if (EsFinLInea())
            {
                FormarComponente();
                EstadoActual = 37;
            }
            else
            {
                FormarComponente();
                EstadoActual = 34;
            }
        }
        private void EstadoTreintaicinco()
        {
            LeerSiguienteCaracter();
            if (EsMultiplicacion())
            {

                FormarComponente();
                EstadoActual = 35;

            }
            else if (EsDivision())
            {
                FormarComponente();
                EstadoActual = 0;
            }
            else
            {
                FormarComponente();
                EstadoActual = 34;
            }
        }
        private void EstadoTreintaiseis()
        {
            LeerSiguienteCaracter();
            if (EsFinLInea())
            {
                FormarComponente();
                EstadoActual = 13;
            }
            else
            {
                FormarComponente();
                EstadoActual = 36;
            }

        }
        private void EstadoTreintaisiete()
        {
            FormarComponente();
            CargarNuevaLinea();
            EstadoActual = 34;
            InicializarPuntero();
        }


        private bool EsLetra()
        {
            return Char.IsLetter(CaracterActual.ToCharArray()[0]);
        }
        private bool EsDigito()
        {
            return Char.IsDigit(CaracterActual.ToCharArray()[0]);
        }
        private bool EsSignoPesos()
        {
            return "$".Equals(CaracterActual);
        }
        private bool EsSuma()
        {
            return "+".Equals(CaracterActual);
        }
        private bool EsResta()
        {
            return "-".Equals(CaracterActual);
        }
        private bool EsMultiplicacion()
        {
            return "*".Equals(CaracterActual);
        }
        private bool EsDivision()
        {
            return "/".Equals(CaracterActual);
        }
        private bool EsPorcentaje()
        {
            return "%".Equals(CaracterActual);
        }
        private bool EsParentesisInicial()
        {
            return "(".Equals(CaracterActual);
        }
        private bool EsParentesisFinal()
        {
            return ")".Equals(CaracterActual);
        }
        private bool EsComa()
        {
            return ",".Equals(CaracterActual);
        }
        private bool EsDosPuntos()
        {
            return ":".Equals(CaracterActual);
        }
        private bool EsIgual()
        {
            return "=".Equals(CaracterActual);
        }
        private bool EsMenorQue()
        {
            return "<".Equals(CaracterActual);
        }
        private bool EsMayorQue()
        {
            return ">".Equals(CaracterActual);
        }
        private bool EsAdmiracion()
        {
            return "!".Equals(CaracterActual);
        }
        private bool EsGuinBajo()
        {
            return "_".Equals(CaracterActual);
        }
        private bool EsFinLInea()
        {
            return "@FL@".Equals(CaracterActual);
        }
        private void CrearComponente(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteSimbolo(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        private void CrearComponenteLiteral(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteLiteral(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        private void CrearComponenteDummy(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteDummy(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
    }

    
}
