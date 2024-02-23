namespace compraventa
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
            lbl_titulo = new Label();
            lbl_tipo = new Label();
            cbx_tipo = new ComboBox();
            lbl_placa = new Label();
            txt_placa = new TextBox();
            lbl_modelo = new Label();
            txt_modelo = new TextBox();
            lbl_pasajeros = new Label();
            radioButton2 = new RadioButton();
            radioButton4 = new RadioButton();
            lbl_observaciones = new Label();
            richTextBox_observaciones = new RichTextBox();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(356, 24);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(79, 15);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Compraventa";
            lbl_titulo.Click += label1_Click;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Location = new Point(69, 72);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(30, 15);
            lbl_tipo.TabIndex = 1;
            lbl_tipo.Text = "Tipo";
            // 
            // cbx_tipo
            // 
            cbx_tipo.FormattingEnabled = true;
            cbx_tipo.Location = new Point(105, 69);
            cbx_tipo.Name = "cbx_tipo";
            cbx_tipo.Size = new Size(121, 23);
            cbx_tipo.TabIndex = 2;
            cbx_tipo.SelectedIndexChanged += cbx_tipo_SelectedIndexChanged;
            // 
            // lbl_placa
            // 
            lbl_placa.AutoSize = true;
            lbl_placa.Location = new Point(69, 115);
            lbl_placa.Name = "lbl_placa";
            lbl_placa.Size = new Size(35, 15);
            lbl_placa.TabIndex = 3;
            lbl_placa.Text = "Placa";
            // 
            // txt_placa
            // 
            txt_placa.Location = new Point(110, 112);
            txt_placa.Name = "txt_placa";
            txt_placa.Size = new Size(100, 23);
            txt_placa.TabIndex = 4;
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Location = new Point(227, 120);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(48, 15);
            lbl_modelo.TabIndex = 5;
            lbl_modelo.Text = "Modelo";
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(296, 115);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(100, 23);
            txt_modelo.TabIndex = 6;
            // 
            // lbl_pasajeros
            // 
            lbl_pasajeros.AutoSize = true;
            lbl_pasajeros.Location = new Point(69, 153);
            lbl_pasajeros.Name = "lbl_pasajeros";
            lbl_pasajeros.Size = new Size(56, 15);
            lbl_pasajeros.TabIndex = 7;
            lbl_pasajeros.Text = "Pasajeros";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(132, 153);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(181, 153);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // lbl_observaciones
            // 
            lbl_observaciones.AutoSize = true;
            lbl_observaciones.Location = new Point(69, 188);
            lbl_observaciones.Name = "lbl_observaciones";
            lbl_observaciones.Size = new Size(84, 15);
            lbl_observaciones.TabIndex = 10;
            lbl_observaciones.Text = "Observaciones";
            // 
            // richTextBox_observaciones
            // 
            richTextBox_observaciones.Location = new Point(159, 188);
            richTextBox_observaciones.Name = "richTextBox_observaciones";
            richTextBox_observaciones.Size = new Size(187, 54);
            richTextBox_observaciones.TabIndex = 11;
            richTextBox_observaciones.Text = "";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(69, 272);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_guardar);
            Controls.Add(richTextBox_observaciones);
            Controls.Add(lbl_observaciones);
            Controls.Add(radioButton4);
            Controls.Add(radioButton2);
            Controls.Add(lbl_pasajeros);
            Controls.Add(txt_modelo);
            Controls.Add(lbl_modelo);
            Controls.Add(txt_placa);
            Controls.Add(lbl_placa);
            Controls.Add(cbx_tipo);
            Controls.Add(lbl_tipo);
            Controls.Add(lbl_titulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_tipo;
        private ComboBox cbx_tipo;
        private Label lbl_placa;
        private TextBox txt_placa;
        private Label lbl_modelo;
        private TextBox txt_modelo;
        private Label lbl_pasajeros;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private Label lbl_observaciones;
        private RichTextBox richTextBox_observaciones;
        private Button btn_guardar;
    }
}
