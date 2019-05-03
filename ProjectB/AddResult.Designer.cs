namespace ProjectB
{
    partial class AddResult
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
            this.comboStudentId = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAssessmentComponent = new System.Windows.Forms.ComboBox();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboRubric = new System.Windows.Forms.ComboBox();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.studentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.assessmentComponentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.AssessmentComponentTableAdapter();
            this.rubricLevelTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.RubricLevelTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboStudentId
            // 
            this.comboStudentId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Id", true));
            this.comboStudentId.DataSource = this.studentBindingSource;
            this.comboStudentId.DisplayMember = "RegistrationNumber";
            this.comboStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStudentId.FormattingEnabled = true;
            this.comboStudentId.Location = new System.Drawing.Point(365, 88);
            this.comboStudentId.Name = "comboStudentId";
            this.comboStudentId.Size = new System.Drawing.Size(163, 28);
            this.comboStudentId.TabIndex = 12;
            this.comboStudentId.ValueMember = "Id";
            this.comboStudentId.SelectedIndexChanged += new System.EventHandler(this.comboStudentId_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Id";
            // 
            // comboAssessmentComponent
            // 
            this.comboAssessmentComponent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assessmentComponentBindingSource, "Id", true));
            this.comboAssessmentComponent.DataSource = this.assessmentComponentBindingSource;
            this.comboAssessmentComponent.DisplayMember = "Name";
            this.comboAssessmentComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAssessmentComponent.FormattingEnabled = true;
            this.comboAssessmentComponent.Location = new System.Drawing.Point(365, 147);
            this.comboAssessmentComponent.Name = "comboAssessmentComponent";
            this.comboAssessmentComponent.Size = new System.Drawing.Size(163, 28);
            this.comboAssessmentComponent.TabIndex = 14;
            this.comboAssessmentComponent.ValueMember = "Id";
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Assessment Component";
            // 
            // comboRubric
            // 
            this.comboRubric.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rubricLevelBindingSource, "Id", true));
            this.comboRubric.DataSource = this.rubricLevelBindingSource;
            this.comboRubric.DisplayMember = "Details";
            this.comboRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRubric.FormattingEnabled = true;
            this.comboRubric.Location = new System.Drawing.Point(365, 199);
            this.comboRubric.Name = "comboRubric";
            this.comboRubric.Size = new System.Drawing.Size(163, 28);
            this.comboRubric.TabIndex = 16;
            this.comboRubric.ValueMember = "Id";
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rubric Measurement";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(391, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 34);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Result";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(668, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboRubric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboAssessmentComponent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboStudentId);
            this.Controls.Add(this.label2);
            this.Name = "AddResult";
            this.Text = "AddResult";
            this.Load += new System.EventHandler(this.AddResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAssessmentComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRubric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSetTableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSetTableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}