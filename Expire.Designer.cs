
namespace Profiler
{
    partial class Expire
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
            this.buyButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пробная версия продукта истекла.\r\nВыберите дальнейшее действие.\r\n";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(28, 95);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(321, 56);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Купить полную версию";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(28, 157);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(321, 56);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Удалить программу";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // Expire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 235);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.label1);
            this.Name = "Expire";
            this.Text = "Expire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button delButton;
    }
}