namespace TicketManager.View
{
    partial class removeTicket
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
            numberAddText = new TextBox();
            nomeEmployee = new TextBox();
            SuspendLayout();
            // 
            // concludeButton
            // 
            concludeButton.ForeColor = Color.Black;
            concludeButton.Location = new Point(169, 46);
            concludeButton.Name = "concludeButton";
            concludeButton.Size = new Size(85, 26);
            concludeButton.TabIndex = 20;
            concludeButton.Text = "Concluir";
            concludeButton.UseVisualStyleBackColor = true;
            // 
            // canelButton
            // 
            canelButton.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canelButton.ForeColor = Color.Black;
            canelButton.Location = new Point(78, 46);
            canelButton.Name = "canelButton";
            canelButton.Size = new Size(85, 26);
            canelButton.TabIndex = 19;
            canelButton.Text = "Cancelar";
            canelButton.UseVisualStyleBackColor = true;
            // 
            // numberAddText
            // 
            numberAddText.BackColor = SystemColors.Menu;
            numberAddText.BorderStyle = BorderStyle.None;
            numberAddText.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberAddText.ForeColor = SystemColors.InactiveCaptionText;
            numberAddText.Location = new Point(6, 16);
            numberAddText.Margin = new Padding(7);
            numberAddText.Name = "numberAddText";
            numberAddText.Size = new Size(130, 20);
            numberAddText.TabIndex = 18;
            numberAddText.Text = "Número de Tickets:";
            // 
            // nomeEmployee
            // 
            nomeEmployee.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nomeEmployee.ForeColor = SystemColors.WindowFrame;
            nomeEmployee.Location = new Point(150, 13);
            nomeEmployee.Margin = new Padding(7);
            nomeEmployee.Name = "nomeEmployee";
            nomeEmployee.Size = new Size(104, 27);
            nomeEmployee.TabIndex = 17;
            nomeEmployee.Text = "1";
            nomeEmployee.TextAlign = HorizontalAlignment.Center;
            // 
            // removeTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 81);
            Controls.Add(concludeButton);
            Controls.Add(canelButton);
            Controls.Add(numberAddText);
            Controls.Add(nomeEmployee);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "removeTicket";
            Text = "Remover Tickets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button concludeButton;
        private Button canelButton;
        private TextBox numberAddText;
        private TextBox nomeEmployee;
    }
}