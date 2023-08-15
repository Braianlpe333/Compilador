
namespace EjmSuma
{
    partial class Ventana
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
            label1 = new Label();
            consola = new Label();
            textoconsola = new RichTextBox();
            carga = new Button();
            textosalida = new RichTextBox();
            salida = new Label();
            ubicacionlb = new Label();
            comboBox1 = new ComboBox();
            ubicacion = new TextBox();
            buscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 60);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 0;
            label1.Text = "Origen de Programa Fuente:";
            // 
            // consola
            // 
            consola.AutoSize = true;
            consola.Location = new Point(43, 169);
            consola.Name = "consola";
            consola.Size = new Size(53, 15);
            consola.TabIndex = 3;
            consola.Text = "Consola:";
            consola.Click += consola_Click;
            // 
            // textoconsola
            // 
            textoconsola.Location = new Point(43, 209);
            textoconsola.Name = "textoconsola";
            textoconsola.Size = new Size(291, 205);
            textoconsola.TabIndex = 4;
            textoconsola.Text = "";
            // 
            // carga
            // 
            carga.Location = new Point(353, 268);
            carga.Name = "carga";
            carga.Size = new Size(95, 34);
            carga.TabIndex = 5;
            carga.Text = "Cargar >>>";
            carga.UseVisualStyleBackColor = true;
            carga.Click += carga_Click;
            // 
            // textosalida
            // 
            textosalida.Location = new Point(474, 209);
            textosalida.Name = "textosalida";
            textosalida.ReadOnly = true;
            textosalida.Size = new Size(291, 205);
            textosalida.TabIndex = 6;
            textosalida.Text = "";
            textosalida.TextChanged += textosalida_TextChanged;
            // 
            // salida
            // 
            salida.AutoSize = true;
            salida.Location = new Point(481, 177);
            salida.Name = "salida";
            salida.Size = new Size(41, 15);
            salida.TabIndex = 7;
            salida.Text = "Salida:";
            // 
            // ubicacionlb
            // 
            ubicacionlb.AutoSize = true;
            ubicacionlb.Location = new Point(53, 169);
            ubicacionlb.Name = "ubicacionlb";
            ubicacionlb.Size = new Size(63, 15);
            ubicacionlb.TabIndex = 8;
            ubicacionlb.Text = "Ubicacion:";
            ubicacionlb.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ingreso Manual", "Carga desde Archivo" });
            comboBox1.Location = new Point(418, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ubicacion
            // 
            ubicacion.Location = new Point(53, 233);
            ubicacion.Name = "ubicacion";
            ubicacion.Size = new Size(242, 23);
            ubicacion.TabIndex = 10;
            ubicacion.TextChanged += ubicacion_TextChanged;
            // 
            // buscar
            // 
            buscar.Location = new Point(353, 308);
            buscar.Name = "buscar";
            buscar.Size = new Size(95, 34);
            buscar.TabIndex = 11;
            buscar.Text = "Buscar >>>";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // Ventana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buscar);
            Controls.Add(ubicacion);
            Controls.Add(comboBox1);
            Controls.Add(ubicacionlb);
            Controls.Add(salida);
            Controls.Add(textosalida);
            Controls.Add(carga);
            Controls.Add(textoconsola);
            Controls.Add(consola);
            Controls.Add(label1);
            Name = "Ventana";
            Text = "Ventana";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label consola;
        private RichTextBox textoconsola;
        private Button carga;
        private RichTextBox textosalida;
        private Label salida;
        private Label ubicacionlb;
        private ComboBox comboBox1;
        private TextBox ubicacion;
        private Button buscar;
    }
}