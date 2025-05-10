namespace StudentManagementApp.Control
{
    partial class RecordGradeControl
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
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tlpAddStudent = new System.Windows.Forms.TableLayoutPanel();
            this.tbAssignGrade = new System.Windows.Forms.TextBox();
            this.cbSelectSubject = new System.Windows.Forms.ComboBox();
            this.cbSelectStudent = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblAssignGrade = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.tlpAddStudent.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.dgvGrade);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 43);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1301, 484);
            this.panelCenter.TabIndex = 9;
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Beige;
            this.dgvGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrade.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrade.Location = new System.Drawing.Point(0, 0);
            this.dgvGrade.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.RowHeadersVisible = false;
            this.dgvGrade.RowHeadersWidth = 51;
            this.dgvGrade.RowTemplate.Height = 35;
            this.dgvGrade.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(1301, 484);
            this.dgvGrade.TabIndex = 5;
            this.dgvGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrade_CellClick);
            this.dgvGrade.SelectionChanged += new System.EventHandler(this.dgvGrade_SelectionChanged);
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
            this.btnModify.Size = new System.Drawing.Size(317, 41);
            this.btnModify.TabIndex = 21;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(4, 18);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(154, 23);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Select Student:";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Khaki;
            this.panelBottom.Controls.Add(this.tlpAddStudent);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 527);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1301, 203);
            this.panelBottom.TabIndex = 8;
            // 
            // tlpAddStudent
            // 
            this.tlpAddStudent.ColumnCount = 4;
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddStudent.Controls.Add(this.tbAssignGrade, 1, 1);
            this.tlpAddStudent.Controls.Add(this.cbSelectSubject, 3, 0);
            this.tlpAddStudent.Controls.Add(this.cbSelectStudent, 1, 0);
            this.tlpAddStudent.Controls.Add(this.btnModify, 0, 2);
            this.tlpAddStudent.Controls.Add(this.lblStudent, 0, 0);
            this.tlpAddStudent.Controls.Add(this.lblSubject, 2, 0);
            this.tlpAddStudent.Controls.Add(this.lblAssignGrade, 0, 1);
            this.tlpAddStudent.Controls.Add(this.btnAdd, 3, 2);
            this.tlpAddStudent.Controls.Add(this.btnDelete, 1, 2);
            this.tlpAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tlpAddStudent.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.tlpAddStudent.Name = "tlpAddStudent";
            this.tlpAddStudent.RowCount = 3;
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.Size = new System.Drawing.Size(1301, 203);
            this.tlpAddStudent.TabIndex = 20;
            // 
            // tbAssignGrade
            // 
            this.tbAssignGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAssignGrade.Location = new System.Drawing.Point(329, 79);
            this.tbAssignGrade.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.tbAssignGrade.Name = "tbAssignGrade";
            this.tbAssignGrade.Size = new System.Drawing.Size(159, 32);
            this.tbAssignGrade.TabIndex = 25;
            // 
            // cbSelectSubject
            // 
            this.cbSelectSubject.AccessibleDescription = "Evaluation";
            this.cbSelectSubject.AccessibleName = "Evaluation";
            this.cbSelectSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectSubject.FormattingEnabled = true;
            this.cbSelectSubject.Items.AddRange(new object[] {
            "Exam",
            "Colloquium"});
            this.cbSelectSubject.Location = new System.Drawing.Point(979, 12);
            this.cbSelectSubject.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.cbSelectSubject.Name = "cbSelectSubject";
            this.cbSelectSubject.Size = new System.Drawing.Size(283, 31);
            this.cbSelectSubject.TabIndex = 24;
            // 
            // cbSelectStudent
            // 
            this.cbSelectStudent.AccessibleDescription = "Evaluation";
            this.cbSelectStudent.AccessibleName = "Evaluation";
            this.cbSelectStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectStudent.FormattingEnabled = true;
            this.cbSelectStudent.Items.AddRange(new object[] {
            "Exam",
            "Colloquium"});
            this.cbSelectStudent.Location = new System.Drawing.Point(329, 12);
            this.cbSelectStudent.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.cbSelectStudent.Name = "cbSelectStudent";
            this.cbSelectStudent.Size = new System.Drawing.Size(220, 31);
            this.cbSelectStudent.TabIndex = 23;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(654, 18);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(154, 23);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Select Subject:";
            // 
            // lblAssignGrade
            // 
            this.lblAssignGrade.AutoSize = true;
            this.lblAssignGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignGrade.Location = new System.Drawing.Point(4, 85);
            this.lblAssignGrade.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblAssignGrade.Name = "lblAssignGrade";
            this.lblAssignGrade.Size = new System.Drawing.Size(147, 23);
            this.lblAssignGrade.TabIndex = 13;
            this.lblAssignGrade.Text = "Assign Grade:";
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
            this.btnAdd.Location = new System.Drawing.Point(979, 146);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(318, 41);
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
            this.btnDelete.Location = new System.Drawing.Point(329, 146);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(317, 41);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTop
            // 
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Sans Serif Collection", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1301, 43);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "Add Grade";
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
            this.PanelTop.Size = new System.Drawing.Size(1301, 43);
            this.PanelTop.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(919, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click the grade to delete or upload.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordGradeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.PanelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecordGradeControl";
            this.Size = new System.Drawing.Size(1301, 730);
            this.Load += new System.EventHandler(this.RecordGradeControl_Load);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.tlpAddStudent.ResumeLayout(false);
            this.tlpAddStudent.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tlpAddStudent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblAssignGrade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.ComboBox cbSelectSubject;
        private System.Windows.Forms.ComboBox cbSelectStudent;
        private System.Windows.Forms.TextBox tbAssignGrade;
        private System.Windows.Forms.Label label1;
    }
}
