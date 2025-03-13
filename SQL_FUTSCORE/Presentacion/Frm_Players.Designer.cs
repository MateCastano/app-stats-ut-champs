namespace SQL_FUTSCORE.Presentacion
{
    partial class Frm_Players
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Players));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamePlayers = new System.Windows.Forms.TextBox();
            this.btnSavePlayer = new System.Windows.Forms.Button();
            this.btnCancelPlayers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListadoPlayers = new System.Windows.Forms.DataGridView();
            this.btnNewPlayerPlayers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGoalsPlayers = new System.Windows.Forms.Label();
            this.txtGoalsPlayers = new System.Windows.Forms.TextBox();
            this.lblAssistPlayers = new System.Windows.Forms.Label();
            this.txtAssistsPlayers = new System.Windows.Forms.TextBox();
            this.btnEliminarPlayers = new System.Windows.Forms.Button();
            this.btnReloadPlayers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FUT SCORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // txtNamePlayers
            // 
            this.txtNamePlayers.Location = new System.Drawing.Point(103, 117);
            this.txtNamePlayers.Name = "txtNamePlayers";
            this.txtNamePlayers.Size = new System.Drawing.Size(250, 20);
            this.txtNamePlayers.TabIndex = 3;
            // 
            // btnSavePlayer
            // 
            this.btnSavePlayer.Location = new System.Drawing.Point(382, 114);
            this.btnSavePlayer.Name = "btnSavePlayer";
            this.btnSavePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnSavePlayer.TabIndex = 4;
            this.btnSavePlayer.Text = "Save";
            this.btnSavePlayer.UseVisualStyleBackColor = true;
            this.btnSavePlayer.Click += new System.EventHandler(this.btnSavePlayer_Click);
            // 
            // btnCancelPlayers
            // 
            this.btnCancelPlayers.Location = new System.Drawing.Point(463, 114);
            this.btnCancelPlayers.Name = "btnCancelPlayers";
            this.btnCancelPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPlayers.TabIndex = 5;
            this.btnCancelPlayers.Text = "Cancel";
            this.btnCancelPlayers.UseVisualStyleBackColor = true;
            this.btnCancelPlayers.Click += new System.EventHandler(this.btnCancelPlayers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select a player to edit:";
            // 
            // dgvListadoPlayers
            // 
            this.dgvListadoPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPlayers.Location = new System.Drawing.Point(48, 218);
            this.dgvListadoPlayers.Name = "dgvListadoPlayers";
            this.dgvListadoPlayers.Size = new System.Drawing.Size(490, 216);
            this.dgvListadoPlayers.TabIndex = 7;
            // 
            // btnNewPlayerPlayers
            // 
            this.btnNewPlayerPlayers.Location = new System.Drawing.Point(419, 143);
            this.btnNewPlayerPlayers.Name = "btnNewPlayerPlayers";
            this.btnNewPlayerPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlayerPlayers.TabIndex = 8;
            this.btnNewPlayerPlayers.Text = "New player";
            this.btnNewPlayerPlayers.UseVisualStyleBackColor = true;
            this.btnNewPlayerPlayers.Click += new System.EventHandler(this.btnNewPlayerPlayers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblGoalsPlayers
            // 
            this.lblGoalsPlayers.AutoSize = true;
            this.lblGoalsPlayers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalsPlayers.Location = new System.Drawing.Point(44, 147);
            this.lblGoalsPlayers.Name = "lblGoalsPlayers";
            this.lblGoalsPlayers.Size = new System.Drawing.Size(50, 19);
            this.lblGoalsPlayers.TabIndex = 10;
            this.lblGoalsPlayers.Text = "Goals:";
            // 
            // txtGoalsPlayers
            // 
            this.txtGoalsPlayers.Location = new System.Drawing.Point(103, 147);
            this.txtGoalsPlayers.Name = "txtGoalsPlayers";
            this.txtGoalsPlayers.Size = new System.Drawing.Size(40, 20);
            this.txtGoalsPlayers.TabIndex = 11;
            // 
            // lblAssistPlayers
            // 
            this.lblAssistPlayers.AutoSize = true;
            this.lblAssistPlayers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistPlayers.Location = new System.Drawing.Point(163, 149);
            this.lblAssistPlayers.Name = "lblAssistPlayers";
            this.lblAssistPlayers.Size = new System.Drawing.Size(57, 19);
            this.lblAssistPlayers.TabIndex = 12;
            this.lblAssistPlayers.Text = "Assists:";
            // 
            // txtAssistsPlayers
            // 
            this.txtAssistsPlayers.Location = new System.Drawing.Point(226, 148);
            this.txtAssistsPlayers.Name = "txtAssistsPlayers";
            this.txtAssistsPlayers.Size = new System.Drawing.Size(40, 20);
            this.txtAssistsPlayers.TabIndex = 14;
            // 
            // btnEliminarPlayers
            // 
            this.btnEliminarPlayers.Location = new System.Drawing.Point(297, 440);
            this.btnEliminarPlayers.Name = "btnEliminarPlayers";
            this.btnEliminarPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPlayers.TabIndex = 15;
            this.btnEliminarPlayers.Text = "Delete";
            this.btnEliminarPlayers.UseVisualStyleBackColor = true;
            this.btnEliminarPlayers.Click += new System.EventHandler(this.btnEliminarPlayers_Click);
            // 
            // btnReloadPlayers
            // 
            this.btnReloadPlayers.Location = new System.Drawing.Point(463, 189);
            this.btnReloadPlayers.Name = "btnReloadPlayers";
            this.btnReloadPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnReloadPlayers.TabIndex = 16;
            this.btnReloadPlayers.Text = "Reload";
            this.btnReloadPlayers.UseVisualStyleBackColor = true;
            this.btnReloadPlayers.Click += new System.EventHandler(this.btnReloadPlayers_Click);
            // 
            // Frm_Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 480);
            this.Controls.Add(this.btnReloadPlayers);
            this.Controls.Add(this.btnEliminarPlayers);
            this.Controls.Add(this.txtAssistsPlayers);
            this.Controls.Add(this.lblAssistPlayers);
            this.Controls.Add(this.txtGoalsPlayers);
            this.Controls.Add(this.lblGoalsPlayers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNewPlayerPlayers);
            this.Controls.Add(this.dgvListadoPlayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelPlayers);
            this.Controls.Add(this.btnSavePlayer);
            this.Controls.Add(this.txtNamePlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Players";
            this.Load += new System.EventHandler(this.Frm_Players_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamePlayers;
        private System.Windows.Forms.Button btnSavePlayer;
        private System.Windows.Forms.Button btnCancelPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListadoPlayers;
        private System.Windows.Forms.Button btnNewPlayerPlayers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGoalsPlayers;
        private System.Windows.Forms.TextBox txtGoalsPlayers;
        private System.Windows.Forms.Label lblAssistPlayers;
        private System.Windows.Forms.TextBox txtAssistsPlayers;
        private System.Windows.Forms.Button btnEliminarPlayers;
        private System.Windows.Forms.Button btnReloadPlayers;
    }
}