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
    public partial class frmAlunos : Form
    {
        BLL.Aluno alunos = new BLL.Aluno();
        DAL.AlunoDAL alunosDAL = new DAL.AlunoDAL();
        public frmAlunos()
        {
            InitializeComponent();
        }
        private void btnGravarAlunos_Click(object sender, EventArgs e)
        {
            alunos.Nome = txtNomeAluno.Text;
            alunos.Email = txtEmailAluno.Text;
            alunos.Cpf = txtCpfAluno.Text;
            alunos.Telefone = txtTelefoneAluno.Text;
            if (btnGravarAlunos.Text != "Atualizar")
            {
                alunosDAL.Cadastrar(alunos);
                MessageBox.Show("Aluno cadastrado com sucesso");
            }
            else
            {
                alunosDAL.Atualizar(alunos);
                MessageBox.Show("Aluno atualizado com sucesso");
            }
            cancelar();
            dgvConsultaAlunos.DataSource = alunosDAL.ConsultarTodos();
        }
        private void frmAlunos_Load(object sender, EventArgs e)
        {
            dgvConsultaAlunos.DataSource = alunosDAL.ConsultarTodos();
        }

        private void txtPesquisarAlunos_TextChanged(object sender, EventArgs e)
        {
            alunos.Nome = txtPesquisarAlunos.Text;
            dgvConsultaAlunos.DataSource = alunosDAL.PesquisarPorNome(alunos);
        }
        public void cancelar()
        {
            txtNomeAluno.Clear();
            txtEmailAluno.Clear();
            txtCpfAluno.Clear();
            txtTelefoneAluno.Clear();
            txtNomeAluno.Focus();
            btnGravarAlunos.Text = "Gravar";
        }
        private void btnLimparAluno_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            if (dgvConsultaAlunos.Rows.Count > 0)
            {
                alunos.CodAluno = Convert.ToInt16(dgvConsultaAlunos[0, dgvConsultaAlunos.CurrentRow.Index].Value);
                alunos = alunosDAL.Retornar(alunos);
                txtEmailAluno.Text = alunos.Email;
                txtNomeAluno.Text = alunos.Nome;
                txtCpfAluno.Text = alunos.Cpf;
                txtTelefoneAluno.Text = alunos.Telefone;
                btnGravarAlunos.Text = "Atualizar";
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                alunos.CodAluno = Convert.ToInt16(dgvConsultaAlunos[0, dgvConsultaAlunos.CurrentRow.Index].Value);
                alunosDAL.Excluir(alunos);
                dgvConsultaAlunos.DataSource = alunosDAL.ConsultarTodos();
            }
        }
    }
}
