namespace Decoder_Cinema
{
    partial class AddEmployee
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelIDE = new System.Windows.Forms.Label();
            this.comboBoxJobPosition = new System.Windows.Forms.ComboBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(132, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(81, 20);
            this.textBoxID.TabIndex = 25;
            // 
            // labelIDE
            // 
            this.labelIDE.AutoSize = true;
            this.labelIDE.BackColor = System.Drawing.Color.Transparent;
            this.labelIDE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIDE.Location = new System.Drawing.Point(92, 20);
            this.labelIDE.Name = "labelIDE";
            this.labelIDE.Size = new System.Drawing.Size(19, 12);
            this.labelIDE.TabIndex = 24;
            this.labelIDE.Text = "ID:";
            // 
            // comboBoxJobPosition
            // 
            this.comboBoxJobPosition.FormattingEnabled = true;
            this.comboBoxJobPosition.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor"});
            this.comboBoxJobPosition.Location = new System.Drawing.Point(132, 141);
            this.comboBoxJobPosition.Name = "comboBoxJobPosition";
            this.comboBoxJobPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJobPosition.TabIndex = 18;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddEmployee.Location = new System.Drawing.Point(0, 181);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(351, 25);
            this.buttonAddEmployee.TabIndex = 17;
            this.buttonAddEmployee.Text = "Registrar Empleado";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserName.Location = new System.Drawing.Point(13, 63);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(108, 12);
            this.labelUserName.TabIndex = 19;
            this.labelUserName.Text = "Nombre Completo:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(132, 101);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassword.TabIndex = 23;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPassword.Location = new System.Drawing.Point(36, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 12);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "Contraseña:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(132, 59);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(209, 20);
            this.textBoxUserName.TabIndex = 20;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelJobTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelJobTitle.Location = new System.Drawing.Point(51, 145);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(46, 12);
            this.labelJobTitle.TabIndex = 22;
            this.labelJobTitle.Text = "Puesto:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(351, 206);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelIDE);
            this.Controls.Add(this.comboBoxJobPosition);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelJobTitle);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelIDE;
        private System.Windows.Forms.ComboBox comboBoxJobPosition;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelJobTitle;
    }
}