namespace SQLServerTest
{
    partial class Pathfinder
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
            this.dgvSpells = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpells
            // 
            this.dgvSpells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpells.Location = new System.Drawing.Point(12, 400);
            this.dgvSpells.Name = "dgvSpells";
            this.dgvSpells.Size = new System.Drawing.Size(760, 150);
            this.dgvSpells.TabIndex = 0;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 371);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(523, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(248, 381);
            this.txtLog.TabIndex = 2;
            // 
            // Pathfinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.dgvSpells);
            this.Name = "Pathfinder";
            this.Text = "Pathfinder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpells;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtLog;
    }
}

