using System.ComponentModel;

namespace AdmissionCommittee.Views;

partial class HomeUserControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
        this.total_applications = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.requests = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // total_applications
        // 
        this.total_applications.BackColor = System.Drawing.Color.Transparent;
        this.total_applications.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.total_applications.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        this.total_applications.Location = new System.Drawing.Point(519, 219);
        this.total_applications.Name = "total_applications";
        this.total_applications.Size = new System.Drawing.Size(384, 36);
        this.total_applications.TabIndex = 0;
        // 
        // label4
        // 
        this.label4.BackColor = System.Drawing.Color.Transparent;
        this.label4.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label4.Location = new System.Drawing.Point(0, 77);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(1264, 49);
        this.label4.TabIndex = 3;
        this.label4.Text = "Welcome";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // requests
        // 
        this.requests.BackColor = System.Drawing.Color.Transparent;
        this.requests.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.requests.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        this.requests.Location = new System.Drawing.Point(497, 271);
        this.requests.Name = "requests";
        this.requests.Size = new System.Drawing.Size(406, 36);
        this.requests.TabIndex = 4;
        // 
        // HomeUserControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.Controls.Add(this.requests);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.total_applications);
        this.DoubleBuffered = true;
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "HomeUserControl";
        this.Size = new System.Drawing.Size(1264, 596);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label requests;

    private System.Windows.Forms.Label total_applications;

    #endregion
}