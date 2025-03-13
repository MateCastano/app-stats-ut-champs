namespace SQL_FUTSCORE.Presentacion
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecordPrincipal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.dgvPlayersPrincipal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchPrincipal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWinsPrincipal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLossesPrincipal = new System.Windows.Forms.TextBox();
            this.btnGuardarPrincipal = new System.Windows.Forms.Button();
            this.btnCancelarPrincipal = new System.Windows.Forms.Button();
            this.btnSearchPrincipal = new System.Windows.Forms.Button();
            this.btnReloadPrincipal = new System.Windows.Forms.Button();
            this.btnResetRecordPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayersPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUT SCORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRecordPrincipal);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnPlayers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(772, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 507);
            this.panel2.TabIndex = 1;
            // 
            // btnRecordPrincipal
            // 
            this.btnRecordPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordPrincipal.Location = new System.Drawing.Point(55, 219);
            this.btnRecordPrincipal.Name = "btnRecordPrincipal";
            this.btnRecordPrincipal.Size = new System.Drawing.Size(106, 49);
            this.btnRecordPrincipal.TabIndex = 3;
            this.btnRecordPrincipal.Text = "Record";
            this.btnRecordPrincipal.UseVisualStyleBackColor = true;
            this.btnRecordPrincipal.Click += new System.EventHandler(this.btnRecordPrincipal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(55, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayers.Location = new System.Drawing.Point(55, 164);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(106, 49);
            this.btnPlayers.TabIndex = 0;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // dgvPlayersPrincipal
            // 
            this.dgvPlayersPrincipal.AllowUserToOrderColumns = true;
            this.dgvPlayersPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayersPrincipal.Location = new System.Drawing.Point(28, 189);
            this.dgvPlayersPrincipal.Name = "dgvPlayersPrincipal";
            this.dgvPlayersPrincipal.Size = new System.Drawing.Size(720, 277);
            this.dgvPlayersPrincipal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search:";
            // 
            // txtSearchPrincipal
            // 
            this.txtSearchPrincipal.Location = new System.Drawing.Point(90, 152);
            this.txtSearchPrincipal.Name = "txtSearchPrincipal";
            this.txtSearchPrincipal.Size = new System.Drawing.Size(204, 20);
            this.txtSearchPrincipal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Record:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wins:";
            // 
            // txtWinsPrincipal
            // 
            this.txtWinsPrincipal.Location = new System.Drawing.Point(104, 540);
            this.txtWinsPrincipal.Name = "txtWinsPrincipal";
            this.txtWinsPrincipal.Size = new System.Drawing.Size(42, 20);
            this.txtWinsPrincipal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Losses:";
            // 
            // txtLossesPrincipal
            // 
            this.txtLossesPrincipal.Location = new System.Drawing.Point(104, 567);
            this.txtLossesPrincipal.Name = "txtLossesPrincipal";
            this.txtLossesPrincipal.Size = new System.Drawing.Size(42, 20);
            this.txtLossesPrincipal.TabIndex = 10;
            // 
            // btnGuardarPrincipal
            // 
            this.btnGuardarPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrincipal.Location = new System.Drawing.Point(208, 552);
            this.btnGuardarPrincipal.Name = "btnGuardarPrincipal";
            this.btnGuardarPrincipal.Size = new System.Drawing.Size(67, 27);
            this.btnGuardarPrincipal.TabIndex = 4;
            this.btnGuardarPrincipal.Text = "Save";
            this.btnGuardarPrincipal.UseVisualStyleBackColor = true;
            this.btnGuardarPrincipal.Click += new System.EventHandler(this.btnGuardarPrincipal_Click);
            // 
            // btnCancelarPrincipal
            // 
            this.btnCancelarPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrincipal.Location = new System.Drawing.Point(354, 552);
            this.btnCancelarPrincipal.Name = "btnCancelarPrincipal";
            this.btnCancelarPrincipal.Size = new System.Drawing.Size(67, 27);
            this.btnCancelarPrincipal.TabIndex = 15;
            this.btnCancelarPrincipal.Text = "Cancel";
            this.btnCancelarPrincipal.UseVisualStyleBackColor = true;
            this.btnCancelarPrincipal.Click += new System.EventHandler(this.btnCancelarPrincipal_Click);
            // 
            // btnSearchPrincipal
            // 
            this.btnSearchPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrincipal.Location = new System.Drawing.Point(313, 148);
            this.btnSearchPrincipal.Name = "btnSearchPrincipal";
            this.btnSearchPrincipal.Size = new System.Drawing.Size(67, 27);
            this.btnSearchPrincipal.TabIndex = 16;
            this.btnSearchPrincipal.Text = "Search";
            this.btnSearchPrincipal.UseVisualStyleBackColor = true;
            this.btnSearchPrincipal.Click += new System.EventHandler(this.btnSearchPrincipal_Click);
            // 
            // btnReloadPrincipal
            // 
            this.btnReloadPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadPrincipal.Location = new System.Drawing.Point(681, 146);
            this.btnReloadPrincipal.Name = "btnReloadPrincipal";
            this.btnReloadPrincipal.Size = new System.Drawing.Size(67, 27);
            this.btnReloadPrincipal.TabIndex = 17;
            this.btnReloadPrincipal.Text = "Reload";
            this.btnReloadPrincipal.UseVisualStyleBackColor = true;
            this.btnReloadPrincipal.Click += new System.EventHandler(this.reloadPrincipal_Click);
            // 
            // btnResetRecordPrincipal
            // 
            this.btnResetRecordPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetRecordPrincipal.Location = new System.Drawing.Point(281, 552);
            this.btnResetRecordPrincipal.Name = "btnResetRecordPrincipal";
            this.btnResetRecordPrincipal.Size = new System.Drawing.Size(67, 27);
            this.btnResetRecordPrincipal.TabIndex = 18;
            this.btnResetRecordPrincipal.Text = "Reset";
            this.btnResetRecordPrincipal.UseVisualStyleBackColor = true;
            this.btnResetRecordPrincipal.Click += new System.EventHandler(this.btnResetRecordPrincipal_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 607);
            this.Controls.Add(this.btnResetRecordPrincipal);
            this.Controls.Add(this.btnReloadPrincipal);
            this.Controls.Add(this.btnSearchPrincipal);
            this.Controls.Add(this.btnCancelarPrincipal);
            this.Controls.Add(this.btnGuardarPrincipal);
            this.Controls.Add(this.txtLossesPrincipal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWinsPrincipal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchPrincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPlayersPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUT SCORE";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayersPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPlayersPrincipal;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchPrincipal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWinsPrincipal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLossesPrincipal;
        private System.Windows.Forms.Button btnRecordPrincipal;
        private System.Windows.Forms.Button btnGuardarPrincipal;
        private System.Windows.Forms.Button btnCancelarPrincipal;
        private System.Windows.Forms.Button btnSearchPrincipal;
        private System.Windows.Forms.Button btnReloadPrincipal;
        private System.Windows.Forms.Button btnResetRecordPrincipal;
    }
}