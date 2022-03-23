
namespace BankAppUI
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.lblSender = new System.Windows.Forms.Label();
            this.cmbSender = new System.Windows.Forms.ComboBox();
            this.lblReciever = new System.Windows.Forms.Label();
            this.txtReciever = new System.Windows.Forms.TextBox();
            this.lblTransferAmt = new System.Windows.Forms.Label();
            this.txtTransferAmt = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.BackColor = System.Drawing.Color.Transparent;
            this.lblSender.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSender.ForeColor = System.Drawing.Color.White;
            this.lblSender.Location = new System.Drawing.Point(262, 206);
            this.lblSender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(282, 34);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Choose Accounts";
            // 
            // cmbSender
            // 
            this.cmbSender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSender.FormattingEnabled = true;
            this.cmbSender.Location = new System.Drawing.Point(674, 205);
            this.cmbSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSender.Name = "cmbSender";
            this.cmbSender.Size = new System.Drawing.Size(319, 41);
            this.cmbSender.TabIndex = 1;
            // 
            // lblReciever
            // 
            this.lblReciever.AutoSize = true;
            this.lblReciever.BackColor = System.Drawing.Color.Transparent;
            this.lblReciever.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReciever.ForeColor = System.Drawing.Color.White;
            this.lblReciever.Location = new System.Drawing.Point(24, 290);
            this.lblReciever.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReciever.Name = "lblReciever";
            this.lblReciever.Size = new System.Drawing.Size(520, 34);
            this.lblReciever.TabIndex = 2;
            this.lblReciever.Text = "Enter Reciever Account Number";
            // 
            // txtReciever
            // 
            this.txtReciever.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReciever.Location = new System.Drawing.Point(674, 285);
            this.txtReciever.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.Size = new System.Drawing.Size(319, 39);
            this.txtReciever.TabIndex = 3;
            // 
            // lblTransferAmt
            // 
            this.lblTransferAmt.AutoSize = true;
            this.lblTransferAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblTransferAmt.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransferAmt.ForeColor = System.Drawing.Color.White;
            this.lblTransferAmt.Location = new System.Drawing.Point(248, 374);
            this.lblTransferAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransferAmt.Name = "lblTransferAmt";
            this.lblTransferAmt.Size = new System.Drawing.Size(296, 34);
            this.lblTransferAmt.TabIndex = 4;
            this.lblTransferAmt.Text = "Enter the Amount";
            // 
            // txtTransferAmt
            // 
            this.txtTransferAmt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTransferAmt.Location = new System.Drawing.Point(674, 369);
            this.txtTransferAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransferAmt.Name = "txtTransferAmt";
            this.txtTransferAmt.Size = new System.Drawing.Size(319, 39);
            this.txtTransferAmt.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(784, 451);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(209, 58);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 674);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransferAmt);
            this.Controls.Add(this.lblTransferAmt);
            this.Controls.Add(this.txtReciever);
            this.Controls.Add(this.lblReciever);
            this.Controls.Add(this.cmbSender);
            this.Controls.Add(this.lblSender);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.ComboBox cmbSender;
        private System.Windows.Forms.Label lblReciever;
        private System.Windows.Forms.TextBox txtReciever;
        private System.Windows.Forms.Label lblTransferAmt;
        private System.Windows.Forms.TextBox txtTransferAmt;
        private System.Windows.Forms.Button btnTransfer;
    }
}