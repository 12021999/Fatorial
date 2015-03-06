namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox = new System.Windows.Forms.TextBox();
            this.buttonIt = new System.Windows.Forms.Button();
            this.buttonRec = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelMultimidia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(80, 12);
            this.txtBox.MaxLength = 2;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(57, 25);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "0";
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonIt
            // 
            this.buttonIt.Location = new System.Drawing.Point(12, 43);
            this.buttonIt.Name = "buttonIt";
            this.buttonIt.Size = new System.Drawing.Size(125, 29);
            this.buttonIt.TabIndex = 1;
            this.buttonIt.Text = "Fatorial - Iterativa";
            this.buttonIt.UseVisualStyleBackColor = true;
            this.buttonIt.Click += new System.EventHandler(this.buttonIt_Click);
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(144, 44);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(120, 28);
            this.buttonRec.TabIndex = 2;
            this.buttonRec.Text = "Fatorial - Recursiva";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(143, 18);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(13, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "0";
            // 
            // labelMultimidia
            // 
            this.labelMultimidia.AutoSize = true;
            this.labelMultimidia.Location = new System.Drawing.Point(152, 83);
            this.labelMultimidia.Name = "labelMultimidia";
            this.labelMultimidia.Size = new System.Drawing.Size(112, 13);
            this.labelMultimidia.TabIndex = 4;
            this.labelMultimidia.Text = "#EuNaoSouMultimidia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 105);
            this.Controls.Add(this.labelMultimidia);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.buttonIt);
            this.Controls.Add(this.txtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Baidu Security";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button buttonIt;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelMultimidia;
    }
}

