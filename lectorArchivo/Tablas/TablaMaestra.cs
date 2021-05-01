using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using System.Linq;

namespace lectorArchivo.Tablas
{
    public class TablaMaestra
    {
        private TablaMaestra()
        {

        }
        public static ComponenteLexico SincronizarTabla(ComponenteLexico Componente)
        {
            if (Componente != null)
            {
                Componente = TablaPalabraReservadas.ComprobarPalabraReservada(Componente);

                switch (Componente.ObtenerTipo())
                {
                    case TipoComponente.DUMMY:
                        TablaDummys.Agregar(Componente);
                        break;
                    case TipoComponente.PALABRA_RESERVADA:
                        TablaPalabraReservadas.Agregar(Componente);
                        break;
                    case TipoComponente.LITERAL:
                        TablaLiterales.Agregar(Componente);
                        break;
                    case TipoComponente.SIMBOLO:
                        TablaSimbolos.Agregar(Componente);
                        break;

                }
            }
            return Componente;
        }

        public static void Limpiar()
        {
            TablaDummys.Limpiar();
            TablaPalabraReservadas.Limpiar();
            TablaLiterales.Limpiar();
            TablaSimbolos.Limpiar();
        }
    }

}
