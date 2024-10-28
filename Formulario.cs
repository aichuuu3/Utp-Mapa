using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace UTPMaps
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            btnIngresar.Enabled = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form1 ventanaMapa = new Form1();
            ventanaMapa.Show(); 
            this.Hide();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);

            // Valida la dirección de correo electrónico ingresada.
            if (!emailRegex.IsMatch(tbEmail.Text))
            {
                btnIngresar.Visible = false;
                errorProvider1.SetError(tbEmail, "La dirección de correo electrónico no es válida.");
                e.Cancel = true; // Cancela el evento si la validación falla
            }
            else
            {
                btnIngresar.Visible = true;
                errorProvider1.SetError(tbEmail, string.Empty); // Limpia el error si la validación pasa
            }
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = tbContraseña.Text;
            if (IsValidInput(tbContraseña.Text))
            {
                btnIngresar.Enabled = true;
                lbError.Text = ""; // Limpiar mensaje de error
            }
            else
            {
                    btnIngresar.Enabled = false;
                    lbError.Text = "Entrada no válida. Por favor corrige.";
            }
        }
        private bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        private void tbContraseña_Validating(object sender, CancelEventArgs e)
        {
            string contraseña = tbContraseña.Text;
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                btnIngresar.Enabled = false;
                errorProvider2.SetError(tbContraseña, "El campo no puede estar vacío.");
                e.Cancel = true;
            }
            else
            {
                btnIngresar.Enabled = true;
                errorProvider2.SetError(tbContraseña, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
