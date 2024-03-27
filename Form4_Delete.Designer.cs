
namespace ParbaudesUzdevums
{
    partial class Form4_Delete
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
            this.userList = new System.Windows.Forms.ListBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izvēlieties personu dzēšanai";
            // 
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 25;
            this.userList.Location = new System.Drawing.Point(227, 43);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(305, 329);
            this.userList.TabIndex = 2;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUserButton.Location = new System.Drawing.Point(287, 379);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(175, 59);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Dzēst";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // Form4_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.label1);
            this.Name = "Form4_Delete";
            this.Text = "Dzēst personu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button deleteUserButton;
    }
}