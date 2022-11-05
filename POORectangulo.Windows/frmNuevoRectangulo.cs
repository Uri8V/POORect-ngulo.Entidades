using POORectángulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POORectangulo.Windows
{
    public partial class frmNuevoRectangulo : Form
    {
        public frmNuevoRectangulo()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (rectangulo != null)
            {
                BaseTextBox.Text = rectangulo.Largo.ToString();
                AltoTextBox.Text = rectangulo.Alto.ToString();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Rectangulo rectangulo;

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                //Veo si no existe ya un rectangulo
                if (rectangulo == null)
                {
                    rectangulo = new Rectangulo();
                }
                rectangulo.Alto = int.Parse(AltoTextBox.Text);
                rectangulo.Largo = int.Parse(BaseTextBox.Text);
                DialogResult = DialogResult.OK;
            }
            
        }

        private bool Validardatos()
        {
            bool valido = true;
            ErroresErrorProvider.Clear();
            if (!int.TryParse(AltoTextBox.Text, out int rectangulo))
            {
                ErroresErrorProvider.SetError(AltoTextBox, "El alto del Rectángulo debe ser entero");
                valido = false;
            }
            else if (!int.TryParse(BaseTextBox.Text, out rectangulo))
            {
                valido = false;
                ErroresErrorProvider.SetError(BaseTextBox, "La base del Rectángulo debe ser entero");
            }
            //else if (AltoTextBox==BaseTextBox)
            //{
            //    valido = false;
            //    ErroresErrorProvider.SetError(AltoTextBox, "La altura ingresada no puede ser igual a la base");
            //    ErroresErrorProvider.SetError(BaseTextBox, "La base ingresada no puede ser igual a la altura");
            //}
            else if (rectangulo <= 0)
            {
                ErroresErrorProvider.SetError(BaseTextBox, "La base debe ser mayor a 0");
                ErroresErrorProvider.SetError(AltoTextBox, "El alto debe ser mayor a 0");
                valido=false;
            }
            return valido;
        }
        internal Rectangulo GetRectangulo()
        {
            return rectangulo;
        }

        internal void SetRectangulo(Rectangulo rect)
        {
            rectangulo = rect;
        }
    }
}
