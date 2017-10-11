using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.OO
{
    class Cliente
    {

        //public int GetCodigo()
        //{
        //    return codigo;  
        //}
        //public void SetCodigo(int Codigo)
        //{
        //    this.codigo = Codigo;           
        //}
        //public string GetNome()
        //{
        //    return nome;    
        //}
        //public void SetNome(string Nome)
        //{
        //    this.nome = Nome;
        //}
        //public string GetEmail()
        //{
        //    return email;
        //}
        //public void SetEmail(string Email)
        //{
        //    this.email = Email;
        //}
        //public string GetCidade()
        //{
        //    return cidade;
        //}
        //public void SetCidade(string Cidade)
        //{
        //    this.cidade = Cidade;
        //}
        //public string GetUF()
        //{
        //    return uf;
        //}
        //public void SetUF(string UF)
        //{
        //    this.uf = UF;
        //}
        //public Cliente (int codigo,string nome,string email,string cidade ,string uf)
        //{
        //    this.codigo = codigo;
        //    this.nome = nome;
        //    this.email = email;
        //    this.cidade = cidade;
        //    this.uf = uf;
        //}

        //private string nome,email,cidade,uf;
        //private int codigo;
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string uf;

        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }


    }
}
