using System.ComponentModel;

namespace AdmissionCommittee.Views;

partial class Request2UserControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridViewRequests
        // 
        this.dataGridViewRequests.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewRequests.GridColor = System.Drawing.SystemColors.Control;
        this.dataGridViewRequests.Location = new System.Drawing.Point(0, 0);
        this.dataGridViewRequests.Name = "dataGridViewRequests";
        this.dataGridViewRequests.Size = new System.Drawing.Size(1264, 596);
        this.dataGridViewRequests.TabIndex = 0;
        // 
        // Request2UserControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.Controls.Add(this.dataGridViewRequests);
        this.DoubleBuffered = true;
        this.Name = "Request2UserControl";
        this.Size = new System.Drawing.Size(1264, 596);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridViewRequests;

    #endregion
}