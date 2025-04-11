namespace TicketManager.View
{
    partial class TicketsView
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
            dataGridTickets = new DataGridView();
            label1 = new Label();
            insertButton = new Button();
            editButton = new Button();
            employeeLabel = new Label();
            filtroDataCheckBox = new CheckBox();
            inicioDateTimePicker = new DateTimePicker();
            fimDateTimePicker = new DateTimePicker();
            dataInicialLabel = new Label();
            dataFinalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTickets).BeginInit();
            SuspendLayout();
            // 
            // dataGridTickets
            // 
            dataGridTickets.AllowUserToOrderColumns = true;
            dataGridTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridTickets.BackgroundColor = SystemColors.ScrollBar;
            dataGridTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTickets.Location = new Point(14, 86);
            dataGridTickets.Name = "dataGridTickets";
            dataGridTickets.ReadOnly = true;
            dataGridTickets.Size = new Size(806, 418);
            dataGridTickets.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 9;
            label1.Text = "Menu de Tickets:";
            // 
            // insertButton
            // 
            insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertButton.Font = new Font("Calibri", 11.25F);
            insertButton.Location = new Point(678, 44);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(67, 36);
            insertButton.TabIndex = 7;
            insertButton.Text = "Inserir";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.UseWaitCursor = true;
            insertButton.Click += insertButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.Font = new Font("Calibri", 11.25F);
            editButton.Location = new Point(751, 44);
            editButton.Name = "editButton";
            editButton.Size = new Size(67, 36);
            editButton.TabIndex = 8;
            editButton.Text = "Editar";
            editButton.TextImageRelation = TextImageRelation.ImageAboveText;
            editButton.UseVisualStyleBackColor = true;
            editButton.UseWaitCursor = true;
            editButton.Click += editButton_Click;
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Enabled = false;
            employeeLabel.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeLabel.Location = new Point(148, 9);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(18, 23);
            employeeLabel.TabIndex = 10;
            employeeLabel.Text = "  ";
            // 
            // filtroDataCheckBox
            // 
            filtroDataCheckBox.AutoSize = true;
            filtroDataCheckBox.Location = new Point(14, 44);
            filtroDataCheckBox.Name = "filtroDataCheckBox";
            filtroDataCheckBox.Size = new Size(106, 19);
            filtroDataCheckBox.TabIndex = 12;
            filtroDataCheckBox.Text = "Filtrar por data.";
            filtroDataCheckBox.UseVisualStyleBackColor = true;
            filtroDataCheckBox.CheckedChanged += filtroDataCheckBox_CheckedChanged;
            filtroDataCheckBox.Click += filtroDataCheckBox_Click;
            // 
            // inicioDateTimePicker
            // 
            inicioDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inicioDateTimePicker.Enabled = false;
            inicioDateTimePicker.Location = new Point(427, 28);
            inicioDateTimePicker.Name = "inicioDateTimePicker";
            inicioDateTimePicker.Size = new Size(245, 23);
            inicioDateTimePicker.TabIndex = 13;
            inicioDateTimePicker.Visible = false;
            inicioDateTimePicker.ValueChanged += inicioDateTimePicker_ValueChanged;
            // 
            // fimDateTimePicker
            // 
            fimDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fimDateTimePicker.Enabled = false;
            fimDateTimePicker.Location = new Point(427, 57);
            fimDateTimePicker.Name = "fimDateTimePicker";
            fimDateTimePicker.Size = new Size(245, 23);
            fimDateTimePicker.TabIndex = 14;
            fimDateTimePicker.Visible = false;
            fimDateTimePicker.ValueChanged += inicioDateTimePicker_ValueChanged;
            // 
            // dataInicialLabel
            // 
            dataInicialLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataInicialLabel.AutoSize = true;
            dataInicialLabel.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataInicialLabel.Location = new Point(320, 33);
            dataInicialLabel.Name = "dataInicialLabel";
            dataInicialLabel.Size = new Size(105, 15);
            dataInicialLabel.TabIndex = 15;
            dataInicialLabel.Text = "Data inicial filtro:";
            dataInicialLabel.Visible = false;
            // 
            // dataFinalLabel
            // 
            dataFinalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataFinalLabel.AutoSize = true;
            dataFinalLabel.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataFinalLabel.Location = new Point(327, 63);
            dataFinalLabel.Name = "dataFinalLabel";
            dataFinalLabel.Size = new Size(94, 15);
            dataFinalLabel.TabIndex = 16;
            dataFinalLabel.Text = "Data final filtro:";
            dataFinalLabel.Visible = false;
            // 
            // TicketsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 524);
            Controls.Add(dataFinalLabel);
            Controls.Add(dataInicialLabel);
            Controls.Add(fimDateTimePicker);
            Controls.Add(inicioDateTimePicker);
            Controls.Add(filtroDataCheckBox);
            Controls.Add(employeeLabel);
            Controls.Add(label1);
            Controls.Add(insertButton);
            Controls.Add(editButton);
            Controls.Add(dataGridTickets);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicketsView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TicketManager / Menu de Tickets";
            Load += AddTickets_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridTickets;
        private Label label1;
        private Button insertButton;
        private Button editButton;
        private Label employeeLabel;
        private CheckBox filtroDataCheckBox;
        private DateTimePicker inicioDateTimePicker;
        private DateTimePicker fimDateTimePicker;
        private Label dataInicialLabel;
        private Label dataFinalLabel;
    }
}