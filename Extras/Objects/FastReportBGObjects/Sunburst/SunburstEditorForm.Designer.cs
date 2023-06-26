
namespace FastReportBGObjects.SunburstChart
{
    partial class SunburstEditorForm
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
        protected override void InitializeComponent()
        {
            base.InitializeComponent();

            this.labelAngle = new System.Windows.Forms.Label();
            this.tbAngle = new System.Windows.Forms.NumericUpDown();
            this.pgStyle.SuspendLayout();
            this.pgGeneral.SuspendLayout();
            this.pageControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgStyle
            // 
            this.pgStyle.Controls.Add(this.labelAngle);
            this.pgStyle.Controls.Add(this.tbAngle);
            this.pgStyle.Controls.SetChildIndex(this.labelDir, 0);
            this.pgStyle.Controls.SetChildIndex(this.cbDirection, 0);
            this.pgStyle.Controls.SetChildIndex(this.tbAngle, 0);
            this.pgStyle.Controls.SetChildIndex(this.labelAngle, 0);
            this.pgStyle.Controls.SetChildIndex(this.cbPalette, 0);
            this.pgStyle.Controls.SetChildIndex(this.labelPalette, 0);
            // 
            // labelAngle
            // 
            this.labelAngle.Location = new System.Drawing.Point(19, 103);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(86, 18);
            this.labelAngle.TabIndex = 8;
            this.labelAngle.Text = "Start Angle";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(148, 94);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(200, 24);
            this.tbAngle.TabIndex = 9;
            this.tbAngle.Maximum = 360;
            this.tbAngle.ValueChanged += new System.EventHandler(this.tbAngle_ValueChanged);
            // 
            // SunburstEditorForm
            // 
            this.Name = "SunburstEditorForm";
            this.Text = "Sunburst Editor";
            this.Controls.SetChildIndex(this.pageControl1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.panelView, 0);
            this.pgStyle.ResumeLayout(false);
            this.pgStyle.PerformLayout();
            this.pgGeneral.ResumeLayout(false);
            this.pgGeneral.PerformLayout();
            this.pageControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.NumericUpDown tbAngle;
    }
}