namespace WindowsFormsApp1
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
            this.busquedaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarYModificarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.busquedaDeArticulosToolStripMenuItem,
            this.agregarYModificarArticulosToolStripMenuItem});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articuloToolStripMenuItem.Text = "Articulos";
            // 
            // busquedaDeArticulosToolStripMenuItem
            // 
            this.busquedaDeArticulosToolStripMenuItem.Name = "busquedaDeArticulosToolStripMenuItem";
            this.busquedaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.busquedaDeArticulosToolStripMenuItem.Text = "Listado de articulos";
            this.busquedaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeArticulosToolStripMenuItem_Click);
            // 
            // agregarYModificarArticulosToolStripMenuItem
            // 
            this.agregarYModificarArticulosToolStripMenuItem.Name = "agregarYModificarArticulosToolStripMenuItem";
            this.agregarYModificarArticulosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarYModificarArticulosToolStripMenuItem.Text = "Agregar y modificar articulos";
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
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
        private System.Windows.Forms.ToolStripMenuItem busquedaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarYModificarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCategoriasToolStripMenuItem;
    }
}

