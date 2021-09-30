
namespace Formulários.QWA
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtSobNome = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.Label();
            this.txtDtNasc = new System.Windows.Forms.Label();
            this.buttonAdicL = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSobreN = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCandidatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(19, 101);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(72, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome: ";
            // 
            // txtSobNome
            // 
            this.txtSobNome.AutoSize = true;
            this.txtSobNome.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobNome.Location = new System.Drawing.Point(19, 139);
            this.txtSobNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSobNome.Name = "txtSobNome";
            this.txtSobNome.Size = new System.Drawing.Size(112, 20);
            this.txtSobNome.TabIndex = 1;
            this.txtSobNome.Text = "Sobrenome:";
            this.txtSobNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.AutoSize = true;
            this.txtCPF.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(19, 183);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(59, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.Text = "CPF: ";
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.AutoSize = true;
            this.txtDtNasc.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtNasc.Location = new System.Drawing.Point(19, 219);
            this.txtDtNasc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(186, 20);
            this.txtDtNasc.TabIndex = 3;
            this.txtDtNasc.Text = "Data de Nascimento:";
            // 
            // buttonAdicL
            // 
            this.buttonAdicL.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicL.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicL.Location = new System.Drawing.Point(154, 323);
            this.buttonAdicL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicL.Name = "buttonAdicL";
            this.buttonAdicL.Size = new System.Drawing.Size(142, 40);
            this.buttonAdicL.TabIndex = 4;
            this.buttonAdicL.Text = "Adicionar a Lista";
            this.buttonAdicL.UseVisualStyleBackColor = true;
            this.buttonAdicL.Click += new System.EventHandler(this.buttonAdicL_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.Black;
            this.buttonSalvar.Location = new System.Drawing.Point(302, 323);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(145, 40);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(219, 98);
            this.textNome.Margin = new System.Windows.Forms.Padding(2);
            this.textNome.MaxLength = 100;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(291, 29);
            this.textNome.TabIndex = 6;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textSobreN
            // 
            this.textSobreN.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSobreN.Location = new System.Drawing.Point(219, 139);
            this.textSobreN.Margin = new System.Windows.Forms.Padding(2);
            this.textSobreN.MaxLength = 100;
            this.textSobreN.Name = "textSobreN";
            this.textSobreN.Size = new System.Drawing.Size(291, 29);
            this.textSobreN.TabIndex = 7;
            // 
            // textCpf
            // 
            this.textCpf.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCpf.Location = new System.Drawing.Point(219, 180);
            this.textCpf.Margin = new System.Windows.Forms.Padding(2);
            this.textCpf.MaxLength = 11;
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(291, 29);
            this.textCpf.TabIndex = 8;
            this.textCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCpf_KeyPress);
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textData.Location = new System.Drawing.Point(219, 219);
            this.textData.Margin = new System.Windows.Forms.Padding(2);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(128, 29);
            this.textData.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ficha de Cadastro";
            // 
            // gridCandidatos
            // 
            this.gridCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCandidatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridCandidatos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridCandidatos.Location = new System.Drawing.Point(539, 20);
            this.gridCandidatos.Name = "gridCandidatos";
            this.gridCandidatos.Size = new System.Drawing.Size(377, 388);
            this.gridCandidatos.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(928, 420);
            this.Controls.Add(this.gridCandidatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textSobreN);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAdicL);
            this.Controls.Add(this.txtDtNasc);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSobNome);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa XPTO";
            ((System.ComponentModel.ISupportInitialize)(this.gridCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtSobNome;
        private System.Windows.Forms.Label txtCPF;
        private System.Windows.Forms.Label txtDtNasc;
        private System.Windows.Forms.Button buttonAdicL;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSobreN;
        private System.Windows.Forms.TextBox textCpf;
        private System.Windows.Forms.DateTimePicker textData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCandidatos;
    }
}

