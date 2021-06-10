using System;

namespace Trabalho
{
	public class Fornecedor:IImprimivel
	{
		private string _nome;
		private string _endereco;
		private string _email;
		private string _contato;

		public string Nome
        {

			get { return this._nome; }
        }

		public string Endereco
		{
			get { return this._endereco; }
		}
		public string Cnpj
		{
			get { return this._email; }
		}
		public string Contato
		{
			get { return this._contato; }
		}

		public Fornecedor (string nome, string endereco, string email, string contato)
        {
			this._nome = nome;
			this._endereco = endereco;
			this._email = email;
			this._contato = contato;
        }

		public void Imprimir()
        {
			Console.WriteLine("Fornecedor:\t{0}", this.Nome);
			Console.WriteLine("endereco:\t{0}", this.Endereco);
			Console.WriteLine("Email:\t{0}", this.Cnpj);
			Console.WriteLine("contato:\t{0}", this.Contato);
		}
	}
}