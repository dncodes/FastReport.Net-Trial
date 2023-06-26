
namespace FastReportBGObjects.Gantt
{
    partial class GanttEditorForm
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
            this.pgStyle = new FastReport.Controls.PageControlPage();
            this.pgGeneral = new FastReport.Controls.PageControlPage();
            this.pgData = new FastReport.Controls.PageControlPage();
            this.cbResourceColumn = new FastReport.Controls.DataColumnComboBox();
            this.labelResource = new System.Windows.Forms.Label();
            this.cbEndDateColumn = new FastReport.Controls.DataColumnComboBox();
            this.labelED = new System.Windows.Forms.Label();
            this.cbStartDateColumn = new FastReport.Controls.DataColumnComboBox();
            this.labelSD = new System.Windows.Forms.Label();
            this.cbNameColumn = new FastReport.Controls.DataColumnComboBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pageControl1 = new FastReport.Controls.PageControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeaderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegInHeader)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pgStyle.SuspendLayout();
            this.pgGeneral.SuspendLayout();
            this.pgData.SuspendLayout();
            this.pageControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNodes
            // 
            this.pnNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNodes.Location = new System.Drawing.Point(8, 149);
            this.pnNodes.Size = new System.Drawing.Size(579, 189);
            // 
            // pnResources
            // 
            this.pnResources.Location = new System.Drawing.Point(424, 9);
            this.pnResources.Size = new System.Drawing.Size(169, 329);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(36, 144);
            // 
            // cbDefaultHeaderHeight
            // 
            this.cbDefaultHeaderHeight.Location = new System.Drawing.Point(9, 6);
            // 
            // lblHeaderHeight
            // 
            this.lblHeaderHeight.Location = new System.Drawing.Point(6, 35);
            // 
            // nudHeaderHeight
            // 
            this.nudHeaderHeight.Location = new System.Drawing.Point(87, 33);
            // 
            // lblBottomHeaderView
            // 
            this.lblBottomHeaderView.Location = new System.Drawing.Point(236, 35);
            // 
            // tbBottomHeaderView
            // 
            this.tbBottomHeaderView.Location = new System.Drawing.Point(345, 32);
            this.tbBottomHeaderView.Size = new System.Drawing.Size(105, 21);
            // 
            // cbShowTopDate
            // 
            this.cbShowTopDate.Location = new System.Drawing.Point(9, 68);
            // 
            // cbDrawVertGrid
            // 
            this.cbDrawVertGrid.Location = new System.Drawing.Point(239, 124);
            // 
            // lblSegs
            // 
            this.lblSegs.Location = new System.Drawing.Point(236, 69);
            // 
            // nudSegInHeader
            // 
            this.nudSegInHeader.Location = new System.Drawing.Point(363, 67);
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(316, 5);
            // 
            // lblPattern
            // 
            this.lblPattern.Location = new System.Drawing.Point(236, 6);
            // 
            // lblScale
            // 
            this.lblScale.Location = new System.Drawing.Point(6, 98);
            // 
            // cbxScale
            // 
            this.cbxScale.Location = new System.Drawing.Point(54, 96);
            this.cbxScale.Size = new System.Drawing.Size(125, 21);
            // 
            // lblHPos
            // 
            this.lblHPos.Location = new System.Drawing.Point(236, 98);
            // 
            // cbxHeaderPosition
            // 
            this.cbxHeaderPosition.Location = new System.Drawing.Point(324, 95);
            // 
            // cbDrawHorzGrid
            // 
            this.cbDrawHorzGrid.Location = new System.Drawing.Point(9, 123);
            // 
            // ganttSample
            // 
            this.ganttSample.Location = new System.Drawing.Point(5, 353);
            this.ganttSample.Size = new System.Drawing.Size(693, 208);
            // 
            // paletteControl
            // 
            this.paletteControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteControl.Size = new System.Drawing.Size(408, 331);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1073, 495);
            this.tabControl1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(9, 147);
            this.panel1.Size = new System.Drawing.Size(476, 59);
            // 
            // lblTextPosition
            // 
            this.lblTextPosition.Location = new System.Drawing.Point(0, 39);
            // 
            // cbxTextPosition
            // 
            this.cbxTextPosition.Location = new System.Drawing.Point(75, 36);
            this.cbxTextPosition.Size = new System.Drawing.Size(122, 21);
            // 
            // cbTextOnIntervals
            // 
            this.cbTextOnIntervals.Location = new System.Drawing.Point(3, 13);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(227, 3);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(230, 33);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(612, 570);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(531, 570);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pgStyle
            // 
            this.pgStyle.BackColor = System.Drawing.SystemColors.Window;
            this.pgStyle.Controls.Add(this.paletteControl);
            this.pgStyle.Controls.Add(this.pnResources);
            this.pgStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgStyle.Location = new System.Drawing.Point(100, 1);
            this.pgStyle.Name = "pgStyle";
            this.pgStyle.Size = new System.Drawing.Size(601, 341);
            this.pgStyle.TabIndex = 0;
            this.pgStyle.Text = "Style";
            // 
            // pgGeneral
            // 
            this.pgGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.pgGeneral.Controls.Add(this.cbDefaultHeaderHeight);
            this.pgGeneral.Controls.Add(this.lblHeaderHeight);
            this.pgGeneral.Controls.Add(this.nudHeaderHeight);
            this.pgGeneral.Controls.Add(this.lblBottomHeaderView);
            this.pgGeneral.Controls.Add(this.tbBottomHeaderView);
            this.pgGeneral.Controls.Add(this.cbShowTopDate);
            this.pgGeneral.Controls.Add(this.cbDrawVertGrid);
            this.pgGeneral.Controls.Add(this.lblSegs);
            this.pgGeneral.Controls.Add(this.nudSegInHeader);
            this.pgGeneral.Controls.Add(this.tbPattern);
            this.pgGeneral.Controls.Add(this.lblPattern);
            this.pgGeneral.Controls.Add(this.lblScale);
            this.pgGeneral.Controls.Add(this.cbxScale);
            this.pgGeneral.Controls.Add(this.lblHPos);
            this.pgGeneral.Controls.Add(this.cbxHeaderPosition);
            this.pgGeneral.Controls.Add(this.cbDrawHorzGrid);
            this.pgGeneral.Controls.Add(this.panel1);
            this.pgGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgGeneral.Location = new System.Drawing.Point(100, 1);
            this.pgGeneral.Name = "pgGeneral";
            this.pgGeneral.Size = new System.Drawing.Size(601, 341);
            this.pgGeneral.TabIndex = 1;
            this.pgGeneral.Text = "General";
            // 
            // pgData
            // 
            this.pgData.Controls.Add(this.cbResourceColumn);
            this.pgData.Controls.Add(this.labelResource);
            this.pgData.Controls.Add(this.cbEndDateColumn);
            this.pgData.Controls.Add(this.labelED);
            this.pgData.Controls.Add(this.cbStartDateColumn);
            this.pgData.Controls.Add(this.labelSD);
            this.pgData.Controls.Add(this.cbNameColumn);
            this.pgData.Controls.Add(this.cbData);
            this.pgData.Controls.Add(this.labelData);
            this.pgData.Controls.Add(this.labelName);
            this.pgData.Controls.Add(this.pnNodes);
            this.pgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgData.Location = new System.Drawing.Point(100, 1);
            this.pgData.Name = "pgData";
            this.pgData.Size = new System.Drawing.Size(601, 341);
            this.pgData.TabIndex = 1;
            this.pgData.Text = "Data";
            this.pgData.Controls.SetChildIndex(this.pnNodes, 0);
            this.pgData.Controls.SetChildIndex(this.labelName, 0);
            this.pgData.Controls.SetChildIndex(this.labelData, 0);
            this.pgData.Controls.SetChildIndex(this.cbData, 0);
            this.pgData.Controls.SetChildIndex(this.cbNameColumn, 0);
            this.pgData.Controls.SetChildIndex(this.labelSD, 0);
            this.pgData.Controls.SetChildIndex(this.cbStartDateColumn, 0);
            this.pgData.Controls.SetChildIndex(this.labelED, 0);
            this.pgData.Controls.SetChildIndex(this.cbEndDateColumn, 0);
            this.pgData.Controls.SetChildIndex(this.labelResource, 0);
            this.pgData.Controls.SetChildIndex(this.cbResourceColumn, 0);
            // 
            // cbResourceColumn
            // 
            this.cbResourceColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbResourceColumn.Location = new System.Drawing.Point(128, 116);
            this.cbResourceColumn.Name = "cbResourceColumn";
            this.cbResourceColumn.Size = new System.Drawing.Size(459, 27);
            this.cbResourceColumn.TabIndex = 50;
            // 
            // labelResource
            // 
            this.labelResource.AutoSize = true;
            this.labelResource.Location = new System.Drawing.Point(5, 121);
            this.labelResource.Name = "labelResource";
            this.labelResource.Size = new System.Drawing.Size(88, 13);
            this.labelResource.TabIndex = 49;
            this.labelResource.Text = "Resource column";
            // 
            // cbEndDateColumn
            // 
            this.cbEndDateColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEndDateColumn.Location = new System.Drawing.Point(128, 89);
            this.cbEndDateColumn.Name = "cbEndDateColumn";
            this.cbEndDateColumn.Size = new System.Drawing.Size(459, 27);
            this.cbEndDateColumn.TabIndex = 48;
            // 
            // labelED
            // 
            this.labelED.AutoSize = true;
            this.labelED.Location = new System.Drawing.Point(5, 94);
            this.labelED.Name = "labelED";
            this.labelED.Size = new System.Drawing.Size(86, 13);
            this.labelED.TabIndex = 47;
            this.labelED.Text = "End date column";
            // 
            // cbStartDateColumn
            // 
            this.cbStartDateColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStartDateColumn.Location = new System.Drawing.Point(128, 62);
            this.cbStartDateColumn.Name = "cbStartDateColumn";
            this.cbStartDateColumn.Size = new System.Drawing.Size(459, 27);
            this.cbStartDateColumn.TabIndex = 46;
            // 
            // labelSD
            // 
            this.labelSD.AutoSize = true;
            this.labelSD.Location = new System.Drawing.Point(5, 67);
            this.labelSD.Name = "labelSD";
            this.labelSD.Size = new System.Drawing.Size(92, 13);
            this.labelSD.TabIndex = 45;
            this.labelSD.Text = "Start date column";
            // 
            // cbNameColumn
            // 
            this.cbNameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNameColumn.Location = new System.Drawing.Point(128, 35);
            this.cbNameColumn.Name = "cbNameColumn";
            this.cbNameColumn.Size = new System.Drawing.Size(459, 27);
            this.cbNameColumn.TabIndex = 44;
            // 
            // cbData
            // 
            this.cbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(128, 8);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(459, 21);
            this.cbData.TabIndex = 43;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(5, 12);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(71, 13);
            this.labelData.TabIndex = 42;
            this.labelData.Text = "Data Sources";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 13);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "Name column";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(261, 213);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 29);
            this.btnDown.TabIndex = 5;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(261, 178);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 29);
            this.btnUp.TabIndex = 4;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(261, 60);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(261, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pageControl1
            // 
            this.pageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl1.Controls.Add(this.pgGeneral);
            this.pageControl1.Controls.Add(this.pgStyle);
            this.pageControl1.Controls.Add(this.pgData);
            this.pageControl1.HighlightPageIndex = -1;
            this.pageControl1.Location = new System.Drawing.Point(0, 0);
            this.pageControl1.Name = "pageControl1";
            this.pageControl1.SelectorWidth = 100;
            this.pageControl1.Size = new System.Drawing.Size(702, 343);
            this.pageControl1.TabIndex = 1;
            this.pageControl1.Text = "pageControl1";
            // 
            // GanttEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(702, 599);
            this.Controls.Add(this.pageControl1);
            this.Name = "GanttEditorForm";
            this.Text = "GanttEditorForm";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.pageControl1, 0);
            this.Controls.SetChildIndex(this.ganttSample, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeaderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegInHeader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pgStyle.ResumeLayout(false);
            this.pgGeneral.ResumeLayout(false);
            this.pgGeneral.PerformLayout();
            this.pgData.ResumeLayout(false);
            this.pgData.PerformLayout();
            this.pageControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        protected FastReport.Controls.PageControlPage pgStyle;
        protected FastReport.Controls.PageControlPage pgGeneral;
        protected FastReport.Controls.PageControlPage pgData;
        protected FastReport.Controls.PageControl pageControl1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;

        #endregion

        protected FastReport.Controls.DataColumnComboBox cbResourceColumn;
        protected System.Windows.Forms.Label labelResource;
        protected FastReport.Controls.DataColumnComboBox cbEndDateColumn;
        protected System.Windows.Forms.Label labelED;
        protected FastReport.Controls.DataColumnComboBox cbStartDateColumn;
        protected System.Windows.Forms.Label labelSD;
        protected FastReport.Controls.DataColumnComboBox cbNameColumn;
        protected System.Windows.Forms.ComboBox cbData;
        protected System.Windows.Forms.Label labelData;
        protected System.Windows.Forms.Label labelName;
    }
}