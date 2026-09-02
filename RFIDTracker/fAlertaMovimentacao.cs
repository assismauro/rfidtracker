using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RFIDTracker
{
    public partial class fAlertaMovimentacao : DevExpress.XtraEditors.XtraForm
    {
        public fAlertaMovimentacao()
        {
            InitializeComponent();
        }
        private int x, y;

        private void timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void lcMensagem_TextChanged(object sender, EventArgs e)
        {
            lcMensagem.Visible = lcMensagem.Text != string.Empty;
        }

        public void ShowAlert(string produto, string deposito, string item, string mensagem)
        {
            lcProduto.Text = produto;
            lcDeposito.Text = deposito;
            lcItem.Text = item;
            lcMensagem.Text = mensagem;
            this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Location = new Point(this.x, this.y);
            this.Opacity = 0;
            this.Show();
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(20);
                this.Opacity = i * .01;
                Application.DoEvents();
                /*
                StartPosition = FormStartPosition.Manual;
                string fname;
                for (int i = 0; i < 10; i++)
                {
                    fname = "altert" + i.ToString();
                    fAlertaMovimentacao frm = (fAlertaMovimentacao)Application.OpenForms[fname];
                    if (frm == null)
                    {
                        this.Name = fname;
                        this.x = Screen.PrimaryScreen.WorkingArea.Width -this.Height + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Width - this.Height * i;
                        this.Location = new Point(this.x, this.y);
                        break;
                    }
                }
                */
            }
            this.TopMost = true;
            this.timer.Start();
        }
    }
}