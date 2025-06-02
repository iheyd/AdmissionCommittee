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
        this.label1 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.BackColor = System.Drawing.Color.Transparent;
        this.label1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        this.label1.Location = new System.Drawing.Point(519, 219);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(384, 36);
        this.label1.TabIndex = 0;
        this.label1.Text = "123";
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
        // label2
        // 
        this.label2.BackColor = System.Drawing.Color.Transparent;
        this.label2.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        this.label2.Location = new System.Drawing.Point(497, 271);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(406, 36);
        this.label2.TabIndex = 4;
        this.label2.Text = "123";
        // 
        // label3
        // 
        this.label3.BackColor = System.Drawing.Color.Transparent;
        this.label3.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        this.label3.Location = new System.Drawing.Point(519, 324);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(384, 36);
        this.label3.TabIndex = 5;
        this.label3.Text = "123";
        // 
        // HomeUserControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label1);
        this.DoubleBuffered = true;
        this.Name = "HomeUserControl";
        this.Size = new System.Drawing.Size(1264, 596);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}