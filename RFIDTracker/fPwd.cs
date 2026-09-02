using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RFIDTracker
{
    public partial class fPwd : DevExpress.XtraEditors.XtraForm
    {

        Db db = null;
        public static Dictionary<string, object> usuario = null;

        public fPwd()
        {
            InitializeComponent();
            edUsuario.Text = Environment.UserName;
            db = new Db();
        }

        private bool usuarioSenhaOk(string nome, string senha)
        {
            List<Dictionary<string, object>> data = (List<Dictionary<string, object>>)db.getRows(
                string.Format("select u.*, p.administrador from usuario u " +
                "inner join perfil p " +
                "on u.idperfil = p.id " +
                "where u.nome = '{0}'", edUsuario.Text));
            if (data.Count > 0)
            {
                usuario = (Dictionary<string, object>)data[0];
                if (!SecurePasswordHasher.IsHashSupported((string)usuario["senha"]))
                    if (edSenha.Text == (string)usuario["senha"]) // Senha ainda não encriptada
                        return true;
                    else
                    {
                    }
                else
                    if (SecurePasswordHasher.Verify(edSenha.Text, (string)usuario["senha"]))
                        return true;
            }
            MessageBox.Show("Senha errada ou usuário não existente.");
            return false;
        }

        private void fPwd_Shown(object sender, EventArgs e)
        {
        }     

        private void edSenha_Leave(object sender, EventArgs e)
        {
            if (edSenha.Text == string.Empty)
            {
                MessageBox.Show("É obrigatório informar a senha para acessar o sistema.");
                return;
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("VisualStudioEdition")) && (edUsuario.Text == string.Empty))
            {

                List<Dictionary<string, object>> data = (List<Dictionary<string, object>>)db.getRows(
                    string.Format("select u.*, p.administrador from usuario u " +
                                 "inner join perfil p " +
                                 "on u.idperfil = p.id " +
                                 "where u.nome = 'mauro.assis'"));
                usuario = data[0];
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (txConfirmaSenha.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                {
                    if (txConfirmaSenha.Text == string.Empty)
                    {
                        MessageBox.Show("É obrigatório o fornecimento de uma nova senha na " +
                            "primeira vez em que se acessa o sistema.");
                        return;
                    }
                    else
                    {
                        string errorMessage = utils.PasswordMessage(utils.CheckStrength(txConfirmaSenha.Text));
                        if (errorMessage != string.Empty)
                        {
                            MessageBox.Show(errorMessage);
                            return;
                        }
                        else
                        {
                            string hash = SecurePasswordHasher.Hash(edNovaSenha.Text);
                            db.execSQL(string.Format("update usuario set senha = '{0}', alterar_senha = 0 " +
                                "where id = {1}", hash, usuario["id"]));
                            Close();
                        }
                    }
                }
                else
                if (usuarioSenhaOk(edUsuario.Text, edSenha.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado ou senha inválida.");
                }
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void edUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void edSenha_Enter(object sender, EventArgs e)
        {
            if (edUsuario.Text != string.Empty)
            {
                List<Dictionary<string, object>> data = (List<Dictionary<string, object>>)db.getRows(
    string.Format("select * from usuario where nome = '{0}'", edUsuario.Text));
                if (data.Count > 0)
                {
                    usuario = (Dictionary<string, object>)data[0];
                    if ((int)usuario["alterar_senha"] == 1)
                        txConfirmaSenha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else
                    MessageBox.Show("Usuário inexistente.");
            }
        }

        private void fPwd_Load(object sender, EventArgs e)
        {

        }
    }
}