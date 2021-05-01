using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using System.Linq;

namespace lectorArchivo.Tablas
{
    public class TablaLiterales
    {
        private Dictionary<String, List<ComponenteLexico>> LITERALES = new Dictionary<string, List<ComponenteLexico>>();

        private static TablaLiterales INSTANCIA = new TablaLiterales();

        private TablaLiterales()
        {

        }

        public static void Limpiar()
        {
            INSTANCIA.LITERALES.Clear();
        }
        private List<ComponenteLexico> ObetenerLiteral(String Lexema)
        {
            if (!LITERALES.ContainsKey(Lexema))
            {
                LITERALES.Add(Lexema, new List<ComponenteLexico>());
            }
            return LITERALES[Lexema];
        }
        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null
                && !componente.ObtenerLexema().Equals("")
                && componente.ObtenerTipo().Equals(TipoComponente.LITERAL))
            {
                INSTANCIA.ObetenerLiteral(componente.ObtenerLexema()).Add(componente);
            }
        }
        public static List<ComponenteLexico> ObtenerLiterales()
        {
            return INSTANCIA.LITERALES.Values.SelectMany(componente => componente).ToList();
        }
    }
}
