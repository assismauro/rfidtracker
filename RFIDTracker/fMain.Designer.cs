namespace RFIDTracker
{
    partial class fMain
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
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tfInventario = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pgProduto = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcProduto = new DevExpress.XtraGrid.GridControl();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet13 = new RFIDTracker.DataSet1();
            this.gvProduto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colncm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumeroitem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelProdutos = new DevExpress.XtraEditors.SimpleButton();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.cnProduto = new DevExpress.XtraEditors.ControlNavigator();
            this.pgItem = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer3 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcItem = new DevExpress.XtraGrid.GridControl();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet14 = new RFIDTracker.DataSet1();
            this.gvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidproduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkProduto = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colnumero_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltag_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliddeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkDepositoGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.depositoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidprateleira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkPrateleira = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.prateleiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet15 = new RFIDTracker.DataSet1();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelItens = new DevExpress.XtraEditors.SimpleButton();
            this.cnItem = new DevExpress.XtraEditors.ControlNavigator();
            this.pgPrateleira = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer5 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcPrateleiras = new DevExpress.XtraGrid.GridControl();
            this.gvPrateleira = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelPrateleiras = new DevExpress.XtraEditors.SimpleButton();
            this.ncPrateleira = new DevExpress.XtraEditors.ControlNavigator();
            this.pgMovimentacao = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer6 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcMovimentacao = new DevExpress.XtraGrid.GridControl();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet17 = new RFIDTracker.DataSet1();
            this.gvMovimentacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidproduto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkDescricao1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vw_itemProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coliditem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.coltag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lktag = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.coltimestamp_movimentacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsentido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbSentido = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.coliddeposito1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.movimentacaoLkUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new RFIDTracker.DataSet1();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelMovimentacao = new DevExpress.XtraEditors.SimpleButton();
            this.cnMovimentacao = new DevExpress.XtraEditors.ControlNavigator();
            this.pgDeposito = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer4 = new DevExpress.XtraBars.TabFormContentContainer();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelDepositos = new DevExpress.XtraEditors.SimpleButton();
            this.cnDeposito = new DevExpress.XtraEditors.ControlNavigator();
            this.pgUsuario = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grUsuario = new DevExpress.XtraGrid.GridControl();
            this.gvUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidperfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkPerfil = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new RFIDTracker.DataSet1();
            this.colsenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edSenha = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.coltag_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalterar_senha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckAlterarSenha = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colpode_usar_coletor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckPodeUsarColetor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelUsuarios = new DevExpress.XtraEditors.SimpleButton();
            this.cnUsuario = new DevExpress.XtraEditors.ControlNavigator();
            this.pgPerfil = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.grPerfil = new DevExpress.XtraGrid.GridControl();
            this.gvPerfil = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladministrador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckPerfilAdministrador = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelPerfis = new DevExpress.XtraEditors.SimpleButton();
            this.cnPerfil = new DevExpress.XtraEditors.ControlNavigator();
            this.pgInventarioDados = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer7 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcDadosInventario = new DevExpress.XtraGrid.GridControl();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDadosInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltag1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_stamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsInventarioTimeStamp = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colidinventario_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.bExcelLeiturasInventario = new DevExpress.XtraEditors.SimpleButton();
            this.cnDadosInventario = new DevExpress.XtraEditors.ControlNavigator();
            this.pgResultadoInventario = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer8 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcResultadoInventario = new DevExpress.XtraGrid.GridControl();
            this.vwresultadoinventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvResultadoInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltag_id2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartnumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprateleira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresultado_inventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliddeposito2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_stamp2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edInventario_time_stamp = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl12 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkDepositoResultado = new DevExpress.XtraEditors.LookUpEdit();
            this.b2ExcelResultadoInventario = new DevExpress.XtraEditors.SimpleButton();
            this.cnResultadosInventario = new DevExpress.XtraEditors.ControlNavigator();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer9 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcInventarioOk = new DevExpress.XtraGrid.GridControl();
            this.vwinventariookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvInventarioOk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltime_stamp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltag2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartnumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposito1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprateleira1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl13 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.dataSet16 = new RFIDTracker.DataSet1();
            this.perfilTableAdapter1 = new RFIDTracker.DataSet1TableAdapters.perfilTableAdapter();
            this.usuarioTableAdapter1 = new RFIDTracker.DataSet1TableAdapters.usuarioTableAdapter();
            this.produtoTableAdapter1 = new RFIDTracker.DataSet1TableAdapters.produtoTableAdapter();
            this.itemTableAdapter1 = new RFIDTracker.DataSet1TableAdapters.itemTableAdapter();
            this.prateleiraTableAdapter1 = new RFIDTracker.DataSet1TableAdapters.prateleiraTableAdapter();
            this.movimentacaoTableAdapter1 = new RFIDTracker.DataSet1TableAdapters.movimentacaoTableAdapter();
            this.vw_itemprodutoTableAdapter = new RFIDTracker.DataSet1TableAdapters.vw_itemprodutoTableAdapter();
            this.inventarioTableAdapter = new RFIDTracker.DataSet1TableAdapters.inventarioTableAdapter();
            this.vw_resultado_inventarioTableAdapter = new RFIDTracker.DataSet1TableAdapters.vw_resultado_inventarioTableAdapter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.save2Excel = new System.Windows.Forms.SaveFileDialog();
            this.vw_inventario_grupo_depositoTableAdapter = new RFIDTracker.DataSet1TableAdapters.vw_inventario_grupo_depositoTableAdapter();
            this.depositoTableAdapter = new RFIDTracker.DataSet1TableAdapters.depositoTableAdapter();
            this.vw_inventario_okTableAdapter = new RFIDTracker.DataSet1TableAdapters.vw_inventario_okTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tfInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.tabFormContentContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDepositoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPrateleira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prateleiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.tabFormContentContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrateleiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrateleira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            this.tabFormContentContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDescricao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itemProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lktag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSentido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoLkUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            this.tabFormContentContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAlterarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPodeUsarColetor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPerfilAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.tabFormContentContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDadosInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDadosInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventarioTimeStamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventarioTimeStamp.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            this.tabFormContentContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResultadoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwresultadoinventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultadoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInventario_time_stamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInventario_time_stamp.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).BeginInit();
            this.panelControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkDepositoResultado.Properties)).BeginInit();
            this.tabFormContentContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInventarioOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwinventariookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventarioOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl13)).BeginInit();
            this.panelControl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // tfInventario
            // 
            this.tfInventario.Location = new System.Drawing.Point(0, 0);
            this.tfInventario.Manager = this.tabFormDefaultManager1;
            this.tfInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tfInventario.Name = "tfInventario";
            this.tfInventario.Pages.Add(this.pgProduto);
            this.tfInventario.Pages.Add(this.pgItem);
            this.tfInventario.Pages.Add(this.pgPrateleira);
            this.tfInventario.Pages.Add(this.pgMovimentacao);
            this.tfInventario.Pages.Add(this.pgDeposito);
            this.tfInventario.Pages.Add(this.pgUsuario);
            this.tfInventario.Pages.Add(this.pgPerfil);
            this.tfInventario.Pages.Add(this.pgInventarioDados);
            this.tfInventario.Pages.Add(this.pgResultadoInventario);
            this.tfInventario.Pages.Add(this.tabFormPage1);
            this.tfInventario.SelectedPage = this.tabFormPage1;
            this.tfInventario.ShowAddPageButton = false;
            this.tfInventario.ShowTabCloseButtons = false;
            this.tfInventario.Size = new System.Drawing.Size(1373, 61);
            this.tfInventario.TabForm = this;
            this.tfInventario.TabIndex = 0;
            this.tfInventario.TabStop = false;
            this.tfInventario.SelectedPageChanged += new DevExpress.XtraBars.TabFormSelectedPageChangedEventHandler(this.formControl_SelectedPageChanged);
            this.tfInventario.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1373, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 569);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1373, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 569);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1373, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 569);
            // 
            // pgProduto
            // 
            this.pgProduto.ContentContainer = this.tabFormContentContainer2;
            this.pgProduto.Name = "pgProduto";
            this.pgProduto.Text = "Produtos";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.gcProduto);
            this.tabFormContentContainer2.Controls.Add(this.panelControl5);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer2.TabIndex = 0;
            // 
            // gcProduto
            // 
            this.gcProduto.DataSource = this.produtoBindingSource;
            this.gcProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduto.Location = new System.Drawing.Point(0, 54);
            this.gcProduto.MainView = this.gvProduto;
            this.gcProduto.MenuManager = this.tabFormDefaultManager1;
            this.gcProduto.Name = "gcProduto";
            this.gcProduto.Size = new System.Drawing.Size(1373, 454);
            this.gcProduto.TabIndex = 1;
            this.gcProduto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduto});
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.dataSet13;
            this.produtoBindingSource.Sort = "";
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet1";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProduto
            // 
            this.gvProduto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colpartnumber,
            this.coldescricao1,
            this.coldescricao2,
            this.colncm,
            this.colnumeroitem});
            this.gvProduto.GridControl = this.gcProduto;
            this.gvProduto.Name = "gvProduto";
            this.gvProduto.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvPerfil_RowDeleted);
            this.gvProduto.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPerfil_RowUpdated);
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colpartnumber
            // 
            this.colpartnumber.Caption = "Part Number";
            this.colpartnumber.FieldName = "partnumber";
            this.colpartnumber.Name = "colpartnumber";
            this.colpartnumber.Visible = true;
            this.colpartnumber.VisibleIndex = 0;
            // 
            // coldescricao1
            // 
            this.coldescricao1.Caption = "Descrição 1";
            this.coldescricao1.FieldName = "descricao1";
            this.coldescricao1.Name = "coldescricao1";
            this.coldescricao1.Visible = true;
            this.coldescricao1.VisibleIndex = 1;
            // 
            // coldescricao2
            // 
            this.coldescricao2.Caption = "Descricão 2";
            this.coldescricao2.FieldName = "descricao2";
            this.coldescricao2.Name = "coldescricao2";
            this.coldescricao2.Visible = true;
            this.coldescricao2.VisibleIndex = 2;
            // 
            // colncm
            // 
            this.colncm.Caption = "NCM";
            this.colncm.FieldName = "ncm";
            this.colncm.Name = "colncm";
            this.colncm.Visible = true;
            this.colncm.VisibleIndex = 3;
            // 
            // colnumeroitem
            // 
            this.colnumeroitem.Caption = "Número do Ítem";
            this.colnumeroitem.FieldName = "numeroitem";
            this.colnumeroitem.Name = "colnumeroitem";
            this.colnumeroitem.Visible = true;
            this.colnumeroitem.VisibleIndex = 4;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.bExcelProdutos);
            this.panelControl5.Controls.Add(this.cnProduto);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1373, 54);
            this.panelControl5.TabIndex = 0;
            // 
            // bExcelProdutos
            // 
            this.bExcelProdutos.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelProdutos.ImageIndex = 0;
            this.bExcelProdutos.ImageList = this.il;
            this.bExcelProdutos.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelProdutos.Location = new System.Drawing.Point(1325, 2);
            this.bExcelProdutos.Name = "bExcelProdutos";
            this.bExcelProdutos.Size = new System.Drawing.Size(46, 50);
            this.bExcelProdutos.TabIndex = 6;
            this.bExcelProdutos.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // il
            // 
            this.il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il.ImageStream")));
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            this.il.Images.SetKeyName(0, "Excel.jpg");
            // 
            // cnProduto
            // 
            this.cnProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnProduto.Location = new System.Drawing.Point(2, 2);
            this.cnProduto.Name = "cnProduto";
            this.cnProduto.NavigatableControl = this.gcProduto;
            this.cnProduto.Size = new System.Drawing.Size(453, 50);
            this.cnProduto.TabIndex = 0;
            this.cnProduto.Text = "controlNavigator2";
            // 
            // pgItem
            // 
            this.pgItem.ContentContainer = this.tabFormContentContainer3;
            this.pgItem.Name = "pgItem";
            this.pgItem.Text = "Ítens";
            // 
            // tabFormContentContainer3
            // 
            this.tabFormContentContainer3.Controls.Add(this.gcItem);
            this.tabFormContentContainer3.Controls.Add(this.panelControl6);
            this.tabFormContentContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer3.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer3.Name = "tabFormContentContainer3";
            this.tabFormContentContainer3.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer3.TabIndex = 12;
            // 
            // gcItem
            // 
            this.gcItem.DataSource = this.itemBindingSource;
            this.gcItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItem.Location = new System.Drawing.Point(0, 54);
            this.gcItem.MainView = this.gvItem;
            this.gcItem.MenuManager = this.tabFormDefaultManager1;
            this.gcItem.Name = "gcItem";
            this.gcItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkProduto,
            this.lkPrateleira,
            this.lkDepositoGrid});
            this.gcItem.Size = new System.Drawing.Size(1373, 454);
            this.gcItem.TabIndex = 1;
            this.gcItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItem});
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.dataSet14;
            this.itemBindingSource.Sort = "";
            // 
            // dataSet14
            // 
            this.dataSet14.DataSetName = "DataSet1";
            this.dataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvItem
            // 
            this.gvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colidproduto,
            this.colnumero_serie,
            this.coltag_id,
            this.coliddeposito,
            this.colidprateleira});
            this.gvItem.GridControl = this.gcItem;
            this.gvItem.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "idproduto", null, "(Produto: Count={0})")});
            this.gvItem.Name = "gvItem";
            this.gvItem.OptionsView.ShowFooter = true;
            this.gvItem.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvPerfil_RowDeleted);
            this.gvItem.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPerfil_RowUpdated);
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // colidproduto
            // 
            this.colidproduto.Caption = "Produto";
            this.colidproduto.ColumnEdit = this.lkProduto;
            this.colidproduto.FieldName = "idproduto";
            this.colidproduto.Name = "colidproduto";
            this.colidproduto.Visible = true;
            this.colidproduto.VisibleIndex = 0;
            // 
            // lkProduto
            // 
            this.lkProduto.AutoHeight = false;
            this.lkProduto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkProduto.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("partnumber", "Part Number", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descricao1", "Descrição", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descricao2", "descricao2", 71, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ncm", "ncm", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("numeroitem", "numeroitem", 79, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lkProduto.DataSource = this.produtoBindingSource;
            this.lkProduto.DisplayMember = "descricao1";
            this.lkProduto.KeyMember = "id";
            this.lkProduto.Name = "lkProduto";
            this.lkProduto.ValueMember = "id";
            // 
            // colnumero_serie
            // 
            this.colnumero_serie.Caption = "Número de Série";
            this.colnumero_serie.FieldName = "numero_serie";
            this.colnumero_serie.Name = "colnumero_serie";
            this.colnumero_serie.Visible = true;
            this.colnumero_serie.VisibleIndex = 3;
            // 
            // coltag_id
            // 
            this.coltag_id.Caption = "Tag Id";
            this.coltag_id.FieldName = "tag_id";
            this.coltag_id.Name = "coltag_id";
            this.coltag_id.Visible = true;
            this.coltag_id.VisibleIndex = 1;
            // 
            // coliddeposito
            // 
            this.coliddeposito.Caption = "Depósito";
            this.coliddeposito.ColumnEdit = this.lkDepositoGrid;
            this.coliddeposito.FieldName = "iddeposito";
            this.coliddeposito.Name = "coliddeposito";
            this.coliddeposito.Visible = true;
            this.coliddeposito.VisibleIndex = 2;
            // 
            // lkDepositoGrid
            // 
            this.lkDepositoGrid.AutoHeight = false;
            this.lkDepositoGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDepositoGrid.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "nome", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkDepositoGrid.DataSource = this.depositoBindingSource;
            this.lkDepositoGrid.DisplayMember = "nome";
            this.lkDepositoGrid.Name = "lkDepositoGrid";
            this.lkDepositoGrid.ValueMember = "id";
            // 
            // depositoBindingSource
            // 
            this.depositoBindingSource.DataMember = "deposito";
            this.depositoBindingSource.DataSource = this.dataSet13;
            // 
            // colidprateleira
            // 
            this.colidprateleira.Caption = "Prateleira";
            this.colidprateleira.ColumnEdit = this.lkPrateleira;
            this.colidprateleira.FieldName = "idprateleira";
            this.colidprateleira.Name = "colidprateleira";
            this.colidprateleira.Visible = true;
            this.colidprateleira.VisibleIndex = 4;
            // 
            // lkPrateleira
            // 
            this.lkPrateleira.AutoHeight = false;
            this.lkPrateleira.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPrateleira.DataSource = this.prateleiraBindingSource;
            this.lkPrateleira.DisplayMember = "nome";
            this.lkPrateleira.KeyMember = "id";
            this.lkPrateleira.Name = "lkPrateleira";
            this.lkPrateleira.ValueMember = "id";
            // 
            // prateleiraBindingSource
            // 
            this.prateleiraBindingSource.DataMember = "prateleira";
            this.prateleiraBindingSource.DataSource = this.dataSet15;
            this.prateleiraBindingSource.Sort = "";
            // 
            // dataSet15
            // 
            this.dataSet15.DataSetName = "DataSet1";
            this.dataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.bExcelItens);
            this.panelControl6.Controls.Add(this.cnItem);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl6.Location = new System.Drawing.Point(0, 0);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1373, 54);
            this.panelControl6.TabIndex = 0;
            // 
            // bExcelItens
            // 
            this.bExcelItens.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelItens.ImageIndex = 0;
            this.bExcelItens.ImageList = this.il;
            this.bExcelItens.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelItens.Location = new System.Drawing.Point(1325, 2);
            this.bExcelItens.Name = "bExcelItens";
            this.bExcelItens.Size = new System.Drawing.Size(46, 50);
            this.bExcelItens.TabIndex = 6;
            this.bExcelItens.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnItem
            // 
            this.cnItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnItem.Location = new System.Drawing.Point(2, 2);
            this.cnItem.Name = "cnItem";
            this.cnItem.NavigatableControl = this.gcItem;
            this.cnItem.Size = new System.Drawing.Size(453, 50);
            this.cnItem.TabIndex = 0;
            // 
            // pgPrateleira
            // 
            this.pgPrateleira.ContentContainer = this.tabFormContentContainer5;
            this.pgPrateleira.Name = "pgPrateleira";
            this.pgPrateleira.Text = "Prateleiras";
            // 
            // tabFormContentContainer5
            // 
            this.tabFormContentContainer5.Controls.Add(this.gcPrateleiras);
            this.tabFormContentContainer5.Controls.Add(this.panelControl8);
            this.tabFormContentContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer5.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer5.Name = "tabFormContentContainer5";
            this.tabFormContentContainer5.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer5.TabIndex = 14;
            // 
            // gcPrateleiras
            // 
            this.gcPrateleiras.DataSource = this.prateleiraBindingSource;
            this.gcPrateleiras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrateleiras.Location = new System.Drawing.Point(0, 54);
            this.gcPrateleiras.MainView = this.gvPrateleira;
            this.gcPrateleiras.MenuManager = this.tabFormDefaultManager1;
            this.gcPrateleiras.Name = "gcPrateleiras";
            this.gcPrateleiras.Size = new System.Drawing.Size(1373, 454);
            this.gcPrateleiras.TabIndex = 2;
            this.gcPrateleiras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrateleira});
            // 
            // gvPrateleira
            // 
            this.gvPrateleira.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid4,
            this.colnome2});
            this.gvPrateleira.GridControl = this.gcPrateleiras;
            this.gvPrateleira.Name = "gvPrateleira";
            this.gvPrateleira.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvPerfil_RowDeleted);
            this.gvPrateleira.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPerfil_RowUpdated);
            // 
            // colid4
            // 
            this.colid4.FieldName = "id";
            this.colid4.Name = "colid4";
            // 
            // colnome2
            // 
            this.colnome2.Caption = "Prateleira";
            this.colnome2.FieldName = "nome";
            this.colnome2.Name = "colnome2";
            this.colnome2.Visible = true;
            this.colnome2.VisibleIndex = 0;
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.bExcelPrateleiras);
            this.panelControl8.Controls.Add(this.ncPrateleira);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl8.Location = new System.Drawing.Point(0, 0);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(1373, 54);
            this.panelControl8.TabIndex = 1;
            // 
            // bExcelPrateleiras
            // 
            this.bExcelPrateleiras.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelPrateleiras.ImageIndex = 0;
            this.bExcelPrateleiras.ImageList = this.il;
            this.bExcelPrateleiras.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelPrateleiras.Location = new System.Drawing.Point(1325, 2);
            this.bExcelPrateleiras.Name = "bExcelPrateleiras";
            this.bExcelPrateleiras.Size = new System.Drawing.Size(46, 50);
            this.bExcelPrateleiras.TabIndex = 6;
            this.bExcelPrateleiras.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // ncPrateleira
            // 
            this.ncPrateleira.Dock = System.Windows.Forms.DockStyle.Left;
            this.ncPrateleira.Location = new System.Drawing.Point(2, 2);
            this.ncPrateleira.Name = "ncPrateleira";
            this.ncPrateleira.NavigatableControl = this.gcPrateleiras;
            this.ncPrateleira.Size = new System.Drawing.Size(453, 50);
            this.ncPrateleira.TabIndex = 0;
            // 
            // pgMovimentacao
            // 
            this.pgMovimentacao.ContentContainer = this.tabFormContentContainer6;
            this.pgMovimentacao.Name = "pgMovimentacao";
            this.pgMovimentacao.Text = "Movimentação";
            // 
            // tabFormContentContainer6
            // 
            this.tabFormContentContainer6.Controls.Add(this.gcMovimentacao);
            this.tabFormContentContainer6.Controls.Add(this.panelControl10);
            this.tabFormContentContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer6.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer6.Name = "tabFormContentContainer6";
            this.tabFormContentContainer6.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer6.TabIndex = 4;
            // 
            // gcMovimentacao
            // 
            this.gcMovimentacao.DataSource = this.movimentacaoBindingSource;
            this.gcMovimentacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMovimentacao.Location = new System.Drawing.Point(0, 54);
            this.gcMovimentacao.MainView = this.gvMovimentacao;
            this.gcMovimentacao.MenuManager = this.tabFormDefaultManager1;
            this.gcMovimentacao.Name = "gcMovimentacao";
            this.gcMovimentacao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkItem,
            this.cbSentido,
            this.movimentacaoLkUsuario,
            this.lkDescricao1,
            this.lktag});
            this.gcMovimentacao.Size = new System.Drawing.Size(1373, 454);
            this.gcMovimentacao.TabIndex = 6;
            this.gcMovimentacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMovimentacao});
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataMember = "movimentacao";
            this.movimentacaoBindingSource.DataSource = this.dataSet17;
            this.movimentacaoBindingSource.Sort = "";
            // 
            // dataSet17
            // 
            this.dataSet17.DataSetName = "DataSet1";
            this.dataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMovimentacao
            // 
            this.gvMovimentacao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid6,
            this.colidproduto1,
            this.coliditem,
            this.coltag,
            this.coltimestamp_movimentacao,
            this.colsentido,
            this.coliddeposito1,
            this.colidusuario});
            this.gvMovimentacao.GridControl = this.gcMovimentacao;
            this.gvMovimentacao.Name = "gvMovimentacao";
            this.gvMovimentacao.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltimestamp_movimentacao, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvMovimentacao.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvPerfil_RowDeleted);
            this.gvMovimentacao.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPerfil_RowUpdated);
            // 
            // colid6
            // 
            this.colid6.FieldName = "id";
            this.colid6.Name = "colid6";
            // 
            // colidproduto1
            // 
            this.colidproduto1.Caption = "Produto";
            this.colidproduto1.ColumnEdit = this.lkDescricao1;
            this.colidproduto1.FieldName = "iditem";
            this.colidproduto1.Name = "colidproduto1";
            this.colidproduto1.Visible = true;
            this.colidproduto1.VisibleIndex = 0;
            // 
            // lkDescricao1
            // 
            this.lkDescricao1.AutoHeight = false;
            this.lkDescricao1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDescricao1.DataSource = this.vw_itemProdutoBindingSource;
            this.lkDescricao1.DisplayMember = "descricao1";
            this.lkDescricao1.KeyMember = "iditem";
            this.lkDescricao1.Name = "lkDescricao1";
            this.lkDescricao1.ReadOnly = true;
            this.lkDescricao1.ValueMember = "iditem";
            // 
            // vw_itemProdutoBindingSource
            // 
            this.vw_itemProdutoBindingSource.DataMember = "vw_itemproduto";
            this.vw_itemProdutoBindingSource.DataSource = this.dataSet13;
            // 
            // coliditem
            // 
            this.coliditem.Caption = "Ítem";
            this.coliditem.ColumnEdit = this.lkItem;
            this.coliditem.FieldName = "iditem";
            this.coliditem.Name = "coliditem";
            this.coliditem.Visible = true;
            this.coliditem.VisibleIndex = 1;
            // 
            // lkItem
            // 
            this.lkItem.AutoHeight = false;
            this.lkItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("numero_serie", "numero_serie", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkItem.DataSource = this.itemBindingSource;
            this.lkItem.DisplayMember = "numero_serie";
            this.lkItem.KeyMember = "id";
            this.lkItem.Name = "lkItem";
            this.lkItem.ValueMember = "id";
            // 
            // coltag
            // 
            this.coltag.Caption = "Tag";
            this.coltag.ColumnEdit = this.lktag;
            this.coltag.FieldName = "iditem";
            this.coltag.Name = "coltag";
            this.coltag.Visible = true;
            this.coltag.VisibleIndex = 2;
            // 
            // lktag
            // 
            this.lktag.AutoHeight = false;
            this.lktag.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lktag.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idproduto", "idproduto", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tag_id", "tag_id", 45, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("iddeposito", "iddeposito", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("numero_serie", "numero_serie", 89, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idprateleira", "idprateleira", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lktag.DataSource = this.itemBindingSource;
            this.lktag.DisplayMember = "tag_id";
            this.lktag.KeyMember = "id";
            this.lktag.Name = "lktag";
            this.lktag.ReadOnly = true;
            this.lktag.ValueMember = "id";
            // 
            // coltimestamp_movimentacao
            // 
            this.coltimestamp_movimentacao.Caption = "Data/Hora";
            this.coltimestamp_movimentacao.DisplayFormat.FormatString = "G";
            this.coltimestamp_movimentacao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coltimestamp_movimentacao.FieldName = "timestamp_movimentacao";
            this.coltimestamp_movimentacao.Name = "coltimestamp_movimentacao";
            this.coltimestamp_movimentacao.Visible = true;
            this.coltimestamp_movimentacao.VisibleIndex = 3;
            // 
            // colsentido
            // 
            this.colsentido.Caption = "Sentido";
            this.colsentido.ColumnEdit = this.cbSentido;
            this.colsentido.FieldName = "sentido";
            this.colsentido.Name = "colsentido";
            this.colsentido.Visible = true;
            this.colsentido.VisibleIndex = 4;
            // 
            // cbSentido
            // 
            this.cbSentido.AutoHeight = false;
            this.cbSentido.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSentido.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbSentido.Name = "cbSentido";
            // 
            // coliddeposito1
            // 
            this.coliddeposito1.Name = "coliddeposito1";
            // 
            // colidusuario
            // 
            this.colidusuario.Caption = "Usuário";
            this.colidusuario.ColumnEdit = this.movimentacaoLkUsuario;
            this.colidusuario.FieldName = "idusuario";
            this.colidusuario.Name = "colidusuario";
            this.colidusuario.Visible = true;
            this.colidusuario.VisibleIndex = 5;
            // 
            // movimentacaoLkUsuario
            // 
            this.movimentacaoLkUsuario.AutoHeight = false;
            this.movimentacaoLkUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.movimentacaoLkUsuario.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 33, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "Usuário", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.movimentacaoLkUsuario.DataSource = this.usuarioBindingSource;
            this.movimentacaoLkUsuario.DisplayMember = "nome";
            this.movimentacaoLkUsuario.KeyMember = "id";
            this.movimentacaoLkUsuario.Name = "movimentacaoLkUsuario";
            this.movimentacaoLkUsuario.NullText = "(não informado)";
            this.movimentacaoLkUsuario.ValueMember = "id";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dataSet12;
            this.usuarioBindingSource.Sort = "";
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.bExcelMovimentacao);
            this.panelControl10.Controls.Add(this.cnMovimentacao);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl10.Location = new System.Drawing.Point(0, 0);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(1373, 54);
            this.panelControl10.TabIndex = 5;
            // 
            // bExcelMovimentacao
            // 
            this.bExcelMovimentacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelMovimentacao.ImageIndex = 0;
            this.bExcelMovimentacao.ImageList = this.il;
            this.bExcelMovimentacao.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelMovimentacao.Location = new System.Drawing.Point(1325, 2);
            this.bExcelMovimentacao.Name = "bExcelMovimentacao";
            this.bExcelMovimentacao.Size = new System.Drawing.Size(46, 50);
            this.bExcelMovimentacao.TabIndex = 6;
            this.bExcelMovimentacao.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnMovimentacao
            // 
            this.cnMovimentacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnMovimentacao.Location = new System.Drawing.Point(2, 2);
            this.cnMovimentacao.Name = "cnMovimentacao";
            this.cnMovimentacao.NavigatableControl = this.gcMovimentacao;
            this.cnMovimentacao.Size = new System.Drawing.Size(453, 50);
            this.cnMovimentacao.TabIndex = 1;
            // 
            // pgDeposito
            // 
            this.pgDeposito.ContentContainer = this.tabFormContentContainer4;
            this.pgDeposito.Name = "pgDeposito";
            this.pgDeposito.Text = "Depósitos";
            // 
            // tabFormContentContainer4
            // 
            this.tabFormContentContainer4.Controls.Add(this.panelControl7);
            this.tabFormContentContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer4.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer4.Name = "tabFormContentContainer4";
            this.tabFormContentContainer4.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer4.TabIndex = 15;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.gridControl1);
            this.panelControl7.Controls.Add(this.panelControl9);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(0, 0);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(1373, 508);
            this.panelControl7.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.depositoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.tabFormDefaultManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1369, 450);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid5,
            this.colnome3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid5
            // 
            this.colid5.FieldName = "id";
            this.colid5.Name = "colid5";
            // 
            // colnome3
            // 
            this.colnome3.Caption = "Nome";
            this.colnome3.FieldName = "nome";
            this.colnome3.Name = "colnome3";
            this.colnome3.Visible = true;
            this.colnome3.VisibleIndex = 0;
            // 
            // panelControl9
            // 
            this.panelControl9.Controls.Add(this.bExcelDepositos);
            this.panelControl9.Controls.Add(this.cnDeposito);
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl9.Location = new System.Drawing.Point(2, 2);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(1369, 54);
            this.panelControl9.TabIndex = 5;
            // 
            // bExcelDepositos
            // 
            this.bExcelDepositos.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelDepositos.ImageIndex = 0;
            this.bExcelDepositos.ImageList = this.il;
            this.bExcelDepositos.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelDepositos.Location = new System.Drawing.Point(1321, 2);
            this.bExcelDepositos.Name = "bExcelDepositos";
            this.bExcelDepositos.Size = new System.Drawing.Size(46, 50);
            this.bExcelDepositos.TabIndex = 6;
            this.bExcelDepositos.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnDeposito
            // 
            this.cnDeposito.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnDeposito.Location = new System.Drawing.Point(2, 2);
            this.cnDeposito.Name = "cnDeposito";
            this.cnDeposito.Size = new System.Drawing.Size(453, 50);
            this.cnDeposito.TabIndex = 0;
            // 
            // pgUsuario
            // 
            this.pgUsuario.ContentContainer = this.tabFormContentContainer1;
            this.pgUsuario.Name = "pgUsuario";
            this.pgUsuario.Text = "Usuários";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.panelControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1373, 508);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grUsuario);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1369, 504);
            this.panelControl2.TabIndex = 0;
            // 
            // grUsuario
            // 
            this.grUsuario.DataSource = this.usuarioBindingSource;
            this.grUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grUsuario.Location = new System.Drawing.Point(2, 56);
            this.grUsuario.MainView = this.gvUsuario;
            this.grUsuario.Name = "grUsuario";
            this.grUsuario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkPerfil,
            this.edSenha,
            this.ckAlterarSenha,
            this.ckPodeUsarColetor});
            this.grUsuario.Size = new System.Drawing.Size(1365, 446);
            this.grUsuario.TabIndex = 5;
            this.grUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuario});
            // 
            // gvUsuario
            // 
            this.gvUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colnome1,
            this.colemail,
            this.colidperfil,
            this.colsenha,
            this.coltag_id1,
            this.colalterar_senha,
            this.colpode_usar_coletor});
            this.gvUsuario.GridControl = this.grUsuario;
            this.gvUsuario.Name = "gvUsuario";
            this.gvUsuario.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvPerfil_RowDeleted);
            this.gvUsuario.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvUsuario_RowUpdated);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colnome1
            // 
            this.colnome1.Caption = "Nome";
            this.colnome1.FieldName = "nome";
            this.colnome1.Name = "colnome1";
            this.colnome1.Visible = true;
            this.colnome1.VisibleIndex = 0;
            // 
            // colemail
            // 
            this.colemail.Caption = "E-Mail";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 1;
            // 
            // colidperfil
            // 
            this.colidperfil.Caption = "Perfil";
            this.colidperfil.ColumnEdit = this.lkPerfil;
            this.colidperfil.FieldName = "idperfil";
            this.colidperfil.Name = "colidperfil";
            this.colidperfil.Visible = true;
            this.colidperfil.VisibleIndex = 2;
            // 
            // lkPerfil
            // 
            this.lkPerfil.AutoHeight = false;
            this.lkPerfil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPerfil.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "nome", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("administrador", "administrador", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lkPerfil.DataSource = this.perfilBindingSource;
            this.lkPerfil.DisplayMember = "nome";
            this.lkPerfil.KeyMember = "id";
            this.lkPerfil.Name = "lkPerfil";
            this.lkPerfil.ValueMember = "id";
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "perfil";
            this.perfilBindingSource.DataSource = this.dataSet11;
            this.perfilBindingSource.Sort = "";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colsenha
            // 
            this.colsenha.Caption = "Senha";
            this.colsenha.ColumnEdit = this.edSenha;
            this.colsenha.FieldName = "senha";
            this.colsenha.Name = "colsenha";
            this.colsenha.Visible = true;
            this.colsenha.VisibleIndex = 3;
            // 
            // edSenha
            // 
            this.edSenha.AutoHeight = false;
            this.edSenha.Name = "edSenha";
            this.edSenha.PasswordChar = '*';
            // 
            // coltag_id1
            // 
            this.coltag_id1.Caption = "Tag Id";
            this.coltag_id1.FieldName = "tag_id";
            this.coltag_id1.Name = "coltag_id1";
            this.coltag_id1.Visible = true;
            this.coltag_id1.VisibleIndex = 4;
            // 
            // colalterar_senha
            // 
            this.colalterar_senha.Caption = "Alterar senha primeiro login";
            this.colalterar_senha.ColumnEdit = this.ckAlterarSenha;
            this.colalterar_senha.FieldName = "alterar_senha";
            this.colalterar_senha.Name = "colalterar_senha";
            this.colalterar_senha.Visible = true;
            this.colalterar_senha.VisibleIndex = 5;
            // 
            // ckAlterarSenha
            // 
            this.ckAlterarSenha.AutoHeight = false;
            this.ckAlterarSenha.Name = "ckAlterarSenha";
            this.ckAlterarSenha.ValueChecked = 1;
            this.ckAlterarSenha.ValueUnchecked = 0;
            // 
            // colpode_usar_coletor
            // 
            this.colpode_usar_coletor.Caption = "Pode usar coletor de inventário?";
            this.colpode_usar_coletor.ColumnEdit = this.ckPodeUsarColetor;
            this.colpode_usar_coletor.FieldName = "pode_usar_coletor";
            this.colpode_usar_coletor.Name = "colpode_usar_coletor";
            this.colpode_usar_coletor.Visible = true;
            this.colpode_usar_coletor.VisibleIndex = 6;
            // 
            // ckPodeUsarColetor
            // 
            this.ckPodeUsarColetor.AutoHeight = false;
            this.ckPodeUsarColetor.Name = "ckPodeUsarColetor";
            this.ckPodeUsarColetor.ValueChecked = ((short)(1));
            this.ckPodeUsarColetor.ValueUnchecked = ((short)(0));
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.bExcelUsuarios);
            this.panelControl3.Controls.Add(this.cnUsuario);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1365, 54);
            this.panelControl3.TabIndex = 4;
            // 
            // bExcelUsuarios
            // 
            this.bExcelUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelUsuarios.ImageIndex = 0;
            this.bExcelUsuarios.ImageList = this.il;
            this.bExcelUsuarios.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelUsuarios.Location = new System.Drawing.Point(1317, 2);
            this.bExcelUsuarios.Name = "bExcelUsuarios";
            this.bExcelUsuarios.Size = new System.Drawing.Size(46, 50);
            this.bExcelUsuarios.TabIndex = 6;
            this.bExcelUsuarios.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnUsuario
            // 
            this.cnUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnUsuario.Location = new System.Drawing.Point(2, 2);
            this.cnUsuario.Name = "cnUsuario";
            this.cnUsuario.NavigatableControl = this.grUsuario;
            this.cnUsuario.Size = new System.Drawing.Size(453, 50);
            this.cnUsuario.TabIndex = 1;
            // 
            // pgPerfil
            // 
            this.pgPerfil.ContentContainer = this.xtraScrollableControl1;
            this.pgPerfil.Name = "pgPerfil";
            this.pgPerfil.Text = "Perfis";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.grPerfil);
            this.xtraScrollableControl1.Controls.Add(this.panelControl4);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1373, 508);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // grPerfil
            // 
            this.grPerfil.DataSource = this.perfilBindingSource;
            this.grPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPerfil.Location = new System.Drawing.Point(0, 54);
            this.grPerfil.MainView = this.gvPerfil;
            this.grPerfil.Name = "grPerfil";
            this.grPerfil.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ckPerfilAdministrador});
            this.grPerfil.Size = new System.Drawing.Size(1373, 454);
            this.grPerfil.TabIndex = 1;
            this.grPerfil.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPerfil});
            // 
            // gvPerfil
            // 
            this.gvPerfil.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome,
            this.coladministrador});
            this.gvPerfil.GridControl = this.grPerfil;
            this.gvPerfil.Name = "gvPerfil";
            this.gvPerfil.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvPerfil_RowDeleted);
            this.gvPerfil.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPerfil_RowUpdated);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnome
            // 
            this.colnome.Caption = "Nome";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 0;
            // 
            // coladministrador
            // 
            this.coladministrador.Caption = "Administrador";
            this.coladministrador.ColumnEdit = this.ckPerfilAdministrador;
            this.coladministrador.FieldName = "administrador";
            this.coladministrador.Name = "coladministrador";
            this.coladministrador.Visible = true;
            this.coladministrador.VisibleIndex = 1;
            // 
            // ckPerfilAdministrador
            // 
            this.ckPerfilAdministrador.AutoHeight = false;
            this.ckPerfilAdministrador.Name = "ckPerfilAdministrador";
            this.ckPerfilAdministrador.ValueChecked = 1;
            this.ckPerfilAdministrador.ValueUnchecked = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.bExcelPerfis);
            this.panelControl4.Controls.Add(this.cnPerfil);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1373, 54);
            this.panelControl4.TabIndex = 0;
            // 
            // bExcelPerfis
            // 
            this.bExcelPerfis.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelPerfis.ImageIndex = 0;
            this.bExcelPerfis.ImageList = this.il;
            this.bExcelPerfis.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelPerfis.Location = new System.Drawing.Point(1325, 2);
            this.bExcelPerfis.Name = "bExcelPerfis";
            this.bExcelPerfis.Size = new System.Drawing.Size(46, 50);
            this.bExcelPerfis.TabIndex = 6;
            this.bExcelPerfis.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnPerfil
            // 
            this.cnPerfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnPerfil.Location = new System.Drawing.Point(2, 2);
            this.cnPerfil.Name = "cnPerfil";
            this.cnPerfil.NavigatableControl = this.grPerfil;
            this.cnPerfil.Size = new System.Drawing.Size(453, 50);
            this.cnPerfil.TabIndex = 0;
            this.cnPerfil.Text = "controlNavigator1";
            // 
            // pgInventarioDados
            // 
            this.pgInventarioDados.ContentContainer = this.tabFormContentContainer7;
            this.pgInventarioDados.Name = "pgInventarioDados";
            this.pgInventarioDados.Text = "Leituras Inventário";
            this.pgInventarioDados.Visible = false;
            // 
            // tabFormContentContainer7
            // 
            this.tabFormContentContainer7.Controls.Add(this.gcDadosInventario);
            this.tabFormContentContainer7.Controls.Add(this.panelControl11);
            this.tabFormContentContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer7.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormContentContainer7.Name = "tabFormContentContainer7";
            this.tabFormContentContainer7.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer7.TabIndex = 4;
            // 
            // gcDadosInventario
            // 
            this.gcDadosInventario.DataSource = this.inventarioBindingSource;
            this.gcDadosInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDadosInventario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDadosInventario.Location = new System.Drawing.Point(0, 54);
            this.gcDadosInventario.MainView = this.gvDadosInventario;
            this.gcDadosInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDadosInventario.MenuManager = this.tabFormDefaultManager1;
            this.gcDadosInventario.Name = "gcDadosInventario";
            this.gcDadosInventario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dsInventarioTimeStamp});
            this.gcDadosInventario.Size = new System.Drawing.Size(1373, 454);
            this.gcDadosInventario.TabIndex = 1;
            this.gcDadosInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDadosInventario});
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.dataSet13;
            // 
            // gvDadosInventario
            // 
            this.gvDadosInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid7,
            this.coltag1,
            this.coltime_stamp,
            this.colidinventario_grupo});
            this.gvDadosInventario.GridControl = this.gcDadosInventario;
            this.gvDadosInventario.Name = "gvDadosInventario";
            // 
            // colid7
            // 
            this.colid7.FieldName = "id";
            this.colid7.Name = "colid7";
            // 
            // coltag1
            // 
            this.coltag1.Caption = "Tag";
            this.coltag1.FieldName = "tag";
            this.coltag1.Name = "coltag1";
            this.coltag1.Visible = true;
            this.coltag1.VisibleIndex = 0;
            // 
            // coltime_stamp
            // 
            this.coltime_stamp.Caption = "Data/Hora Leitura";
            this.coltime_stamp.ColumnEdit = this.dsInventarioTimeStamp;
            this.coltime_stamp.DisplayFormat.FormatString = "G";
            this.coltime_stamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coltime_stamp.FieldName = "time_stamp";
            this.coltime_stamp.Name = "coltime_stamp";
            this.coltime_stamp.Visible = true;
            this.coltime_stamp.VisibleIndex = 1;
            // 
            // dsInventarioTimeStamp
            // 
            this.dsInventarioTimeStamp.AutoHeight = false;
            this.dsInventarioTimeStamp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dsInventarioTimeStamp.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dsInventarioTimeStamp.Mask.EditMask = "G";
            this.dsInventarioTimeStamp.Name = "dsInventarioTimeStamp";
            // 
            // colidinventario_grupo
            // 
            this.colidinventario_grupo.FieldName = "idinventario_grupo";
            this.colidinventario_grupo.Name = "colidinventario_grupo";
            // 
            // panelControl11
            // 
            this.panelControl11.Controls.Add(this.bExcelLeiturasInventario);
            this.panelControl11.Controls.Add(this.cnDadosInventario);
            this.panelControl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl11.Location = new System.Drawing.Point(0, 0);
            this.panelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(1373, 54);
            this.panelControl11.TabIndex = 0;
            // 
            // bExcelLeiturasInventario
            // 
            this.bExcelLeiturasInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExcelLeiturasInventario.ImageIndex = 0;
            this.bExcelLeiturasInventario.ImageList = this.il;
            this.bExcelLeiturasInventario.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bExcelLeiturasInventario.Location = new System.Drawing.Point(1325, 2);
            this.bExcelLeiturasInventario.Name = "bExcelLeiturasInventario";
            this.bExcelLeiturasInventario.Size = new System.Drawing.Size(46, 50);
            this.bExcelLeiturasInventario.TabIndex = 6;
            this.bExcelLeiturasInventario.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnDadosInventario
            // 
            this.cnDadosInventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnDadosInventario.Location = new System.Drawing.Point(2, 2);
            this.cnDadosInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnDadosInventario.Name = "cnDadosInventario";
            this.cnDadosInventario.Size = new System.Drawing.Size(398, 50);
            this.cnDadosInventario.TabIndex = 0;
            this.cnDadosInventario.Text = "controlNavigator1";
            // 
            // pgResultadoInventario
            // 
            this.pgResultadoInventario.ContentContainer = this.tabFormContentContainer8;
            this.pgResultadoInventario.Name = "pgResultadoInventario";
            this.pgResultadoInventario.Text = "Ocorrências Inventário";
            // 
            // tabFormContentContainer8
            // 
            this.tabFormContentContainer8.Controls.Add(this.gcResultadoInventario);
            this.tabFormContentContainer8.Controls.Add(this.panelControl12);
            this.tabFormContentContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer8.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFormContentContainer8.Name = "tabFormContentContainer8";
            this.tabFormContentContainer8.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer8.TabIndex = 9;
            // 
            // gcResultadoInventario
            // 
            this.gcResultadoInventario.DataSource = this.vwresultadoinventarioBindingSource;
            this.gcResultadoInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcResultadoInventario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcResultadoInventario.Location = new System.Drawing.Point(0, 54);
            this.gcResultadoInventario.MainView = this.gvResultadoInventario;
            this.gcResultadoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcResultadoInventario.MenuManager = this.tabFormDefaultManager1;
            this.gcResultadoInventario.Name = "gcResultadoInventario";
            this.gcResultadoInventario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.edInventario_time_stamp});
            this.gcResultadoInventario.Size = new System.Drawing.Size(1373, 454);
            this.gcResultadoInventario.TabIndex = 2;
            this.gcResultadoInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResultadoInventario});
            this.gcResultadoInventario.Click += new System.EventHandler(this.gcResultadoInventario_Click);
            // 
            // vwresultadoinventarioBindingSource
            // 
            this.vwresultadoinventarioBindingSource.DataMember = "vw_resultado_inventario";
            this.vwresultadoinventarioBindingSource.DataSource = this.dataSet13;
            // 
            // gvResultadoInventario
            // 
            this.gvResultadoInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltag_id2,
            this.colnumero_serie1,
            this.colpartnumber1,
            this.coldescricao11,
            this.coldeposito,
            this.colprateleira,
            this.colresultado_inventario,
            this.coliddeposito2,
            this.coltime_stamp2});
            this.gvResultadoInventario.GridControl = this.gcResultadoInventario;
            this.gvResultadoInventario.GroupCount = 1;
            this.gvResultadoInventario.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "time_stamp", null, "")});
            this.gvResultadoInventario.Name = "gvResultadoInventario";
            this.gvResultadoInventario.OptionsView.ShowFooter = true;
            this.gvResultadoInventario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltime_stamp2, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // coltag_id2
            // 
            this.coltag_id2.Caption = "Tag Id";
            this.coltag_id2.FieldName = "tag_id";
            this.coltag_id2.Name = "coltag_id2";
            this.coltag_id2.Visible = true;
            this.coltag_id2.VisibleIndex = 5;
            // 
            // colnumero_serie1
            // 
            this.colnumero_serie1.Caption = "Número de Série";
            this.colnumero_serie1.FieldName = "numero_serie";
            this.colnumero_serie1.Name = "colnumero_serie1";
            this.colnumero_serie1.Visible = true;
            this.colnumero_serie1.VisibleIndex = 0;
            // 
            // colpartnumber1
            // 
            this.colpartnumber1.Caption = "Part Number";
            this.colpartnumber1.FieldName = "partnumber";
            this.colpartnumber1.Name = "colpartnumber1";
            this.colpartnumber1.Visible = true;
            this.colpartnumber1.VisibleIndex = 1;
            // 
            // coldescricao11
            // 
            this.coldescricao11.Caption = "Descrição";
            this.coldescricao11.FieldName = "descricao1";
            this.coldescricao11.Name = "coldescricao11";
            this.coldescricao11.Visible = true;
            this.coldescricao11.VisibleIndex = 2;
            // 
            // coldeposito
            // 
            this.coldeposito.Caption = "Depósito";
            this.coldeposito.FieldName = "deposito";
            this.coldeposito.Name = "coldeposito";
            this.coldeposito.Visible = true;
            this.coldeposito.VisibleIndex = 3;
            // 
            // colprateleira
            // 
            this.colprateleira.Caption = "Prateleira";
            this.colprateleira.FieldName = "prateleira";
            this.colprateleira.Name = "colprateleira";
            this.colprateleira.Visible = true;
            this.colprateleira.VisibleIndex = 4;
            // 
            // colresultado_inventario
            // 
            this.colresultado_inventario.Caption = "Resultado";
            this.colresultado_inventario.FieldName = "resultado_inventario";
            this.colresultado_inventario.Name = "colresultado_inventario";
            this.colresultado_inventario.Visible = true;
            this.colresultado_inventario.VisibleIndex = 6;
            // 
            // coliddeposito2
            // 
            this.coliddeposito2.FieldName = "iddeposito";
            this.coliddeposito2.Name = "coliddeposito2";
            // 
            // coltime_stamp2
            // 
            this.coltime_stamp2.Caption = "Inventário";
            this.coltime_stamp2.FieldName = "time_stamp";
            this.coltime_stamp2.Name = "coltime_stamp2";
            this.coltime_stamp2.Visible = true;
            this.coltime_stamp2.VisibleIndex = 7;
            // 
            // edInventario_time_stamp
            // 
            this.edInventario_time_stamp.AutoHeight = false;
            this.edInventario_time_stamp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edInventario_time_stamp.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edInventario_time_stamp.DisplayFormat.FormatString = "G";
            this.edInventario_time_stamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edInventario_time_stamp.EditFormat.FormatString = "G";
            this.edInventario_time_stamp.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edInventario_time_stamp.Name = "edInventario_time_stamp";
            // 
            // panelControl12
            // 
            this.panelControl12.Controls.Add(this.labelControl1);
            this.panelControl12.Controls.Add(this.lkDepositoResultado);
            this.panelControl12.Controls.Add(this.b2ExcelResultadoInventario);
            this.panelControl12.Controls.Add(this.cnResultadosInventario);
            this.panelControl12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl12.Location = new System.Drawing.Point(0, 0);
            this.panelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl12.Name = "panelControl12";
            this.panelControl12.Size = new System.Drawing.Size(1373, 54);
            this.panelControl12.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(596, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Depósito";
            // 
            // lkDepositoResultado
            // 
            this.lkDepositoResultado.Location = new System.Drawing.Point(596, 27);
            this.lkDepositoResultado.MenuManager = this.tabFormDefaultManager1;
            this.lkDepositoResultado.Name = "lkDepositoResultado";
            this.lkDepositoResultado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDepositoResultado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "nome", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkDepositoResultado.Properties.DataSource = this.depositoBindingSource;
            this.lkDepositoResultado.Properties.DisplayMember = "nome";
            this.lkDepositoResultado.Properties.ValueMember = "id";
            this.lkDepositoResultado.Size = new System.Drawing.Size(160, 22);
            this.lkDepositoResultado.TabIndex = 6;
            this.lkDepositoResultado.EditValueChanged += new System.EventHandler(this.lkDepositoResultado_EditValueChanged);
            // 
            // b2ExcelResultadoInventario
            // 
            this.b2ExcelResultadoInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.b2ExcelResultadoInventario.ImageIndex = 0;
            this.b2ExcelResultadoInventario.ImageList = this.il;
            this.b2ExcelResultadoInventario.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.b2ExcelResultadoInventario.Location = new System.Drawing.Point(1325, 2);
            this.b2ExcelResultadoInventario.Name = "b2ExcelResultadoInventario";
            this.b2ExcelResultadoInventario.Size = new System.Drawing.Size(46, 50);
            this.b2ExcelResultadoInventario.TabIndex = 5;
            this.b2ExcelResultadoInventario.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // cnResultadosInventario
            // 
            this.cnResultadosInventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnResultadosInventario.Location = new System.Drawing.Point(2, 2);
            this.cnResultadosInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnResultadosInventario.Name = "cnResultadosInventario";
            this.cnResultadosInventario.Size = new System.Drawing.Size(464, 50);
            this.cnResultadosInventario.TabIndex = 0;
            this.cnResultadosInventario.Text = "controlNavigator1";
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer9;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Inventário Ok";
            // 
            // tabFormContentContainer9
            // 
            this.tabFormContentContainer9.Controls.Add(this.gcInventarioOk);
            this.tabFormContentContainer9.Controls.Add(this.panelControl13);
            this.tabFormContentContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer9.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer9.Name = "tabFormContentContainer9";
            this.tabFormContentContainer9.Size = new System.Drawing.Size(1373, 508);
            this.tabFormContentContainer9.TabIndex = 14;
            // 
            // gcInventarioOk
            // 
            this.gcInventarioOk.DataSource = this.vwinventariookBindingSource;
            this.gcInventarioOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInventarioOk.Location = new System.Drawing.Point(0, 54);
            this.gcInventarioOk.MainView = this.gvInventarioOk;
            this.gcInventarioOk.MenuManager = this.tabFormDefaultManager1;
            this.gcInventarioOk.Name = "gcInventarioOk";
            this.gcInventarioOk.Size = new System.Drawing.Size(1373, 454);
            this.gcInventarioOk.TabIndex = 2;
            this.gcInventarioOk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInventarioOk});
            // 
            // vwinventariookBindingSource
            // 
            this.vwinventariookBindingSource.DataMember = "vw_inventario_ok";
            this.vwinventariookBindingSource.DataSource = this.dataSet13;
            // 
            // gvInventarioOk
            // 
            this.gvInventarioOk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltime_stamp1,
            this.coltag2,
            this.colpartnumber2,
            this.coldescricao12,
            this.coldescricao21,
            this.coldeposito1,
            this.colprateleira1});
            this.gvInventarioOk.GridControl = this.gcInventarioOk;
            this.gvInventarioOk.GroupCount = 1;
            this.gvInventarioOk.Name = "gvInventarioOk";
            this.gvInventarioOk.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltime_stamp1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // coltime_stamp1
            // 
            this.coltime_stamp1.Caption = "Inventário";
            this.coltime_stamp1.FieldName = "time_stamp";
            this.coltime_stamp1.Name = "coltime_stamp1";
            this.coltime_stamp1.Visible = true;
            this.coltime_stamp1.VisibleIndex = 0;
            // 
            // coltag2
            // 
            this.coltag2.Caption = "Tag";
            this.coltag2.FieldName = "tag";
            this.coltag2.Name = "coltag2";
            this.coltag2.Visible = true;
            this.coltag2.VisibleIndex = 0;
            // 
            // colpartnumber2
            // 
            this.colpartnumber2.Caption = "Part Number";
            this.colpartnumber2.FieldName = "partnumber";
            this.colpartnumber2.Name = "colpartnumber2";
            this.colpartnumber2.Visible = true;
            this.colpartnumber2.VisibleIndex = 1;
            // 
            // coldescricao12
            // 
            this.coldescricao12.Caption = "Descrição";
            this.coldescricao12.FieldName = "descricao1";
            this.coldescricao12.Name = "coldescricao12";
            this.coldescricao12.Visible = true;
            this.coldescricao12.VisibleIndex = 2;
            // 
            // coldescricao21
            // 
            this.coldescricao21.Caption = "Descrição 2";
            this.coldescricao21.FieldName = "descricao2";
            this.coldescricao21.Name = "coldescricao21";
            this.coldescricao21.Visible = true;
            this.coldescricao21.VisibleIndex = 3;
            // 
            // coldeposito1
            // 
            this.coldeposito1.Caption = "Depósito";
            this.coldeposito1.FieldName = "deposito";
            this.coldeposito1.Name = "coldeposito1";
            this.coldeposito1.Visible = true;
            this.coldeposito1.VisibleIndex = 4;
            // 
            // colprateleira1
            // 
            this.colprateleira1.Caption = "Prateleira";
            this.colprateleira1.FieldName = "prateleira";
            this.colprateleira1.Name = "colprateleira1";
            this.colprateleira1.Visible = true;
            this.colprateleira1.VisibleIndex = 5;
            // 
            // panelControl13
            // 
            this.panelControl13.Controls.Add(this.simpleButton1);
            this.panelControl13.Controls.Add(this.controlNavigator1);
            this.panelControl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl13.Location = new System.Drawing.Point(0, 0);
            this.panelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl13.Name = "panelControl13";
            this.panelControl13.Size = new System.Drawing.Size(1373, 54);
            this.panelControl13.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.il;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1325, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 50);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Click += new System.EventHandler(this.b2Excel_Click);
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlNavigator1.Location = new System.Drawing.Point(2, 2);
            this.controlNavigator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(398, 50);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            // 
            // dataSet16
            // 
            this.dataSet16.DataSetName = "DataSet1";
            this.dataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perfilTableAdapter1
            // 
            this.perfilTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // prateleiraTableAdapter1
            // 
            this.prateleiraTableAdapter1.ClearBeforeFill = true;
            // 
            // movimentacaoTableAdapter1
            // 
            this.movimentacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_itemprodutoTableAdapter
            // 
            this.vw_itemprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // vw_resultado_inventarioTableAdapter
            // 
            this.vw_resultado_inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // save2Excel
            // 
            this.save2Excel.DefaultExt = "XLSX";
            this.save2Excel.Filter = "xlsx files (*.xlsx)|*.xlsx";
            // 
            // vw_inventario_grupo_depositoTableAdapter
            // 
            this.vw_inventario_grupo_depositoTableAdapter.ClearBeforeFill = true;
            // 
            // depositoTableAdapter
            // 
            this.depositoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_inventario_okTableAdapter
            // 
            this.vw_inventario_okTableAdapter.ClearBeforeFill = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1373, 569);
            this.Controls.Add(this.tabFormContentContainer9);
            this.Controls.Add(this.tfInventario);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.TabFormControl = this.tfInventario;
            this.Text = "RFID Tracker v3.02";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.Shown += new System.EventHandler(this.fMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tfInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.tabFormContentContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDepositoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPrateleira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prateleiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.tabFormContentContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrateleiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrateleira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.tabFormContentContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDescricao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_itemProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lktag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSentido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoLkUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.tabFormContentContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAlterarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPodeUsarColetor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPerfilAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.tabFormContentContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDadosInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDadosInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventarioTimeStamp.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventarioTimeStamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.tabFormContentContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcResultadoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwresultadoinventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultadoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInventario_time_stamp.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInventario_time_stamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).EndInit();
            this.panelControl12.ResumeLayout(false);
            this.panelControl12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkDepositoResultado.Properties)).EndInit();
            this.tabFormContentContainer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInventarioOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwinventariookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventarioOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl13)).EndInit();
            this.panelControl13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tfInventario;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage pgPerfil;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.perfilTableAdapter perfilTableAdapter1;
        private DevExpress.XtraBars.TabFormPage pgUsuario;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSet1 dataSet12;
        private DataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colnome1;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colidperfil;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkPerfil;
        private DevExpress.XtraGrid.Columns.GridColumn colsenha;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit edSenha;
        private DevExpress.XtraGrid.Columns.GridColumn colalterar_senha;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckAlterarSenha;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.ControlNavigator cnUsuario;
        private DevExpress.XtraGrid.GridControl grPerfil;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPerfil;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn coladministrador;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckPerfilAdministrador;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.ControlNavigator cnPerfil;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraGrid.GridControl gcProduto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSet1 dataSet13;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colpartnumber;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao2;
        private DevExpress.XtraGrid.Columns.GridColumn colncm;
        private DevExpress.XtraGrid.Columns.GridColumn colnumeroitem;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.ControlNavigator cnProduto;
        private DevExpress.XtraBars.TabFormPage pgProduto;
        private DataSet1TableAdapters.produtoTableAdapter produtoTableAdapter1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer3;
        private DevExpress.XtraGrid.GridControl gcItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItem;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.ControlNavigator cnItem;
        private DevExpress.XtraBars.TabFormPage pgItem;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSet1 dataSet14;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colidproduto;
        private DevExpress.XtraGrid.Columns.GridColumn coltag_id;
        private DevExpress.XtraGrid.Columns.GridColumn coliddeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_serie;
        private DevExpress.XtraGrid.Columns.GridColumn colidprateleira;
        private DataSet1TableAdapters.itemTableAdapter itemTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkProduto;
        private DevExpress.XtraBars.TabFormPage pgDeposito;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer5;
        private DevExpress.XtraBars.TabFormPage pgPrateleira;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.ControlNavigator ncPrateleira;
        private DevExpress.XtraGrid.GridControl gcPrateleiras;
        private System.Windows.Forms.BindingSource prateleiraBindingSource;
        private DataSet1 dataSet15;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrateleira;
        private DevExpress.XtraGrid.Columns.GridColumn colid4;
        private DevExpress.XtraGrid.Columns.GridColumn colnome2;
        private DataSet1TableAdapters.prateleiraTableAdapter prateleiraTableAdapter1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer4;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.ControlNavigator cnDeposito;
        private DataSet1 dataSet16;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkPrateleira;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer6;
        private DevExpress.XtraBars.TabFormPage pgMovimentacao;
        private DevExpress.XtraGrid.GridControl gcMovimentacao;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private DataSet1 dataSet17;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMovimentacao;
        private DevExpress.XtraGrid.Columns.GridColumn colid6;
        private DevExpress.XtraGrid.Columns.GridColumn coliditem;
        private DevExpress.XtraGrid.Columns.GridColumn colsentido;
        private DevExpress.XtraGrid.Columns.GridColumn coliddeposito1;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.ControlNavigator cnMovimentacao;
        private DataSet1TableAdapters.movimentacaoTableAdapter movimentacaoTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbSentido;
        private DevExpress.XtraGrid.Columns.GridColumn coltimestamp_movimentacao;
        private DevExpress.XtraGrid.Columns.GridColumn coltag_id1;
        private DevExpress.XtraGrid.Columns.GridColumn colidusuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit movimentacaoLkUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkDescricao1;
        private System.Windows.Forms.BindingSource vw_itemProdutoBindingSource;
        private DataSet1TableAdapters.vw_itemprodutoTableAdapter vw_itemprodutoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidproduto1;
        private DevExpress.XtraGrid.Columns.GridColumn coltag;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lktag;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer7;
        private DevExpress.XtraBars.TabFormPage pgInventarioDados;
        private DevExpress.XtraGrid.GridControl gcDadosInventario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDadosInventario;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.ControlNavigator cnDadosInventario;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private DataSet1TableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid7;
        private DevExpress.XtraGrid.Columns.GridColumn coltag1;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_stamp;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dsInventarioTimeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn colidinventario_grupo;
        private DevExpress.XtraBars.TabFormPage pgResultadoInventario;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer8;
        private DevExpress.XtraEditors.PanelControl panelControl12;
        private DevExpress.XtraEditors.ControlNavigator cnResultadosInventario;
        private DevExpress.XtraGrid.GridControl gcResultadoInventario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResultadoInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn colpartnumber1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao11;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colprateleira;
        private System.Windows.Forms.BindingSource vwresultadoinventarioBindingSource;
        private DataSet1TableAdapters.vw_resultado_inventarioTableAdapter vw_resultado_inventarioTableAdapter;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.SimpleButton b2ExcelResultadoInventario;
        private System.Windows.Forms.ImageList il;
        private DevExpress.XtraEditors.SimpleButton bExcelProdutos;
        private DevExpress.XtraEditors.SimpleButton bExcelItens;
        private DevExpress.XtraEditors.SimpleButton bExcelPrateleiras;
        private DevExpress.XtraEditors.SimpleButton bExcelMovimentacao;
        private DevExpress.XtraEditors.SimpleButton bExcelDepositos;
        private DevExpress.XtraEditors.SimpleButton bExcelUsuarios;
        private DevExpress.XtraEditors.SimpleButton bExcelPerfis;
        private DevExpress.XtraEditors.SimpleButton bExcelLeiturasInventario;
        private System.Windows.Forms.SaveFileDialog save2Excel;
        private DevExpress.XtraGrid.Columns.GridColumn colpode_usar_coletor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckPodeUsarColetor;
        private DataSet1TableAdapters.vw_inventario_grupo_depositoTableAdapter vw_inventario_grupo_depositoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit edInventario_time_stamp;
        private DevExpress.XtraGrid.Columns.GridColumn coltag_id2;
        private DevExpress.XtraGrid.Columns.GridColumn colresultado_inventario;
        private DevExpress.XtraGrid.Columns.GridColumn coliddeposito2;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_stamp2;
        private DevExpress.XtraEditors.LookUpEdit lkDepositoResultado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkDepositoGrid;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource depositoBindingSource;
        private DataSet1TableAdapters.depositoTableAdapter depositoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid5;
        private DevExpress.XtraGrid.Columns.GridColumn colnome3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer9;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraEditors.PanelControl panelControl13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraGrid.GridControl gcInventarioOk;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventarioOk;
        private System.Windows.Forms.BindingSource vwinventariookBindingSource;
        private DataSet1TableAdapters.vw_inventario_okTableAdapter vw_inventario_okTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_stamp1;
        private DevExpress.XtraGrid.Columns.GridColumn coltag2;
        private DevExpress.XtraGrid.Columns.GridColumn colpartnumber2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao12;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao21;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposito1;
        private DevExpress.XtraGrid.Columns.GridColumn colprateleira1;
    }
}

