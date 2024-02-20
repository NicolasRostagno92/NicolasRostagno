namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSiete = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnBorrar = new Button();
            btnBorrarTodo = new Button();
            btnQuitar = new Button();
            btnRaizCuadrada = new Button();
            btnCuadrado = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnSumar = new Button();
            btnRestar = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 24;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(335, 44);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.Gray;
            btnUno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUno.Location = new Point(10, 247);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(45, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.Gray;
            btnDos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDos.Location = new Point(77, 247);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(45, 45);
            btnDos.TabIndex = 1;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.Gray;
            btnTres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(147, 247);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(45, 45);
            btnTres.TabIndex = 1;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = Color.Gray;
            btnCuatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuatro.Location = new Point(10, 186);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(45, 45);
            btnCuatro.TabIndex = 1;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.Gray;
            btnCinco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(77, 186);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(45, 45);
            btnCinco.TabIndex = 1;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.Gray;
            btnSeis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(147, 186);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(45, 45);
            btnSeis.TabIndex = 1;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.Gray;
            btnSiete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiete.Location = new Point(10, 126);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(45, 45);
            btnSiete.TabIndex = 1;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.Gray;
            btnOcho.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOcho.Location = new Point(77, 126);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(45, 45);
            btnOcho.TabIndex = 1;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.Gray;
            btnNueve.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNueve.Location = new Point(147, 126);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(45, 45);
            btnNueve.TabIndex = 1;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += agregarNumero;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.ActiveCaption;
            btnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(11, 62);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(45, 45);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = SystemColors.ActiveCaption;
            btnBorrarTodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrarTodo.Location = new Point(77, 62);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(45, 45);
            btnBorrarTodo.TabIndex = 1;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = SystemColors.ActiveCaption;
            btnQuitar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(147, 62);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(45, 45);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "<";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.BackColor = Color.FromArgb(128, 255, 255);
            btnRaizCuadrada.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaizCuadrada.Location = new Point(232, 62);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(45, 45);
            btnRaizCuadrada.TabIndex = 1;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = false;
            btnRaizCuadrada.Click += ClickOperador;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = Color.FromArgb(128, 255, 255);
            btnCuadrado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuadrado.Location = new Point(302, 62);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(45, 45);
            btnCuadrado.TabIndex = 1;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = false;
            btnCuadrado.Click += ClickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.MediumTurquoise;
            btnMultiplicar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(302, 126);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(45, 45);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += ClickOperador;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.MediumTurquoise;
            btnDividir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(232, 126);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(45, 45);
            btnDividir.TabIndex = 3;
            btnDividir.Tag = "̷∕";
            btnDividir.Text = "̷∕";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += ClickOperador;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.MediumTurquoise;
            btnSumar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(232, 186);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(45, 45);
            btnSumar.TabIndex = 3;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += ClickOperador;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.MediumTurquoise;
            btnRestar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(302, 186);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(45, 45);
            btnRestar.TabIndex = 2;
            btnRestar.Tag = "-";
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += ClickOperador;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = SystemColors.Highlight;
            btnResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(232, 247);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(115, 45);
            btnResultado.TabIndex = 3;
            btnResultado.Tag = "";
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = SystemColors.ActiveCaption;
            btnPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(147, 307);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(45, 45);
            btnPunto.TabIndex = 4;
            btnPunto.Tag = ".";
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.Gray;
            btnCero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCero.Location = new Point(77, 307);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(45, 45);
            btnCero.TabIndex = 5;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.BackColor = SystemColors.ActiveCaption;
            btnSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSigno.Location = new Point(10, 307);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(45, 45);
            btnSigno.TabIndex = 6;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.gettyimages_1348095156_6411fc4b64b94;
            ClientSize = new Size(356, 358);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnRestar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResultado);
            Controls.Add(btnSumar);
            Controls.Add(btnDividir);
            Controls.Add(btnNueve);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnOcho);
            Controls.Add(btnBorrar);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora by NicoRostagnoDev.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnBorrar;
        private Button btnBorrarTodo;
        private Button btnQuitar;
        private Button btnRaizCuadrada;
        private Button btnCuadrado;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
    }
}
