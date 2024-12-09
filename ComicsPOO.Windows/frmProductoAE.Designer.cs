namespace ComicsPOO.Windows
{
    partial class frmProductoAE
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
            components = new System.ComponentModel.Container();
            btnCancelar = new Button();
            btnOK = new Button();
            cboTipo = new ComboBox();
            nudStock = new NumericUpDown();
            txtAutor = new TextBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            lblTipo = new Label();
            label2 = new Label();
            lblAutor = new Label();
            gbTipo = new GroupBox();
            rbtFigurita = new RadioButton();
            rbtComic = new RadioButton();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblAltura = new Label();
            txtAltura = new TextBox();
            nudPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(422, 359);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 79);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(43, 359);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(117, 79);
            btnOK.TabIndex = 20;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(127, 256);
            cboTipo.Margin = new Padding(3, 4, 3, 4);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(138, 28);
            cboTipo.TabIndex = 18;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(129, 171);
            nudStock.Margin = new Padding(3, 4, 3, 4);
            nudStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(112, 27);
            nudStock.TabIndex = 17;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(127, 213);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(411, 27);
            txtAutor.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(127, 89);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(411, 27);
            txtDescripcion.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 172);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 6;
            label3.Text = "Stock:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(38, 255);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 133);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 9;
            label2.Text = "Precio:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(38, 217);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 20);
            lblAutor.TabIndex = 10;
            lblAutor.Text = "Autor:";
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(rbtFigurita);
            gbTipo.Controls.Add(rbtComic);
            gbTipo.Location = new Point(40, 16);
            gbTipo.Margin = new Padding(3, 4, 3, 4);
            gbTipo.Name = "gbTipo";
            gbTipo.Padding = new Padding(3, 4, 3, 4);
            gbTipo.Size = new Size(256, 59);
            gbTipo.TabIndex = 12;
            gbTipo.TabStop = false;
            gbTipo.Text = " Tipo ";
            // 
            // rbtFigurita
            // 
            rbtFigurita.AutoSize = true;
            rbtFigurita.Location = new Point(129, 25);
            rbtFigurita.Margin = new Padding(3, 4, 3, 4);
            rbtFigurita.Name = "rbtFigurita";
            rbtFigurita.Size = new Size(80, 24);
            rbtFigurita.TabIndex = 0;
            rbtFigurita.Text = "Figurita";
            rbtFigurita.UseVisualStyleBackColor = true;
            // 
            // rbtComic
            // 
            rbtComic.AutoSize = true;
            rbtComic.Checked = true;
            rbtComic.Location = new Point(14, 25);
            rbtComic.Margin = new Padding(3, 4, 3, 4);
            rbtComic.Name = "rbtComic";
            rbtComic.Size = new Size(72, 24);
            rbtComic.TabIndex = 0;
            rbtComic.TabStop = true;
            rbtComic.Text = "Comic";
            rbtComic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 93);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 11;
            label1.Text = "Descripción:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(333, 136);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(52, 20);
            lblAltura.TabIndex = 7;
            lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(422, 132);
            txtAltura.Margin = new Padding(3, 4, 3, 4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(114, 27);
            txtAltura.TabIndex = 13;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(129, 129);
            nudPrecio.Margin = new Padding(3, 4, 3, 4);
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(112, 27);
            nudPrecio.TabIndex = 17;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmProductoAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 455);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboTipo);
            Controls.Add(nudPrecio);
            Controls.Add(nudStock);
            Controls.Add(txtAltura);
            Controls.Add(txtAutor);
            Controls.Add(txtDescripcion);
            Controls.Add(lblAltura);
            Controls.Add(label3);
            Controls.Add(lblTipo);
            Controls.Add(label2);
            Controls.Add(lblAutor);
            Controls.Add(gbTipo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProductoAE";
            Text = "frmProductoAE";
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private ComboBox cboTipo;
        private NumericUpDown nudStock;
        private TextBox txtAutor;
        private TextBox txtDescripcion;
        private Label label3;
        private Label lblTipo;
        private Label label2;
        private Label lblAutor;
        private GroupBox gbTipo;
        private RadioButton rbtFigurita;
        private RadioButton rbtComic;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox txtAltura;
        private Label lblAltura;
        private NumericUpDown nudPrecio;
    }
}