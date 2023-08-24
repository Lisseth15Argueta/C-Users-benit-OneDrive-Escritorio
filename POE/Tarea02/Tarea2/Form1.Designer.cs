namespace Tarea2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListElectrodomestico = new System.Windows.Forms.ListBox();
            this.AgregarElectrodomesticoButton = new System.Windows.Forms.Button();
            this.electrodomesticoLabel = new System.Windows.Forms.Label();
            this.EliminarElectrodomesticoButton = new System.Windows.Forms.Button();
            this.electrodometicoLabel = new System.Windows.Forms.Label();
            this.ListClientes = new System.Windows.Forms.ListBox();
            this.ListVentas = new System.Windows.Forms.ListBox();
            this.AgregarClienteButton = new System.Windows.Forms.Button();
            this.RealizarVentaButton = new System.Windows.Forms.Button();
            this.EliminarClienteButton = new System.Windows.Forms.Button();
            this.EliminarVentaButton = new System.Windows.Forms.Button();
            this.textBoxNombreElectrodomestico = new System.Windows.Forms.TextBox();
            this.textBoxPrecioElectrodomestico = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListElectrodomestico
            // 
            this.ListElectrodomestico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListElectrodomestico.FormattingEnabled = true;
            this.ListElectrodomestico.ItemHeight = 28;
            this.ListElectrodomestico.Items.AddRange(new object[] {
            "Plancha",
            "Licuadora",
            "Tostodor",
            "Cafetera"});
            this.ListElectrodomestico.Location = new System.Drawing.Point(12, 12);
            this.ListElectrodomestico.Name = "ListElectrodomestico";
            this.ListElectrodomestico.Size = new System.Drawing.Size(246, 172);
            this.ListElectrodomestico.TabIndex = 0;
            // 
            // AgregarElectrodomesticoButton
            // 
            this.AgregarElectrodomesticoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgregarElectrodomesticoButton.Location = new System.Drawing.Point(25, 202);
            this.AgregarElectrodomesticoButton.Name = "AgregarElectrodomesticoButton";
            this.AgregarElectrodomesticoButton.Size = new System.Drawing.Size(198, 71);
            this.AgregarElectrodomesticoButton.TabIndex = 2;
            this.AgregarElectrodomesticoButton.Text = "Agregar Electrodomestico";
            this.AgregarElectrodomesticoButton.UseVisualStyleBackColor = true;
            this.AgregarElectrodomesticoButton.Click += new System.EventHandler(this.AgregarElectrodomesticoButton_Click);
            // 
            // electrodomesticoLabel
            // 
            this.electrodomesticoLabel.AutoSize = true;
            this.electrodomesticoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.electrodomesticoLabel.Location = new System.Drawing.Point(25, 202);
            this.electrodomesticoLabel.Name = "electrodomesticoLabel";
            this.electrodomesticoLabel.Size = new System.Drawing.Size(12, 56);
            this.electrodomesticoLabel.TabIndex = 3;
            this.electrodomesticoLabel.Text = "\r\n\r\n";
            this.electrodomesticoLabel.StyleChanged += new System.EventHandler(this.electrodomesticoLabel_StyleChanged);
            // 
            // EliminarElectrodomesticoButton
            // 
            this.EliminarElectrodomesticoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EliminarElectrodomesticoButton.Location = new System.Drawing.Point(25, 288);
            this.EliminarElectrodomesticoButton.Name = "EliminarElectrodomesticoButton";
            this.EliminarElectrodomesticoButton.Size = new System.Drawing.Size(189, 84);
            this.EliminarElectrodomesticoButton.TabIndex = 4;
            this.EliminarElectrodomesticoButton.Text = "Eliminar Electrodomestico";
            this.EliminarElectrodomesticoButton.UseVisualStyleBackColor = true;
            this.EliminarElectrodomesticoButton.Click += new System.EventHandler(this.EliminarElectrodomesticoButton_Click);
            // 
            // electrodometicoLabel
            // 
            this.electrodometicoLabel.AutoSize = true;
            this.electrodometicoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.electrodometicoLabel.Location = new System.Drawing.Point(35, 217);
            this.electrodometicoLabel.Name = "electrodometicoLabel";
            this.electrodometicoLabel.Size = new System.Drawing.Size(0, 28);
            this.electrodometicoLabel.TabIndex = 5;
            this.electrodometicoLabel.StyleChanged += new System.EventHandler(this.electrodometicoLabel_StyleChanged);
            // 
            // ListClientes
            // 
            this.ListClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListClientes.FormattingEnabled = true;
            this.ListClientes.ItemHeight = 28;
            this.ListClientes.Location = new System.Drawing.Point(299, 12);
            this.ListClientes.Name = "ListClientes";
            this.ListClientes.Size = new System.Drawing.Size(246, 172);
            this.ListClientes.TabIndex = 6;
            // 
            // ListVentas
            // 
            this.ListVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListVentas.FormattingEnabled = true;
            this.ListVentas.ItemHeight = 28;
            this.ListVentas.Location = new System.Drawing.Point(632, 12);
            this.ListVentas.Name = "ListVentas";
            this.ListVentas.Size = new System.Drawing.Size(246, 172);
            this.ListVentas.TabIndex = 7;
            // 
            // AgregarClienteButton
            // 
            this.AgregarClienteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgregarClienteButton.Location = new System.Drawing.Point(331, 190);
            this.AgregarClienteButton.Name = "AgregarClienteButton";
            this.AgregarClienteButton.Size = new System.Drawing.Size(178, 56);
            this.AgregarClienteButton.TabIndex = 8;
            this.AgregarClienteButton.Text = "Agregar Cliente";
            this.AgregarClienteButton.UseVisualStyleBackColor = true;
            this.AgregarClienteButton.Click += new System.EventHandler(this.AgregarClienteButton_Click);
            // 
            // RealizarVentaButton
            // 
            this.RealizarVentaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RealizarVentaButton.Location = new System.Drawing.Point(647, 209);
            this.RealizarVentaButton.Name = "RealizarVentaButton";
            this.RealizarVentaButton.Size = new System.Drawing.Size(198, 56);
            this.RealizarVentaButton.TabIndex = 9;
            this.RealizarVentaButton.Text = "Realizar Venta";
            this.RealizarVentaButton.UseVisualStyleBackColor = true;
            this.RealizarVentaButton.Click += new System.EventHandler(this.RealizarVentaButton_Click);
            // 
            // EliminarClienteButton
            // 
            this.EliminarClienteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EliminarClienteButton.Location = new System.Drawing.Point(329, 252);
            this.EliminarClienteButton.Name = "EliminarClienteButton";
            this.EliminarClienteButton.Size = new System.Drawing.Size(180, 53);
            this.EliminarClienteButton.TabIndex = 10;
            this.EliminarClienteButton.Text = "Eliminar Cliente";
            this.EliminarClienteButton.UseVisualStyleBackColor = true;
            this.EliminarClienteButton.Click += new System.EventHandler(this.EliminarClienteButton_Click);
            // 
            // EliminarVentaButton
            // 
            this.EliminarVentaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EliminarVentaButton.Location = new System.Drawing.Point(691, 284);
            this.EliminarVentaButton.Name = "EliminarVentaButton";
            this.EliminarVentaButton.Size = new System.Drawing.Size(110, 44);
            this.EliminarVentaButton.TabIndex = 11;
            this.EliminarVentaButton.Text = "Eliminar Venta";
            this.EliminarVentaButton.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreElectrodomestico
            // 
            this.textBoxNombreElectrodomestico.Location = new System.Drawing.Point(35, 378);
            this.textBoxNombreElectrodomestico.Multiline = true;
            this.textBoxNombreElectrodomestico.Name = "textBoxNombreElectrodomestico";
            this.textBoxNombreElectrodomestico.Size = new System.Drawing.Size(150, 49);
            this.textBoxNombreElectrodomestico.TabIndex = 12;
            // 
            // textBoxPrecioElectrodomestico
            // 
            this.textBoxPrecioElectrodomestico.Location = new System.Drawing.Point(348, 320);
            this.textBoxPrecioElectrodomestico.Multiline = true;
            this.textBoxPrecioElectrodomestico.Name = "textBoxPrecioElectrodomestico";
            this.textBoxPrecioElectrodomestico.Size = new System.Drawing.Size(150, 49);
            this.textBoxPrecioElectrodomestico.TabIndex = 13;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(348, 389);
            this.textBoxNombreCliente.Multiline = true;
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(150, 49);
            this.textBoxNombreCliente.TabIndex = 14;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(675, 378);
            this.textBoxCantidad.Multiline = true;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(150, 49);
            this.textBoxCantidad.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.textBoxPrecioElectrodomestico);
            this.Controls.Add(this.textBoxNombreElectrodomestico);
            this.Controls.Add(this.EliminarVentaButton);
            this.Controls.Add(this.EliminarClienteButton);
            this.Controls.Add(this.RealizarVentaButton);
            this.Controls.Add(this.AgregarClienteButton);
            this.Controls.Add(this.ListVentas);
            this.Controls.Add(this.ListClientes);
            this.Controls.Add(this.electrodometicoLabel);
            this.Controls.Add(this.EliminarElectrodomesticoButton);
            this.Controls.Add(this.electrodomesticoLabel);
            this.Controls.Add(this.AgregarElectrodomesticoButton);
            this.Controls.Add(this.ListElectrodomestico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListElectrodomestico;
        private Button AgregarElectrodomesticoButton;
        private Label electrodomesticoLabel;
        private Button EliminarElectrodomesticoButton;
        private Label electrodometicoLabel;
        private ListBox ListClientes;
        private ListBox ListVentas;
        private Button AgregarClienteButton;
        private Button RealizarVentaButton;
        private Button EliminarClienteButton;
        private Button EliminarVentaButton;
        private TextBox textBoxNombreElectrodomestico;
        private TextBox textBoxPrecioElectrodomestico;
        private TextBox textBoxNombreCliente;
        private TextBox textBoxCantidad;
    }
}