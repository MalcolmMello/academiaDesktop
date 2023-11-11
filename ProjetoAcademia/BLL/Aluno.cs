using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    internal class Aluno
    {
        private int codAluno;
        private string nome;
        private string cpf;
        private string email;
        private string telefone;

        public int CodAluno { get => codAluno; set => codAluno = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
