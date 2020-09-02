namespace Ejemplo2HerenciaPOO
{
    partial class btncalcular
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
            this.label2 = new System.Windows.Forms.Label();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.btncalcularsalariobase = new System.Windows.Forms.Button();
            this.lblsalariobase = new System.Windows.Forms.Label();
            this.btncalculardescuento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvalorsalud = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblvalorpension = new System.Windows.Forms.Label();
            this.lblvalorccp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblvalorsalariofinal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de salarios y descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las horas trabajadas:";
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(446, 109);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 39);
            this.txthoras.TabIndex = 3;
            // 
            // btncalcularsalariobase
            // 
            this.btncalcularsalariobase.Location = new System.Drawing.Point(108, 221);
            this.btncalcularsalariobase.Name = "btncalcularsalariobase";
            this.btncalcularsalariobase.Size = new System.Drawing.Size(177, 49);
            this.btncalcularsalariobase.TabIndex = 5;
            this.btncalcularsalariobase.Text = "Salario Base";
            this.btncalcularsalariobase.UseVisualStyleBackColor = true;
            this.btncalcularsalariobase.Click += new System.EventHandler(this.btncalcularsalariobase_Click);
            // 
            // lblsalariobase
            // 
            this.lblsalariobase.AutoSize = true;
            this.lblsalariobase.Location = new System.Drawing.Point(323, 229);
            this.lblsalariobase.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblsalariobase.Name = "lblsalariobase";
            this.lblsalariobase.Size = new System.Drawing.Size(182, 32);
            this.lblsalariobase.TabIndex = 6;
            this.lblsalariobase.Text = "Salario base:";
            this.lblsalariobase.Visible = false;
            // 
            // btncalculardescuento
            // 
            this.btncalculardescuento.Enabled = false;
            this.btncalculardescuento.Location = new System.Drawing.Point(108, 306);
            this.btncalculardescuento.Name = "btncalculardescuento";
            this.btncalculardescuento.Size = new System.Drawing.Size(183, 49);
            this.btncalculardescuento.TabIndex = 7;
            this.btncalculardescuento.Text = "Descuentos ";
            this.btncalculardescuento.UseVisualStyleBackColor = true;
            this.btncalculardescuento.Click += new System.EventHandler(this.btncalculardescuento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salud:";
            // 
            // lblvalorsalud
            // 
            this.lblvalorsalud.AutoSize = true;
            this.lblvalorsalud.Location = new System.Drawing.Point(595, 314);
            this.lblvalorsalud.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvalorsalud.Name = "lblvalorsalud";
            this.lblvalorsalud.Size = new System.Drawing.Size(151, 32);
            this.lblvalorsalud.TabIndex = 9;
            this.lblvalorsalud.Text = "Valorsalud";
            this.lblvalorsalud.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pensión:";
            // 
            // lblvalorpension
            // 
            this.lblvalorpension.AutoSize = true;
            this.lblvalorpension.Location = new System.Drawing.Point(595, 360);
            this.lblvalorpension.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvalorpension.Name = "lblvalorpension";
            this.lblvalorpension.Size = new System.Drawing.Size(183, 32);
            this.lblvalorpension.TabIndex = 11;
            this.lblvalorpension.Text = "Valorpension";
            this.lblvalorpension.Visible = false;
            // 
            // lblvalorccp
            // 
            this.lblvalorccp.AutoSize = true;
            this.lblvalorccp.Location = new System.Drawing.Point(595, 406);
            this.lblvalorccp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvalorccp.Name = "lblvalorccp";
            this.lblvalorccp.Size = new System.Drawing.Size(126, 32);
            this.lblvalorccp.TabIndex = 13;
            this.lblvalorccp.Text = "Valorccp";
            this.lblvalorccp.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "CCP:";
            // 
            // lblvalorsalariofinal
            // 
            this.lblvalorsalariofinal.AutoSize = true;
            this.lblvalorsalariofinal.Location = new System.Drawing.Point(594, 453);
            this.lblvalorsalariofinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvalorsalariofinal.Name = "lblvalorsalariofinal";
            this.lblvalorsalariofinal.Size = new System.Drawing.Size(221, 32);
            this.lblvalorsalariofinal.TabIndex = 15;
            this.lblvalorsalariofinal.Text = "Valorsalariofinal";
            this.lblvalorsalariofinal.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 453);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "Salario a pagar:";
            // 
            // btncalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.lblvalorsalariofinal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblvalorccp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblvalorpension);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblvalorsalud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalculardescuento);
            this.Controls.Add(this.lblsalariobase);
            this.Controls.Add(this.btncalcularsalariobase);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "btncalcular";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.Button btncalcularsalariobase;
        private System.Windows.Forms.Label lblsalariobase;
        private System.Windows.Forms.Button btncalculardescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblvalorsalud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblvalorpension;
        private System.Windows.Forms.Label lblvalorccp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblvalorsalariofinal;
        private System.Windows.Forms.Label label12;
    }
}

