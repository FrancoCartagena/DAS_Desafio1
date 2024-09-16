namespace DAS_Biblioteca
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            lstUsuarios = new ListBox();
            label1 = new Label();
            lstLibros = new ListBox();
            dtpFechaPrestamo = new DateTimePicker();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            libro = new DataGridViewTextBoxColumn();
            fechaPrestamo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lstUsuarios);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lstLibros);
            groupBox1.Controls.Add(dtpFechaPrestamo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realizar Prestamo";
            // 
            // button1
            // 
            button1.Location = new Point(83, 191);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 9;
            button1.Text = "Prestar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 136);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 25);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Usuarios";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(174, 43);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(106, 79);
            lstUsuarios.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Libros";
            // 
            // lstLibros
            // 
            lstLibros.FormattingEnabled = true;
            lstLibros.ItemHeight = 15;
            lstLibros.Location = new Point(20, 43);
            lstLibros.Name = "lstLibros";
            lstLibros.Size = new Size(106, 79);
            lstLibros.TabIndex = 4;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(20, 154);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(260, 23);
            dtpFechaPrestamo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, usuario, libro, fechaPrestamo });
            dataGridView1.Location = new Point(345, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(515, 222);
            dataGridView1.TabIndex = 1;
            // 
            // no
            // 
            no.HeaderText = "No";
            no.Name = "no";
            no.ReadOnly = true;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            // 
            // libro
            // 
            libro.HeaderText = "Libro";
            libro.Name = "libro";
            libro.ReadOnly = true;
            // 
            // fechaPrestamo
            // 
            fechaPrestamo.HeaderText = "Fecha Prestamo";
            fechaPrestamo.Name = "fechaPrestamo";
            fechaPrestamo.ReadOnly = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 258);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Prestamos";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpFechaPrestamo;
        private Button button1;
        private Label label3;
        private Label label2;
        private ListBox lstUsuarios;
        private Label label1;
        private ListBox lstLibros;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn libro;
        private DataGridViewTextBoxColumn fechaPrestamo;
    }
}