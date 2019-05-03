namespace ProjectB
{
    partial class Add_CLO
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
            this.btnAddCLO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.Location = new System.Drawing.Point(427, 183);
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.Size = new System.Drawing.Size(136, 23);
            this.btnAddCLO.TabIndex = 0;
            this.btnAddCLO.Text = "Add ";
            this.btnAddCLO.UseVisualStyleBackColor = true;
            this.btnAddCLO.Click += new System.EventHandler(this.btnAddCLO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLO Name";
            // 
            // txtCLOName
            // 
            this.txtCLOName.Location = new System.Drawing.Point(368, 97);
            this.txtCLOName.Multiline = true;
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(195, 20);
            this.txtCLOName.TabIndex = 2;
            this.txtCLOName.TextChanged += new System.EventHandler(this.txtCLOName_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(672, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Add_CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtCLOName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCLO);
            this.Name = "Add_CLO";
            this.Text = "Add_CLO";
            this.Load += new System.EventHandler(this.Add_CLO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}