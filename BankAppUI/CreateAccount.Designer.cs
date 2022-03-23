
namespace BankAppUI
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.lblInitialAmt = new System.Windows.Forms.Label();
            this.txtInitailAmt = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.rdbSaving = new System.Windows.Forms.RadioButton();
            this.rdbCurrent = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInitialAmt
            // 
            this.lblInitialAmt.AutoSize = true;
            this.lblInitialAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblInitialAmt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInitialAmt.ForeColor = System.Drawing.Color.White;
            this.lblInitialAmt.Location = new System.Drawing.Point(188, 170);
            this.lblInitialAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialAmt.Name = "lblInitialAmt";
            this.lblInitialAmt.Size = new System.Drawing.Size(207, 29);
            this.lblInitialAmt.TabIndex = 0;
            this.lblInitialAmt.Text = "Initial Amount";
            // 
            // txtInitailAmt
            // 
            this.txtInitailAmt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInitailAmt.ForeColor = System.Drawing.Color.White;
            this.txtInitailAmt.Location = new System.Drawing.Point(458, 168);
            this.txtInitailAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInitailAmt.Name = "txtInitailAmt";
            this.txtInitailAmt.Size = new System.Drawing.Size(318, 37);
            this.txtInitailAmt.TabIndex = 1;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountType.ForeColor = System.Drawing.Color.White;
            this.lblAccountType.Location = new System.Drawing.Point(188, 291);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(194, 29);
            this.lblAccountType.TabIndex = 2;
            this.lblAccountType.Text = "Account Type";
            // 
            // rdbSaving
            // 
            this.rdbSaving.AutoSize = true;
            this.rdbSaving.BackColor = System.Drawing.Color.Transparent;
            this.rdbSaving.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbSaving.ForeColor = System.Drawing.Color.White;
            this.rdbSaving.Location = new System.Drawing.Point(458, 294);
            this.rdbSaving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSaving.Name = "rdbSaving";
            this.rdbSaving.Size = new System.Drawing.Size(129, 33);
            this.rdbSaving.TabIndex = 3;
            this.rdbSaving.TabStop = true;
            this.rdbSaving.Text = "Saving";
            this.rdbSaving.UseVisualStyleBackColor = false;
            // 
            // rdbCurrent
            // 
            this.rdbCurrent.AutoSize = true;
            this.rdbCurrent.BackColor = System.Drawing.Color.Transparent;
            this.rdbCurrent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbCurrent.ForeColor = System.Drawing.Color.White;
            this.rdbCurrent.Location = new System.Drawing.Point(629, 294);
            this.rdbCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCurrent.Name = "rdbCurrent";
            this.rdbCurrent.Size = new System.Drawing.Size(140, 33);
            this.rdbCurrent.TabIndex = 4;
            this.rdbCurrent.TabStop = true;
            this.rdbCurrent.Text = "Current";
            this.rdbCurrent.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(577, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbCurrent);
            this.Controls.Add(this.rdbSaving);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.txtInitailAmt);
            this.Controls.Add(this.lblInitialAmt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitialAmt;
        private System.Windows.Forms.TextBox txtInitailAmt;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.RadioButton rdbSaving;
        private System.Windows.Forms.RadioButton rdbCurrent;
        private System.Windows.Forms.Button button1;
    }
}