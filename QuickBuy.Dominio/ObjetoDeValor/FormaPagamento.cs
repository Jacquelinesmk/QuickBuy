using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
	public class FormaPagamento
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }

		public bool isBoleto
		{
			get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
		}

		public bool isCartaoCredito
		{
			get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
		}

		public bool isDeposito
		{
			get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
		}

		public bool isNaoDefinido
		{
			get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
		}
	}
}
