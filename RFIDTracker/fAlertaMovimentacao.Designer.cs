namespace RFIDTracker
{
    partial class fAlertaMovimentacao
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lcItem = new DevExpress.XtraEditors.LabelControl();
            this.lcDeposito = new DevExpress.XtraEditors.LabelControl();
            this.lcProduto = new DevExpress.XtraEditors.LabelControl();
            this.lcUsuario = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lcMensagem = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Produto:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Depósito:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ítem:";
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lcItem
            // 
            this.lcItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcItem.Appearance.Options.UseForeColor = true;
            this.lcItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lcItem.Location = new System.Drawing.Point(68, 74);
            this.lcItem.Name = "lcItem";
            this.lcItem.Size = new System.Drawing.Size(26, 16);
            this.lcItem.TabIndex = 5;
            this.lcItem.Text = "Ítem";
            // 
            // lcDeposito
            // 
            this.lcDeposito.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcDeposito.Appearance.Options.UseForeColor = true;
            this.lcDeposito.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lcDeposito.Location = new System.Drawing.Point(68, 42);
            this.lcDeposito.Name = "lcDeposito";
            this.lcDeposito.Size = new System.Drawing.Size(49, 16);
            this.lcDeposito.TabIndex = 4;
            this.lcDeposito.Text = "Depósito";
            // 
            // lcProduto
            // 
            this.lcProduto.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcProduto.Appearance.Options.UseForeColor = true;
            this.lcProduto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lcProduto.Location = new System.Drawing.Point(68, 13);
            this.lcProduto.Name = "lcProduto";
            this.lcProduto.Size = new System.Drawing.Size(44, 16);
            this.lcProduto.TabIndex = 3;
            this.lcProduto.Text = "Produto";
            // 
            // lcUsuario
            // 
            this.lcUsuario.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcUsuario.Appearance.Options.UseForeColor = true;
            this.lcUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lcUsuario.Location = new System.Drawing.Point(68, 101);
            this.lcUsuario.Name = "lcUsuario";
            this.lcUsuario.Size = new System.Drawing.Size(26, 16);
            this.lcUsuario.TabIndex = 7;
            this.lcUsuario.Text = "Ítem";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 101);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 16);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Usuário:";
            // 
            // lcMensagem
            // 
            this.lcMensagem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lcMensagem.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcMensagem.Appearance.Options.UseFont = true;
            this.lcMensagem.Appearance.Options.UseForeColor = true;
            this.lcMensagem.Location = new System.Drawing.Point(13, 130);
            this.lcMensagem.Name = "lcMensagem";
            this.lcMensagem.Size = new System.Drawing.Size(79, 18);
            this.lcMensagem.TabIndex = 8;
            this.lcMensagem.Text = "Mensagem";
            this.lcMensagem.Visible = false;
            this.lcMensagem.TextChanged += new System.EventHandler(this.lcMensagem_TextChanged);
            // 
            // fAlertaMovimentacao
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(290, 158);
            this.Controls.Add(this.lcMensagem);
            this.Controls.Add(this.lcUsuario);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lcItem);
            this.Controls.Add(this.lcDeposito);
            this.Controls.Add(this.lcProduto);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1200, 700);
            this.Name = "fAlertaMovimentacao";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alterta de Movimentação";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.LabelControl lcItem;
        private DevExpress.XtraEditors.LabelControl lcDeposito;
        private DevExpress.XtraEditors.LabelControl lcProduto;
        private DevExpress.XtraEditors.LabelControl lcUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lcMensagem;
    }
}