namespace ImportArchive
{
    partial class Form1
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.btnMTodos = new System.Windows.Forms.Button();
            this.btnDTodos = new System.Windows.Forms.Button();
            this.btnAumento = new System.Windows.Forms.Button();
            this.lblAumentar = new System.Windows.Forms.Label();
            this.TxtPorcentagem = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProdutos.Location = new System.Drawing.Point(20, 106);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(545, 265);
            this.dgvProdutos.StandardTab = true;
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Transparent;
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportar.Location = new System.Drawing.Point(20, 43);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(121, 57);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(16, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecao:";
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelecao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSelecao.Location = new System.Drawing.Point(100, 379);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(41, 21);
            this.lblSelecao.TabIndex = 4;
            this.lblSelecao.Text = "0,00";
            // 
            // btnMTodos
            // 
            this.btnMTodos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMTodos.Location = new System.Drawing.Point(455, 68);
            this.btnMTodos.Name = "btnMTodos";
            this.btnMTodos.Size = new System.Drawing.Size(110, 32);
            this.btnMTodos.TabIndex = 5;
            this.btnMTodos.Text = "Marcar Todos";
            this.btnMTodos.UseVisualStyleBackColor = true;
            this.btnMTodos.Click += new System.EventHandler(this.btnMTodos_Click);
            // 
            // btnDTodos
            // 
            this.btnDTodos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDTodos.Location = new System.Drawing.Point(455, 30);
            this.btnDTodos.Name = "btnDTodos";
            this.btnDTodos.Size = new System.Drawing.Size(110, 32);
            this.btnDTodos.TabIndex = 6;
            this.btnDTodos.Text = "Desmarcar Todos";
            this.btnDTodos.UseVisualStyleBackColor = true;
            this.btnDTodos.Click += new System.EventHandler(this.btnDTodos_Click);
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(401, 406);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(164, 41);
            this.btnAumento.TabIndex = 7;
            this.btnAumento.Text = "(%) Aumentar";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // lblAumentar
            // 
            this.lblAumentar.AutoSize = true;
            this.lblAumentar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumentar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAumentar.Location = new System.Drawing.Point(397, 379);
            this.lblAumentar.Name = "lblAumentar";
            this.lblAumentar.Size = new System.Drawing.Size(91, 21);
            this.lblAumentar.TabIndex = 9;
            this.lblAumentar.Text = "Aumentar:";
            // 
            // TxtPorcentagem
            // 
            this.TxtPorcentagem.Location = new System.Drawing.Point(494, 380);
            this.TxtPorcentagem.Name = "TxtPorcentagem";
            this.TxtPorcentagem.Size = new System.Drawing.Size(41, 20);
            this.TxtPorcentagem.TabIndex = 10;
            this.TxtPorcentagem.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(20, 406);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 41);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(541, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(585, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.TxtPorcentagem);
            this.Controls.Add(this.lblAumentar);
            this.Controls.Add(this.btnAumento);
            this.Controls.Add(this.btnDTodos);
            this.Controls.Add(this.btnMTodos);
            this.Controls.Add(this.lblSelecao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.Button btnMTodos;
        private System.Windows.Forms.Button btnDTodos;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.Label lblAumentar;
        private System.Windows.Forms.NumericUpDown TxtPorcentagem;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label2;
    }
}

