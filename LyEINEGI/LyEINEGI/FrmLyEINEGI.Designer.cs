
namespace LyEINEGI
{
    partial class FrmLyEINEGI
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEntidad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbEntidad = new System.Windows.Forms.ComboBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.lvLista = new System.Windows.Forms.ListView();
            this.cEntidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHom05 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMuj05 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHom10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMuj10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHom20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMuj20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbEntidad = new System.Windows.Forms.Label();
            this.lbGrubo = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.lb2005 = new System.Windows.Forms.Label();
            this.lb2015 = new System.Windows.Forms.Label();
            this.lb2020 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button1.Location = new System.Drawing.Point(544, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar por grupo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEntidad
            // 
            this.btnEntidad.BackColor = System.Drawing.Color.Snow;
            this.btnEntidad.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntidad.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnEntidad.Location = new System.Drawing.Point(544, 51);
            this.btnEntidad.Name = "btnEntidad";
            this.btnEntidad.Size = new System.Drawing.Size(267, 47);
            this.btnEntidad.TabIndex = 1;
            this.btnEntidad.Text = "Buscar por entidad";
            this.btnEntidad.UseVisualStyleBackColor = false;
            this.btnEntidad.Click += new System.EventHandler(this.btnEntidad_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button3.Location = new System.Drawing.Point(544, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buscar por sexo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button4.Location = new System.Drawing.Point(544, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Buscar por año";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // cbEntidad
            // 
            this.cbEntidad.BackColor = System.Drawing.Color.Snow;
            this.cbEntidad.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidad.FormattingEnabled = true;
            this.cbEntidad.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Bajo California Sur",
            "Campeche",
            "Coahuila de Zaragoza",
            "Colima",
            "Chiapas",
            "Chihuahua",
            "Ciudad de Mexico",
            "Durango",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Mexico",
            "Michoacan de Ocampo",
            "Morelos",
            "Narayit",
            "Nuevo Leon",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "Quintana Roo",
            "San Luis Potosi",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz de Ignacio de la Llave",
            "Yucatan",
            "Zacatecas"});
            this.cbEntidad.Location = new System.Drawing.Point(254, 60);
            this.cbEntidad.Name = "cbEntidad";
            this.cbEntidad.Size = new System.Drawing.Size(262, 24);
            this.cbEntidad.TabIndex = 4;
            // 
            // cbGrupo
            // 
            this.cbGrupo.BackColor = System.Drawing.Color.Snow;
            this.cbGrupo.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "0 a 4 años",
            "5 a 9 años",
            "10 a 14 años",
            "15 a 19 años",
            "20 a 24 años",
            "25 a 29 años",
            "30 a 34 años",
            "35 a 39 años",
            "40 a 44 años",
            "45 a 49 años",
            "50 a 54 años",
            "55 a 59 años",
            "60 a 64 años",
            "65 a 69 años",
            "70 a 74 años",
            "75 a 79 años",
            "80 a 84 años",
            "85 a 89 años",
            "90 a 94 años",
            "95 a 99 años",
            "100 años y más",
            "No especificado"});
            this.cbGrupo.Location = new System.Drawing.Point(308, 126);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(208, 24);
            this.cbGrupo.TabIndex = 5;
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.Snow;
            this.cbSexo.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Hombres",
            "Mujeres"});
            this.cbSexo.Location = new System.Drawing.Point(254, 200);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(262, 24);
            this.cbSexo.TabIndex = 6;
            // 
            // cbAño
            // 
            this.cbAño.BackColor = System.Drawing.Color.Snow;
            this.cbAño.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Items.AddRange(new object[] {
            "2005",
            "2010",
            "2020"});
            this.cbAño.Location = new System.Drawing.Point(254, 270);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(262, 24);
            this.cbAño.TabIndex = 7;
            // 
            // lvLista
            // 
            this.lvLista.BackColor = System.Drawing.Color.Snow;
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cEntidad,
            this.cGrupo,
            this.cHom05,
            this.cMuj05,
            this.cHom10,
            this.cMuj10,
            this.cHom20,
            this.cMuj20});
            this.lvLista.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(61, 405);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(959, 251);
            this.lvLista.TabIndex = 8;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // cEntidad
            // 
            this.cEntidad.Text = "Entidad Federativa";
            this.cEntidad.Width = 185;
            // 
            // cGrupo
            // 
            this.cGrupo.Text = "Grupo quinquenal de edad";
            this.cGrupo.Width = 196;
            // 
            // cHom05
            // 
            this.cHom05.Text = "Hombres";
            this.cHom05.Width = 100;
            // 
            // cMuj05
            // 
            this.cMuj05.Text = "Mujeres";
            this.cMuj05.Width = 96;
            // 
            // cHom10
            // 
            this.cHom10.Text = "Hombres";
            this.cHom10.Width = 89;
            // 
            // cMuj10
            // 
            this.cMuj10.Text = "Mujeres";
            this.cMuj10.Width = 90;
            // 
            // cHom20
            // 
            this.cHom20.Text = "Hombres";
            this.cHom20.Width = 90;
            // 
            // cMuj20
            // 
            this.cMuj20.Text = "Mujeres";
            this.cMuj20.Width = 98;
            // 
            // lbEntidad
            // 
            this.lbEntidad.AutoSize = true;
            this.lbEntidad.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntidad.ForeColor = System.Drawing.Color.Snow;
            this.lbEntidad.Location = new System.Drawing.Point(39, 63);
            this.lbEntidad.Name = "lbEntidad";
            this.lbEntidad.Size = new System.Drawing.Size(185, 21);
            this.lbEntidad.TabIndex = 9;
            this.lbEntidad.Text = "Entidad Federativa:";
            // 
            // lbGrubo
            // 
            this.lbGrubo.AutoSize = true;
            this.lbGrubo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrubo.ForeColor = System.Drawing.Color.Snow;
            this.lbGrubo.Location = new System.Drawing.Point(26, 126);
            this.lbGrubo.Name = "lbGrubo";
            this.lbGrubo.Size = new System.Drawing.Size(250, 21);
            this.lbGrubo.TabIndex = 10;
            this.lbGrubo.Text = "Grupo quinquenal de edad:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.ForeColor = System.Drawing.Color.Snow;
            this.lbSexo.Location = new System.Drawing.Point(168, 200);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(56, 21);
            this.lbSexo.TabIndex = 11;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAño.ForeColor = System.Drawing.Color.Snow;
            this.lbAño.Location = new System.Drawing.Point(174, 270);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(50, 21);
            this.lbAño.TabIndex = 12;
            this.lbAño.Text = "Año:";
            // 
            // lb2005
            // 
            this.lb2005.AutoSize = true;
            this.lb2005.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2005.ForeColor = System.Drawing.Color.Snow;
            this.lb2005.Location = new System.Drawing.Point(526, 372);
            this.lb2005.Name = "lb2005";
            this.lb2005.Size = new System.Drawing.Size(50, 21);
            this.lb2005.TabIndex = 13;
            this.lb2005.Text = "2005";
            // 
            // lb2015
            // 
            this.lb2015.AutoSize = true;
            this.lb2015.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2015.ForeColor = System.Drawing.Color.Snow;
            this.lb2015.Location = new System.Drawing.Point(711, 372);
            this.lb2015.Name = "lb2015";
            this.lb2015.Size = new System.Drawing.Size(50, 21);
            this.lb2015.TabIndex = 14;
            this.lb2015.Text = "2010";
            // 
            // lb2020
            // 
            this.lb2020.AutoSize = true;
            this.lb2020.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2020.ForeColor = System.Drawing.Color.Snow;
            this.lb2020.Location = new System.Drawing.Point(881, 372);
            this.lb2020.Name = "lb2020";
            this.lb2020.Size = new System.Drawing.Size(50, 21);
            this.lb2020.TabIndex = 15;
            this.lb2020.Text = "2020";
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.Snow;
            this.btnLeer.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLeer.Location = new System.Drawing.Point(893, 23);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(160, 61);
            this.btnLeer.TabIndex = 16;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = false;
            // 
            // FrmLyEINEGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1075, 684);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lb2020);
            this.Controls.Add(this.lb2015);
            this.Controls.Add(this.lb2005);
            this.Controls.Add(this.lbAño);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbGrubo);
            this.Controls.Add(this.lbEntidad);
            this.Controls.Add(this.lvLista);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.cbEntidad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEntidad);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLyEINEGI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INEGI";
            this.Load += new System.EventHandler(this.FrmLyEINEGI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEntidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbEntidad;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader cEntidad;
        private System.Windows.Forms.ColumnHeader cGrupo;
        private System.Windows.Forms.ColumnHeader cHom05;
        private System.Windows.Forms.ColumnHeader cMuj05;
        private System.Windows.Forms.ColumnHeader cHom10;
        private System.Windows.Forms.ColumnHeader cMuj10;
        private System.Windows.Forms.ColumnHeader cHom20;
        private System.Windows.Forms.ColumnHeader cMuj20;
        private System.Windows.Forms.Label lbEntidad;
        private System.Windows.Forms.Label lbGrubo;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.Label lb2005;
        private System.Windows.Forms.Label lb2015;
        private System.Windows.Forms.Label lb2020;
        private System.Windows.Forms.Button btnLeer;
    }
}

