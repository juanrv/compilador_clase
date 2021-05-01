using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using System.Linq;

namespace lectorArchivo.Tablas
{
    public class TablaPalabraReservadas
    {
        private Dictionary<String, ComponenteLexico> PALABRAS_RESERVADAS = new Dictionary<string, ComponenteLexico>();
        private Dictionary<String, List<ComponenteLexico>> SIMBOLOS = new Dictionary<string, List<ComponenteLexico>>();
        private static TablaPalabraReservadas INSTANCIA = new TablaPalabraReservadas();

        private TablaPalabraReservadas()
        {
            PALABRAS_RESERVADAS.Add("A", ComponenteLexico.CrearComponentePalabraReservada("A", Categoria.PALABRA_RESERVADA_A));
            PALABRAS_RESERVADAS.Add("B", ComponenteLexico.CrearComponentePalabraReservada("B", Categoria.PALABRA_RESERVADA_B));
            PALABRAS_RESERVADAS.Add("C", ComponenteLexico.CrearComponentePalabraReservada("C", Categoria.PALABRA_RESERVADA_C));
        }

        

        public static void Limpiar()
        {
            INSTANCIA.SIMBOLOS.Clear();
        }
        private List<ComponenteLexico> ObetenerSimbolo(String Lexema)
        {
            if (!SIMBOLOS.ContainsKey(Lexema))
            {
                SIMBOLOS.Add(Lexema, new List<ComponenteLexico>());

            }
            return SIMBOLOS[Lexema];
        }
        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null
                && !componente.ObtenerLexema().Equals("")
                && componente.ObtenerTipo().Equals(TipoComponente.SIMBOLO))
            {
                INSTANCIA.ObetenerSimbolo(componente.ObtenerLexema()).Add(componente);
            }
        }
        public static List<ComponenteLexico> ObtenerSimbolos()
        {
            return INSTANCIA.SIMBOLOS.Values.SelectMany(componente => componente).ToList();
        }

        public Boolean EsPalabraReservada(String Lexema)
        {
            return PALABRAS_RESERVADAS.ContainsKey(Lexema);

        }
        public ComponenteLexico ObtenerPalabraReservada(String Lexema)
        {
            return PALABRAS_RESERVADAS[Lexema];
        }

        public static ComponenteLexico ComprobarPalabraReservada(ComponenteLexico Componente)
        {
            if (Componente != null && INSTANCIA.EsPalabraReservada(Componente.ObtenerLexema()))
            {
                
                Categoria Categoria = INSTANCIA.ObtenerPalabraReservada(Componente.ObtenerLexema()).ObtenerCategoria();
                ComponenteLexico NuevoComponente = ComponenteLexico.CrearComponentePalabraReservada(Componente.ObtenerLexema(), Categoria, Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal());

                return NuevoComponente;
            }

            return Componente;
        }
    }
}
