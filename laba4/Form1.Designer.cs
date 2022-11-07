namespace laba4
{
    partial class Laba3
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
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_polygon = new System.Windows.Forms.RadioButton();
            this.radioButton_otrezok = new System.Windows.Forms.RadioButton();
            this.radioButton_point = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 607);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.radioButton_polygon);
            this.groupBox1.Controls.Add(this.radioButton_otrezok);
            this.groupBox1.Controls.Add(this.radioButton_point);
            this.groupBox1.Location = new System.Drawing.Point(667, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(183, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_polygon
            // 
            this.radioButton_polygon.AutoSize = true;
            this.radioButton_polygon.Location = new System.Drawing.Point(117, 17);
            this.radioButton_polygon.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_polygon.Name = "radioButton_polygon";
            this.radioButton_polygon.Size = new System.Drawing.Size(63, 17);
            this.radioButton_polygon.TabIndex = 2;
            this.radioButton_polygon.TabStop = true;
            this.radioButton_polygon.Text = "Polygon";
            this.radioButton_polygon.UseVisualStyleBackColor = true;
            this.radioButton_polygon.CheckedChanged += new System.EventHandler(this.radioButton_polygon_CheckedChanged);
            // 
            // radioButton_otrezok
            // 
            this.radioButton_otrezok.AutoSize = true;
            this.radioButton_otrezok.Location = new System.Drawing.Point(63, 17);
            this.radioButton_otrezok.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_otrezok.Name = "radioButton_otrezok";
            this.radioButton_otrezok.Size = new System.Drawing.Size(50, 17);
            this.radioButton_otrezok.TabIndex = 1;
            this.radioButton_otrezok.TabStop = true;
            this.radioButton_otrezok.Text = "Edge";
            this.radioButton_otrezok.UseVisualStyleBackColor = true;
            // 
            // radioButton_point
            // 
            this.radioButton_point.AutoSize = true;
            this.radioButton_point.Location = new System.Drawing.Point(4, 17);
            this.radioButton_point.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_point.Name = "radioButton_point";
            this.radioButton_point.Size = new System.Drawing.Size(49, 17);
            this.radioButton_point.TabIndex = 0;
            this.radioButton_point.TabStop = true;
            this.radioButton_point.Text = "Point";
            this.radioButton_point.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(671, 60);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 26);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Laba3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1258, 629);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Laba3";
            this.Text = "Laba3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_polygon;
        private System.Windows.Forms.RadioButton radioButton_otrezok;
        private System.Windows.Forms.RadioButton radioButton_point;
        private System.Windows.Forms.Button clearButton;
    }
}

