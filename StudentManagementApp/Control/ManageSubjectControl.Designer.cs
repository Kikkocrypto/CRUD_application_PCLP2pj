namespace StudentManagementApp.Control
{
    partial class ManageSubjectControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tlpAddStudent = new System.Windows.Forms.TableLayoutPanel();
            this.lblEvaluationType = new System.Windows.Forms.Label();
            this.lblSubjectAcronym = new System.Windows.Forms.Label();
            this.tbSubjectAcronym = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbEvaluationType = new System.Windows.Forms.ComboBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.tlpAddStudent.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.dgvSubjects);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 43);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1276, 536);
            this.panelCenter.TabIndex = 9;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Beige;
            this.dgvSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjects.Location = new System.Drawing.Point(0, 0);
            this.dgvSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 35;
            this.dgvSubjects.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(1276, 536);
            this.dgvSubjects.TabIndex = 5;
            this.dgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellClick);
            this.dgvSubjects.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSubjects_DataBindingComplete);
            this.dgvSubjects.SelectionChanged += new System.EventHandler(this.dgvSubjects_SelectionChanged);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.AutoSize = true;
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(4, 146);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnModify.Size = new System.Drawing.Size(311, 41);
            this.btnModify.TabIndex = 21;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(4, 16);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(4, 16, 4, 0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(160, 23);
            this.lblSubjectName.TabIndex = 3;
            this.lblSubjectName.Text = "Subject Name: ";
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubjectName.Location = new System.Drawing.Point(323, 12);
            this.tbSubjectName.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(255, 32);
            this.tbSubjectName.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Khaki;
            this.panelBottom.Controls.Add(this.tlpAddStudent);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 579);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1276, 203);
            this.panelBottom.TabIndex = 8;
            // 
            // tlpAddStudent
            // 
            this.tlpAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddStudent.ColumnCount = 4;
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.Controls.Add(this.btnModify, 0, 2);
            this.tlpAddStudent.Controls.Add(this.lblSubjectName, 0, 0);
            this.tlpAddStudent.Controls.Add(this.tbSubjectName, 1, 0);
            this.tlpAddStudent.Controls.Add(this.lblEvaluationType, 2, 0);
            this.tlpAddStudent.Controls.Add(this.lblSubjectAcronym, 0, 1);
            this.tlpAddStudent.Controls.Add(this.tbSubjectAcronym, 1, 1);
            this.tlpAddStudent.Controls.Add(this.btnAdd, 3, 2);
            this.tlpAddStudent.Controls.Add(this.btnDelete, 1, 2);
            this.tlpAddStudent.Controls.Add(this.cbEvaluationType, 3, 0);
            this.tlpAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tlpAddStudent.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.tlpAddStudent.Name = "tlpAddStudent";
            this.tlpAddStudent.RowCount = 3;
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.Size = new System.Drawing.Size(1276, 203);
            this.tlpAddStudent.TabIndex = 20;
            // 
            // lblEvaluationType
            // 
            this.lblEvaluationType.AutoSize = true;
            this.lblEvaluationType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluationType.Location = new System.Drawing.Point(642, 18);
            this.lblEvaluationType.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblEvaluationType.Name = "lblEvaluationType";
            this.lblEvaluationType.Size = new System.Drawing.Size(168, 23);
            this.lblEvaluationType.TabIndex = 5;
            this.lblEvaluationType.Text = "Evaluation Type:";
            // 
            // lblSubjectAcronym
            // 
            this.lblSubjectAcronym.AutoSize = true;
            this.lblSubjectAcronym.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectAcronym.Location = new System.Drawing.Point(4, 83);
            this.lblSubjectAcronym.Margin = new System.Windows.Forms.Padding(4, 16, 4, 0);
            this.lblSubjectAcronym.Name = "lblSubjectAcronym";
            this.lblSubjectAcronym.Size = new System.Drawing.Size(190, 23);
            this.lblSubjectAcronym.TabIndex = 13;
            this.lblSubjectAcronym.Text = "Subject Acronym: ";
            // 
            // tbSubjectAcronym
            // 
            this.tbSubjectAcronym.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubjectAcronym.Location = new System.Drawing.Point(323, 79);
            this.tbSubjectAcronym.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.tbSubjectAcronym.Name = "tbSubjectAcronym";
            this.tbSubjectAcronym.Size = new System.Drawing.Size(255, 32);
            this.tbSubjectAcronym.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(961, 146);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(311, 41);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(323, 146);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(311, 41);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbEvaluationType
            // 
            this.cbEvaluationType.AccessibleDescription = "Evaluation";
            this.cbEvaluationType.AccessibleName = "Evaluation";
            this.cbEvaluationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvaluationType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvaluationType.FormattingEnabled = true;
            this.cbEvaluationType.Items.AddRange(new object[] {
            "Exam",
            "Colloquium"});
            this.cbEvaluationType.Location = new System.Drawing.Point(961, 12);
            this.cbEvaluationType.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.cbEvaluationType.Name = "cbEvaluationType";
            this.cbEvaluationType.Size = new System.Drawing.Size(287, 31);
            this.cbEvaluationType.TabIndex = 22;
            // 
            // lblTop
            // 
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Sans Serif Collection", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1276, 43);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "Manage Subject";
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Khaki;
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.lblTop);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1276, 43);
            this.PanelTop.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(882, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click the subject to delete or upload.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageSubjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.PanelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageSubjectControl";
            this.Size = new System.Drawing.Size(1276, 782);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.tlpAddStudent.ResumeLayout(false);
            this.tlpAddStudent.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tlpAddStudent;
        private System.Windows.Forms.Label lblEvaluationType;
        private System.Windows.Forms.Label lblSubjectAcronym;
        private System.Windows.Forms.TextBox tbSubjectAcronym;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.ComboBox cbEvaluationType;
        private System.Windows.Forms.Label label1;
    }
}
