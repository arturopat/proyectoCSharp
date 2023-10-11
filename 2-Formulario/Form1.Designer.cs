namespace _2_Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.comBox1 = new System.Windows.Forms.ComboBox();
            this.antes = new System.Windows.Forms.Button();
            this.despues = new System.Windows.Forms.Button();
            this.contador = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(263, 55);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(178, 22);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(263, 83);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(178, 22);
            this.txt2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(204, 150);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(95, 20);
            this.cb1.TabIndex = 8;
            this.cb1.Text = "Servidores";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(371, 150);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(70, 20);
            this.cb2.TabIndex = 9;
            this.cb2.Text = "Redes";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(204, 194);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(77, 20);
            this.rbt1.TabIndex = 10;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Hombre";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(380, 194);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(61, 20);
            this.rbt2.TabIndex = 11;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Mujer";
            this.rbt2.UseVisualStyleBackColor = true;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbt2_CheckedChanged);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(204, 274);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 13;
            // 
            // comBox1
            // 
            this.comBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox1.FormattingEnabled = true;
            this.comBox1.Items.AddRange(new object[] {
            "Rodolfo",
            "Astolfo",
            "Rodolfo astolfo"});
            this.comBox1.Location = new System.Drawing.Point(204, 235);
            this.comBox1.Name = "comBox1";
            this.comBox1.Size = new System.Drawing.Size(193, 24);
            this.comBox1.TabIndex = 14;
            this.comBox1.SelectedIndexChanged += new System.EventHandler(this.comBox1_SelectedIndexChanged);
            // 
            // antes
            // 
            this.antes.Location = new System.Drawing.Point(204, 377);
            this.antes.Name = "antes";
            this.antes.Size = new System.Drawing.Size(75, 23);
            this.antes.TabIndex = 15;
            this.antes.Text = "<";
            this.antes.UseVisualStyleBackColor = true;
            this.antes.Click += new System.EventHandler(this.antes_Click);
            // 
            // despues
            // 
            this.despues.Location = new System.Drawing.Point(366, 377);
            this.despues.Name = "despues";
            this.despues.Size = new System.Drawing.Size(75, 23);
            this.despues.TabIndex = 16;
            this.despues.Text = ">";
            this.despues.UseVisualStyleBackColor = true;
            this.despues.Click += new System.EventHandler(this.despues_Click);
            // 
            // contador
            // 
            this.contador.Location = new System.Drawing.Point(575, 235);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(100, 22);
            this.contador.TabIndex = 17;
            this.contador.TextChanged += new System.EventHandler(this.contador_TextChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(275, 326);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 29);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(481, 326);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 29);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.contador);
            this.Controls.Add(this.despues);
            this.Controls.Add(this.antes);
            this.Controls.Add(this.comBox1);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox comBox1;
        private System.Windows.Forms.Button antes;
        private System.Windows.Forms.Button despues;
        private System.Windows.Forms.TextBox contador;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

