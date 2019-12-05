namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvBinario = new System.Windows.Forms.Button();
            this.btnConvDecimal = new System.Windows.Forms.Button();
            this.operador = new System.Windows.Forms.ComboBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(26, 140);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(170, 56);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(245, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 56);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(448, 140);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(170, 56);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvBinario
            // 
            this.btnConvBinario.Location = new System.Drawing.Point(26, 226);
            this.btnConvBinario.Name = "btnConvBinario";
            this.btnConvBinario.Size = new System.Drawing.Size(290, 56);
            this.btnConvBinario.TabIndex = 7;
            this.btnConvBinario.Text = "Convertir a Binario";
            this.btnConvBinario.UseVisualStyleBackColor = true;
            this.btnConvBinario.Click += new System.EventHandler(this.btnConvBinario_Click);
            // 
            // btnConvDecimal
            // 
            this.btnConvDecimal.Location = new System.Drawing.Point(328, 226);
            this.btnConvDecimal.Name = "btnConvDecimal";
            this.btnConvDecimal.Size = new System.Drawing.Size(290, 56);
            this.btnConvDecimal.TabIndex = 8;
            this.btnConvDecimal.Text = "Convertir a Decimal";
            this.btnConvDecimal.UseVisualStyleBackColor = true;
            this.btnConvDecimal.Click += new System.EventHandler(this.btnConvDecimal_Click);
            // 
            // operador
            // 
            this.operador.FormattingEnabled = true;
            this.operador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.operador.Location = new System.Drawing.Point(263, 63);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(120, 33);
            this.operador.TabIndex = 1;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(26, 63);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(170, 31);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(448, 63);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(150, 31);
            this.txtNumero2.TabIndex = 2;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(545, 23);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(53, 25);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "labe";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 314);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.btnConvDecimal);
            this.Controls.Add(this.btnConvBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Carolina Stomboli del curso 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvBinario;
        private System.Windows.Forms.Button btnConvDecimal;
        private System.Windows.Forms.ComboBox operador;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label labelResultado;
    }
}

