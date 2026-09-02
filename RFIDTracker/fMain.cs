using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RFIDTracker
{
    public partial class fMain : DevExpress.XtraBars.TabForm
    {
        static Db db = null;

        int movimentacaoRecCount = 0;

        public fMain()
        {
            db = new Db();
            InitializeComponent();
        }

        string produto = string.Empty; string deposito = string.Empty; string item = string.Empty;

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            fMain form = new fMain();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;


        private void fMain_Shown(object sender, EventArgs e)
        {
            //pgInventarioDados.Text = "Leituras" + Environment.NewLine + "Inventário";
            try
            {
                perfilTableAdapter1.Connection = Db.dbConnection;
                usuarioTableAdapter1.Connection = Db.dbConnection; 
                produtoTableAdapter1.Connection = Db.dbConnection;
                itemTableAdapter1.Connection = Db.dbConnection;
                prateleiraTableAdapter1.Connection = Db.dbConnection;
                movimentacaoTableAdapter1.Connection = Db.dbConnection;
                vw_itemprodutoTableAdapter.Connection = Db.dbConnection;
                inventarioTableAdapter.Connection = Db.dbConnection;
                depositoTableAdapter.Connection = Db.dbConnection;

                vw_resultado_inventarioTableAdapter.Connection = Db.dbConnection;
                vw_inventario_okTableAdapter.Connection = Db.dbConnection;

                perfilTableAdapter1.Fill(dataSet11.perfil);
                usuarioTableAdapter1.Fill(dataSet12.usuario);
                produtoTableAdapter1.Fill(dataSet13.produto);
                itemTableAdapter1.Fill(dataSet14.item);
                prateleiraTableAdapter1.Fill(dataSet15.prateleira);
                movimentacaoTableAdapter1.Fill(dataSet17.movimentacao);
                vw_itemprodutoTableAdapter.Fill(dataSet13.vw_itemproduto);
                vw_resultado_inventarioTableAdapter.Fill(dataSet13.vw_resultado_inventario);
                depositoTableAdapter.Fill(dataSet13.deposito);
                vw_inventario_okTableAdapter.Fill(this.dataSet13.vw_inventario_ok);

                movimentacaoRecCount = Convert.ToInt32(db.getValue("select count(1) from movimentacao"));
                edInventario_time_stamp.Mask.EditMask = "G";
                edInventario_time_stamp.Mask.UseMaskAsDisplayFormat = true;
                lkDepositoResultado.EditValue = 
                    Convert.ToInt32(db.getValue("select min(id) from deposito"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro conectando: Mensagem: {0}", ex.Message));
                    throw ex;
            }
            tfInventario.SelectedPage = pgProduto;
            bool isAdm = (int)(fPwd.usuario["administrador"]) == 1;
            pgUsuario.Visible = isAdm;
            pgPerfil.Visible = isAdm;
        }

        private void gvPerfil_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            /*
            if (((System.Data.DataRowView)e.Row).Row.Table.TableName =="movimentacao")
            {
                DateTime timestamp_movimentacao = (DateTime)((System.Data.DataRowView)e.Row)["timestamp_movimentacao"];
                
                ((System.Data.DataRowView)e.Row)["timestamp_movimentacao"] = DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture); 
                db.UpdateTable((System.Data.DataRowView)e.Row);
                db.execSQL(string.Format("UPDATE movimentacao set timestamp_movimentacao = '{0}' where id = {1}",
                    timestamp_movimentacao.ToString("MM-dd-yyyy HH:mm:ss"), ((System.Data.DataRowView)e.Row)["id"]));
                ((System.Data.DataRowView)e.Row)["timestamp_movimentacao"] = timestamp_movimentacao;
            }
            else*/
                db.UpdateTable((System.Data.DataRowView)e.Row);
        }

        private void gvPerfil_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            db.UpdateTable((System.Data.DataRowView)e.Row, true);
        }

        private void gvUsuario_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            string providedPwd = (string)((System.Data.DataRowView)e.Row)["senha"];
            string errorMessage = utils.PasswordMessage(utils.CheckStrength(providedPwd));
            if (errorMessage != string.Empty)
            {
                MessageBox.Show(errorMessage);
                return;
            }
            string pwd = SecurePasswordHasher.Hash(providedPwd);

            ((System.Data.DataRowView)e.Row)["senha"] = pwd;
            ((System.Data.DataRowView)e.Row)["alterar_senha"] = 1;
            db.UpdateTable((System.Data.DataRowView)e.Row);
        }

        private void formControl_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
            if (e.Page.Name == "pgMovimentacao")
                movimentacaoTableAdapter1.Fill(dataSet17.movimentacao);
            //else if (e.Page.Name == "pgInventarioDados")
            //    lkInventarioGrupoLeituras.ItemIndex = 0;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            
        }

        private void lkInventarioGrupo_EditValueChanged(object sender, EventArgs e)
        {
            //gvDadosInventario.ActiveFilterString = string.Format("[idinventario_grupo] = {0}", lkInventarioGrupoLeituras.EditValue);
        }

        private void lkInvenarioGrupoResultados_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkInventarioGrupoLeituras_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void lkEditResutadoInventario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            return;
            int atualMovimentacao = Convert.ToInt32(db.getValue("select count(1) from movimentacao"));
            if (atualMovimentacao != movimentacaoRecCount)
            {
                List<Dictionary<string, object>> movimentacao = (List<Dictionary<string, object>>)db.getRows(
                    @"select p.partnumber as produto,d.nome as deposito,i.tag_id as item from movimentacao m 
                    inner join item i
                    on m.iditem = i.id 
                    inner join produto p 
                    on i.idproduto = p.id 
                    inner join deposito d
                    on i.iddeposito = d.id 
                    left join usuario u
                    on m.idusuario = i.id
                    order by m.timestamp_movimentacao desc
                    limit 1");
                string mensagem = atualMovimentacao > movimentacaoRecCount + 1 ? "Outros ítens foram movimentados" : string.Empty;
                movimentacaoRecCount = atualMovimentacao;
                fAlertaMovimentacao fAlerta = new fAlertaMovimentacao();
                fAlerta.ShowAlert((string)movimentacao[0]["produto"],
                                  (string)movimentacao[0]["deposito"],
                                  Convert.ToString(movimentacao[0]["item"]),
                                  mensagem);

            }

        }

        private void b2Excel_Click(object sender, EventArgs e)
        {
            save2Excel.FileName = string.Format("RFIDTracker{0}.xlsx", ((Control)sender).Name.Replace("bExcel", ""));
            DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)((DevExpress.XtraEditors.PanelControl)((DevExpress.XtraEditors.SimpleButton)sender).Parent).Parent.Controls[0];
            if (save2Excel.ShowDialog() == DialogResult.OK)
            {
                grid.ExportToXlsx(save2Excel.FileName);    
            }
        }

        private void gcResultadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void lkDepositoResultado_EditValueChanged(object sender, EventArgs e)
        {
            gvResultadoInventario.ActiveFilterString = string.Format("[iddeposito] = {0} or IsNullOrEmpty([iddeposito])", lkDepositoResultado.EditValue);
        }
    }
}
