﻿
namespace Punto_de_Venta
{
    partial class TicketReportScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTicketReportRecibo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultTicketReportRecibo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTicketReport = new System.Windows.Forms.DateTimePicker();
            this.cbTicketReport = new System.Windows.Forms.ComboBox();
            this.btnConsultTicketReport2 = new System.Windows.Forms.Button();
            this.btnReprintTicketNota = new System.Windows.Forms.Button();
            this.dataGridTicketReport = new System.Windows.Forms.DataGridView();
            this.btnConsultTicketReportNota = new System.Windows.Forms.Button();
            this.txtIdTicketReportNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReprintTicketRecibo = new System.Windows.Forms.Button();
            this.cbRecibo = new System.Windows.Forms.CheckBox();
            this.cbNota = new System.Windows.Forms.CheckBox();
            this.dataGridConsultaTicket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicketReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 56);
            this.label2.TabIndex = 85;
            this.label2.Text = "Recibos / Notas de crédito";
            // 
            // txtIdTicketReportRecibo
            // 
            this.txtIdTicketReportRecibo.Location = new System.Drawing.Point(57, 177);
            this.txtIdTicketReportRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdTicketReportRecibo.Multiline = true;
            this.txtIdTicketReportRecibo.Name = "txtIdTicketReportRecibo";
            this.txtIdTicketReportRecibo.Size = new System.Drawing.Size(312, 26);
            this.txtIdTicketReportRecibo.TabIndex = 88;
            this.txtIdTicketReportRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTicketReport_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 30);
            this.label1.TabIndex = 87;
            this.label1.Text = "Número de recibo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultTicketReportRecibo
            // 
            this.btnConsultTicketReportRecibo.BackColor = System.Drawing.Color.Navy;
            this.btnConsultTicketReportRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultTicketReportRecibo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultTicketReportRecibo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultTicketReportRecibo.Location = new System.Drawing.Point(57, 212);
            this.btnConsultTicketReportRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultTicketReportRecibo.Name = "btnConsultTicketReportRecibo";
            this.btnConsultTicketReportRecibo.Size = new System.Drawing.Size(185, 63);
            this.btnConsultTicketReportRecibo.TabIndex = 89;
            this.btnConsultTicketReportRecibo.Text = "Consultar";
            this.btnConsultTicketReportRecibo.UseVisualStyleBackColor = false;
            this.btnConsultTicketReportRecibo.Click += new System.EventHandler(this.btnConsultTicketReport1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 558);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 30);
            this.label3.TabIndex = 90;
            this.label3.Text = "Fecha de venta y Caja ";
            // 
            // dtpTicketReport
            // 
            this.dtpTicketReport.Location = new System.Drawing.Point(57, 599);
            this.dtpTicketReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTicketReport.Name = "dtpTicketReport";
            this.dtpTicketReport.Size = new System.Drawing.Size(268, 22);
            this.dtpTicketReport.TabIndex = 92;
            this.dtpTicketReport.ValueChanged += new System.EventHandler(this.dtpTicketReport_ValueChanged);
            // 
            // cbTicketReport
            // 
            this.cbTicketReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketReport.FormattingEnabled = true;
            this.cbTicketReport.Location = new System.Drawing.Point(57, 631);
            this.cbTicketReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTicketReport.Name = "cbTicketReport";
            this.cbTicketReport.Size = new System.Drawing.Size(268, 24);
            this.cbTicketReport.TabIndex = 93;
            this.cbTicketReport.SelectedIndexChanged += new System.EventHandler(this.cbTicketReport_SelectedIndexChanged);
            // 
            // btnConsultTicketReport2
            // 
            this.btnConsultTicketReport2.BackColor = System.Drawing.Color.Navy;
            this.btnConsultTicketReport2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultTicketReport2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultTicketReport2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultTicketReport2.Location = new System.Drawing.Point(57, 665);
            this.btnConsultTicketReport2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultTicketReport2.Name = "btnConsultTicketReport2";
            this.btnConsultTicketReport2.Size = new System.Drawing.Size(185, 63);
            this.btnConsultTicketReport2.TabIndex = 94;
            this.btnConsultTicketReport2.Text = "Filtrar";
            this.btnConsultTicketReport2.UseVisualStyleBackColor = false;
            this.btnConsultTicketReport2.Click += new System.EventHandler(this.btnConsultTicketReport2_Click);
            // 
            // btnReprintTicketNota
            // 
            this.btnReprintTicketNota.BackColor = System.Drawing.Color.Green;
            this.btnReprintTicketNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReprintTicketNota.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintTicketNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReprintTicketNota.Location = new System.Drawing.Point(264, 416);
            this.btnReprintTicketNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReprintTicketNota.Name = "btnReprintTicketNota";
            this.btnReprintTicketNota.Size = new System.Drawing.Size(185, 63);
            this.btnReprintTicketNota.TabIndex = 95;
            this.btnReprintTicketNota.Text = "Reimprimir";
            this.btnReprintTicketNota.UseVisualStyleBackColor = false;
            this.btnReprintTicketNota.Click += new System.EventHandler(this.btnReprintTicketNota_Click);
            // 
            // dataGridTicketReport
            // 
            this.dataGridTicketReport.AllowUserToAddRows = false;
            this.dataGridTicketReport.AllowUserToDeleteRows = false;
            this.dataGridTicketReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridTicketReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTicketReport.Location = new System.Drawing.Point(555, 132);
            this.dataGridTicketReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridTicketReport.Name = "dataGridTicketReport";
            this.dataGridTicketReport.ReadOnly = true;
            this.dataGridTicketReport.RowHeadersWidth = 51;
            this.dataGridTicketReport.Size = new System.Drawing.Size(655, 606);
            this.dataGridTicketReport.TabIndex = 99;
            // 
            // btnConsultTicketReportNota
            // 
            this.btnConsultTicketReportNota.BackColor = System.Drawing.Color.Navy;
            this.btnConsultTicketReportNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultTicketReportNota.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultTicketReportNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultTicketReportNota.Location = new System.Drawing.Point(57, 416);
            this.btnConsultTicketReportNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultTicketReportNota.Name = "btnConsultTicketReportNota";
            this.btnConsultTicketReportNota.Size = new System.Drawing.Size(185, 63);
            this.btnConsultTicketReportNota.TabIndex = 102;
            this.btnConsultTicketReportNota.Text = "Consultar";
            this.btnConsultTicketReportNota.UseVisualStyleBackColor = false;
            this.btnConsultTicketReportNota.Click += new System.EventHandler(this.btnConsultTicketReportNota_Click);
            // 
            // txtIdTicketReportNota
            // 
            this.txtIdTicketReportNota.Location = new System.Drawing.Point(57, 382);
            this.txtIdTicketReportNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdTicketReportNota.Multiline = true;
            this.txtIdTicketReportNota.Name = "txtIdTicketReportNota";
            this.txtIdTicketReportNota.Size = new System.Drawing.Size(312, 26);
            this.txtIdTicketReportNota.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 30);
            this.label5.TabIndex = 100;
            this.label5.Text = "Nota de crédito";
            // 
            // btnReprintTicketRecibo
            // 
            this.btnReprintTicketRecibo.BackColor = System.Drawing.Color.Green;
            this.btnReprintTicketRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReprintTicketRecibo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintTicketRecibo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReprintTicketRecibo.Location = new System.Drawing.Point(264, 212);
            this.btnReprintTicketRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReprintTicketRecibo.Name = "btnReprintTicketRecibo";
            this.btnReprintTicketRecibo.Size = new System.Drawing.Size(185, 63);
            this.btnReprintTicketRecibo.TabIndex = 103;
            this.btnReprintTicketRecibo.Text = "Reimprimir";
            this.btnReprintTicketRecibo.UseVisualStyleBackColor = false;
            this.btnReprintTicketRecibo.Click += new System.EventHandler(this.btnReprintTicketRecibo_Click);
            // 
            // cbRecibo
            // 
            this.cbRecibo.AutoSize = true;
            this.cbRecibo.Location = new System.Drawing.Point(92, 96);
            this.cbRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRecibo.Name = "cbRecibo";
            this.cbRecibo.Size = new System.Drawing.Size(74, 21);
            this.cbRecibo.TabIndex = 105;
            this.cbRecibo.Text = "Recibo";
            this.cbRecibo.UseVisualStyleBackColor = true;
            this.cbRecibo.Click += new System.EventHandler(this.cbRecibo_Click);
            // 
            // cbNota
            // 
            this.cbNota.AutoSize = true;
            this.cbNota.Location = new System.Drawing.Point(207, 96);
            this.cbNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNota.Name = "cbNota";
            this.cbNota.Size = new System.Drawing.Size(129, 21);
            this.cbNota.TabIndex = 106;
            this.cbNota.Text = "Nota de Credito";
            this.cbNota.UseVisualStyleBackColor = true;
            this.cbNota.Click += new System.EventHandler(this.cbNota_Click);
            // 
            // dataGridConsultaTicket
            // 
            this.dataGridConsultaTicket.AllowUserToAddRows = false;
            this.dataGridConsultaTicket.AllowUserToDeleteRows = false;
            this.dataGridConsultaTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaTicket.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridConsultaTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaTicket.Location = new System.Drawing.Point(367, 558);
            this.dataGridConsultaTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridConsultaTicket.Name = "dataGridConsultaTicket";
            this.dataGridConsultaTicket.ReadOnly = true;
            this.dataGridConsultaTicket.RowHeadersWidth = 51;
            this.dataGridConsultaTicket.Size = new System.Drawing.Size(155, 180);
            this.dataGridConsultaTicket.TabIndex = 107;
            // 
            // TicketReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1245, 777);
            this.Controls.Add(this.dataGridConsultaTicket);
            this.Controls.Add(this.cbNota);
            this.Controls.Add(this.cbRecibo);
            this.Controls.Add(this.btnReprintTicketRecibo);
            this.Controls.Add(this.btnConsultTicketReportNota);
            this.Controls.Add(this.txtIdTicketReportNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridTicketReport);
            this.Controls.Add(this.btnReprintTicketNota);
            this.Controls.Add(this.btnConsultTicketReport2);
            this.Controls.Add(this.cbTicketReport);
            this.Controls.Add(this.dtpTicketReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultTicketReportRecibo);
            this.Controls.Add(this.txtIdTicketReportRecibo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketReportScreen";
            this.Text = "Consulta de Recibos";
            this.Load += new System.EventHandler(this.TicketReportScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicketReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTicketReportRecibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultTicketReportRecibo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTicketReport;
        private System.Windows.Forms.ComboBox cbTicketReport;
        private System.Windows.Forms.Button btnConsultTicketReport2;
        private System.Windows.Forms.Button btnReprintTicketNota;
        private System.Windows.Forms.DataGridView dataGridTicketReport;
        private System.Windows.Forms.Button btnConsultTicketReportNota;
        private System.Windows.Forms.TextBox txtIdTicketReportNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReprintTicketRecibo;
        private System.Windows.Forms.CheckBox cbRecibo;
        private System.Windows.Forms.CheckBox cbNota;
        private System.Windows.Forms.DataGridView dataGridConsultaTicket;
    }
}