
namespace FastReportBGObjects.IcicleChart
{
    partial class IcicleEditorForm
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

            this.pageControl1.SuspendLayout();
            this.pgStyle.SuspendLayout();
            this.pgGeneral.SuspendLayout();
            this.SuspendLayout();            
            // 
            // cbDirection
            // 
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            // 
            // IcicleEditorForm
            // 
            this.Name = "IcicleEditorForm";
            this.Text = "Icicle Editor";
            this.pageControl1.ResumeLayout(false);
            this.pgStyle.ResumeLayout(false);
            this.pgStyle.PerformLayout();
            this.pgGeneral.ResumeLayout(false);
            this.pgGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}