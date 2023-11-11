namespace ProjetoAcademia.UI
{
    partial class frmAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGravarAlunos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAluno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPesquisarAlunos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvConsultaAlunos = new System.Windows.Forms.DataGridView();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnLimparAluno = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimparAluno);
            this.tabPage1.Controls.Add(this.btnGravarAlunos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCpfAluno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmailAluno);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTelefoneAluno);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNomeAluno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGravarAlunos
            // 
            this.btnGravarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarAlunos.ForeColor = System.Drawing.Color.Black;
            this.btnGravarAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarAlunos.Location = new System.Drawing.Point(16, 291);
            this.btnGravarAlunos.Name = "btnGravarAlunos";
            this.btnGravarAlunos.Size = new System.Drawing.Size(109, 33);
            this.btnGravarAlunos.TabIndex = 8;
            this.btnGravarAlunos.Text = "Gravar";
            this.btnGravarAlunos.UseVisualStyleBackColor = true;
            this.btnGravarAlunos.Click += new System.EventHandler(this.btnGravarAlunos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cpf:";
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfAluno.Location = new System.Drawing.Point(16, 233);
            this.txtCpfAluno.Mask = "000.000.000-00";
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(203, 33);
            this.txtCpfAluno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAluno.Location = new System.Drawing.Point(16, 99);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(203, 33);
            this.txtEmailAluno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone:";
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneAluno.Location = new System.Drawing.Point(19, 169);
            this.txtTelefoneAluno.Mask = "(00)00000-0000";
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(203, 33);
            this.txtTelefoneAluno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(19, 35);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(203, 33);
            this.txtNomeAluno.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluirAluno);
            this.tabPage2.Controls.Add(this.btnAtualizarAluno);
            this.tabPage2.Controls.Add(this.txtPesquisarAlunos);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvConsultaAlunos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPesquisarAlunos
            // 
            this.txtPesquisarAlunos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarAlunos.Location = new System.Drawing.Point(3, 33);
            this.txtPesquisarAlunos.Name = "txtPesquisarAlunos";
            this.txtPesquisarAlunos.Size = new System.Drawing.Size(396, 29);
            this.txtPesquisarAlunos.TabIndex = 5;
            this.txtPesquisarAlunos.TextChanged += new System.EventHandler(this.txtPesquisarAlunos_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pesquisar";
            // 
            // dgvConsultaAlunos
            // 
            this.dgvConsultaAlunos.AllowUserToAddRows = false;
            this.dgvConsultaAlunos.AllowUserToDeleteRows = false;
            this.dgvConsultaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAlunos.Location = new System.Drawing.Point(4, 68);
            this.dgvConsultaAlunos.Name = "dgvConsultaAlunos";
            this.dgvConsultaAlunos.ReadOnly = true;
            this.dgvConsultaAlunos.Size = new System.Drawing.Size(779, 351);
            this.dgvConsultaAlunos.TabIndex = 0;
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Location = new System.Drawing.Point(460, 33);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(83, 29);
            this.btnAtualizarAluno.TabIndex = 6;
            this.btnAtualizarAluno.Text = "Atualizar";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(573, 33);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(83, 29);
            this.btnExcluirAluno.TabIndex = 7;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnLimparAluno
            // 
            this.btnLimparAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAluno.ForeColor = System.Drawing.Color.Black;
            this.btnLimparAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparAluno.Location = new System.Drawing.Point(156, 291);
            this.btnLimparAluno.Name = "btnLimparAluno";
            this.btnLimparAluno.Size = new System.Drawing.Size(109, 33);
            this.btnLimparAluno.TabIndex = 9;
            this.btnLimparAluno.Text = "Novo";
            this.btnLimparAluno.UseVisualStyleBackColor = true;
            this.btnLimparAluno.Click += new System.EventHandler(this.btnLimparAluno_Click);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAlunos";
            this.Text = "frmAlunos";
            this.Load += new System.EventHandler(this.frmAlunos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCpfAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtEmailAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefoneAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNomeAluno;
        private System.Windows.Forms.Button btnGravarAlunos;
        private System.Windows.Forms.DataGridView dgvConsultaAlunos;
        private System.Windows.Forms.TextBox txtPesquisarAlunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnAtualizarAluno;
        private System.Windows.Forms.Button btnLimparAluno;
    }
}