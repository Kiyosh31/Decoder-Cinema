namespace Decoder_Cinema
{
    partial class ModifyEmployee
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
            this.buttonModifyEmployee = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(132, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(81, 20);
            this.textBoxID.TabIndex = 100;
            // 
            // labelIDE
            // 
            this.labelIDE.AutoSize = true;
            this.labelIDE.BackColor = System.Drawing.Color.Transparent;
            this.labelIDE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIDE.Location = new System.Drawing.Point(92, 23);
            this.labelIDE.Name = "labelIDE";
            this.labelIDE.Size = new System.Drawing.Size(19, 12);
            this.labelIDE.TabIndex = 33;
            this.labelIDE.Text = "ID:";
            // 
            // comboBoxJobPosition
            // 
            this.comboBoxJobPosition.FormattingEnabled = true;
            this.comboBoxJobPosition.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor"});
            this.comboBoxJobPosition.Location = new System.Drawing.Point(132, 144);
            this.comboBoxJobPosition.Name = "comboBoxJobPosition";
            this.comboBoxJobPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJobPosition.TabIndex = 3;
            // 
            // buttonModifyEmployee
            // 
            this.buttonModifyEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonModifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModifyEmployee.Location = new System.Drawing.Point(0, 181);
            this.buttonModifyEmployee.Name = "buttonModifyEmployee";
            this.buttonModifyEmployee.Size = new System.Drawing.Size(351, 25);
            this.buttonModifyEmployee.TabIndex = 4;
            this.buttonModifyEmployee.Text = "Modificar";
            this.buttonModifyEmployee.UseVisualStyleBackColor = true;
            this.buttonModifyEmployee.Click += new System.EventHandler(this.buttonModifyEmployee_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserName.Location = new System.Drawing.Point(13, 66);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(108, 12);
            this.labelUserName.TabIndex = 28;
            this.labelUserName.Text = "Nombre Completo:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(132, 104);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPassword.Location = new System.Drawing.Point(36, 107);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 12);
            this.labelPassword.TabIndex = 30;
            this.labelPassword.Text = "Contraseña:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(132, 62);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(209, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelJobTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelJobTitle.Location = new System.Drawing.Point(51, 148);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(46, 12);
            this.labelJobTitle.TabIndex = 31;
            this.labelJobTitle.Text = "Puesto:";
            // 
            // ModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(351, 206);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelIDE);
            this.Controls.Add(this.comboBoxJobPosition);
            this.Controls.Add(this.buttonModifyEmployee);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelJobTitle);
            this.Name = "ModifyEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyEmployee";
            this.Load += new System.EventHandler(this.ModifyEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelIDE;
        private System.Windows.Forms.ComboBox comboBoxJobPosition;
        private System.Windows.Forms.Button buttonModifyEmployee;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelJobTitle;
    }
}