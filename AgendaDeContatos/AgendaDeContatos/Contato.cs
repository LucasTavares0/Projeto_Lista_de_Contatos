using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos
{
    class Contato
    {
        //atributos
        private string email;
        private string nome;
        private string telefone;

        //propriedades 
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getTelefone()
        {
            return this.telefone;
        }

        //Contrutores
        public Contato()
        {
            setEmail("");
            setNome("");
            setTelefone("");
        }
        public Contato(string email, string nome, string telefone)
        {
            setEmail(email);
            setNome(nome);
            setTelefone(telefone);
        }

        //métodos funcionais
        public String dadosResumidos()
        {
            StringBuilder dados = new StringBuilder();
            dados.Append("Email: " + getEmail() + " - ");
            dados.Append("Nome: " + getNome() + " - ");
            dados.Append("Telefone: " + getTelefone());
            return dados.ToString();
        }
    }
}
