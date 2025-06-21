using System.ComponentModel;

namespace AdmissionCommittee.Views;

partial class Rating2UserControl
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
        this.dataGridViewRating2 = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating2)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridViewRating2
        // 
        this.dataGridViewRating2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        this.dataGridViewRating2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewRating2.GridColor = System.Drawing.SystemColors.Control;
        this.dataGridViewRating2.Location = new System.Drawing.Point(8, 8);
        this.dataGridViewRating2.Name = "dataGridViewRating2";
        this.dataGridViewRating2.Size = new System.Drawing.Size(1264, 596);
        this.dataGridViewRating2.TabIndex = 2;
        // 
        // Rating2UserControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.dataGridViewRating2);
        this.Name = "Rating2UserControl";
        this.Size = new System.Drawing.Size(1264, 596);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating2)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridViewRating2;

    #endregion
}