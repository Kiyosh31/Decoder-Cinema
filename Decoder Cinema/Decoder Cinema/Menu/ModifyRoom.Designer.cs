namespace Decoder_Cinema
{
    partial class ModifyRoom
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
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelIDE = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonModify
            // 
            this.buttonModify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModify.Location = new System.Drawing.Point(0, 167);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(284, 25);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Modificar";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(123, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(54, 20);
            this.textBoxID.TabIndex = 100;
            // 
            // labelIDE
            // 
            this.labelIDE.AutoSize = true;
            this.labelIDE.BackColor = System.Drawing.Color.Transparent;
            this.labelIDE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIDE.Location = new System.Drawing.Point(98, 39);
            this.labelIDE.Name = "labelIDE";
            this.labelIDE.Size = new System.Drawing.Size(19, 12);
            this.labelIDE.TabIndex = 42;
            this.labelIDE.Text = "ID:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserName.Location = new System.Drawing.Point(68, 99);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(65, 12);
            this.labelUserName.TabIndex = 40;
            this.labelUserName.Text = "Capacidad";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(160, 95);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(45, 20);
            this.textBoxCapacity.TabIndex = 1;
            // 
            // ModifyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelIDE);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxCapacity);
            this.Name = "ModifyRoom";
            this.Text = "ModifyRoom";
            this.Load += new System.EventHandler(this.ModifyRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelIDE;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxCapacity;
    }
}