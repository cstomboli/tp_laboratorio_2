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
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerar = new System.Windows.Forms.Button();
            this.ConvertirAbinario = new System.Windows.Forms.Button();
            this.ConvertirAdecimal = new System.Windows.Forms.Button();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.Operador1 = new System.Windows.Forms.TextBox();
            this.Operador2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOperar
            // 
            this.buttonOperar.Location = new System.Drawing.Point(29, 92);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(130, 31);
            this.buttonOperar.TabIndex = 4;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.ButtonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(165, 92);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(140, 31);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.btnLimpiar);
            // 
            // buttonCerar
            // 
            this.buttonCerar.Location = new System.Drawing.Point(311, 92);
            this.buttonCerar.Name = "buttonCerar";
            this.buttonCerar.Size = new System.Drawing.Size(127, 31);
            this.buttonCerar.TabIndex = 6;
            this.buttonCerar.Text = "Cerrar";
            this.buttonCerar.UseVisualStyleBackColor = true;
            this.buttonCerar.Click += new System.EventHandler(this.ButtonCerar_Click);
            // 
            // ConvertirAbinario
            // 
            this.ConvertirAbinario.Location = new System.Drawing.Point(29, 129);
            this.ConvertirAbinario.Name = "ConvertirAbinario";
            this.ConvertirAbinario.Size = new System.Drawing.Size(213, 43);
            this.ConvertirAbinario.TabIndex = 7;
            this.ConvertirAbinario.Text = "Convertir a Binario";
            this.ConvertirAbinario.UseVisualStyleBackColor = true;
            this.ConvertirAbinario.Click += new System.EventHandler(this.ConvertirAbinario_Click);
            // 
            // ConvertirAdecimal
            // 
            this.ConvertirAdecimal.Location = new System.Drawing.Point(248, 129);
            this.ConvertirAdecimal.Name = "ConvertirAdecimal";
            this.ConvertirAdecimal.Size = new System.Drawing.Size(190, 43);
            this.ConvertirAdecimal.TabIndex = 8;
            this.ConvertirAdecimal.Text = "Convertir a Decimal";
            this.ConvertirAdecimal.UseVisualStyleBackColor = true;
            this.ConvertirAdecimal.Click += new System.EventHandler(this.ConvertirAdecimal_Click);
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "/",
            "*",
            "+",
            "-"});
            this.comboBoxOperador.Location = new System.Drawing.Point(157, 46);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(144, 21);
            this.comboBoxOperador.TabIndex = 1;
            // 
            // Operador1
            // 
            this.Operador1.Location = new System.Drawing.Point(29, 47);
            this.Operador1.Name = "Operador1";
            this.Operador1.Size = new System.Drawing.Size(122, 20);
            this.Operador1.TabIndex = 0;
            // 
            // Operador2
            // 
            this.Operador2.Location = new System.Drawing.Point(307, 47);
            this.Operador2.Name = "Operador2";
            this.Operador2.Size = new System.Drawing.Size(131, 20);
            this.Operador2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "resultado";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operador2);
            this.Controls.Add(this.Operador1);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.ConvertirAdecimal);
            this.Controls.Add(this.ConvertirAbinario);
            this.Controls.Add(this.buttonCerar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Stomboli Carolina 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerar;
        private System.Windows.Forms.Button ConvertirAbinario;
        private System.Windows.Forms.Button ConvertirAdecimal;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.TextBox Operador1;
        private System.Windows.Forms.TextBox Operador2;
        private System.Windows.Forms.Label label1;
    }
}

