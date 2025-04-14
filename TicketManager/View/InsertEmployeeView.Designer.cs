namespace TicketManager.View
{
    partial class InsertEmployeeView
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
            nameEmployeeLabel = new TextBox();
            nameTextBox = new TextBox();
            cpfTextBox = new TextBox();
            cpfEmployeeLabel = new TextBox();
            concludeButton = new Button();
            canelButton = new Button();
            ticketsQuantTextBox = new TextBox();
            ticketsQuantLabel = new TextBox();
            campoTextBox = new TextBox();
            SuspendLayout();
            // 
            // nameEmployeeLabel
            // 
            nameEmployeeLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameEmployeeLabel.ForeColor = SystemColors.WindowFrame;
            nameEmployeeLabel.Location = new Point(124, 13);
            nameEmployeeLabel.Margin = new Padding(7);
            nameEmployeeLabel.Name = "nameEmployeeLabel";
            nameEmployeeLabel.Size = new Size(214, 27);
            nameEmployeeLabel.TabIndex = 7;
            nameEmployeeLabel.Text = "Nome do colaborador";
            nameEmployeeLabel.Click += nameEmployeeLabel_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.AccessibleRole = AccessibleRole.None;
            nameTextBox.BackColor = SystemColors.ButtonHighlight;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Enabled = false;
            nameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = SystemColors.InactiveCaptionText;
            nameTextBox.Location = new Point(7, 12);
            nameTextBox.Margin = new Padding(7);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(117, 20);
            nameTextBox.TabIndex = 8;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "Nome completo*:";
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
            cpfTextBox.TabIndex = 38;
            cpfTextBox.Text = "CPF*(apenas numeros):";
            // 
            // cpfEmployeeLabel
            // 
            cpfEmployeeLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpfEmployeeLabel.ForeColor = SystemColors.WindowFrame;
            cpfEmployeeLabel.Location = new Point(164, 47);
            cpfEmployeeLabel.Margin = new Padding(7);
            cpfEmployeeLabel.Name = "cpfEmployeeLabel";
            cpfEmployeeLabel.Size = new Size(174, 27);
            cpfEmployeeLabel.TabIndex = 37;
            cpfEmployeeLabel.Text = "Cadastro de pessoa fisíca";
            cpfEmployeeLabel.Click += cpfLabel_Click;
            // 
            // concludeButton
            // 
            concludeButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concludeButton.ForeColor = Color.Black;
            concludeButton.Location = new Point(266, 123);
            concludeButton.Name = "concludeButton";
            concludeButton.Size = new Size(66, 26);
            concludeButton.TabIndex = 34;
            concludeButton.Text = "Concluir";
            concludeButton.UseVisualStyleBackColor = true;
            concludeButton.Click += concludeButton_Click;
            // 
            // canelButton
            // 
            canelButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canelButton.ForeColor = Color.Black;
            canelButton.Location = new Point(194, 123);
            canelButton.Name = "canelButton";
            canelButton.Size = new Size(66, 26);
            canelButton.TabIndex = 33;
            canelButton.Text = "Cancelar";
            canelButton.UseVisualStyleBackColor = true;
            canelButton.Click += canelButton_Click_1;
            // 
            // ticketsQuantTextBox
            // 
            ticketsQuantTextBox.BackColor = SystemColors.ControlLightLight;
            ticketsQuantTextBox.BorderStyle = BorderStyle.None;
            ticketsQuantTextBox.Enabled = false;
            ticketsQuantTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketsQuantTextBox.ForeColor = SystemColors.InactiveCaptionText;
            ticketsQuantTextBox.Location = new Point(7, 89);
            ticketsQuantTextBox.Margin = new Padding(7);
            ticketsQuantTextBox.Name = "ticketsQuantTextBox";
            ticketsQuantTextBox.Size = new Size(166, 20);
            ticketsQuantTextBox.TabIndex = 32;
            ticketsQuantTextBox.Text = "Número inicial de Tickets:";
            // 
            // ticketsQuantLabel
            // 
            ticketsQuantLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketsQuantLabel.ForeColor = SystemColors.WindowFrame;
            ticketsQuantLabel.Location = new Point(183, 86);
            ticketsQuantLabel.Margin = new Padding(7);
            ticketsQuantLabel.Name = "ticketsQuantLabel";
            ticketsQuantLabel.Size = new Size(155, 27);
            ticketsQuantLabel.TabIndex = 31;
            ticketsQuantLabel.Text = "1";
            ticketsQuantLabel.TextAlign = HorizontalAlignment.Center;
            ticketsQuantLabel.Click += ticketsQuantLabel_Click;
            // 
            // campoTextBox
            // 
            campoTextBox.BackColor = SystemColors.ControlLightLight;
            campoTextBox.BorderStyle = BorderStyle.None;
            campoTextBox.Enabled = false;
            campoTextBox.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campoTextBox.ForeColor = SystemColors.InactiveCaptionText;
            campoTextBox.Location = new Point(7, 131);
            campoTextBox.Margin = new Padding(7);
            campoTextBox.Name = "campoTextBox";
            campoTextBox.Size = new Size(156, 14);
            campoTextBox.TabIndex = 39;
            campoTextBox.Text = "Campos com * são obrigatórios";
            // 
            // InsertEmployeeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(344, 164);
            Controls.Add(campoTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(cpfEmployeeLabel);
            Controls.Add(concludeButton);
            Controls.Add(canelButton);
            Controls.Add(ticketsQuantTextBox);
            Controls.Add(ticketsQuantLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameEmployeeLabel);
            ForeColor = SystemColors.Desktop;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertEmployeeView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inserção de Colaborador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameEmployeeLabel;
        private TextBox setorText;
        private TextBox setorLabel;
        private TextBox cpfTextBox;
        private TextBox cpfEmployeeLabel;
        private Button concludeButton;
        private Button canelButton;
        private TextBox ticketsQuantTextBox;
        private TextBox ticketsQuantLabel;
        private TextBox campoTextBox;
        public TextBox nameTextBox;
    }
}