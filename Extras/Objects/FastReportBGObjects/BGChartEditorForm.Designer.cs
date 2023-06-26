
namespace FastReportBGObjects
{
    partial class BGChartEditorForm
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
        protected virtual void InitializeComponent()
        {
            this.pgStyle = new FastReport.Controls.PageControlPage();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.labelDir = new System.Windows.Forms.Label();
            this.labelPalette = new System.Windows.Forms.Label();
            this.cbPalette = new System.Windows.Forms.ComboBox();
            this.pgGeneral = new FastReport.Controls.PageControlPage();
            this.tbDepth = new System.Windows.Forms.NumericUpDown();
            this.labelDepth = new System.Windows.Forms.Label();
            this.tbRoot = new System.Windows.Forms.TextBox();
            this.labelRoot = new System.Windows.Forms.Label();
            this.gbExpressions = new System.Windows.Forms.GroupBox();
            this.lvExpressions = new System.Windows.Forms.ListView();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbValueColumn = new FastReport.Controls.DataColumnComboBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.pageControl1 = new FastReport.Controls.PageControl();
            this.panelView = new System.Windows.Forms.Panel();
            this.pgStyle.SuspendLayout();
            this.pgGeneral.SuspendLayout();
            this.gbExpressions.SuspendLayout();
            this.pageControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(678, 528);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(780, 528);
            // 
            // pgStyle
            // 
            this.pgStyle.BackColor = System.Drawing.SystemColors.Window;
            this.pgStyle.Controls.Add(this.cbDirection);
            this.pgStyle.Controls.Add(this.labelDir);
            this.pgStyle.Controls.Add(this.labelPalette);
            this.pgStyle.Controls.Add(this.cbPalette);
            this.pgStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgStyle.Location = new System.Drawing.Point(120, 1);
            this.pgStyle.Name = "pgStyle";
            this.pgStyle.Size = new System.Drawing.Size(400, 502);
            this.pgStyle.TabIndex = 0;
            this.pgStyle.Text = "Style";
            // 
            // cbDirection
            // 
            this.cbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirection.Location = new System.Drawing.Point(139, 48);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(241, 24);
            this.cbDirection.TabIndex = 3;
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(17, 48);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(66, 17);
            this.labelDir.TabIndex = 4;
            this.labelDir.Text = "Direction ";
            // 
            // labelPalette
            // 
            this.labelPalette.AutoSize = true;
            this.labelPalette.Location = new System.Drawing.Point(16, 20);
            this.labelPalette.Name = "labelPalette";
            this.labelPalette.Size = new System.Drawing.Size(49, 17);
            this.labelPalette.TabIndex = 2;
            this.labelPalette.Text = "Palette";
            // 
            // cbPalette
            // 
            this.cbPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalette.FormattingEnabled = true;
            this.cbPalette.Location = new System.Drawing.Point(139, 16);
            this.cbPalette.Name = "cbPalette";
            this.cbPalette.Size = new System.Drawing.Size(241, 24);
            this.cbPalette.TabIndex = 1;
            this.cbPalette.SelectedIndexChanged += new System.EventHandler(this.cbPalette_SelectedIndexChanged);
            // 
            // pgGeneral
            // 
            this.pgGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.pgGeneral.Controls.Add(this.tbDepth);
            this.pgGeneral.Controls.Add(this.labelDepth);
            this.pgGeneral.Controls.Add(this.tbRoot);
            this.pgGeneral.Controls.Add(this.labelRoot);
            this.pgGeneral.Controls.Add(this.gbExpressions);
            this.pgGeneral.Controls.Add(this.cbValueColumn);
            this.pgGeneral.Controls.Add(this.cbData);
            this.pgGeneral.Controls.Add(this.labelData);
            this.pgGeneral.Controls.Add(this.labelValue);
            this.pgGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgGeneral.Location = new System.Drawing.Point(120, 1);
            this.pgGeneral.Name = "pgGeneral";
            this.pgGeneral.Size = new System.Drawing.Size(400, 502);
            this.pgGeneral.TabIndex = 1;
            this.pgGeneral.Text = "General";
            // 
            // tbDepth
            // 
            this.tbDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDepth.Location = new System.Drawing.Point(175, 356);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(207, 24);
            this.tbDepth.TabIndex = 17;
            this.tbDepth.Minimum = 0;
            this.tbDepth.ValueChanged += new System.EventHandler(this.tbDepth_ValueChanged);
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(18, 363);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(46, 17);
            this.labelDepth.TabIndex = 16;
            this.labelDepth.Text = "Depth";
            // 
            // tbRoot
            // 
            this.tbRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRoot.Location = new System.Drawing.Point(175, 384);
            this.tbRoot.Name = "tbRoot";
            this.tbRoot.Size = new System.Drawing.Size(207, 24);
            this.tbRoot.TabIndex = 15;
            this.tbRoot.TextChanged += new System.EventHandler(this.tbRoot_TextChanged);
            // 
            // labelRoot
            // 
            this.labelRoot.AutoSize = true;
            this.labelRoot.Location = new System.Drawing.Point(18, 391);
            this.labelRoot.Name = "labelRoot";
            this.labelRoot.Size = new System.Drawing.Size(67, 17);
            this.labelRoot.TabIndex = 14;
            this.labelRoot.Text = "Root text";
            // 
            // gbExpressions
            // 
            this.gbExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExpressions.Controls.Add(this.lvExpressions);
            this.gbExpressions.Controls.Add(this.btnDown);
            this.gbExpressions.Controls.Add(this.btnUp);
            this.gbExpressions.Controls.Add(this.btnEdit);
            this.gbExpressions.Controls.Add(this.btnDelete);
            this.gbExpressions.Controls.Add(this.btnAdd);
            this.gbExpressions.Location = new System.Drawing.Point(19, 87);
            this.gbExpressions.Margin = new System.Windows.Forms.Padding(4);
            this.gbExpressions.Name = "gbExpressions";
            this.gbExpressions.Padding = new System.Windows.Forms.Padding(4);
            this.gbExpressions.Size = new System.Drawing.Size(361, 258);
            this.gbExpressions.TabIndex = 13;
            this.gbExpressions.TabStop = false;
            this.gbExpressions.Text = "Text Columns";
            // 
            // lvExpressions
            // 
            this.lvExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvExpressions.HideSelection = false;
            this.lvExpressions.Location = new System.Drawing.Point(15, 25);
            this.lvExpressions.Margin = new System.Windows.Forms.Padding(4);
            this.lvExpressions.Name = "lvExpressions";
            this.lvExpressions.Size = new System.Drawing.Size(232, 219);
            this.lvExpressions.TabIndex = 6;
            this.lvExpressions.UseCompatibleStateImageBehavior = false;
            this.lvExpressions.View = System.Windows.Forms.View.List;
            this.lvExpressions.SelectedIndexChanged += new System.EventHandler(this.lvExpressions_SelectedIndexChanged);
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
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
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
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(261, 95);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbValueColumn
            // 
            this.cbValueColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbValueColumn.Location = new System.Drawing.Point(139, 48);
            this.cbValueColumn.Name = "cbValueColumn";
            this.cbValueColumn.Size = new System.Drawing.Size(241, 23);
            this.cbValueColumn.TabIndex = 10;
            this.cbValueColumn.Leave += new System.EventHandler(this.cbValueColumn_Leave);
            // 
            // cbData
            // 
            this.cbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(139, 16);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(241, 24);
            this.cbData.TabIndex = 9;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(16, 20);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(90, 17);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data Sources";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(16, 48);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(91, 17);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Value Column";
            // 
            // pageControl1
            // 
            this.pageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl1.Controls.Add(this.pgGeneral);
            this.pageControl1.Controls.Add(this.pgStyle);
            this.pageControl1.HighlightPageIndex = -1;
            this.pageControl1.Location = new System.Drawing.Point(356, 12);
            this.pageControl1.Name = "pageControl1";
            this.pageControl1.SelectorWidth = 120;
            this.pageControl1.Size = new System.Drawing.Size(521, 504);
            this.pageControl1.TabIndex = 1;
            this.pageControl1.Text = "pageControl1";
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelView.Location = new System.Drawing.Point(13, 13);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(330, 330);
            this.panelView.TabIndex = 2;
            this.panelView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelView_Paint);
            // 
            // BGChartEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 562);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.pageControl1);
            this.Name = "BGChartEditorForm";
            this.Text = "Chart Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BGChartEditorForm_FormClosed);
            this.Controls.SetChildIndex(this.pageControl1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.panelView, 0);
            this.pgStyle.ResumeLayout(false);
            this.pgStyle.PerformLayout();
            this.pgGeneral.ResumeLayout(false);
            this.pgGeneral.PerformLayout();
            this.gbExpressions.ResumeLayout(false);
            this.pageControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected FastReport.Controls.PageControlPage pgStyle;
        protected System.Windows.Forms.Label labelValue;
        protected FastReport.Controls.PageControlPage pgGeneral;
        protected System.Windows.Forms.ComboBox cbPalette;
        protected System.Windows.Forms.Label labelPalette;
        protected System.Windows.Forms.ComboBox cbData;
        protected System.Windows.Forms.Label labelData;
        protected FastReport.Controls.DataColumnComboBox cbValueColumn;
        protected System.Windows.Forms.ComboBox cbDirection;
        protected System.Windows.Forms.Label labelDir;
        protected System.Windows.Forms.Panel panelView;
        protected FastReport.Controls.PageControl pageControl1;
        protected System.Windows.Forms.NumericUpDown tbDepth;
        protected System.Windows.Forms.Label labelDepth;
        protected System.Windows.Forms.TextBox tbRoot;
        protected System.Windows.Forms.Label labelRoot;
        private System.Windows.Forms.GroupBox gbExpressions;
        private System.Windows.Forms.ListView lvExpressions;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}