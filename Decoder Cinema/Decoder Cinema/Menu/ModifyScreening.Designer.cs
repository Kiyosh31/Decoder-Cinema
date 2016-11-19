namespace Decoder_Cinema
{
    partial class ModifyScreening
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
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.buttonChooseM = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelIDE = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAvailable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(111, 183);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(82, 21);
            this.comboBoxRoom.TabIndex = 138;
            this.comboBoxRoom.Text = "...";
            this.comboBoxRoom.Click += new System.EventHandler(this.comboBoxRoom_Click);
            // 
            // buttonChooseM
            // 
            this.buttonChooseM.Location = new System.Drawing.Point(199, 210);
            this.buttonChooseM.Name = "buttonChooseM";
            this.buttonChooseM.Size = new System.Drawing.Size(33, 20);
            this.buttonChooseM.TabIndex = 137;
            this.buttonChooseM.Text = ".";
            this.buttonChooseM.UseVisualStyleBackColor = true;
            this.buttonChooseM.Click += new System.EventHandler(this.buttonChooseM_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(0, 266);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(346, 23);
            this.buttonModify.TabIndex = 136;
            this.buttonModify.Text = "Modificar";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.Enabled = false;
            this.textBoxMovie.Location = new System.Drawing.Point(111, 210);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(82, 20);
            this.textBoxMovie.TabIndex = 135;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "HH:mm:ss";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(111, 106);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.ShowUpDown = true;
            this.dateTimeStart.Size = new System.Drawing.Size(71, 20);
            this.dateTimeStart.TabIndex = 134;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "HH:mm:ss";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(111, 132);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowUpDown = true;
            this.dateTimeEnd.Size = new System.Drawing.Size(71, 20);
            this.dateTimeEnd.TabIndex = 133;
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDate.Location = new System.Drawing.Point(111, 158);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(201, 20);
            this.dateTimeDate.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(53, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 131;
            this.label5.Text = "Hora Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(65, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 130;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 129;
            this.label3.Text = "Sala No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 128;
            this.label2.Text = "Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 126;
            this.label1.Text = "Hora Inicio";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(65, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(54, 20);
            this.textBoxID.TabIndex = 127;
            // 
            // labelIDE
            // 
            this.labelIDE.AutoSize = true;
            this.labelIDE.BackColor = System.Drawing.Color.Transparent;
            this.labelIDE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIDE.Location = new System.Drawing.Point(40, 27);
            this.labelIDE.Name = "labelIDE";
            this.labelIDE.Size = new System.Drawing.Size(19, 12);
            this.labelIDE.TabIndex = 125;
            this.labelIDE.Text = "ID:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(63, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 124;
            this.label.Text = "Precio";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(111, 80);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(82, 20);
            this.textBoxPrice.TabIndex = 123;
            // 
            // textBoxAvailable
            // 
            this.textBoxAvailable.Enabled = false;
            this.textBoxAvailable.Location = new System.Drawing.Point(299, 23);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.Size = new System.Drawing.Size(35, 20);
            this.textBoxAvailable.TabIndex = 141;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(179, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 12);
            this.label7.TabIndex = 142;
            this.label7.Text = "Boletos Disponibles";
            // 
            // ModifyScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAvailable);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.buttonChooseM);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxMovie);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelIDE);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "ModifyScreening";
            this.Text = "ModifyScreening";
            this.Load += new System.EventHandler(this.ModifyScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Button buttonChooseM;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelIDE;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAvailable;
        private System.Windows.Forms.Label label7;
    }
}