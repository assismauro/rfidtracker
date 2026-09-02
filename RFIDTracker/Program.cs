using System;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;
using DevExpress.UserSkins;
using DevExpress.Skins;
using RFIDTracker;

/*

 connectionString="Dsn=RFIDTracker;uid=rfidtracker;pwd=REDACTED"
 connectionString="REDACTED_ENCRYPTED_CONNECTION_STRING"

 */

namespace RFIDTracker
{
    static class Program
    {
        static bool loginOk()
        {
            fPwd fpwd = new fPwd();
            DialogResult dr = fpwd.ShowDialog();
            return dr == DialogResult.OK;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create a new object, representing the German culture. 
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");

            // The following line localizes the application's user interface. 
            Thread.CurrentThread.CurrentUICulture = culture;

            // The following line localizes data formats. 
            Thread.CurrentThread.CurrentCulture = culture;

            // Set this culture as the default culture for all threads in this application. 
            // Note: The following properties are supported in .NET Framework 4.5+:
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fMain fMain = new fMain();
            if (!loginOk())
                return;
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            fMain.Show();
            Application.Run();
        }
    }
}
