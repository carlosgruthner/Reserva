namespace Reserva
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.GrupoReservas = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Reservas = new System.Windows.Forms.Label();
            this.TabelaReserva = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.Sala = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CursoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Termino = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Microfone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Audio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GrupoReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoReservas
            // 
            this.GrupoReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoReservas.Controls.Add(this.BtnExcluir);
            this.GrupoReservas.Controls.Add(this.dateTimePicker1);
            this.GrupoReservas.Controls.Add(this.Reservas);
            this.GrupoReservas.Controls.Add(this.TabelaReserva);
            this.GrupoReservas.Location = new System.Drawing.Point(11, 11);
            this.GrupoReservas.Margin = new System.Windows.Forms.Padding(2);
            this.GrupoReservas.Name = "GrupoReservas";
            this.GrupoReservas.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoReservas.Size = new System.Drawing.Size(1092, 524);
            this.GrupoReservas.TabIndex = 0;
            this.GrupoReservas.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(735, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Reservas
            // 
            this.Reservas.AutoSize = true;
            this.Reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Reservas.Location = new System.Drawing.Point(2, 10);
            this.Reservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reservas.Name = "Reservas";
            this.Reservas.Size = new System.Drawing.Size(96, 24);
            this.Reservas.TabIndex = 1;
            this.Reservas.Text = "Reservas";
            // 
            // TabelaReserva
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaReserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TabelaReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelaReserva.BackgroundColor = System.Drawing.Color.White;
            this.TabelaReserva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabelaReserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TabelaReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sala,
            this.CursoDisciplina,
            this.Serie,
            this.Inicio,
            this.Termino,
            this.NomeProfessor,
            this.PC,
            this.DataShow,
            this.Microfone,
            this.Audio});
            this.TabelaReserva.GridColor = System.Drawing.SystemColors.Control;
            this.TabelaReserva.Location = new System.Drawing.Point(0, 51);
            this.TabelaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.TabelaReserva.Name = "TabelaReserva";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaReserva.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaReserva.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.TabelaReserva.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TabelaReserva.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TabelaReserva.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TabelaReserva.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaReserva.Size = new System.Drawing.Size(1092, 465);
            this.TabelaReserva.TabIndex = 0;
            this.TabelaReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaReserva_CellContentClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Location = new System.Drawing.Point(965, 10);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(120, 25);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir Reserva";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // Sala
            // 
            this.Sala.AutoComplete = false;
            this.Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sala.HeaderText = "Sala";
            this.Sala.Items.AddRange(new object[] {
            "SALA 01",
            "SALA 02",
            "SALA 03",
            "SALA 04",
            "SALA 05",
            "SALA 06",
            "SALA 07",
            "SALA 08",
            "SALA 09",
            "SALA 10"});
            this.Sala.Name = "Sala";
            this.Sala.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sala.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sala.ToolTipText = "Sala que será utilizado o equipamento. Ex.: 01";
            this.Sala.Width = 80;
            // 
            // CursoDisciplina
            // 
            this.CursoDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CursoDisciplina.HeaderText = "Curso/Disciplina";
            this.CursoDisciplina.MaxInputLength = 400;
            this.CursoDisciplina.Name = "CursoDisciplina";
            this.CursoDisciplina.Width = 200;
            // 
            // Serie
            // 
            this.Serie.AutoComplete = false;
            this.Serie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Serie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serie.HeaderText = "Serie";
            this.Serie.Items.AddRange(new object[] {
            "1º FUND",
            "2º FUND",
            "3º FUND",
            "4º FUND",
            "5º FUND",
            "6º FUND",
            "7º FUND",
            "8º FUND",
            "9º FUND",
            "1º MED",
            "2º MED",
            "3º MED"});
            this.Serie.Name = "Serie";
            this.Serie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Serie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Serie.Width = 80;
            // 
            // Inicio
            // 
            this.Inicio.AutoComplete = false;
            this.Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Items.AddRange(new object[] {
            "08:00",
            "10:00",
            "13:00",
            "15:00"});
            this.Inicio.Name = "Inicio";
            this.Inicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Inicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Inicio.Width = 80;
            // 
            // Termino
            // 
            this.Termino.AutoComplete = false;
            this.Termino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Termino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Termino.HeaderText = "Termino";
            this.Termino.Items.AddRange(new object[] {
            "09:45",
            "12:00",
            "14:45",
            "18:00"});
            this.Termino.Name = "Termino";
            this.Termino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Termino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Termino.Width = 80;
            // 
            // NomeProfessor
            // 
            this.NomeProfessor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomeProfessor.HeaderText = "Nome Professor(a)";
            this.NomeProfessor.MaxInputLength = 400;
            this.NomeProfessor.Name = "NomeProfessor";
            this.NomeProfessor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NomeProfessor.Width = 250;
            // 
            // PC
            // 
            this.PC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PC.HeaderText = "PC";
            this.PC.Name = "PC";
            this.PC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PC.Width = 50;
            // 
            // DataShow
            // 
            this.DataShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataShow.HeaderText = "Data Show";
            this.DataShow.Name = "DataShow";
            this.DataShow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataShow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Microfone
            // 
            this.Microfone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Microfone.HeaderText = "Microfone";
            this.Microfone.Name = "Microfone";
            this.Microfone.Width = 75;
            // 
            // Audio
            // 
            this.Audio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Audio.HeaderText = "Audio";
            this.Audio.Name = "Audio";
            this.Audio.Width = 50;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1114, 550);
            this.Controls.Add(this.GrupoReservas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.GrupoReservas.ResumeLayout(false);
            this.GrupoReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoReservas;
        private System.Windows.Forms.DataGridView TabelaReserva;
        private System.Windows.Forms.Label Reservas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoDisciplina;
        private System.Windows.Forms.DataGridViewComboBoxColumn Serie;
        private System.Windows.Forms.DataGridViewComboBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProfessor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataShow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Microfone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Audio;
    }
}