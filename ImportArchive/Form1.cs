using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImportArchive
{
    public partial class Form1 : Form
    {
        double selecao = 0;
        double valorcompra = 0;
        double valorvenda = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProdutos.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgvProdutos.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgvProdutos.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgvProdutos.Columns.Insert(3, new DataGridViewTextBoxColumn());
            dgvProdutos.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgvProdutos.Columns.Insert(5, new DataGridViewTextBoxColumn());
            dgvProdutos.Columns.Insert(6, new DataGridViewTextBoxColumn());

            dgvProdutos.Columns[0].Name = "OK";
            dgvProdutos.Columns[1].Name = "ID";
            dgvProdutos.Columns[2].Name = "EAN";
            dgvProdutos.Columns[3].Name = "PRODUTO";
            dgvProdutos.Columns[4].Name = "VALOR COMPRA";
            dgvProdutos.Columns[5].Name = "VALOR VENDA";
            dgvProdutos.Columns[6].Name = "ESTOQUE";

            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProdutos.ReadOnly = true;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToOrderColumns = true;

            dgvProdutos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProdutos.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";

            dgvProdutos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProdutos.Columns[5].DefaultCellStyle.Format = "###,###,##0.00";
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            try
            {
                StreamReader arquivo = File.OpenText(ofdArquivo.FileName);
                String linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    string[] dados = linha.Split(';');
                    string id = dados[0].Replace(" ", "");
                    string ean = dados[1].Replace(" ", "");
                    string produto = dados[2].Replace(" ", "");
                    try
                    {
                        valorcompra = Convert.ToDouble(dados[3]);
                        valorvenda = Convert.ToDouble(dados[4]);
                    }
                    catch
                    {
                        valorcompra = 0;
                        valorvenda = 0;
                    }
                    string estoque = dados[5].Replace(" ", "");
                    dgvProdutos.Rows.Add(false, id, ean, produto, valorcompra, valorvenda, estoque);
                }
                foreach (DataGridViewRow dgvlinha in dgvProdutos.Rows)
                {
                    if (Convert.ToDouble(dgvlinha.Cells[5].Value) < Convert.ToDouble(dgvlinha.Cells[4].Value))
                    {
                        dgvlinha.Cells[5].Style.BackColor = Color.Red;
                        dgvlinha.Cells[5].Style.ForeColor = Color.White;
                    }
                }
            } catch
            {
                MessageBox.Show("Tente outro arquivo!", "ERRO");
            }
        }

    private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvProdutos.CurrentRow.Cells[0].Value) == false)
                {
                    dgvProdutos.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgvProdutos.CurrentRow.Cells[4].Value);
                }
                else
                {
                    dgvProdutos.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dgvProdutos.CurrentRow.Cells[4].Value);
                }
                lblSelecao.Text = selecao.ToString("C");
            }
        }

        private void btnMTodos_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dgvProdutos.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[5].Value);
            }
            lblSelecao.Text = selecao.ToString("C");
        }

        private void btnDTodos_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach(DataGridViewRow linha in dgvProdutos.Rows)
            {
                linha.Cells[0].Value = false;
            }
            lblSelecao.Text = selecao.ToString("C");
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dgvProdutos.Rows)
            {
                if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                {
                    double valor = Convert.ToDouble(linha.Cells[5].Value);
                    linha.Cells[5].Value = valor + valor * Convert.ToDouble(TxtPorcentagem.Text)/100;
                }
                if (Convert.ToDouble(linha.Cells[5].Value) > Convert.ToDouble(linha.Cells[4].Value))
                {
                    linha.Cells[5].Style.BackColor = Color.Empty;
                    linha.Cells[5].Style.ForeColor = Color.Black;
                } else
                {
                    linha.Cells[5].Style.BackColor = Color.Red;
                    linha.Cells[5].Style.ForeColor = Color.White;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dgvProdutos.Rows)
            {
                if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                {
                    dgvProdutos.Rows.RemoveAt(linha.Index);
                }
            }
        }
    }   
}
