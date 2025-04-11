
using TicketManager.Domian;
using TicketManager.View;

namespace TicketManager
{
    partial class EmployeeView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuColabLabel = new Label();
            editButton = new Button();
            insertButton = new Button();
            findEmployeesTextBox = new TextBox();
            dataGridEmployees = new DataGridView();
            avisoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).BeginInit();
            SuspendLayout();
            // 
            // MenuColabLabel
            // 
            MenuColabLabel.AutoSize = true;
            MenuColabLabel.Enabled = false;
            MenuColabLabel.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuColabLabel.Location = new Point(11, 7);
            MenuColabLabel.Name = "MenuColabLabel";
            MenuColabLabel.Size = new Size(213, 23);
            MenuColabLabel.TabIndex = 3;
            MenuColabLabel.Text = "Menu dos Colaboradores:";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.AutoSize = true;
            editButton.Font = new Font("Calibri", 11.25F);
            editButton.Location = new Point(718, 7);
            editButton.Name = "editButton";
            editButton.Size = new Size(67, 36);
            editButton.TabIndex = 2;
            editButton.Text = "Editar";
            editButton.TextImageRelation = TextImageRelation.ImageAboveText;
            editButton.UseVisualStyleBackColor = true;
            editButton.UseWaitCursor = true;
            editButton.Click += editButton_Click;
            // 
            // insertButton
            // 
            insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertButton.AutoSize = true;
            insertButton.Font = new Font("Calibri", 11.25F);
            insertButton.Location = new Point(645, 7);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(67, 36);
            insertButton.TabIndex = 1;
            insertButton.Text = "Inserir";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.UseWaitCursor = true;
            insertButton.Click += insertButton_Click;
            // 
            // findEmployeesTextBox
            // 
            findEmployeesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            findEmployeesTextBox.Font = new Font("Calibri", 11.25F);
            findEmployeesTextBox.ForeColor = SystemColors.WindowFrame;
            findEmployeesTextBox.Location = new Point(11, 50);
            findEmployeesTextBox.Margin = new Padding(7);
            findEmployeesTextBox.Name = "findEmployeesTextBox";
            findEmployeesTextBox.Size = new Size(773, 26);
            findEmployeesTextBox.TabIndex = 6;
            findEmployeesTextBox.Text = "Digite informações do colaborador";
            findEmployeesTextBox.Click += findEmployeesTextBox_Click;
            findEmployeesTextBox.TextChanged += findEmployeesTextBox_TextChanged;
            // 
            // dataGridEmployees
            // 
            dataGridEmployees.AllowUserToOrderColumns = true;
            dataGridEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridEmployees.BackgroundColor = SystemColors.ScrollBar;
            dataGridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployees.Location = new Point(12, 86);
            dataGridEmployees.Name = "dataGridEmployees";
            dataGridEmployees.ReadOnly = true;
            dataGridEmployees.Size = new Size(773, 352);
            dataGridEmployees.TabIndex = 5;
            dataGridEmployees.CellMouseDoubleClick += dataGridEmployees_CellMouseDoubleClick;
            // 
            // avisoLabel
            // 
            avisoLabel.AutoSize = true;
            avisoLabel.Enabled = false;
            avisoLabel.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avisoLabel.Location = new Point(11, 32);
            avisoLabel.Name = "avisoLabel";
            avisoLabel.Size = new Size(504, 14);
            avisoLabel.TabIndex = 7;
            avisoLabel.Text = "Aviso: Com dois cliques em um colaborador selecionado é possivel ver o menu de Tickets do mesmo.";
            avisoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(avisoLabel);
            Controls.Add(MenuColabLabel);
            Controls.Add(insertButton);
            Controls.Add(editButton);
            Controls.Add(findEmployeesTextBox);
            Controls.Add(dataGridEmployees);
            Name = "EmployeeView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TicketManager / Menu dos Colaboradores.";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void removerTicket_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void mainTab_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button insertButton;
        private Button editButton;
        private TextBox findEmployeesTextBox;
        private DataGridView dataGridEmployees;
        private Label MenuColabLabel;
        private Label avisoLabel;
    }
}
