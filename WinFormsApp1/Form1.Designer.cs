namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.TextBox txtBottom;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Button btnCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.txtBottom = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtCenter
            this.txtCenter.Location = new System.Drawing.Point(150, 150);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(60, 60); // Square size
            this.txtCenter.TabIndex = 0;
            this.txtCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCenter.TextChanged += new System.EventHandler(this.txtCenter_TextChanged);

            // txtTop
            this.txtTop.Location = new System.Drawing.Point(150, 90); // Just above the center box
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(60, 60); // Square size
            this.txtTop.TabIndex = 1;

            // txtBottom
            this.txtBottom.Location = new System.Drawing.Point(150, 210); // Just below the center box
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(60, 60); // Square size
            this.txtBottom.TabIndex = 2;

            // txtLeft
            this.txtLeft.Location = new System.Drawing.Point(90, 150); // Just left of the center box
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(60, 60); // Square size
            this.txtLeft.TabIndex = 3;

            // txtRight
            this.txtRight.Location = new System.Drawing.Point(210, 150); // Just right of the center box
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(60, 60); // Square size
            this.txtRight.TabIndex = 4;

            // btnCheck
            this.btnCheck.Location = new System.Drawing.Point(150, 280);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
