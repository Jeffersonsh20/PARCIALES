
namespace Parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.buttonPromedioparciall = new System.Windows.Forms.Button();
            this.buttonPromedioporSeccion = new System.Windows.Forms.Button();
            this.buttonPromedioGeneralSeccion = new System.Windows.Forms.Button();
            this.buttonClasificaciondeAlunmos = new System.Windows.Forms.Button();
            this.buttonNotaGeneralMayor = new System.Windows.Forms.Button();
            this.buttonNOTAMAYOR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(742, 28);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(427, 388);
            this.listBoxResultado.TabIndex = 0;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(216, 23);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(327, 404);
            this.textBoxResultado.TabIndex = 1;
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.BackColor = System.Drawing.Color.Red;
            this.buttonCargarArchivo.Location = new System.Drawing.Point(559, 183);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(168, 47);
            this.buttonCargarArchivo.TabIndex = 2;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = false;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // buttonPromedioparciall
            // 
            this.buttonPromedioparciall.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPromedioparciall.Location = new System.Drawing.Point(12, 38);
            this.buttonPromedioparciall.Name = "buttonPromedioparciall";
            this.buttonPromedioparciall.Size = new System.Drawing.Size(178, 77);
            this.buttonPromedioparciall.TabIndex = 3;
            this.buttonPromedioparciall.Text = "Promedio de Parcial";
            this.buttonPromedioparciall.UseVisualStyleBackColor = false;
            this.buttonPromedioparciall.Click += new System.EventHandler(this.buttonPromedioparciall_Click);
            // 
            // buttonPromedioporSeccion
            // 
            this.buttonPromedioporSeccion.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPromedioporSeccion.Location = new System.Drawing.Point(12, 199);
            this.buttonPromedioporSeccion.Name = "buttonPromedioporSeccion";
            this.buttonPromedioporSeccion.Size = new System.Drawing.Size(178, 71);
            this.buttonPromedioporSeccion.TabIndex = 4;
            this.buttonPromedioporSeccion.Text = "Promedio por Seccion";
            this.buttonPromedioporSeccion.UseVisualStyleBackColor = false;
            this.buttonPromedioporSeccion.Click += new System.EventHandler(this.buttonPromedioporSeccion_Click);
            // 
            // buttonPromedioGeneralSeccion
            // 
            this.buttonPromedioGeneralSeccion.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPromedioGeneralSeccion.Location = new System.Drawing.Point(33, 321);
            this.buttonPromedioGeneralSeccion.Name = "buttonPromedioGeneralSeccion";
            this.buttonPromedioGeneralSeccion.Size = new System.Drawing.Size(157, 78);
            this.buttonPromedioGeneralSeccion.TabIndex = 5;
            this.buttonPromedioGeneralSeccion.Text = "Promedio General Seccion";
            this.buttonPromedioGeneralSeccion.UseVisualStyleBackColor = false;
            this.buttonPromedioGeneralSeccion.Click += new System.EventHandler(this.buttonPromedioGeneralSeccion_Click);
            // 
            // buttonClasificaciondeAlunmos
            // 
            this.buttonClasificaciondeAlunmos.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonClasificaciondeAlunmos.Location = new System.Drawing.Point(269, 452);
            this.buttonClasificaciondeAlunmos.Name = "buttonClasificaciondeAlunmos";
            this.buttonClasificaciondeAlunmos.Size = new System.Drawing.Size(197, 88);
            this.buttonClasificaciondeAlunmos.TabIndex = 6;
            this.buttonClasificaciondeAlunmos.Text = "Clasificacion de Alunmos";
            this.buttonClasificaciondeAlunmos.UseVisualStyleBackColor = false;
            this.buttonClasificaciondeAlunmos.Click += new System.EventHandler(this.buttonClasificaciondeAlunmos_Click);
            // 
            // buttonNotaGeneralMayor
            // 
            this.buttonNotaGeneralMayor.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonNotaGeneralMayor.Location = new System.Drawing.Point(559, 452);
            this.buttonNotaGeneralMayor.Name = "buttonNotaGeneralMayor";
            this.buttonNotaGeneralMayor.Size = new System.Drawing.Size(194, 88);
            this.buttonNotaGeneralMayor.TabIndex = 7;
            this.buttonNotaGeneralMayor.Text = "Nota General Mayor";
            this.buttonNotaGeneralMayor.UseVisualStyleBackColor = false;
            this.buttonNotaGeneralMayor.Click += new System.EventHandler(this.buttonNotaGeneralMayor_Click);
            // 
            // buttonNOTAMAYOR
            // 
            this.buttonNOTAMAYOR.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonNOTAMAYOR.Location = new System.Drawing.Point(904, 452);
            this.buttonNOTAMAYOR.Name = "buttonNOTAMAYOR";
            this.buttonNOTAMAYOR.Size = new System.Drawing.Size(196, 88);
            this.buttonNOTAMAYOR.TabIndex = 8;
            this.buttonNOTAMAYOR.Text = "NOTA MAYOR";
            this.buttonNOTAMAYOR.UseVisualStyleBackColor = false;
            this.buttonNOTAMAYOR.Click += new System.EventHandler(this.buttonNOTAMAYOR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1199, 552);
            this.Controls.Add(this.buttonNOTAMAYOR);
            this.Controls.Add(this.buttonNotaGeneralMayor);
            this.Controls.Add(this.buttonClasificaciondeAlunmos);
            this.Controls.Add(this.buttonPromedioGeneralSeccion);
            this.Controls.Add(this.buttonPromedioporSeccion);
            this.Controls.Add(this.buttonPromedioparciall);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.Button buttonPromedioparciall;
        private System.Windows.Forms.Button buttonPromedioporSeccion;
        private System.Windows.Forms.Button buttonPromedioGeneralSeccion;
        private System.Windows.Forms.Button buttonClasificaciondeAlunmos;
        private System.Windows.Forms.Button buttonNotaGeneralMayor;
        private System.Windows.Forms.Button buttonNOTAMAYOR;
    }
}

