namespace TicketManager.View
{
    partial class EditEmployeesView
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
            nameTextBox = new TextBox();
            nameEmployeeLabel = new TextBox();
            situacaoComboBox = new ComboBox();
            situacaoTextBox = new TextBox();
            cpfTextBox = new TextBox();
            cpfLabel = new TextBox();
            camposTextBox = new TextBox();
            SuspendLayout();
            // 
            // concludeButton
            // 
            concludeButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concludeButton.ForeColor = Color.Black;
            concludeButton.Location = new Point(266, 118);
            concludeButton.Name = "concludeButton";
            concludeButton.Size = new Size(66, 26);
            concludeButton.TabIndex = 26;
            concludeButton.Text = "Concluir";
            concludeButton.UseVisualStyleBackColor = true;
            concludeButton.Click += concludeButton_Click;
            // 
            // canelButton
            // 
            canelButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canelButton.ForeColor = Color.Black;
            canelButton.Location = new Point(194, 118);
            canelButton.Name = "canelButton";
            canelButton.Size = new Size(66, 26);
            canelButton.TabIndex = 25;
            canelButton.Text = "Cancelar";
            canelButton.UseVisualStyleBackColor = true;
            canelButton.Click += canelButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.ButtonHighlight;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Enabled = false;
            nameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = SystemColors.InactiveCaptionText;
            nameTextBox.Location = new Point(7, 16);
            nameTextBox.Margin = new Padding(7);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(116, 20);
            nameTextBox.TabIndex = 20;
            nameTextBox.Text = "Nome completo*:";
            // 
            // nameEmployeeLabel
            // 
            nameEmployeeLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameEmployeeLabel.ForeColor = SystemColors.WindowFrame;
            nameEmployeeLabel.Location = new Point(123, 13);
            nameEmployeeLabel.Margin = new Padding(7);
            nameEmployeeLabel.Name = "nameEmployeeLabel";
            nameEmployeeLabel.Size = new Size(215, 27);
            nameEmployeeLabel.TabIndex = 19;
            nameEmployeeLabel.Text = "Nome do colaborador";
            nameEmployeeLabel.Click += nameEmployeeLabel_Click;
            // 
            // situacaoComboBox
            // 
            situacaoComboBox.FormattingEnabled = true;
            situacaoComboBox.Items.AddRange(new object[] { "A - Ativo\t", "I - Inativo" });
            situacaoComboBox.Location = new Point(177, 84);
            situacaoComboBox.Name = "situacaoComboBox";
            situacaoComboBox.Size = new Size(161, 23);
            situacaoComboBox.TabIndex = 27;
            // 
            // situacaoTextBox
            // 
            situacaoTextBox.BackColor = SystemColors.ControlLightLight;
            situacaoTextBox.BorderStyle = BorderStyle.None;
            situacaoTextBox.Enabled = false;
            situacaoTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            situacaoTextBox.ForeColor = SystemColors.InactiveCaptionText;
            situacaoTextBox.Location = new Point(7, 84);
            situacaoTextBox.Margin = new Padding(7);
            situacaoTextBox.Name = "situacaoTextBox";
            situacaoTextBox.Size = new Size(166, 20);
            situacaoTextBox.TabIndex = 28;
            situacaoTextBox.Text = "Situação do colaborador:";
            // 
            // cpfTextBox
            // 
            cpfTextBox.BackColor = SystemColors.ControlLightLight;
            cpfTextBox.BorderStyle = BorderStyle.None;
            cpfTextBox.Enabled = false;
            cpfTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpfTextBox.ForeColor = SystemColors.InactiveCaptionText;
            cpfTextBox.Location = new Point(7, 50);
            cpfTextBox.Margin = new Padding(7);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(156, 20);
            cpfTextBox.TabIndex = 30;
            cpfTextBox.Text = "CPF*(apenas numeros):";
            // 
            // cpfLabel
            // 
            cpfLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpfLabel.ForeColor = SystemColors.WindowFrame;
            cpfLabel.Location = new Point(165, 47);
            cpfLabel.Margin = new Padding(7);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(173, 27);
            cpfLabel.TabIndex = 29;
            cpfLabel.Text = "Cadastro de pessoa fisíca";
            cpfLabel.Click += cpfLabel_Click;
            // 
            // camposTextBox
            // 
            camposTextBox.BackColor = SystemColors.ControlLightLight;
            camposTextBox.BorderStyle = BorderStyle.None;
            camposTextBox.Enabled = false;
            camposTextBox.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camposTextBox.ForeColor = SystemColors.InactiveCaptionText;
            camposTextBox.Location = new Point(7, 126);
            camposTextBox.Margin = new Padding(7);
            camposTextBox.Name = "camposTextBox";
            camposTextBox.Size = new Size(156, 14);
            camposTextBox.TabIndex = 40;
            camposTextBox.Text = "Campos com * são obrigatórios";
            // 
            // EditEmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 153);
            Controls.Add(camposTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(cpfLabel);
            Controls.Add(situacaoTextBox);
            Controls.Add(situacaoComboBox);
            Controls.Add(concludeButton);
            Controls.Add(canelButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameEmployeeLabel);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "EditEmployeesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Colaborador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button concludeButton;
        private Button canelButton;
        private TextBox ticketsNumberText;
        private TextBox ticketsNumberLabel;
        private TextBox nameTextBox;
        private TextBox nameEmployeeLabel;
        private ComboBox situacaoComboBox;
        private TextBox situacaoTextBox;
        private TextBox cpfTextBox;
        private TextBox cpfLabel;
        private TextBox camposTextBox;
    }
}