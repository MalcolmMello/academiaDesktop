using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.UI
{
    public partial class frmUsuarios : Form
    {
        BLL.Usuario usu = new BLL.Usuario();
        DAL.UsuarioDAL usuDAL = new DAL.UsuarioDAL();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            usu.Nome = txtNome.Text;
            usu.Email = txtEmail.Text;
            usu.Senha = txtSenha.Text;
            if(btnGravar.Text != "Atualizar")
            {
                usuDAL.Cadastrar(usu);
            }
            else
            {
                usuDAL.Atualizar(usu);
            }
            cancelar();
            MessageBox.Show("Usuário cadastrado com sucesso");
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        public void cancelar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtNome.Focus();
            btnGravar.Text = "Gravar";
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            usu.Nome = txtPesquisar.Text;
            dgvConsulta.DataSource = usuDAL.PesquisarPorNome(usu);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usu.Codusuario = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                usuDAL.Excluir(usu);
                dgvConsulta.DataSource = usuDAL.ConsultarTodos();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(dgvConsulta.Rows.Count > 0)
            {
                usu.Codusuario = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                usu = usuDAL.Retornar(usu);
                txtEmail.Text = usu.Email;
                txtNome.Text = usu.Nome;
                txtSenha.Text = usu.Senha;
                btnGravar.Text = "Atualizar";
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cancelar();
        }
    }
}
