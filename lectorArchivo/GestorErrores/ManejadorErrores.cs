using System;
using System.Collections.Generic;
using System.Text;

namespace lectorArchivo.GestorErrores
{
	public class ManejadorErrores
	{
		private Dictionary<TipoError, List<Error>> ERRORES = new Dictionary<TipoError, List<Error>>();
		private static ManejadorErrores INSTANCIA = new ManejadorErrores();

		private ManejadorErrores()
		{
			ERRORES.Add(TipoError.LEXICO, new List<Error>());
			ERRORES.Add(TipoError.SINTACTICO, new List<Error>());
			ERRORES.Add(TipoError.SEMANTICO, new List<Error>());

		}

		public static void Limpiar()
		{
			INSTANCIA.ERRORES[TipoError.LEXICO].Clear();
			INSTANCIA.ERRORES[TipoError.SINTACTICO].Clear();
			INSTANCIA.ERRORES[TipoError.SEMANTICO].Clear();
		}

		public static List<Error> ObtenerErrores(TipoError Tipo)
		{
			return INSTANCIA.ERRORES[Tipo];
		}
		public static void Reportar(Error Error)
		{
			if (Error != null)
			{
				ObtenerErrores(Error.ObtenerTipo()).Add(Error);
			}
		}

		public static bool HayErrores(TipoError Tipo)
		{
			return ObtenerErrores(Tipo).Count > 0;
		}
		public static bool HayErroresLexicos()
		{
			return HayErrores(TipoError.LEXICO);
		}
		public static bool HayErroresSintancticos()
		{
			return HayErrores(TipoError.SINTACTICO);
		}
		public static bool HayErroresSemanticos()
		{
			return HayErrores(TipoError.SEMANTICO);
		}
		public static bool HayErrores()
		{
			return HayErroresLexicos() || HayErroresSemanticos() || HayErroresSintancticos();
		}
		public static List<Error> ObtenerErroresLexicos()
		{
			List<Error> ListaRetorno = new List<Error>();
			ListaRetorno.AddRange(ObtenerErrores(TipoError.LEXICO));

			return ListaRetorno;

			//INSTANCIA.ERRORES.Values.SelectMany(error => error).ToList();
		}
		public static List<Error> ObtenerErroresSintatacticos()
		{
			List<Error> ListaRetorno = new List<Error>();
			ListaRetorno.AddRange(ObtenerErrores(TipoError.SINTACTICO));
			return ListaRetorno;

			//INSTANCIA.ERRORES.Values.SelectMany(error => error).ToList();
		}
		public static List<Error> ObtenerErroresSemanticos()
		{
			List<Error> ListaRetorno = new List<Error>();
			ListaRetorno.AddRange(ObtenerErrores(TipoError.SEMANTICO));

			return ListaRetorno;

			//INSTANCIA.ERRORES.Values.SelectMany(error => error).ToList();
		}
	}
}
