﻿namespace Punto_de_Venta.Pantallas
{
    partial class CashRegisterToUseWND
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseRegisterToUserWnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterToUseCB = new System.Windows.Forms.ComboBox();
            this.GoToSellerScreenbUTTN = new System.Windows.Forms.Button();
            this.dtpCajaCobro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNombreCajero = new System.Windows.Forms.ComboBox();
            this.cbIdCajero = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.CloseRegisterToUserWnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 0;
            // 
            // CloseRegisterToUserWnd
            // 
            this.CloseRegisterToUserWnd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CloseRegisterToUserWnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRegisterToUserWnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseRegisterToUserWnd.Location = new System.Drawing.Point(741, 0);
            this.CloseRegisterToUserWnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseRegisterToUserWnd.Name = "CloseRegisterToUserWnd";
            this.CloseRegisterToUserWnd.Size = new System.Drawing.Size(59, 42);
            this.CloseRegisterToUserWnd.TabIndex = 1;
            this.CloseRegisterToUserWnd.Text = "X";
            this.CloseRegisterToUserWnd.UseVisualStyleBackColor = true;
            this.CloseRegisterToUserWnd.Click += new System.EventHandler(this.CloseRegisterToUserWnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja a cobrar";
            // 
            // RegisterToUseCB
            // 
            this.RegisterToUseCB.BackColor = System.Drawing.Color.White;
            this.RegisterToUseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegisterToUseCB.FormattingEnabled = true;
            this.RegisterToUseCB.Location = new System.Drawing.Point(143, 154);
            this.RegisterToUseCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterToUseCB.Name = "RegisterToUseCB";
            this.RegisterToUseCB.Size = new System.Drawing.Size(220, 24);
            this.RegisterToUseCB.TabIndex = 1;
            this.RegisterToUseCB.SelectedIndexChanged += new System.EventHandler(this.RegisterToUseCB_SelectedIndexChanged);
            // 
            // GoToSellerScreenbUTTN
            // 
            this.GoToSellerScreenbUTTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.GoToSellerScreenbUTTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToSellerScreenbUTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToSellerScreenbUTTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GoToSellerScreenbUTTN.Location = new System.Drawing.Point(344, 209);
            this.GoToSellerScreenbUTTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoToSellerScreenbUTTN.Name = "GoToSellerScreenbUTTN";
            this.GoToSellerScreenbUTTN.Size = new System.Drawing.Size(141, 57);
            this.GoToSellerScreenbUTTN.TabIndex = 2;
            this.GoToSellerScreenbUTTN.Text = "Listo";
            this.GoToSellerScreenbUTTN.UseVisualStyleBackColor = false;
            this.GoToSellerScreenbUTTN.Click += new System.EventHandler(this.GoToSellerScreenbUTTN_Click);
            // 
            // dtpCajaCobro
            // 
            this.dtpCajaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCajaCobro.Location = new System.Drawing.Point(479, 155);
            this.dtpCajaCobro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCajaCobro.Name = "dtpCajaCobro";
            this.dtpCajaCobro.Size = new System.Drawing.Size(209, 22);
            this.dtpCajaCobro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione la caja a cobrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione la fecha de hoy";
            // 
            // cbNombreCajero
            // 
            this.cbNombreCajero.FormattingEnabled = true;
            this.cbNombreCajero.Location = new System.Drawing.Point(612, 240);
            this.cbNombreCajero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNombreCajero.Name = "cbNombreCajero";
            this.cbNombreCajero.Size = new System.Drawing.Size(41, 24);
            this.cbNombreCajero.TabIndex = 6;
            // 
            // cbIdCajero
            // 
            this.cbIdCajero.FormattingEnabled = true;
            this.cbIdCajero.Location = new System.Drawing.Point(663, 240);
            this.cbIdCajero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIdCajero.Name = "cbIdCajero";
            this.cbIdCajero.Size = new System.Drawing.Size(41, 24);
            this.cbIdCajero.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(599, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 70);
            this.panel2.TabIndex = 8;
            // 
            // CashRegisterToUseWND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbIdCajero);
            this.Controls.Add(this.cbNombreCajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCajaCobro);
            this.Controls.Add(this.GoToSellerScreenbUTTN);
            this.Controls.Add(this.RegisterToUseCB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CashRegisterToUseWND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashRegisterToUseWND";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RegisterToUseCB;
        private System.Windows.Forms.Button GoToSellerScreenbUTTN;
        private System.Windows.Forms.Button CloseRegisterToUserWnd;
        private System.Windows.Forms.DateTimePicker dtpCajaCobro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNombreCajero;
        private System.Windows.Forms.ComboBox cbIdCajero;
        private System.Windows.Forms.Panel panel2;
    }
}