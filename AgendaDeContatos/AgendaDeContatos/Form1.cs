using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeContatos
{
    public partial class Form1 : Form
    {
        //intancia do controller
        private Contatos listaContatos;

        public Form1()
        {
            InitializeComponent();
            listaContatos = new Contatos();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparDadosTotal();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "" || textBoxEmail.Text == null)
            {
                MessageBox.Show("Email deve ser preenchido! ");
            }
            else
            {
                if(listaContatos.contatoExiste(textBoxEmail.Text))
                {
                    MessageBox.Show("Já existe um contato cadastrado com esse email! ");
                }
                else
                {
                    listaContatos.adicionarContato(textBoxEmail.Text, textBoxNome.Text, textBoxTelefone.Text);
                    MessageBox.Show("Contato adicionado com sucesso! ");
                    limparDadosParcial();
                }
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxEmail.Text == null)
            {
                MessageBox.Show("Email deve ser preenchido! ");
            }
            else
            {
                if (listaContatos.contatoExiste(textBoxEmail.Text) == false)
                {
                    MessageBox.Show("Não existe nenhum contato cadastrado com esse email! ");
                }
                else
                {
                    Contato contato = listaContatos.pesquisarContato(textBoxEmail.Text);
                    listBoxListaContatos.Items.Clear();
                    listBoxListaContatos.Items.Add(contato.dadosResumidos());
                }
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxEmail.Text == null)
            {
                MessageBox.Show("Email deve ser preenchido! ");
            }
            else
            {
                if(listaContatos.excluiContato(textBoxEmail.Text))
                {
                    MessageBox.Show("Contato excluído com sucesso! ");
                    limparDadosTotal();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir. Contato não encontrado. ");
                    limparDadosTotal();
                }
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            List<string> lista = listaContatos.dadosContatos();
            listBoxListaContatos.Items.Clear();

            if(lista.Count > 0)
            {
                foreach(string s in lista)
                {
                    listBoxListaContatos.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Não existe nenhum contato na lista! ");
            }
        }

        private void limparDadosParcial()
        {
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxTelefone.Text = "";
        }
        private void limparDadosTotal()
        {
            limparDadosParcial();
            listBoxListaContatos.Items.Clear();
        }
    }
}
