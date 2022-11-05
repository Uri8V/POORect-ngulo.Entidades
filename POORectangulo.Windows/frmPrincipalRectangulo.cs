using POORectángulo.Datos;
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
    public partial class frmPrincipalRectangulo : Form
    {   //Variable para controlar los cambios
        bool HayCambios = false;
        public frmPrincipalRectangulo()
        {
            InitializeComponent();
        }
        private List<Rectangulo> Lista;
        private RepositorioDeRectangulos repo;
        private int Cantidad;

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipalRectangulo_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeRectangulos();
            Lista = repo.GetLista();
            Cantidad = repo.GatCantidad();
            if (Cantidad > 0)
            {
                MostrarLista();
            }
            else
            {
                MessageBox.Show("El Repositorio esta vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MostrarTotal();
        }

        private void MostrarLista()
        {
            RectanguloDataGridView.Rows.Clear();
            foreach (var Rectangulo in Lista)
            {
                var r = ConstruirFila();
                SetearFila(r, Rectangulo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            RectanguloDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Rectangulo rectangulo)
        {
            r.Cells[colRectanguloAlto.Index].Value = rectangulo.Alto;
            r.Cells[colRectanguloBase.Index].Value = rectangulo.Largo;
            r.Cells[colArea.Index].Value = rectangulo.GetArea().ToString();
            r.Cells[colPerimetro.Index].Value = rectangulo.GetPerimetro().ToString();
            
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow ();
            r.CreateCells(RectanguloDataGridView);
            return r;
        }

        private void MostrarTotal()
        {
            CantidadLabel.Text = Cantidad.ToString();
        }

        private void RectanguloDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarLista();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmNuevoRectangulo frm = new frmNuevoRectangulo() { Text = "Agregar nuevo rectangulo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("El usuario canceló");
                return;
            }
            var RectNuevo = frm.GetRectangulo();
            repo.Agregar(RectNuevo);
            var r = ConstruirFila();
            SetearFila(r, RectNuevo);
            AgregarFila(r);
            MessageBox.Show("Rectangulo agregado");
            Cantidad = repo.GatCantidad();
            HayCambios = true;
            MostrarTotal();
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            if (HayCambios)
            {
                ManejadorArchivosSecuencial.GuardarEnArchivosSecuencial(Lista);
            }

            DialogResult dr = MessageBox.Show("¿Desea salir del programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            //Veo si tengo seleccionada alguna fila
            if (RectanguloDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            //Si seleccione alguna fila
            var r = RectanguloDataGridView.SelectedRows[0];
            Rectangulo rect = r.Tag as Rectangulo;
            DialogResult dr = MessageBox.Show("¿Desea eliminar la fila?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                MessageBox.Show("El usuario se arreointió");
                return;
            }

            if (repo.Borrar(rect))
            {
               repo.Borrar(rect);//El repo borra el Rect
               Lista.Remove(rect);//La saco de la lista de memoria
               RectanguloDataGridView.Rows.Remove(r);//La saco de la Grilla
               Cantidad = repo.GatCantidad();
                HayCambios = true;
               MostrarTotal();
               MessageBox.Show("Rectangulo eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo dar de baja", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
                
            
           
        }

        private void RestaurarToolStripButton_Click(object sender, EventArgs e)
        {
            Lista = repo.GetLista();
            MostrarLista();
            Cantidad = repo.GatCantidad();
            MostrarTotal();
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (RectanguloDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = RectanguloDataGridView.SelectedRows[0];
            Rectangulo rect = r.Tag as Rectangulo;
            frmNuevoRectangulo frm = new frmNuevoRectangulo() { Text = "Editar Rectángulo" };
            frm.SetRectangulo(rect);
            DialogResult dr=frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            rect = frm.GetRectangulo();
            SetearFila(r, rect);
            HayCambios = true;
            MessageBox.Show("Rectangulo modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FiltrarToolStripButton_Click(object sender, EventArgs e)
        {
            int rectFiltro = 20;
            Lista = repo.FiltrarDatos(rectFiltro);
            MostrarLista();
            Cantidad = repo.GatCantidadFiltrada(rectFiltro);
            MostrarTotal();
            // PROFE no me aparecen las referencias en Explorador de Soluciones
            //Solo las dependencias, por eso no seguí con lo del boton FILTRAR
            //No aparecia el ensamblado
            //var RactanguloString=Microsoft.VisualBasic.Interaction("Ingrese el valor del Rectangulo", "Rectangulo filtro", "0", 400, 400);
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            ManejadorArchivosSecuencial.GuardarEnArchivosSecuencial(repo.GetLista());
            MessageBox.Show("Registros Guardados", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
