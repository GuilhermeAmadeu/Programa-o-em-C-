using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.OO
{
    public class Pedido
    {
        //private int codigo, clientecodigo;
        //private decimal valor;
        //private DateTime datahora;
        //private string observacoes;
        //public int GetCodigo()
        //{
        //    return codigo;
        //}
        //public void SetCodigo(int Codigo)
        //{
        //    this.codigo = Codigo;
        //}
        //public int GetClienteCodigo()
        //{
        //    return clientecodigo;
        //}
        //public void SetClienteCodigo(int clientecodigo)
        //{
        //    this.clientecodigo = clientecodigo;
        //}
        //public decimal GetValor()
        //{
        //    return valor;
        //}
        //public void SetValor(decimal Valor)
        //{
        //    this.valor = Valor;
        //}
        //public DateTime GetDataHora()
        //{
        //    return datahora;
        //}
        //public void SetDataHora(DateTime DataHora)
        //{
        //    this.datahora = DataHora;
        //}
        //public string GetObservacoes()
        //{
        //    return observacoes; 
        //}
        //public void SetObservacoes(string Observacoes)
        //{
        //    this.observacoes = Observacoes;
        //}
        //public Pedido(int codigo, int clientecodigo, decimal valor,DateTime datahora,string observacoes)
        //{
        //    this.codigo = codigo;
        //    this.clientecodigo = clientecodigo;
        //    this.valor = valor;
        //    this.datahora = datahora;
        //    this.observacoes = observacoes;
        //}

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int clientecodigo;

        public int ClienteCodigo
        {
            get { return clientecodigo; }
            set { clientecodigo = value; }
        }
        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private DateTime datahora;

        public DateTime DataHora
        {
            get { return datahora; }
            set { datahora = value; }
        }
        private string observacoes;

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }


    }
}
