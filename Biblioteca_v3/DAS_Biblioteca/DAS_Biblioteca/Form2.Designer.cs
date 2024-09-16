namespace DAS_Biblioteca
{
    partial class Form2
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
            btnCancelar = new Button();
            btnSaveNewBook = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxIsbn = new TextBox();
            txtBoxAutor = new TextBox();
            txtBoxTitulo = new TextBox();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            btnNewBook = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            lblId = new Label();
            label11 = new Label();
            lblIsbn = new Label();
            lblAutor = new Label();
            lblTitulo = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSaveNewBook);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBoxIsbn);
            groupBox1.Controls.Add(txtBoxAutor);
            groupBox1.Controls.Add(txtBoxTitulo);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Libro";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(15, 177);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSaveNewBook
            // 
            btnSaveNewBook.Location = new Point(143, 177);
            btnSaveNewBook.Name = "btnSaveNewBook";
            btnSaveNewBook.Size = new Size(85, 23);
            btnSaveNewBook.TabIndex = 6;
            btnSaveNewBook.Text = "Guardar";
            btnSaveNewBook.UseVisualStyleBackColor = true;
            btnSaveNewBook.Click += btnSaveNewBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 130);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Titulo";
            // 
            // txtBoxIsbn
            // 
            txtBoxIsbn.Location = new Point(15, 148);
            txtBoxIsbn.Name = "txtBoxIsbn";
            txtBoxIsbn.Size = new Size(213, 23);
            txtBoxIsbn.TabIndex = 2;
            txtBoxIsbn.TextChanged += textBox3_TextChanged;
            // 
            // txtBoxAutor
            // 
            txtBoxAutor.Location = new Point(15, 96);
            txtBoxAutor.Name = "txtBoxAutor";
            txtBoxAutor.Size = new Size(213, 23);
            txtBoxAutor.TabIndex = 1;
            // 
            // txtBoxTitulo
            // 
            txtBoxTitulo.Location = new Point(15, 37);
            txtBoxTitulo.Name = "txtBoxTitulo";
            txtBoxTitulo.Size = new Size(213, 23);
            txtBoxTitulo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, titulo, autor, isbn });
            dataGridView1.Location = new Point(21, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(767, 207);
            dataGridView1.TabIndex = 1;
            // 
            // no
            // 
            no.HeaderText = "No";
            no.Name = "no";
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.Name = "isbn";
            // 
            // btnNewBook
            // 
            btnNewBook.Location = new Point(642, 67);
            btnNewBook.Name = "btnNewBook";
            btnNewBook.Size = new Size(134, 30);
            btnNewBook.TabIndex = 2;
            btnNewBook.Text = "Nuevo";
            btnNewBook.UseVisualStyleBackColor = true;
            btnNewBook.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 178);
            button3.Name = "button3";
            button3.Size = new Size(134, 30);
            button3.TabIndex = 4;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(184, 176);
            button4.Name = "button4";
            button4.Size = new Size(134, 30);
            button4.TabIndex = 5;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblId);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(lblIsbn);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(lblAutor);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(lblTitulo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(278, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 214);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de libro";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(61, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(10, 15);
            lblId.TabIndex = 7;
            lblId.Text = ".";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(13, 41);
            label11.Name = "label11";
            label11.Size = new Size(23, 15);
            label11.TabIndex = 6;
            label11.Text = "ID:";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(62, 103);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(10, 15);
            lblIsbn.TabIndex = 5;
            lblIsbn.Text = ".";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(62, 80);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(10, 15);
            lblAutor.TabIndex = 4;
            lblAutor.Text = ".";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(61, 61);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(10, 15);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 103);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 2;
            label6.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 82);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 1;
            label5.Text = "Autor:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 61);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 0;
            label4.Text = "Titulo:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(642, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 30);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Consultar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(groupBox2);
            Controls.Add(btnNewBook);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Libros";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtBoxIsbn;
        private TextBox txtBoxAutor;
        private TextBox txtBoxTitulo;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn isbn;
        private Button btnNewBook;
        private Button button3;
        private Button button4;
        private Button btnSaveNewBook;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label lblIsbn;
        private Label lblAutor;
        private Label lblTitulo;
        private Button btnSearch;
        private Label lblId;
        private Label label11;
    }
}