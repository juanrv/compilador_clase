using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using lectorArchivo.Transversal;

namespace lectorArchivo.GestorErrores
{
	public class Error
	{
		private String Lexema;
		private Categoria categoria;
		private int NumeroLinea;
		private int posicionInicial;
		private int posicionFinal;
		private String Falla;
		private String Causa;
		private String Solucion;
		private TipoError Tipo;

		private Error(String Lexedema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal, String Falla, String Causa, String Solucion
		   , TipoError Tipo)
		{
			this.Falla = Falla;
			this.Causa = Causa;
			this.Solucion = Solucion;
			this.Tipo = Tipo;
			this.Lexema = Lexedema;
			this.categoria = categoria;
			this.NumeroLinea = numeroLinea;
			this.posicionFinal = posicionFinal;
			this.posicionInicial = posicionInicial;
		}

		public static Error CrearErrorLexico(String Lexedema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal, String Falla, String Causa, String Solucion)
		{
			return new Error(Lexedema, categoria, numeroLinea, posicionInicial, posicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
		}
		public static Error CrearErrorSemantico(String Lexedema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal, String Falla, String Causa, String Solucion)
		{
			return new Error(Lexedema, categoria, numeroLinea, posicionInicial, posicionFinal, Falla, Causa, Solucion, TipoError.SEMANTICO);
		}
		public static Error CrearErrorSintactico(String Lexedema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal, String Falla, String Causa, String Solucion)
		{
			return new Error(Lexedema, categoria, numeroLinea, posicionInicial, posicionFinal, Falla, Causa, Solucion, TipoError.SINTACTICO);
		}


		public String ObtenerLexema()
		{
			return Lexema;
		}
		public Categoria ObtenerCategoria()
		{
			return categoria;
		}
		public int ObtenerNumeroLinea()
		{
			return NumeroLinea;
		}
		public int ObtenerPosicionFinal()
		{
			return posicionFinal;
		}
		public int ObetenerPosicionInicial()
		{
			return posicionInicial;
		}
		public String ObtenerFalla()
		{
			return Falla;
		}
		public String ObtenerCausa()
		{
			return Causa;
		}
		public String ObtenerSolucion()
		{
			return Solucion;
		}
		public TipoError ObtenerTipo()
		{
			return Tipo;
		}
		
	}
}
