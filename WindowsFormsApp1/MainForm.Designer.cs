namespace Vista
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarYModificarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListadoDeArticulosToolStripMenuItem,
            this.AgregarYModificarArticulosToolStripMenuItem});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articuloToolStripMenuItem.Text = "Articulos";
            // 
            // ListadoDeArticulosToolStripMenuItem
            // 
            this.ListadoDeArticulosToolStripMenuItem.Name = "ListadoDeArticulosToolStripMenuItem";
            this.ListadoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ListadoDeArticulosToolStripMenuItem.Text = "Listado de articulos";
            this.ListadoDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.ListadoDeArticulosToolStripMenuItem_Click);
            // 
            // AgregarYModificarArticulosToolStripMenuItem
            // 
            this.AgregarYModificarArticulosToolStripMenuItem.Name = "AgregarYModificarArticulosToolStripMenuItem";
            this.AgregarYModificarArticulosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.AgregarYModificarArticulosToolStripMenuItem.Text = "Agregar y modificar articulos";
            this.AgregarYModificarArticulosToolStripMenuItem.Click += new System.EventHandler(this.AgregarYModificarArticulosToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeMarcasToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcaToolStripMenuItem.Text = "Marcas";
            // 
            // listadoDeMarcasToolStripMenuItem
            // 
            this.listadoDeMarcasToolStripMenuItem.Name = "listadoDeMarcasToolStripMenuItem";
            this.listadoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listadoDeMarcasToolStripMenuItem.Text = "Listado de marcas";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCategoriasToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            // 
            // listadoDeCategoriasToolStripMenuItem
            // 
            this.listadoDeCategoriasToolStripMenuItem.Name = "listadoDeCategoriasToolStripMenuItem";
            this.listadoDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeCategoriasToolStripMenuItem.Text = "Listado de categorias";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(240, 186);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(309, 79);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Bienvenido, seleccione una de las opciones de menu superior para empezar a gestio" +
    "nar";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListadoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarYModificarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.Label lblMensaje;
    }
}

