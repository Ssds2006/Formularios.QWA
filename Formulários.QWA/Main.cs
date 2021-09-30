using Formulários.QWA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulários.QWA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        List<Candidato> lstcandidato = new List<Candidato>();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            gridCandidatos.DataSource = null;
            gridCandidatos.DataSource = lstcandidato;
        }

        private void buttonAdicL_Click(object sender, EventArgs e)
        {
            string Retorno = ValidaDados();

            if (Retorno == "")
            {
                if (lstcandidato.Count < 10)
                {
                    Candidato candidato = new Candidato(
                                                        textNome.Text,
                                                        textSobreN.Text,
                                                        textCpf.Text,
                                                        textData.Text
                                                        );

                    if (lstcandidato.Where(x => x.CPF == candidato.CPF).Any())
                    {
                        MessageBox.Show("CPF existente na lista!!, Candidato ja foi adicionado anteriormente");
                    }
                    else
                    {
                        lstcandidato.Add(candidato);
                        MessageBox.Show("Candidado adiconado na lista com Sucesso!!!");
                        LimpaCampos();
                    }

                }
                else
                {
                    MessageBox.Show("Não é Possivel inserir nenhum usuario na lista, limite de 10 candidatos alcançado!!!");
                    LimpaCampos();
                }
                //criar logica para inserir candidato a lista

            }
            else
            {
                MessageBox.Show(Retorno);
            }
        }

        private void textCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private string ValidaDados()
        {
            string Mensagem = "";

            if(textNome.Text == "")
            {
                Mensagem = "\nCampo Nome esta em branco, por gentileza preencha o campo corretamente\n";
            }

            if (textSobreN.Text == "")
            {
                Mensagem = Mensagem + "\nCampo Sobrenome está em branco, por gentileza preencha o campo corretamente\n";
            }
            
            if(textCpf.Text == "")
            {
                Mensagem = Mensagem + "\nCampo CPF está em branco, por gentileza preencha o campo corretamento";
            }
            else if (textCpf.Text.Length < 11)
            {
                Mensagem = Mensagem + "\nValor digitado no campo CPF é inválido, por gentileza preencha o campo corretamento";
            }


            return Mensagem;
        }

        private void LimpaCampos()
        {
            textNome.Text = "";
            textSobreN.Text = "";
            textCpf.Text = "";
            textData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
