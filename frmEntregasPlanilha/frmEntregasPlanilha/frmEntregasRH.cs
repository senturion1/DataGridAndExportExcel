using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Reflection;

namespace frmEntregasPlanilha
{
    public partial class frmEntregasRH : Form
    {

        clsBancodeDados.clsBancoDados clsBanco = new clsBancodeDados.clsBancoDados();
        DataSet ds = new DataSet();
        string data;
        public frmEntregasRH()
        {
            InitializeComponent();

            dtEntregas.CustomFormat = dtEntregas.Value.ToString("MMM/yyyy").ToUpper();
            PlanilhaEntregas();

        }

        private void btnImporta_Click(object sender, EventArgs e)
        {

            StringBuilder cmd = new StringBuilder();
            string data = dtEntregas.Value.ToString("MMM/yyyy").ToUpper();

            try
            {
                cmd.Append("  SELECT RH.MES_ANO, ");
                cmd.Append("        RH.SETOR, ");
                cmd.Append("        RH.REGISTRO, ");
                cmd.Append("        RH.NOME, ");
                cmd.Append("        RH.TIPO, ");
                cmd.Append("        RH.DATA_CESTA_AMARELA, ");
                cmd.Append("        RH.DATA_CESTA_BRANCA, ");
                cmd.Append("        RH.DATA_ENTREGA ");
                cmd.Append("   FROM japiaux.RH_ENTREGA_CESTA RH ");
                cmd.Append("  WHERE RH.MES_ANO = '" + data + "'");
                ds = clsBanco.CarregaDataSet(2, cmd.ToString(), "CESTA");

                dgvEntregas.DataSource = ds.Tables["CESTA"];

                dgvEntregas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void PlanilhaEntregas()

        {
            StringBuilder cmd = new StringBuilder();
            data = dtEntregas.Value.ToString("MMM/yyyy").ToUpper();

            try
            {
                cmd.Append("  SELECT RH.MES_ANO, ");
                cmd.Append("        RH.SETOR, ");
                cmd.Append("        RH.REGISTRO, ");
                cmd.Append("        RH.NOME, ");
                cmd.Append("        RH.TIPO, ");
                cmd.Append("        RH.DATA_CESTA_AMARELA, ");
                cmd.Append("        RH.DATA_CESTA_BRANCA, ");
                cmd.Append("        RH.DATA_ENTREGA ");
                cmd.Append("   FROM japiaux.RH_ENTREGA_CESTA RH ");
                cmd.Append("  WHERE RH.MES_ANO = '" + data + "'");
                ds = clsBanco.CarregaDataSet(2, cmd.ToString(), "CESTA");

                dgvEntregas.DataSource = ds.Tables["CESTA"];

                dgvEntregas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dtEntregas_ValueChanged(object sender, EventArgs e)
        {
            dtEntregas.CustomFormat = dtEntregas.Value.ToString("MMM/yyyy").ToUpper();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            PlanilhaEntregas();

            string Cesta = "";
            string Setor = "";
            string Nome = "";



            if (cbxCesta.SelectedItem != null)
            {
                Cesta = cbxCesta.SelectedItem.ToString();
            }
            if (cbxSetor.SelectedItem != null)
            {
                Setor = cbxSetor.SelectedItem.ToString();
            }
            if (txtNome.Text != null)
            {
                Nome = txtNome.Text;
            }

            string CodeCesta = dgvEntregas.Columns[4].HeaderText.ToString() + " = '" + Cesta + "' AND ";
            string CodeSetor = dgvEntregas.Columns[1].HeaderText.ToString() + " = '" + Setor + "' AND ";
            string CodeNome = dgvEntregas.Columns[3].HeaderText.ToString() + " LIKE '%" + Nome + "%' ";




            if (!string.IsNullOrEmpty(Cesta))
            {

                if (!string.IsNullOrEmpty(Setor) && !string.IsNullOrEmpty(Cesta))
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvEntregas.DataSource;
                    bs.Filter = CodeSetor + CodeCesta + CodeNome;
                    dgvEntregas.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvEntregas.DataSource;
                    bs.Filter = CodeCesta + CodeNome;
                    dgvEntregas.DataSource = bs;
                }



            }
            else if (!string.IsNullOrEmpty(Setor))
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvEntregas.DataSource;
                bs.Filter = CodeSetor + CodeNome;
                dgvEntregas.DataSource = bs;
            }
            else if (!string.IsNullOrEmpty(Nome))
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvEntregas.DataSource;
                bs.Filter = CodeNome;
                dgvEntregas.DataSource = bs;
            }
            if (string.IsNullOrEmpty(Cesta) && string.IsNullOrEmpty(Setor) && string.IsNullOrEmpty(Nome))
            {
                PlanilhaEntregas();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbxCesta.SelectedItem = null;
            cbxCesta.Text = "TIPO";
            cbxSetor.SelectedItem = null;
            cbxSetor.Text = "SETORES";
            txtNome.Text = null;
        }

        private void btnExporta_Click(object sender, EventArgs e)
        {
            
            PlanilhaEntregas();
            double porc = 0;
            SaveFileDialog vs_salvar = new SaveFileDialog();

            

            try
            {
                vs_salvar.Title = "Salvar Como";
                vs_salvar.Filter = "Pasta de trabalho do Excel (.xlsx)|xlsx";
                vs_salvar.DefaultExt = "xlsx";

                if (vs_salvar.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    //txtArquivoSalvar.Text = vs_salvar.FileName;
                    return;
                }

                this.Cursor = Cursors.WaitCursor;

                //Create an Excel application instance
                excel.Application excelApp = new excel.Application();
                excel.Workbook excelWorkBook = excelApp.Workbooks.Add(excel.XlWBATemplate.xlWBATWorksheet);
                excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = "Entregas"; //table.TableName;

                if (dgvEntregas.Rows.Count > 0)
                {

                    for (int i = 1; i < dgvEntregas.Columns.Count + 1; i++)
                    {
                        excelWorkSheet.Cells[1, i] = dgvEntregas.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvEntregas.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvEntregas.Columns.Count; j++)
                        {
                            excelWorkSheet.Cells[i + 2, j + 1] = dgvEntregas.Rows[i].Cells[j].Value;
                        }

                    }
                }
                //excel.Workbook excelWorkBook1 = excelApp.Workbooks.Add(excel.XlWBATemplate.xlWBATWorksheet);
                //excel.Worksheet excelWorkSheet1 = excelWorkBook.Sheets.Add();
                excelWorkBook.SaveAs(vs_salvar.FileName, excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value, Missing.Value, false, false, excel.XlSaveAsAccessMode.xlNoChange, excel.XlSaveConflictResolution.xlUserResolution, true, Missing.Value, Missing.Value, Missing.Value);
                excelWorkBook.Close();
                excelApp.Quit();

                this.Cursor = Cursors.Default;

                MessageBox.Show("Arquivo criado!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
