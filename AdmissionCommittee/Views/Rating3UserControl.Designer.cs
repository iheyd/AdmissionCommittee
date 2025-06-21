using System.ComponentModel;

namespace AdmissionCommittee.Views;

partial class Rating3UserControl
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
        this.dataGridViewRating3 = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating3)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridViewRating3
        // 
        this.dataGridViewRating3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        this.dataGridViewRating3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewRating3.GridColor = System.Drawing.SystemColors.Control;
        this.dataGridViewRating3.Location = new System.Drawing.Point(8, 8);
        this.dataGridViewRating3.Name = "dataGridViewRating3";
        this.dataGridViewRating3.Size = new System.Drawing.Size(1264, 596);
        this.dataGridViewRating3.TabIndex = 2;
        // 
        // Rating3UserControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.dataGridViewRating3);
        this.Name = "Rating3UserControl";
        this.Size = new System.Drawing.Size(1264, 596);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating3)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridViewRating3;

    #endregion
}