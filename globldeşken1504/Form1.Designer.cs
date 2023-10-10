namespace globldeşken1504
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
            this.buttopla = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.bntOde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttopla
            // 
            this.buttopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttopla.Location = new System.Drawing.Point(13, 18);
            this.buttopla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttopla.Name = "buttopla";
            this.buttopla.Size = new System.Drawing.Size(112, 72);
            this.buttopla.TabIndex = 0;
            this.buttopla.Text = "topla";
            this.buttopla.UseVisualStyleBackColor = true;
            this.buttopla.Click += new System.EventHandler(this.buttopla_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(18, 126);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(152, 55);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "label1";
            // 
            // bntOde
            // 
            this.bntOde.Location = new System.Drawing.Point(161, 24);
            this.bntOde.Name = "bntOde";
            this.bntOde.Size = new System.Drawing.Size(75, 71);
            this.bntOde.TabIndex = 2;
            this.bntOde.Text = "Ode";
            this.bntOde.UseVisualStyleBackColor = true;
            this.bntOde.Click += new System.EventHandler(this.bntOde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 252);
            this.Controls.Add(this.bntOde);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.buttopla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttopla;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button bntOde;
    }
}

