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
            this.gb_minhas_reservas = new System.Windows.Forms.GroupBox();
            this.lb_minhas_reservas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnReserva = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.gb_minhas_reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_minhas_reservas
            // 
            this.gb_minhas_reservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_minhas_reservas.Controls.Add(this.BtnSair);
            this.gb_minhas_reservas.Controls.Add(this.lb_minhas_reservas);
            this.gb_minhas_reservas.Controls.Add(this.BtnReserva);
            this.gb_minhas_reservas.Controls.Add(this.dataGridView1);
            this.gb_minhas_reservas.Location = new System.Drawing.Point(25, 25);
            this.gb_minhas_reservas.Margin = new System.Windows.Forms.Padding(4);
            this.gb_minhas_reservas.Name = "gb_minhas_reservas";
            this.gb_minhas_reservas.Padding = new System.Windows.Forms.Padding(4);
            this.gb_minhas_reservas.Size = new System.Drawing.Size(700, 485);
            this.gb_minhas_reservas.TabIndex = 0;
            this.gb_minhas_reservas.TabStop = false;
            // 
            // lb_minhas_reservas
            // 
            this.lb_minhas_reservas.AutoSize = true;
            this.lb_minhas_reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_minhas_reservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_minhas_reservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lb_minhas_reservas.Location = new System.Drawing.Point(10, 10);
            this.lb_minhas_reservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_minhas_reservas.Name = "lb_minhas_reservas";
            this.lb_minhas_reservas.Size = new System.Drawing.Size(169, 24);
            this.lb_minhas_reservas.TabIndex = 1;
            this.lb_minhas_reservas.Text = "Minhas Reservas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(8, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnReserva
            // 
            this.BtnReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnReserva.FlatAppearance.BorderSize = 0;
            this.BtnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReserva.Location = new System.Drawing.Point(465, 9);
            this.BtnReserva.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReserva.Name = "BtnReserva";
            this.BtnReserva.Size = new System.Drawing.Size(110, 30);
            this.BtnReserva.TabIndex = 7;
            this.BtnReserva.Text = "Nova reserva";
            this.BtnReserva.UseVisualStyleBackColor = false;
            this.BtnReserva.Click += new System.EventHandler(this.BtnReserva_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(582, 9);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(110, 30);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.gb_minhas_reservas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.gb_minhas_reservas.ResumeLayout(false);
            this.gb_minhas_reservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_minhas_reservas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_minhas_reservas;
        private System.Windows.Forms.Button BtnReserva;
        private System.Windows.Forms.Button BtnSair;
    }
}