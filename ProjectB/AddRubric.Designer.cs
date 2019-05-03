namespace ProjectB
{
    partial class AddRubric
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRubric = new System.Windows.Forms.Button();
            this.txtdetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboCloId = new System.Windows.Forms.ComboBox();
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.CloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLO Id";
            // 
            // btnAddRubric
            // 
            this.btnAddRubric.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRubric.Location = new System.Drawing.Point(446, 235);
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Size = new System.Drawing.Size(112, 38);
            this.btnAddRubric.TabIndex = 4;
            this.btnAddRubric.Text = "Add ";
            this.btnAddRubric.UseVisualStyleBackColor = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
            // 
            // txtdetails
            // 
            this.txtdetails.Location = new System.Drawing.Point(402, 153);
            this.txtdetails.Multiline = true;
            this.txtdetails.Name = "txtdetails";
            this.txtdetails.Size = new System.Drawing.Size(132, 20);
            this.txtdetails.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(652, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboCloId
            // 
            this.comboCloId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cloBindingSource, "Id", true));
            this.comboCloId.DataSource = this.cloBindingSource;
            this.comboCloId.DisplayMember = "Name";
            this.comboCloId.FormattingEnabled = true;
            this.comboCloId.Location = new System.Drawing.Point(402, 65);
            this.comboCloId.Name = "comboCloId";
            this.comboCloId.Size = new System.Drawing.Size(132, 21);
            this.comboCloId.TabIndex = 6;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // AddRubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboCloId);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAddRubric);
            this.Controls.Add(this.txtdetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRubric";
            this.Text = "AddRubric";
            this.Load += new System.EventHandler(this.AddRubric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRubric;
        private System.Windows.Forms.TextBox txtdetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboCloId;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSetTableAdapters.CloTableAdapter cloTableAdapter;
    }
}