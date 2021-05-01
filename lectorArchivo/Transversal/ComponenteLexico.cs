using System;
using System.Collections.Generic;
using System.Text;

namespace lectorArchivo.Transversal
{
	public class ComponenteLexico
	{
		private String Lexema;
		private Categoria categoria;
		private int NumeroLinea;
		private int posicionInicial;
		private int posicionFinal;
		private TipoComponente Tipo;


		private ComponenteLexico(String Lexedema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal, TipoComponente Componente)
		{
			this.Lexema = Lexedema;
			this.categoria = categoria;
			this.NumeroLinea = numeroLinea;
			this.posicionFinal = posicionFinal;
			this.posicionInicial = posicionInicial;
			this.Tipo = Componente;
		}

		public static ComponenteLexico CrearComponenteLiteral(String Lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
		{
			return new ComponenteLexico(Lexema, categoria, numeroLinea, posicionInicial, posicionFinal, TipoComponente.LITERAL);
		}
		public static ComponenteLexico CrearComponenteSimbolo(String Lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
		{
			return new ComponenteLexico(Lexema, categoria, numeroLinea, posicionInicial, posicionFinal, TipoComponente.SIMBOLO);
		}
		public static ComponenteLexico CrearComponenteDummy(String Lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
		{
			return new ComponenteLexico(Lexema, categoria, numeroLinea, posicionInicial, posicionFinal, TipoComponente.DUMMY);
		}
		public static ComponenteLexico CrearComponentePalabraReservada(String Lexema, Categoria categoria)
		{
			return new ComponenteLexico(Lexema, categoria, 0, 0, 0, TipoComponente.PALABRA_RESERVADA);
		}
		public static ComponenteLexico CrearComponentePalabraReservada(String Lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
		{
			return new ComponenteLexico(Lexema, categoria, numeroLinea, posicionInicial, posicionFinal, TipoComponente.PALABRA_RESERVADA);
		}

		public TipoComponente ObtenerTipo()
		{
			return Tipo;
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
		public override string ToString()
		{
			StringBuilder informacion = new StringBuilder();
			informacion.Append("Categoria: ").Append(ObtenerCategoria()).Append(" ");
			informacion.Append("Lexema: ").Append(ObtenerLexema()).Append(" ");
			informacion.Append("Numero de Linea: ").Append(ObtenerNumeroLinea()).Append(" ");
			informacion.Append("Posicion Inicial de la linea: ").Append(ObetenerPosicionInicial()).Append(" ");
			informacion.Append("Posicion final de la linea: ").Append(ObtenerPosicionFinal()).Append(" ");



			return informacion.ToString();
		}
	}
}
