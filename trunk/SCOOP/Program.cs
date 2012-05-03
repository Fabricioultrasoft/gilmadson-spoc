using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;
using SCOOP.Properties;
using SCOOP.GUI;

namespace SCOOP
{
    static class Program
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        // Counter is an integer that help us to fix the number of seconds during them the Splash form is displayed

        static int counter = 0;

        // b is a boolean related to the event if the Spalsh form will be disposed or not

        static bool b = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (VerificarConexao())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                // New instance of Form2

                SplashScreen oForm2 = new SplashScreen();

                //Add event handler to myTimer.Tick event

                myTimer.Tick += new EventHandler(myTimer_Tick);

                //Fix myTimer interval to 1000 witch is 1 second

                myTimer.Interval = 1000;

                //Start myTimer

                myTimer.Start();

                /* This is the conditional loop during it the Form2 will appear as Splash form */

                while (b == false)
                {

                    //Display oForm2

                    oForm2.Show();

                    /*This is very important to add this line of code because it is responsable for

                     dispalying oForm2 during the time provided to this action*/

                    Application.DoEvents();

                    if (b == true)
                    {

                        /*Disposing oForm2 when the time is out */

                        oForm2.Dispose();

                        /*Going out of this while loop*/

                        break;

                    }



                }
                Login login = new Login();

                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Principal());
                }
            }
            else
            {
                MessageBox.Show("Erro ao conectar com o banco de dados!\n Verifique sua Rede!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        static void myTimer_Tick(Object sender, EventArgs e)
        {

            // Stop the timer

            myTimer.Stop();

            /* Here we chose 4 seconds or a little more to dispaly the splash form oForm2, and then to dispose it */

            if (counter < 4)
            {

                // Enable the counter

                myTimer.Enabled = true;

                // Increment the counter

                counter++;

            }

            // The condition related to witch the Spalsh form will be disposed

            if (counter == 4) b = true;



        }

        public static bool VerificarConexao()
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Settings.Default.SCOOPConnectionString.ToString());

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
