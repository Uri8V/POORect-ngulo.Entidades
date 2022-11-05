
namespace POORectangulo.Windows
{
    partial class frmPrincipalRectangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalRectangulo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RestaurarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RectanguloDataGridView = new System.Windows.Forms.DataGridView();
            this.colRectanguloAlto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRectanguloBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectanguloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CantidadLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 100);
            this.panel1.TabIndex = 0;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CantidadLabel.Location = new System.Drawing.Point(199, 38);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(14, 15);
            this.CantidadLabel.TabIndex = 1;
            this.CantidadLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Rectángulos:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.FiltrarToolStripButton,
            this.SalirToolStripButton,
            this.RestaurarToolStripButton,
            this.GuardarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 22);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FiltrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarToolStripButton.Image")));
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.Click += new System.EventHandler(this.FiltrarToolStripButton_Click);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SalirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.SalirToolStripButton.Text = "SALIR";
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // RestaurarToolStripButton
            // 
            this.RestaurarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RestaurarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarToolStripButton.Image")));
            this.RestaurarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestaurarToolStripButton.Name = "RestaurarToolStripButton";
            this.RestaurarToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.RestaurarToolStripButton.Text = "Restaurar";
            this.RestaurarToolStripButton.Click += new System.EventHandler(this.RestaurarToolStripButton_Click);
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GuardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripButton.Image")));
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.GuardarToolStripButton.Text = "Guardar";
            this.GuardarToolStripButton.Click += new System.EventHandler(this.GuardarToolStripButton_Click);
            // 
            // RectanguloDataGridView
            // 
            this.RectanguloDataGridView.AllowUserToAddRows = false;
            this.RectanguloDataGridView.AllowUserToDeleteRows = false;
            this.RectanguloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RectanguloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRectanguloAlto,
            this.colRectanguloBase,
            this.colArea,
            this.colPerimetro});
            this.RectanguloDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanguloDataGridView.Location = new System.Drawing.Point(0, 25);
            this.RectanguloDataGridView.Name = "RectanguloDataGridView";
            this.RectanguloDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrchid;
            this.RectanguloDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RectanguloDataGridView.RowTemplate.Height = 25;
            this.RectanguloDataGridView.Size = new System.Drawing.Size(705, 280);
            this.RectanguloDataGridView.TabIndex = 4;
            // 
            // colRectanguloAlto
            // 
            this.colRectanguloAlto.HeaderText = "Rectangulo(Alto)";
            this.colRectanguloAlto.Name = "colRectanguloAlto";
            this.colRectanguloAlto.ReadOnly = true;
            // 
            // colRectanguloBase
            // 
            this.colRectanguloBase.HeaderText = "Rectangulo(base)";
            this.colRectanguloBase.Name = "colRectanguloBase";
            this.colRectanguloBase.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Area";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // frmPrincipalRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 405);
            this.ControlBox = false;
            this.Controls.Add(this.RectanguloDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(721, 444);
            this.MinimumSize = new System.Drawing.Size(721, 444);
            this.Name = "frmPrincipalRectangulo";
            this.Text = "frmPrincipalRectangulo";
            this.Load += new System.EventHandler(this.frmPrincipalRectangulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectanguloDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridView RectanguloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRectanguloAlto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRectanguloBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.ToolStripButton RestaurarToolStripButton;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
    }
}