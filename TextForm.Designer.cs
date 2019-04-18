namespace Paint
{
    partial class TextForm
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
            this.txtBox_Text = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Font = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Text
            // 
            this.txtBox_Text.Location = new System.Drawing.Point(12, 13);
            this.txtBox_Text.Multiline = true;
            this.txtBox_Text.Name = "txtBox_Text";
            this.txtBox_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox_Text.Size = new System.Drawing.Size(391, 80);
            this.txtBox_Text.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(247, 99);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancle.Location = new System.Drawing.Point(334, 99);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 8;
            this.btn_Cancle.Text = "&Cancel";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            // 
            // btn_Font
            // 
            this.btn_Font.Location = new System.Drawing.Point(32, 99);
            this.btn_Font.Name = "btn_Font";
            this.btn_Font.Size = new System.Drawing.Size(75, 23);
            this.btn_Font.TabIndex = 7;
            this.btn_Font.Text = "&Font...";
            this.btn_Font.UseVisualStyleBackColor = true;
            this.btn_Font.Click += new System.EventHandler(this.btn_Font_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 134);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Font);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_Text);
            this.Name = "TextForm";
            this.Text = "Set Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Text;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Font;
    }
}