using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos
{
    class Contatos
    {
        //atributos
        private List<Contato> listaContatos;

        //Propriedades getter e setter
        public Contato getContato(string email)
        {
            Contato contato = null;

            foreach(Contato c in listaContatos)
            {
                if (c.getEmail() == email)
                {
                    contato = c;
                    break;
                }
                else contato = null;
            }
            return contato;
        }
        public void setContato(Contato contato)
        {
                this.listaContatos.Add(contato);
        }

        //Contrutores
        public Contatos()
        {
            listaContatos = new List<Contato>();
        }

        //métodos funcionais
        public List<string> dadosContatos()
        {
            List<string> lista = new List<string>();

            foreach(Contato c in listaContatos)
            {
                lista.Add(c.dadosResumidos());
            }
            return lista;
        }
        public bool contatoExiste(string email)
        {
            if (getContato(email) != null) return true;
            else return false;
        }
        public bool adicionarContato(string email, string nome, string telefone)
        {
            try
            {
                if (nome == "") nome = "Não informado";
                if (telefone == "") telefone = "Não informado";

                Contato contato = new Contato(email, nome, telefone);
                setContato(contato);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public Contato pesquisarContato(string email)
        {
            Contato contato = new Contato();

            foreach(Contato c in listaContatos)
            {
                if (c.getEmail() == email)
                {
                    contato = c;
                    break;
                }
                else contato = null;
            }
            return contato;
        }
        public bool excluiContato(string email)
        {
            bool concluido = false;

            foreach (Contato c in listaContatos)
            {
                if (c.getEmail() == email)
                {
                    listaContatos.Remove(c);
                    concluido = true;
                    break;
                }
                else concluido = false;
            }
            return concluido;
        }
    }
}
