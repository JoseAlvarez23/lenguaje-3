
namespace ejercicio_1
{
    partial class FuncionesAsincronas
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
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_suma = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.Location = new System.Drawing.Point(105, 79);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(178, 57);
            this.btn_ejecutar.TabIndex = 0;
            this.btn_ejecutar.Text = "EJECUTAR";
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.btn_ejecutar_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(169, 184);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 1;
            this.lbl_resultado.Text = "label1";
            // 
            // lbl_suma
            // 
            this.lbl_suma.AutoSize = true;
            this.lbl_suma.Location = new System.Drawing.Point(497, 184);
            this.lbl_suma.Name = "lbl_suma";
            this.lbl_suma.Size = new System.Drawing.Size(35, 13);
            this.lbl_suma.TabIndex = 3;
            this.lbl_suma.Text = "label1";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(433, 79);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(178, 57);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // FuncionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_suma);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_ejecutar);
            this.Name = "FuncionesAsincronas";
            this.Text = "FuncionesAsincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_suma;
        private System.Windows.Forms.Button btn_calcular;
    }
}