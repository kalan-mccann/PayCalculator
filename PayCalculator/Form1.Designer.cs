namespace PayCalculator
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.payInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pretaxOutput = new System.Windows.Forms.Label();
            this.pretaxLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.earnedLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.earnedOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-3, -3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(310, 53);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Pay Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.Location = new System.Drawing.Point(35, 103);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(137, 24);
            this.hourLabel.TabIndex = 1;
            this.hourLabel.Text = "Hours Worked:";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(83, 139);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(89, 24);
            this.payLabel.TabIndex = 2;
            this.payLabel.Text = "Pay Rate:";
            // 
            // hoursInput
            // 
            this.hoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursInput.Location = new System.Drawing.Point(179, 103);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(100, 26);
            this.hoursInput.TabIndex = 3;
            // 
            // payInput
            // 
            this.payInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payInput.Location = new System.Drawing.Point(178, 139);
            this.payInput.Name = "payInput";
            this.payInput.Size = new System.Drawing.Size(100, 26);
            this.payInput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(87, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(122, 44);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pretaxOutput
            // 
            this.pretaxOutput.BackColor = System.Drawing.Color.White;
            this.pretaxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretaxOutput.Location = new System.Drawing.Point(163, 271);
            this.pretaxOutput.Name = "pretaxOutput";
            this.pretaxOutput.Size = new System.Drawing.Size(100, 23);
            this.pretaxOutput.TabIndex = 7;
            this.pretaxOutput.Text = "label1";
            // 
            // pretaxLabel
            // 
            this.pretaxLabel.AutoSize = true;
            this.pretaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretaxLabel.Location = new System.Drawing.Point(67, 268);
            this.pretaxLabel.Name = "pretaxLabel";
            this.pretaxLabel.Size = new System.Drawing.Size(81, 24);
            this.pretaxLabel.TabIndex = 8;
            this.pretaxLabel.Text = "Pre Tax:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(101, 308);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(47, 24);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // earnedLabel
            // 
            this.earnedLabel.AutoSize = true;
            this.earnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnedLabel.Location = new System.Drawing.Point(71, 348);
            this.earnedLabel.Name = "earnedLabel";
            this.earnedLabel.Size = new System.Drawing.Size(77, 24);
            this.earnedLabel.TabIndex = 10;
            this.earnedLabel.Text = "Earned:";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(163, 311);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.Text = "label2";
            // 
            // earnedOutput
            // 
            this.earnedOutput.BackColor = System.Drawing.Color.White;
            this.earnedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnedOutput.Location = new System.Drawing.Point(163, 348);
            this.earnedOutput.Name = "earnedOutput";
            this.earnedOutput.Size = new System.Drawing.Size(100, 23);
            this.earnedOutput.TabIndex = 12;
            this.earnedOutput.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.earnedOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.earnedLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.pretaxLabel);
            this.Controls.Add(this.pretaxOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.payInput);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.TextBox payInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label pretaxOutput;
        private System.Windows.Forms.Label pretaxLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label earnedLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label earnedOutput;
    }
}

