using System.ComponentModel;

namespace AdmissionCommittee.Views;

partial class Request1UserControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request1UserControl));
        this.textBoxFIO = new System.Windows.Forms.TextBox();
        this.textBoxDirection = new System.Windows.Forms.TextBox();
        this.textBoxMath = new System.Windows.Forms.TextBox();
        this.textBoxRussian = new System.Windows.Forms.TextBox();
        this.textBoxAdditional = new System.Windows.Forms.TextBox();
        this.textBoxAddPoints = new System.Windows.Forms.TextBox();
        this.wrapButton = new System.Windows.Forms.Button();
        this.wrap2 = new System.Windows.Forms.Button();
        this.wrap3 = new System.Windows.Forms.Button();
        this.wrap1 = new System.Windows.Forms.Button();
        this.wrapPanel = new System.Windows.Forms.Panel();
        this.textBoxCode = new System.Windows.Forms.MaskedTextBox();
        this.saveButton = new System.Windows.Forms.Button();
        this.clearButton = new System.Windows.Forms.Button();
        this.wrapPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // textBoxFIO
        // 
        this.textBoxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxFIO.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxFIO.Location = new System.Drawing.Point(400, 173);
        this.textBoxFIO.Name = "textBoxFIO";
        this.textBoxFIO.Size = new System.Drawing.Size(381, 24);
        this.textBoxFIO.TabIndex = 1;
        // 
        // textBoxDirection
        // 
        this.textBoxDirection.BackColor = System.Drawing.Color.White;
        this.textBoxDirection.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxDirection.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.textBoxDirection.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxDirection.ForeColor = System.Drawing.SystemColors.GrayText;
        this.textBoxDirection.Location = new System.Drawing.Point(400, 226);
        this.textBoxDirection.Name = "textBoxDirection";
        this.textBoxDirection.ReadOnly = true;
        this.textBoxDirection.Size = new System.Drawing.Size(381, 24);
        this.textBoxDirection.TabIndex = 2;
        // 
        // textBoxMath
        // 
        this.textBoxMath.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxMath.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxMath.Location = new System.Drawing.Point(400, 279);
        this.textBoxMath.Name = "textBoxMath";
        this.textBoxMath.Size = new System.Drawing.Size(381, 24);
        this.textBoxMath.TabIndex = 3;
        this.textBoxMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
        this.textBoxMath.Validated += new System.EventHandler(this.ScoreTextBox_Validated);
        // 
        // textBoxRussian
        // 
        this.textBoxRussian.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxRussian.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxRussian.Location = new System.Drawing.Point(400, 332);
        this.textBoxRussian.Name = "textBoxRussian";
        this.textBoxRussian.Size = new System.Drawing.Size(381, 24);
        this.textBoxRussian.TabIndex = 4;
        this.textBoxRussian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
        this.textBoxRussian.Validated += new System.EventHandler(this.ScoreTextBox_Validated);
        // 
        // textBoxAdditional
        // 
        this.textBoxAdditional.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxAdditional.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxAdditional.Location = new System.Drawing.Point(400, 385);
        this.textBoxAdditional.Name = "textBoxAdditional";
        this.textBoxAdditional.Size = new System.Drawing.Size(381, 24);
        this.textBoxAdditional.TabIndex = 5;
        this.textBoxAdditional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
        this.textBoxAdditional.Validated += new System.EventHandler(this.ScoreTextBox_Validated);
        // 
        // textBoxAddPoints
        // 
        this.textBoxAddPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxAddPoints.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxAddPoints.Location = new System.Drawing.Point(400, 438);
        this.textBoxAddPoints.Name = "textBoxAddPoints";
        this.textBoxAddPoints.Size = new System.Drawing.Size(381, 24);
        this.textBoxAddPoints.TabIndex = 6;
        this.textBoxAddPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
        this.textBoxAddPoints.Validated += new System.EventHandler(this.ScoreTextBox_Validated);
        // 
        // wrapButton
        // 
        this.wrapButton.BackColor = System.Drawing.Color.Transparent;
        this.wrapButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapButton.BackgroundImage")));
        this.wrapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.wrapButton.FlatAppearance.BorderSize = 0;
        this.wrapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.wrapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.wrapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.wrapButton.Location = new System.Drawing.Point(760, 220);
        this.wrapButton.Name = "wrapButton";
        this.wrapButton.Size = new System.Drawing.Size(30, 40);
        this.wrapButton.TabIndex = 8;
        this.wrapButton.UseVisualStyleBackColor = true;
        this.wrapButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrapButton_MouseDown);
        this.wrapButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrapButton_MouseUp);
        // 
        // wrap2
        // 
        this.wrap2.BackColor = System.Drawing.Color.Transparent;
        this.wrap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrap2.BackgroundImage")));
        this.wrap2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.wrap2.FlatAppearance.BorderSize = 0;
        this.wrap2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.wrap2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.wrap2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.wrap2.Location = new System.Drawing.Point(1, 35);
        this.wrap2.Name = "wrap2";
        this.wrap2.Size = new System.Drawing.Size(212, 32);
        this.wrap2.TabIndex = 11;
        this.wrap2.UseVisualStyleBackColor = true;
        this.wrap2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrap2_MouseDown);
        this.wrap2.MouseEnter += new System.EventHandler(this.wrap2_MouseEnter);
        this.wrap2.MouseLeave += new System.EventHandler(this.wrap2_MouseLeave);
        this.wrap2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrap2_MouseUp);
        // 
        // wrap3
        // 
        this.wrap3.BackColor = System.Drawing.Color.Transparent;
        this.wrap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrap3.BackgroundImage")));
        this.wrap3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.wrap3.FlatAppearance.BorderSize = 0;
        this.wrap3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.wrap3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.wrap3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.wrap3.Location = new System.Drawing.Point(1, 70);
        this.wrap3.Name = "wrap3";
        this.wrap3.Size = new System.Drawing.Size(212, 31);
        this.wrap3.TabIndex = 11;
        this.wrap3.UseVisualStyleBackColor = true;
        this.wrap3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrap3_MouseDown);
        this.wrap3.MouseEnter += new System.EventHandler(this.wrap3_MouseEnter);
        this.wrap3.MouseLeave += new System.EventHandler(this.wrap3_MouseLeave);
        this.wrap3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrap3_MouseUp);
        // 
        // wrap1
        // 
        this.wrap1.BackColor = System.Drawing.Color.Transparent;
        this.wrap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrap1.BackgroundImage")));
        this.wrap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.wrap1.FlatAppearance.BorderSize = 0;
        this.wrap1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.wrap1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.wrap1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.wrap1.Location = new System.Drawing.Point(1, 1);
        this.wrap1.Name = "wrap1";
        this.wrap1.Size = new System.Drawing.Size(212, 32);
        this.wrap1.TabIndex = 10;
        this.wrap1.UseVisualStyleBackColor = false;
        this.wrap1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrap1_MouseDown);
        this.wrap1.MouseEnter += new System.EventHandler(this.wrap1_MouseEnter);
        this.wrap1.MouseLeave += new System.EventHandler(this.wrap1_MouseLeave);
        this.wrap1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrap1_MouseUp);
        // 
        // wrapPanel
        // 
        this.wrapPanel.BackColor = System.Drawing.Color.White;
        this.wrapPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapPanel.BackgroundImage")));
        this.wrapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.wrapPanel.Controls.Add(this.wrap1);
        this.wrapPanel.Controls.Add(this.wrap2);
        this.wrapPanel.Controls.Add(this.wrap3);
        this.wrapPanel.Location = new System.Drawing.Point(796, 220);
        this.wrapPanel.Margin = new System.Windows.Forms.Padding(0);
        this.wrapPanel.Name = "wrapPanel";
        this.wrapPanel.Size = new System.Drawing.Size(214, 103);
        this.wrapPanel.TabIndex = 12;
        this.wrapPanel.Visible = false;
        // 
        // textBoxCode
        // 
        this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBoxCode.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.textBoxCode.Location = new System.Drawing.Point(400, 120);
        this.textBoxCode.Mask = "000-000-000 00";
        this.textBoxCode.Name = "textBoxCode";
        this.textBoxCode.Size = new System.Drawing.Size(381, 24);
        this.textBoxCode.TabIndex = 13;
        // 
        // saveButton
        // 
        this.saveButton.BackColor = System.Drawing.Color.Transparent;
        this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
        this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.saveButton.FlatAppearance.BorderSize = 0;
        this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.saveButton.Location = new System.Drawing.Point(396, 487);
        this.saveButton.Name = "saveButton";
        this.saveButton.Size = new System.Drawing.Size(194, 36);
        this.saveButton.TabIndex = 14;
        this.saveButton.UseVisualStyleBackColor = true;
        this.saveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseDown);
        this.saveButton.MouseEnter += new System.EventHandler(this.saveButton_MouseEnter);
        this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
        this.saveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseUp);
        // 
        // clearButton
        // 
        this.clearButton.BackColor = System.Drawing.Color.Transparent;
        this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
        this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.clearButton.FlatAppearance.BorderSize = 0;
        this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.clearButton.Location = new System.Drawing.Point(596, 487);
        this.clearButton.Name = "clearButton";
        this.clearButton.Size = new System.Drawing.Size(194, 36);
        this.clearButton.TabIndex = 15;
        this.clearButton.UseVisualStyleBackColor = true;
        this.clearButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clearButton_MouseDown);
        this.clearButton.MouseEnter += new System.EventHandler(this.clearButton_MouseEnter);
        this.clearButton.MouseLeave += new System.EventHandler(this.clearButton_MouseLeave);
        this.clearButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clearButton_MouseUp);
        // 
        // Request1UserControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.Controls.Add(this.clearButton);
        this.Controls.Add(this.saveButton);
        this.Controls.Add(this.textBoxCode);
        this.Controls.Add(this.wrapPanel);
        this.Controls.Add(this.wrapButton);
        this.Controls.Add(this.textBoxAddPoints);
        this.Controls.Add(this.textBoxAdditional);
        this.Controls.Add(this.textBoxRussian);
        this.Controls.Add(this.textBoxMath);
        this.Controls.Add(this.textBoxDirection);
        this.Controls.Add(this.textBoxFIO);
        this.DoubleBuffered = true;
        this.Name = "Request1UserControl";
        this.Size = new System.Drawing.Size(1264, 596);
        this.wrapPanel.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button clearButton;

    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.MaskedTextBox textBoxCode;

    private System.Windows.Forms.Panel wrapPanel;

    private System.Windows.Forms.Button wrap1;
    private System.Windows.Forms.Button wrap3;
    private System.Windows.Forms.Button wrap2;

    private System.Windows.Forms.Button wrapButton;

    private System.Windows.Forms.TextBox textBoxAdditional;
    private System.Windows.Forms.TextBox textBoxAddPoints;

    private System.Windows.Forms.TextBox textBoxFIO;
    private System.Windows.Forms.TextBox textBoxDirection;
    private System.Windows.Forms.TextBox textBoxMath;
    private System.Windows.Forms.TextBox textBoxRussian;

    #endregion
}