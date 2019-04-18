namespace Paint
{
    partial class NewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.btn_Set = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Location = new System.Drawing.Point(30, 50);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(202, 20);
            this.numericUpDown_width.TabIndex = 1;
            this.numericUpDown_width.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Location = new System.Drawing.Point(30, 116);
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            555,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(202, 20);
            this.numericUpDown_height.TabIndex = 3;
            this.numericUpDown_height.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // btn_Set
            // 
            this.btn_Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Set.Location = new System.Drawing.Point(91, 162);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 4;
            this.btn_Set.Text = "SET";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 217);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.numericUpDown_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_width);
            this.Controls.Add(this.label1);
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Button btn_Set;
    }
}