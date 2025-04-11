namespace TicketManager.View.Tickets
{
    partial class InsertTicketView
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
            textBox = new TextBox();
            quantLabel = new TextBox();
            concludeButton = new Button();
            canelButton = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ButtonHighlight;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Enabled = false;
            textBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.ForeColor = SystemColors.InactiveCaptionText;
            textBox.Location = new Point(23, 25);
            textBox.Margin = new Padding(7);
            textBox.Name = "textBox";
            textBox.Size = new Size(129, 20);
            textBox.TabIndex = 10;
            textBox.Text = "Número de Tickets";
            // 
            // quantLabel
            // 
            quantLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantLabel.ForeColor = SystemColors.WindowFrame;
            quantLabel.Location = new Point(154, 22);
            quantLabel.Margin = new Padding(7);
            quantLabel.Name = "quantLabel";
            quantLabel.Size = new Size(214, 27);
            quantLabel.TabIndex = 9;
            quantLabel.Text = "1";
            quantLabel.TextAlign = HorizontalAlignment.Center;
            quantLabel.Click += quantLabel_Click;
            // 
            // concludeButton
            // 
            concludeButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concludeButton.ForeColor = Color.Black;
            concludeButton.Location = new Point(302, 59);
            concludeButton.Name = "concludeButton";
            concludeButton.Size = new Size(66, 26);
            concludeButton.TabIndex = 36;
            concludeButton.Text = "Concluir";
            concludeButton.UseVisualStyleBackColor = true;
            concludeButton.Click += concludeButton_Click;
            // 
            // canelButton
            // 
            canelButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canelButton.ForeColor = Color.Black;
            canelButton.Location = new Point(230, 59);
            canelButton.Name = "canelButton";
            canelButton.Size = new Size(66, 26);
            canelButton.TabIndex = 35;
            canelButton.Text = "Cancelar";
            canelButton.UseVisualStyleBackColor = true;
            canelButton.Click += canelButton_Click;
            // 
            // InsertTicketView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 96);
            Controls.Add(concludeButton);
            Controls.Add(canelButton);
            Controls.Add(textBox);
            Controls.Add(quantLabel);
            Name = "InsertTicketView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inserção de um novo Ticket para o Colaborador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private TextBox quantLabel;
        private Button concludeButton;
        private Button canelButton;
    }
}