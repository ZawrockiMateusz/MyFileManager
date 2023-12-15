namespace MyFileManager.View
{
    partial class MyFileManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFileManagerView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvFileList2 = new System.Windows.Forms.DataGridView();
            this.colPath2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridViewName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreationDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGv1FolderAbove = new System.Windows.Forms.Button();
            this.btnGv1DeleteElement = new System.Windows.Forms.Button();
            this.btnGv1DodajElement = new System.Windows.Forms.Button();
            this.cmbGv1Drives = new System.Windows.Forms.ComboBox();
            this.gvFileList1 = new System.Windows.Forms.DataGridView();
            this.colPath1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridViewName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreationDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGv2FolderAbove = new System.Windows.Forms.Button();
            this.btnGv2DodajElement = new System.Windows.Forms.Button();
            this.btnGv2DeleteElement = new System.Windows.Forms.Button();
            this.cmbGv2Drives = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.fileSystemItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFileList2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFileList1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gvFileList2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvFileList1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.88191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.10358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01451F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gvFileList2
            // 
            this.gvFileList2.AllowUserToAddRows = false;
            this.gvFileList2.AllowUserToDeleteRows = false;
            this.gvFileList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFileList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPath2,
            this.colGridViewName2,
            this.colName2,
            this.colFullName2,
            this.colSize2,
            this.colCreationDate2,
            this.colType2});
            this.gvFileList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFileList2.Location = new System.Drawing.Point(590, 40);
            this.gvFileList2.Name = "gvFileList2";
            this.gvFileList2.ReadOnly = true;
            this.gvFileList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFileList2.Size = new System.Drawing.Size(521, 641);
            this.gvFileList2.TabIndex = 1;
            this.gvFileList2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvFileList2_CellMouseDoubleClick);
            this.gvFileList2.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvFileList2_ColumnHeaderMouseDoubleClick);
            this.gvFileList2.DragDrop += new System.Windows.Forms.DragEventHandler(this.gvFileList2_DragDrop);
            this.gvFileList2.DragEnter += new System.Windows.Forms.DragEventHandler(this.gvFileList2_DragEnter);
            this.gvFileList2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvFileList2_MouseDown);
            // 
            // colPath2
            // 
            this.colPath2.DataPropertyName = "Path";
            this.colPath2.HeaderText = "Path ";
            this.colPath2.Name = "colPath2";
            this.colPath2.ReadOnly = true;
            this.colPath2.Visible = false;
            // 
            // colGridViewName2
            // 
            this.colGridViewName2.DataPropertyName = "GridViewName";
            this.colGridViewName2.HeaderText = "GridViewName";
            this.colGridViewName2.Name = "colGridViewName2";
            this.colGridViewName2.ReadOnly = true;
            this.colGridViewName2.Visible = false;
            // 
            // colName2
            // 
            this.colName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName2.DataPropertyName = "Name";
            this.colName2.HeaderText = "Nazwa";
            this.colName2.Name = "colName2";
            this.colName2.ReadOnly = true;
            // 
            // colFullName2
            // 
            this.colFullName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName2.DataPropertyName = "FullName";
            this.colFullName2.HeaderText = "FullName";
            this.colFullName2.Name = "colFullName2";
            this.colFullName2.ReadOnly = true;
            this.colFullName2.Visible = false;
            // 
            // colSize2
            // 
            this.colSize2.DataPropertyName = "Size";
            this.colSize2.HeaderText = "Rozmiar (bytes)";
            this.colSize2.Name = "colSize2";
            this.colSize2.ReadOnly = true;
            this.colSize2.Width = 120;
            // 
            // colCreationDate2
            // 
            this.colCreationDate2.DataPropertyName = "CreationDate";
            this.colCreationDate2.HeaderText = "Data utworzenia";
            this.colCreationDate2.Name = "colCreationDate2";
            this.colCreationDate2.ReadOnly = true;
            this.colCreationDate2.Width = 120;
            // 
            // colType2
            // 
            this.colType2.DataPropertyName = "Type";
            this.colType2.HeaderText = "Type";
            this.colType2.Name = "colType2";
            this.colType2.ReadOnly = true;
            this.colType2.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.681603F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5796F));
            this.tableLayoutPanel2.Controls.Add(this.btnGv1FolderAbove, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGv1DeleteElement, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGv1DodajElement, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbGv1Drives, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 31);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnGv1FolderAbove
            // 
            this.btnGv1FolderAbove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGv1FolderAbove.Location = new System.Drawing.Point(3, 3);
            this.btnGv1FolderAbove.Name = "btnGv1FolderAbove";
            this.btnGv1FolderAbove.Size = new System.Drawing.Size(23, 25);
            this.btnGv1FolderAbove.TabIndex = 0;
            this.btnGv1FolderAbove.Text = "▲";
            this.btnGv1FolderAbove.UseVisualStyleBackColor = true;
            this.btnGv1FolderAbove.Click += new System.EventHandler(this.btnGv1FolderAbove_Click);
            // 
            // btnGv1DeleteElement
            // 
            this.btnGv1DeleteElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGv1DeleteElement.Location = new System.Drawing.Point(154, 3);
            this.btnGv1DeleteElement.Name = "btnGv1DeleteElement";
            this.btnGv1DeleteElement.Size = new System.Drawing.Size(116, 25);
            this.btnGv1DeleteElement.TabIndex = 1;
            this.btnGv1DeleteElement.Text = "Usuń (F8)";
            this.btnGv1DeleteElement.UseVisualStyleBackColor = true;
            this.btnGv1DeleteElement.Click += new System.EventHandler(this.btnGv1DeleteElement_Click);
            // 
            // btnGv1DodajElement
            // 
            this.btnGv1DodajElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGv1DodajElement.Location = new System.Drawing.Point(32, 3);
            this.btnGv1DodajElement.Name = "btnGv1DodajElement";
            this.btnGv1DodajElement.Size = new System.Drawing.Size(116, 25);
            this.btnGv1DodajElement.TabIndex = 2;
            this.btnGv1DodajElement.Text = "Dodaj (F7)";
            this.btnGv1DodajElement.UseVisualStyleBackColor = true;
            this.btnGv1DodajElement.Click += new System.EventHandler(this.btnGv1DodajElement_Click);
            // 
            // cmbGv1Drives
            // 
            this.cmbGv1Drives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGv1Drives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGv1Drives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGv1Drives.FormattingEnabled = true;
            this.cmbGv1Drives.Location = new System.Drawing.Point(276, 3);
            this.cmbGv1Drives.Name = "cmbGv1Drives";
            this.cmbGv1Drives.Size = new System.Drawing.Size(116, 21);
            this.cmbGv1Drives.TabIndex = 7;
            this.cmbGv1Drives.SelectedIndexChanged += new System.EventHandler(this.cmbGv1Drives_SelectedIndexChanged);
            // 
            // gvFileList1
            // 
            this.gvFileList1.AllowUserToAddRows = false;
            this.gvFileList1.AllowUserToDeleteRows = false;
            this.gvFileList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFileList1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPath1,
            this.colGridViewName1,
            this.colName1,
            this.colFullName1,
            this.colSize1,
            this.colCreationDate1,
            this.colType1});
            this.gvFileList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFileList1.Location = new System.Drawing.Point(3, 40);
            this.gvFileList1.Name = "gvFileList1";
            this.gvFileList1.ReadOnly = true;
            this.gvFileList1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFileList1.Size = new System.Drawing.Size(521, 641);
            this.gvFileList1.TabIndex = 4;
            this.gvFileList1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvFileList1_CellMouseDoubleClick);
            this.gvFileList1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvFileList1_ColumnHeaderMouseDoubleClick);
            this.gvFileList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.gvFileList1_DragDrop);
            this.gvFileList1.DragEnter += new System.Windows.Forms.DragEventHandler(this.gvFileList1_DragEnter);
            this.gvFileList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvFileList1_MouseDown);
            // 
            // colPath1
            // 
            this.colPath1.DataPropertyName = "Path";
            this.colPath1.HeaderText = "Path";
            this.colPath1.Name = "colPath1";
            this.colPath1.ReadOnly = true;
            this.colPath1.Visible = false;
            // 
            // colGridViewName1
            // 
            this.colGridViewName1.DataPropertyName = "GridViewName";
            this.colGridViewName1.HeaderText = "GridViewName";
            this.colGridViewName1.Name = "colGridViewName1";
            this.colGridViewName1.ReadOnly = true;
            this.colGridViewName1.Visible = false;
            // 
            // colName1
            // 
            this.colName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName1.DataPropertyName = "Name";
            this.colName1.HeaderText = "Nazwa";
            this.colName1.Name = "colName1";
            this.colName1.ReadOnly = true;
            // 
            // colFullName1
            // 
            this.colFullName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFullName1.DataPropertyName = "FullName";
            this.colFullName1.HeaderText = "FullName";
            this.colFullName1.Name = "colFullName1";
            this.colFullName1.ReadOnly = true;
            this.colFullName1.Visible = false;
            this.colFullName1.Width = 288;
            // 
            // colSize1
            // 
            this.colSize1.DataPropertyName = "Size";
            this.colSize1.HeaderText = "Rozmiar (bytes)";
            this.colSize1.Name = "colSize1";
            this.colSize1.ReadOnly = true;
            this.colSize1.Width = 120;
            // 
            // colCreationDate1
            // 
            this.colCreationDate1.DataPropertyName = "CreationDate";
            this.colCreationDate1.HeaderText = "Data utworzenia";
            this.colCreationDate1.Name = "colCreationDate1";
            this.colCreationDate1.ReadOnly = true;
            this.colCreationDate1.Width = 120;
            // 
            // colType1
            // 
            this.colType1.DataPropertyName = "Type";
            this.colType1.HeaderText = "Type";
            this.colType1.Name = "colType1";
            this.colType1.ReadOnly = true;
            this.colType1.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.680776F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.57916F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58002F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58002F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58002F));
            this.tableLayoutPanel3.Controls.Add(this.btnGv2FolderAbove, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGv2DodajElement, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGv2DeleteElement, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbGv2Drives, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(590, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(521, 31);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnGv2FolderAbove
            // 
            this.btnGv2FolderAbove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGv2FolderAbove.Location = new System.Drawing.Point(3, 3);
            this.btnGv2FolderAbove.Name = "btnGv2FolderAbove";
            this.btnGv2FolderAbove.Size = new System.Drawing.Size(23, 25);
            this.btnGv2FolderAbove.TabIndex = 1;
            this.btnGv2FolderAbove.Text = "▲";
            this.btnGv2FolderAbove.UseVisualStyleBackColor = true;
            this.btnGv2FolderAbove.Click += new System.EventHandler(this.btnGv2FolderAbove_Click);
            // 
            // btnGv2DodajElement
            // 
            this.btnGv2DodajElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGv2DodajElement.Location = new System.Drawing.Point(32, 3);
            this.btnGv2DodajElement.Name = "btnGv2DodajElement";
            this.btnGv2DodajElement.Size = new System.Drawing.Size(116, 25);
            this.btnGv2DodajElement.TabIndex = 3;
            this.btnGv2DodajElement.Text = "Dodaj (F7)";
            this.btnGv2DodajElement.UseVisualStyleBackColor = true;
            this.btnGv2DodajElement.Click += new System.EventHandler(this.btnGv2DodajElement_Click);
            // 
            // btnGv2DeleteElement
            // 
            this.btnGv2DeleteElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGv2DeleteElement.Location = new System.Drawing.Point(154, 3);
            this.btnGv2DeleteElement.Name = "btnGv2DeleteElement";
            this.btnGv2DeleteElement.Size = new System.Drawing.Size(116, 25);
            this.btnGv2DeleteElement.TabIndex = 2;
            this.btnGv2DeleteElement.Text = "Usuń (F8)";
            this.btnGv2DeleteElement.UseVisualStyleBackColor = true;
            this.btnGv2DeleteElement.Click += new System.EventHandler(this.btnGv2DeleteElement_Click);
            // 
            // cmbGv2Drives
            // 
            this.cmbGv2Drives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGv2Drives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGv2Drives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGv2Drives.FormattingEnabled = true;
            this.cmbGv2Drives.Location = new System.Drawing.Point(276, 3);
            this.cmbGv2Drives.Name = "cmbGv2Drives";
            this.cmbGv2Drives.Size = new System.Drawing.Size(116, 21);
            this.cmbGv2Drives.TabIndex = 4;
            this.cmbGv2Drives.SelectedIndexChanged += new System.EventHandler(this.cmbGv2Drives_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnZamknij, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(590, 687);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(521, 71);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZamknij.Location = new System.Drawing.Point(263, 3);
            this.btnZamknij.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(255, 40);
            this.btnZamknij.TabIndex = 0;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // fileSystemItemBindingSource
            // 
            this.fileSystemItemBindingSource.DataSource = typeof(MyFileManager.Models.MyDirectoryItem);
            // 
            // MyFileManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MyFileManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My File Manager";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyFileManagerView_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFileList2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFileList1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gvFileList2;
        private System.Windows.Forms.BindingSource fileSystemItemBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGv1FolderAbove;
        private System.Windows.Forms.DataGridView gvFileList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnGv2FolderAbove;
        private System.Windows.Forms.Button btnGv2DeleteElement;
        private System.Windows.Forms.Button btnGv1DeleteElement;
        private System.Windows.Forms.Button btnGv2DodajElement;
        private System.Windows.Forms.Button btnGv1DodajElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridViewName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreationDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridViewName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreationDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.ComboBox cmbGv1Drives;
        private System.Windows.Forms.ComboBox cmbGv2Drives;
    }
}