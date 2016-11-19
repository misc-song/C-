namespace MMS.UIL
{
    partial class Manger
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
            this.type_manager_btn = new System.Windows.Forms.Button();
            this.money_manager_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // type_manager_btn
            // 
            this.type_manager_btn.Location = new System.Drawing.Point(22, 13);
            this.type_manager_btn.Name = "type_manager_btn";
            this.type_manager_btn.Size = new System.Drawing.Size(75, 23);
            this.type_manager_btn.TabIndex = 2;
            this.type_manager_btn.Text = "类别管理";
            this.type_manager_btn.UseVisualStyleBackColor = true;
            this.type_manager_btn.Click += new System.EventHandler(this.type_manager_btn_Click);
            // 
            // money_manager_btn
            // 
            this.money_manager_btn.Location = new System.Drawing.Point(149, 12);
            this.money_manager_btn.Name = "money_manager_btn";
            this.money_manager_btn.Size = new System.Drawing.Size(75, 23);
            this.money_manager_btn.TabIndex = 3;
            this.money_manager_btn.Text = "理财管理";
            this.money_manager_btn.UseVisualStyleBackColor = true;
            this.money_manager_btn.Click += new System.EventHandler(this.money_manager_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Type_Manger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money_manager_btn);
            this.Controls.Add(this.type_manager_btn);
            this.Name = "Type_Manger";
            this.Text = "Type_Manger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button type_manager_btn;
        private System.Windows.Forms.Button money_manager_btn;
        private System.Windows.Forms.Label label1;
    }
}