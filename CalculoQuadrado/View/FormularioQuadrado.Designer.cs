namespace CalculoQuadrado.View
{
    partial class FormularioQuadrado
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
            label2 = new Label();
            tbx_Valor = new TextBox();
            lbl_Resultado = new Label();
            btn_Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 23);
            label1.Name = "label1";
            label1.Size = new Size(545, 54);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Calculo Quadrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 109);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Digite o Valor";
            // 
            // tbx_Valor
            // 
            tbx_Valor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Valor.Location = new Point(178, 106);
            tbx_Valor.Name = "tbx_Valor";
            tbx_Valor.Size = new Size(100, 27);
            tbx_Valor.TabIndex = 2;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = Color.FromArgb(192, 0, 0);
            lbl_Resultado.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(40, 244);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(596, 194);
            lbl_Resultado.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(40, 172);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(596, 50);
            btn_Calcular.TabIndex = 5;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // FormularioQuadrado
            // 
            AcceptButton = btn_Calcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Resultado);
            Controls.Add(tbx_Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioQuadrado";
            ShowIcon = false;
            Text = "SCQ - Sistema de Formulario Quadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_Valor;
        private Label lbl_Resultado;
        private Button btn_Calcular;
    }
}