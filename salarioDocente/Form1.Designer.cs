namespace salarioDocente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            MetroSuite.MetroButton.MainColorScheme mainColorScheme1 = new MetroSuite.MetroButton.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtAños = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Antiguo",
            "Nuevo"});
            this.comboBox1.Location = new System.Drawing.Point(242, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(44, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 148);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Años de servicio";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Incremento";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Liquido Pagable";
            this.columnHeader5.Width = 102;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(44, 87);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Nombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(139, 23);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Nombre";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAños
            // 
            // 
            // 
            // 
            this.txtAños.CustomButton.Image = null;
            this.txtAños.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtAños.CustomButton.Name = "";
            this.txtAños.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAños.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAños.CustomButton.TabIndex = 1;
            this.txtAños.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAños.CustomButton.UseSelectable = true;
            this.txtAños.CustomButton.Visible = false;
            this.txtAños.Lines = new string[0];
            this.txtAños.Location = new System.Drawing.Point(396, 87);
            this.txtAños.MaxLength = 32767;
            this.txtAños.Name = "txtAños";
            this.txtAños.PasswordChar = '\0';
            this.txtAños.PromptText = "Años trabajados";
            this.txtAños.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAños.SelectedText = "";
            this.txtAños.SelectionLength = 0;
            this.txtAños.SelectionStart = 0;
            this.txtAños.ShortcutsEnabled = true;
            this.txtAños.Size = new System.Drawing.Size(115, 23);
            this.txtAños.TabIndex = 7;
            this.txtAños.UseSelectable = true;
            this.txtAños.WaterMark = "Años trabajados";
            this.txtAños.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAños.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            mainColorScheme1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            mainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.FillColor = System.Drawing.Color.White;
            mainColorScheme1.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme1.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            mainColorScheme1.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.metroButton1.ColorScheme = mainColorScheme1;
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(232, 126);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 27);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Mostrar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel1.ForeColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            this.metroLabel1.ForeColorNormal = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(270, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 15);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Estado";
            this.metroLabel1.UseHoverMode = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(575, 335);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Administracion de Salarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtAños;
        private MetroSuite.MetroButton metroButton1;
        private MetroSuite.MetroLabel metroLabel1;
    }
}

