using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicadeNegocios;


namespace ProyectoBases2018
{
    public partial class LogIn_UASJ : Form
    {
        public LogIn_UASJ()
        {
            InitializeComponent();
        }

        private void LogIn_UASJ_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            var loggin = new LogicadeNegocios.Login();
            string log, pas;
            log = txt_login.Text;
            pas = txt_pass.Text;

            if (!loggin.loggin(log,pas))
            {
                MessageBox.Show("Conexion Exitosa");
                PrincipalUASJ G = new PrincipalUASJ();
            }
            else
            {
                MessageBox.Show("Conexion Fallida");
            }

         
        }
    }
}
