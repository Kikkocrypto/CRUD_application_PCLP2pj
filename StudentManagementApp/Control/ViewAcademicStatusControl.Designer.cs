namespace StudentManagementApp.Control
{
    partial class ViewAcademicStatusControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvShowStatus = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearSubject = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowStatus = new System.Windows.Forms.Button();
            this.cbSelectSubject = new System.Windows.Forms.ComboBox();
            this.lblStd = new System.Windows.Forms.Label();
            this.cbSelectStudent = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tlpAddStudent = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageGrade = new System.Windows.Forms.Label();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.lblAcademicStatus = new System.Windows.Forms.Label();
            this.panelCenter.SuspendLayout();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tlpAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelDgv);
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 43);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1209, 501);
            this.panelCenter.TabIndex = 12;
            // 
            // panelDgv
            // 
            this.panelDgv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDgv.Controls.Add(this.dgvShowStatus);
            this.panelDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgv.Location = new System.Drawing.Point(0, 171);
            this.panelDgv.Margin = new System.Windows.Forms.Padding(4);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1209, 330);
            this.panelDgv.TabIndex = 1;
            // 
            // dgvShowStatus
            // 
            this.dgvShowStatus.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            this.dgvShowStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowStatus.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvShowStatus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowStatus.Name = "dgvShowStatus";
            this.dgvShowStatus.ReadOnly = true;
            this.dgvShowStatus.RowHeadersVisible = false;
            this.dgvShowStatus.RowHeadersWidth = 51;
            this.dgvShowStatus.RowTemplate.Height = 35;
            this.dgvShowStatus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowStatus.Size = new System.Drawing.Size(1209, 330);
            this.dgvShowStatus.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 171);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnClearSubject, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnShowAll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnShowStatus, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbSelectSubject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbSelectStudent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSubject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClearStudent, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1207, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClearSubject
            // 
            this.btnClearSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSubject.Location = new System.Drawing.Point(607, 68);
            this.btnClearSubject.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnClearSubject.Name = "btnClearSubject";
            this.btnClearSubject.Size = new System.Drawing.Size(96, 39);
            this.btnClearSubject.TabIndex = 29;
            this.btnClearSubject.Text = "CLEAR";
            this.btnClearSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearSubject.UseVisualStyleBackColor = true;
            this.btnClearSubject.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(366, 124);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(208, 41);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowStatus
            // 
            this.btnShowStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowStatus.AutoSize = true;
            this.btnShowStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnShowStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowStatus.FlatAppearance.BorderSize = 0;
            this.btnShowStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.btnShowStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStatus.ForeColor = System.Drawing.Color.White;
            this.btnShowStatus.Location = new System.Drawing.Point(4, 124);
            this.btnShowStatus.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnShowStatus.Name = "btnShowStatus";
            this.btnShowStatus.Size = new System.Drawing.Size(354, 41);
            this.btnShowStatus.TabIndex = 26;
            this.btnShowStatus.Text = "Show Status";
            this.btnShowStatus.UseVisualStyleBackColor = false;
            this.btnShowStatus.Click += new System.EventHandler(this.btnShowStatus_Click);
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
            this.cbSelectSubject.Location = new System.Drawing.Point(366, 68);
            this.cbSelectSubject.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.cbSelectSubject.Name = "cbSelectSubject";
            this.cbSelectSubject.Size = new System.Drawing.Size(232, 31);
            this.cbSelectSubject.TabIndex = 25;
            // 
            // lblStd
            // 
            this.lblStd.AutoSize = true;
            this.lblStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStd.Location = new System.Drawing.Point(4, 18);
            this.lblStd.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblStd.Name = "lblStd";
            this.lblStd.Size = new System.Drawing.Size(354, 38);
            this.lblStd.TabIndex = 4;
            this.lblStd.Text = "Select Student:";
            this.lblStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cbSelectStudent.Location = new System.Drawing.Point(366, 12);
            this.cbSelectStudent.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.cbSelectStudent.Name = "cbSelectStudent";
            this.cbSelectStudent.Size = new System.Drawing.Size(232, 31);
            this.cbSelectStudent.TabIndex = 24;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(4, 74);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(354, 38);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Select Subject:";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStudent.Location = new System.Drawing.Point(607, 12);
            this.btnClearStudent.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(96, 39);
            this.btnClearStudent.TabIndex = 28;
            this.btnClearStudent.Text = "CLEAR";
            this.btnClearStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearStudent.UseVisualStyleBackColor = true;
            this.btnClearStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTop
            // 
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Sans Serif Collection", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1209, 43);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "View and Analyze";
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Khaki;
            this.PanelTop.Controls.Add(this.lblTop);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1209, 43);
            this.PanelTop.TabIndex = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Khaki;
            this.panelBottom.Controls.Add(this.tlpAddStudent);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 544);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1209, 65);
            this.panelBottom.TabIndex = 11;
            // 
            // tlpAddStudent
            // 
            this.tlpAddStudent.ColumnCount = 4;
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04472F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.39973F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddStudent.Controls.Add(this.label1, 4, 0);
            this.tlpAddStudent.Controls.Add(this.lblAverageGrade, 0, 0);
            this.tlpAddStudent.Controls.Add(this.btnExportToCsv, 1, 0);
            this.tlpAddStudent.Controls.Add(this.lblAcademicStatus, 2, 0);
            this.tlpAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tlpAddStudent.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.tlpAddStudent.Name = "tlpAddStudent";
            this.tlpAddStudent.RowCount = 1;
            this.tlpAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddStudent.Size = new System.Drawing.Size(1209, 65);
            this.tlpAddStudent.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(807, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 65);
            this.label1.TabIndex = 29;
            this.label1.Text = "<-- Academic status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageGrade
            // 
            this.lblAverageGrade.AutoSize = true;
            this.lblAverageGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageGrade.Location = new System.Drawing.Point(4, 18);
            this.lblAverageGrade.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.lblAverageGrade.Name = "lblAverageGrade";
            this.lblAverageGrade.Size = new System.Drawing.Size(100, 46);
            this.lblAverageGrade.TabIndex = 3;
            this.lblAverageGrade.Text = "Average Grade:";
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.AutoSize = true;
            this.btnExportToCsv.BackColor = System.Drawing.Color.Gray;
            this.btnExportToCsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportToCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportToCsv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToCsv.FlatAppearance.BorderSize = 0;
            this.btnExportToCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.btnExportToCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToCsv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToCsv.ForeColor = System.Drawing.Color.Black;
            this.btnExportToCsv.Location = new System.Drawing.Point(150, 0);
            this.btnExportToCsv.Margin = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(225, 65);
            this.btnExportToCsv.TabIndex = 27;
            this.btnExportToCsv.Text = "EXPORT TO CSV";
            this.btnExportToCsv.UseVisualStyleBackColor = false;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // lblAcademicStatus
            // 
            this.lblAcademicStatus.AutoSize = true;
            this.lblAcademicStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAcademicStatus.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicStatus.Location = new System.Drawing.Point(539, 0);
            this.lblAcademicStatus.Name = "lblAcademicStatus";
            this.lblAcademicStatus.Size = new System.Drawing.Size(262, 65);
            this.lblAcademicStatus.TabIndex = 28;
            this.lblAcademicStatus.Text = "lblAcademicStatus";
            this.lblAcademicStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAcademicStatus.Visible = false;
            // 
            // ViewAcademicStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.PanelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAcademicStatusControl";
            this.Size = new System.Drawing.Size(1209, 609);
            this.Load += new System.EventHandler(this.ViewAcademicStatusControl_Load);
            this.panelCenter.ResumeLayout(false);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.tlpAddStudent.ResumeLayout(false);
            this.tlpAddStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnShowStatus;
        private System.Windows.Forms.ComboBox cbSelectSubject;
        private System.Windows.Forms.Label lblStd;
        private System.Windows.Forms.ComboBox cbSelectStudent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tlpAddStudent;
        private System.Windows.Forms.Label lblAverageGrade;
        private System.Windows.Forms.Panel panelDgv;
        private System.Windows.Forms.DataGridView dgvShowStatus;
        private System.Windows.Forms.Button btnExportToCsv;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.Button btnClearSubject;
        private System.Windows.Forms.Label lblAcademicStatus;
        private System.Windows.Forms.Label label1;
    }
}
