namespace CalculadoraPractico
{
    partial class Calculadora
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblResultadoPrevio = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button14, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button15, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button20, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 195);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(3, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(131, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 83);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnIgual.Location = new System.Drawing.Point(387, 359);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(125, 85);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.Location = new System.Drawing.Point(259, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 83);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button5.Location = new System.Drawing.Point(3, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 83);
            this.button5.TabIndex = 5;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button6.Location = new System.Drawing.Point(131, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 83);
            this.button6.TabIndex = 6;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button7.Location = new System.Drawing.Point(259, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 83);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button9.Location = new System.Drawing.Point(3, 270);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 83);
            this.button9.TabIndex = 9;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button10.Location = new System.Drawing.Point(259, 270);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 83);
            this.button10.TabIndex = 10;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button11.Location = new System.Drawing.Point(131, 270);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 83);
            this.button11.TabIndex = 11;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button13.Location = new System.Drawing.Point(3, 359);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(122, 85);
            this.button13.TabIndex = 13;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button14.Location = new System.Drawing.Point(131, 359);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(122, 85);
            this.button14.TabIndex = 14;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button15.Location = new System.Drawing.Point(259, 359);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(122, 85);
            this.button15.TabIndex = 15;
            this.button15.Text = ",";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCE.Location = new System.Drawing.Point(131, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(122, 83);
            this.btnCE.TabIndex = 19;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button20.Location = new System.Drawing.Point(3, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(122, 83);
            this.button20.TabIndex = 20;
            this.button20.Text = "%";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button4.Location = new System.Drawing.Point(387, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 83);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button8.Location = new System.Drawing.Point(387, 92);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 83);
            this.button8.TabIndex = 8;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button12.Location = new System.Drawing.Point(387, 181);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(125, 83);
            this.button12.TabIndex = 12;
            this.button12.Text = "x";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button16.Location = new System.Drawing.Point(387, 270);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(125, 83);
            this.button16.TabIndex = 16;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.BotonNumero_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnC.Location = new System.Drawing.Point(259, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(120, 83);
            this.btnC.TabIndex = 18;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPantalla.Location = new System.Drawing.Point(12, 136);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(512, 53);
            this.txtPantalla.TabIndex = 2;
            this.txtPantalla.Click += new System.EventHandler(this.BotonNumero_Click);
            this.txtPantalla.TextChanged += new System.EventHandler(this.txtPantalla_TextChanged_1);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 20;
            this.lstHistorial.Location = new System.Drawing.Point(12, 12);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(512, 64);
            this.lstHistorial.TabIndex = 3;
            // 
            // lblResultadoPrevio
            // 
            this.lblResultadoPrevio.AutoSize = true;
            this.lblResultadoPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultadoPrevio.Location = new System.Drawing.Point(12, 88);
            this.lblResultadoPrevio.Name = "lblResultadoPrevio";
            this.lblResultadoPrevio.Size = new System.Drawing.Size(174, 36);
            this.lblResultadoPrevio.TabIndex = 4;
            this.lblResultadoPrevio.Text = "Resultado : ";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(539, 654);
            this.Controls.Add(this.lblResultadoPrevio);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.forms_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblResultadoPrevio;
    }
}

