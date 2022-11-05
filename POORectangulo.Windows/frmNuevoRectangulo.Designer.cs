
namespace POORectangulo.Windows
{
    partial class frmNuevoRectangulo
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
            this.BaseLabel = new System.Windows.Forms.Label();
            this.AltoLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BaseTextBox = new System.Windows.Forms.TextBox();
            this.AltoTextBox = new System.Windows.Forms.TextBox();
            this.ErroresErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Location = new System.Drawing.Point(30, 39);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(116, 15);
            this.BaseLabel.TabIndex = 0;
            this.BaseLabel.Text = "Base del Rectángulo:";
            // 
            // AltoLabel
            // 
            this.AltoLabel.AutoSize = true;
            this.AltoLabel.Location = new System.Drawing.Point(30, 75);
            this.AltoLabel.Name = "AltoLabel";
            this.AltoLabel.Size = new System.Drawing.Size(114, 15);
            this.AltoLabel.TabIndex = 1;
            this.AltoLabel.Text = "Alto del Rectángulo:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(30, 127);
            this.OKButton.MaximumSize = new System.Drawing.Size(74, 49);
            this.OKButton.MinimumSize = new System.Drawing.Size(74, 49);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(74, 49);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(189, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(73, 50);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BaseTextBox
            // 
            this.BaseTextBox.Location = new System.Drawing.Point(153, 30);
            this.BaseTextBox.Name = "BaseTextBox";
            this.BaseTextBox.Size = new System.Drawing.Size(100, 23);
            this.BaseTextBox.TabIndex = 4;
            // 
            // AltoTextBox
            // 
            this.AltoTextBox.Location = new System.Drawing.Point(151, 66);
            this.AltoTextBox.Name = "AltoTextBox";
            this.AltoTextBox.Size = new System.Drawing.Size(100, 23);
            this.AltoTextBox.TabIndex = 5;
            // 
            // ErroresErrorProvider
            // 
            this.ErroresErrorProvider.ContainerControl = this;
            // 
            // frmNuevoRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 199);
            this.ControlBox = false;
            this.Controls.Add(this.AltoTextBox);
            this.Controls.Add(this.BaseTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AltoLabel);
            this.Controls.Add(this.BaseLabel);
            this.Name = "frmNuevoRectangulo";
            this.Text = "frmNuevoRectangulo";
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.Label AltoLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox BaseTextBox;
        private System.Windows.Forms.TextBox AltoTextBox;
        private System.Windows.Forms.ErrorProvider ErroresErrorProvider;
    }
}