namespace Decoder_Cinema
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSellTicket = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReportSale = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPelículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFunciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Decoder_Cinema.Properties.Resources.Logo_Decoder;
            this.pictureBox1.Location = new System.Drawing.Point(98, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSellTicket
            // 
            this.buttonSellTicket.BackColor = System.Drawing.Color.Transparent;
            this.buttonSellTicket.BackgroundImage = global::Decoder_Cinema.Properties.Resources.Clip2;
            this.buttonSellTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSellTicket.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellTicket.Location = new System.Drawing.Point(169, 281);
            this.buttonSellTicket.Name = "buttonSellTicket";
            this.buttonSellTicket.Size = new System.Drawing.Size(211, 132);
            this.buttonSellTicket.TabIndex = 5;
            this.buttonSellTicket.Text = "Venta de boletos";
            this.buttonSellTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSellTicket.UseVisualStyleBackColor = false;
            this.buttonSellTicket.Click += new System.EventHandler(this.buttonSellTicket_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUser.Location = new System.Drawing.Point(12, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(70, 12);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Bienvenido:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Decoder_Cinema.Properties.Resources.Logout;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(822, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 52);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReportSale
            // 
            this.buttonReportSale.BackColor = System.Drawing.Color.Transparent;
            this.buttonReportSale.BackgroundImage = global::Decoder_Cinema.Properties.Resources.Admin;
            this.buttonReportSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReportSale.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReportSale.Location = new System.Drawing.Point(516, 281);
            this.buttonReportSale.Name = "buttonReportSale";
            this.buttonReportSale.Size = new System.Drawing.Size(211, 132);
            this.buttonReportSale.TabIndex = 13;
            this.buttonReportSale.Text = "Reporte de ventas";
            this.buttonReportSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReportSale.UseVisualStyleBackColor = false;
            this.buttonReportSale.Click += new System.EventHandler(this.buttonReportSale_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.películasToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.funcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registrarNuevoToolStripMenuItem
            // 
            this.registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            this.registrarNuevoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.registrarNuevoToolStripMenuItem.Text = "Registrar Nuevo";
            this.registrarNuevoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoToolStripMenuItem1,
            this.administrarToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registrarNuevoToolStripMenuItem1
            // 
            this.registrarNuevoToolStripMenuItem1.Name = "registrarNuevoToolStripMenuItem1";
            this.registrarNuevoToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.registrarNuevoToolStripMenuItem1.Text = "Registrar Nuevo";
            this.registrarNuevoToolStripMenuItem1.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem1_Click);
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            this.administrarToolStripMenuItem1.Click += new System.EventHandler(this.administrarToolStripMenuItem1_Click);
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPelículaToolStripMenuItem,
            this.administrarToolStripMenuItem2});
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.películasToolStripMenuItem.Text = "Películas";
            // 
            // nuevaPelículaToolStripMenuItem
            // 
            this.nuevaPelículaToolStripMenuItem.Name = "nuevaPelículaToolStripMenuItem";
            this.nuevaPelículaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaPelículaToolStripMenuItem.Text = "Nueva Película";
            this.nuevaPelículaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPelículaToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem2
            // 
            this.administrarToolStripMenuItem2.Name = "administrarToolStripMenuItem2";
            this.administrarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.administrarToolStripMenuItem2.Text = "Administrar";
            this.administrarToolStripMenuItem2.Click += new System.EventHandler(this.administrarToolStripMenuItem2_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSalaToolStripMenuItem,
            this.administrarToolStripMenuItem3});
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // registrarSalaToolStripMenuItem
            // 
            this.registrarSalaToolStripMenuItem.Name = "registrarSalaToolStripMenuItem";
            this.registrarSalaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.registrarSalaToolStripMenuItem.Text = "Registrar Sala";
            this.registrarSalaToolStripMenuItem.Click += new System.EventHandler(this.registrarSalaToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem3
            // 
            this.administrarToolStripMenuItem3.Name = "administrarToolStripMenuItem3";
            this.administrarToolStripMenuItem3.Size = new System.Drawing.Size(144, 22);
            this.administrarToolStripMenuItem3.Text = "Administrar";
            this.administrarToolStripMenuItem3.Click += new System.EventHandler(this.administrarToolStripMenuItem3_Click);
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFunciónToolStripMenuItem,
            this.administrarToolStripMenuItem4});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // nuevaFunciónToolStripMenuItem
            // 
            this.nuevaFunciónToolStripMenuItem.Name = "nuevaFunciónToolStripMenuItem";
            this.nuevaFunciónToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nuevaFunciónToolStripMenuItem.Text = "Nueva Función";
            this.nuevaFunciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaFunciónToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem4
            // 
            this.administrarToolStripMenuItem4.Name = "administrarToolStripMenuItem4";
            this.administrarToolStripMenuItem4.Size = new System.Drawing.Size(154, 22);
            this.administrarToolStripMenuItem4.Text = "Administrar";
            this.administrarToolStripMenuItem4.Click += new System.EventHandler(this.administrarToolStripMenuItem4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(808, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cerrar Sesión";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReportSale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonSellTicket);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decoder Cinema Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSellTicket;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReportSale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPelículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFunciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem4;
        private System.Windows.Forms.Label label1;
    }
}