namespace TicketManager.View.Tickets
{
    partial class EditTicketView
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
            concludeButton = new Button();
            canelButton = new Button();
            textBox = new TextBox();
            quantAtualLabel = new TextBox();
            textBox1 = new TextBox();
            situacaoComboBox = new ComboBox();
            textBox2 = new TextBox();
            operacaoComboBox = new ComboBox();
            textBox3 = new TextBox();
            quantLabel = new TextBox();
            SuspendLayout();
            // 
            // concludeButton
            // 
            concludeButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concludeButton.ForeColor = Color.Black;
            concludeButton.Location = new Point(296, 164);
            concludeButton.Name = "concludeButton";
            concludeButton.Size = new Size(66, 26);
            concludeButton.TabIndex = 40;
            concludeButton.Text = "Concluir";
            concludeButton.UseVisualStyleBackColor = true;
            concludeButton.Click += concludeButton_Click;
            // 
            // canelButton
            // 
            canelButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canelButton.ForeColor = Color.Black;
            canelButton.Location = new Point(223, 164);
            canelButton.Name = "canelButton";
            canelButton.Size = new Size(66, 26);
            canelButton.TabIndex = 39;
            canelButton.Text = "Cancelar";
            canelButton.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ButtonHighlight;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Enabled = false;
            textBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.ForeColor = SystemColors.InactiveCaptionText;
            textBox.Location = new Point(15, 19);
            textBox.Margin = new Padding(7);
            textBox.Name = "textBox";
            textBox.Size = new Size(162, 20);
            textBox.TabIndex = 38;
            textBox.Text = "Número de Tickets atual:";
            // 
            // quantAtualLabel
            // 
            quantAtualLabel.Enabled = false;
            quantAtualLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantAtualLabel.ForeColor = SystemColors.WindowFrame;
            quantAtualLabel.Location = new Point(191, 16);
            quantAtualLabel.Margin = new Padding(7);
            quantAtualLabel.Name = "quantAtualLabel";
            quantAtualLabel.Size = new Size(171, 27);
            quantAtualLabel.TabIndex = 37;
            quantAtualLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(15, 87);
            textBox1.Margin = new Padding(7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 20);
            textBox1.TabIndex = 42;
            textBox1.Text = "Situação do colaborador:";
            // 
            // situacaoComboBox
            // 
            situacaoComboBox.FormattingEnabled = true;
            situacaoComboBox.Items.AddRange(new object[] { "A - Ativo\t", "I - Inativo" });
            situacaoComboBox.Location = new Point(195, 83);
            situacaoComboBox.Name = "situacaoComboBox";
            situacaoComboBox.Size = new Size(167, 23);
            situacaoComboBox.TabIndex = 41;
            situacaoComboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.InactiveCaptionText;
            textBox2.Location = new Point(15, 115);
            textBox2.Margin = new Padding(7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 20);
            textBox2.TabIndex = 44;
            textBox2.Text = "Operação a realizar:";
            // 
            // operacaoComboBox
            // 
            operacaoComboBox.FormattingEnabled = true;
            operacaoComboBox.Items.AddRange(new object[] { "Subtrair\t", "Adicionar" });
            operacaoComboBox.Location = new Point(195, 112);
            operacaoComboBox.Name = "operacaoComboBox";
            operacaoComboBox.Size = new Size(167, 23);
            operacaoComboBox.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.InactiveCaptionText;
            textBox3.Location = new Point(15, 53);
            textBox3.Margin = new Padding(7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 20);
            textBox3.TabIndex = 46;
            textBox3.Text = "Número para Adicionar/Subtrair:";
            // 
            // quantLabel
            // 
            quantLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantLabel.ForeColor = SystemColors.WindowFrame;
            quantLabel.Location = new Point(238, 50);
            quantLabel.Margin = new Padding(7);
            quantLabel.Name = "quantLabel";
            quantLabel.Size = new Size(124, 27);
            quantLabel.TabIndex = 45;
            quantLabel.Text = "1";
            quantLabel.TextAlign = HorizontalAlignment.Center;
            quantLabel.Click += quantLabel_Click;
            // 
            // EditTicketView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 202);
            Controls.Add(textBox3);
            Controls.Add(quantLabel);
            Controls.Add(textBox2);
            Controls.Add(operacaoComboBox);
            Controls.Add(textBox1);
            Controls.Add(situacaoComboBox);
            Controls.Add(concludeButton);
            Controls.Add(canelButton);
            Controls.Add(textBox);
            Controls.Add(quantAtualLabel);
            Name = "EditTicketView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Tickets do Colaborador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button concludeButton;
        private Button canelButton;
        private TextBox textBox;
        private TextBox quantAtualLabel;
        private TextBox textBox1;
        private ComboBox situacaoComboBox;
        private TextBox textBox2;
        private ComboBox operacaoComboBox;
        private TextBox textBox3;
        private TextBox quantLabel;
    }
}