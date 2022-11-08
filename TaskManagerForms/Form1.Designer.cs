namespace TaskManagerForms
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
            this.drawtask = new System.Windows.Forms.Button();
            this.addtask = new System.Windows.Forms.Button();
            this.deltask = new System.Windows.Forms.Button();
            this.savenexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawtask
            // 
            this.drawtask.Location = new System.Drawing.Point(308, 35);
            this.drawtask.Name = "drawtask";
            this.drawtask.Size = new System.Drawing.Size(147, 69);
            this.drawtask.TabIndex = 0;
            this.drawtask.Text = "Show Tasks";
            this.drawtask.UseVisualStyleBackColor = true;
            this.drawtask.Click += new System.EventHandler(this.drawtask_Click);
            // 
            // addtask
            // 
            this.addtask.Location = new System.Drawing.Point(308, 110);
            this.addtask.Name = "addtask";
            this.addtask.Size = new System.Drawing.Size(147, 69);
            this.addtask.TabIndex = 1;
            this.addtask.Text = "Add Task";
            this.addtask.UseVisualStyleBackColor = true;
            this.addtask.Click += new System.EventHandler(this.addtask_Click);
            // 
            // deltask
            // 
            this.deltask.Location = new System.Drawing.Point(308, 185);
            this.deltask.Name = "deltask";
            this.deltask.Size = new System.Drawing.Size(147, 69);
            this.deltask.TabIndex = 2;
            this.deltask.Text = "Delete Task";
            this.deltask.UseVisualStyleBackColor = true;
            this.deltask.Click += new System.EventHandler(this.deltask_Click);
            // 
            // savenexit
            // 
            this.savenexit.Location = new System.Drawing.Point(308, 260);
            this.savenexit.Name = "savenexit";
            this.savenexit.Size = new System.Drawing.Size(147, 69);
            this.savenexit.TabIndex = 3;
            this.savenexit.Text = "Save\'n Exit";
            this.savenexit.UseVisualStyleBackColor = true;
            this.savenexit.Click += new System.EventHandler(this.savenexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savenexit);
            this.Controls.Add(this.deltask);
            this.Controls.Add(this.addtask);
            this.Controls.Add(this.drawtask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawtask;
        private System.Windows.Forms.Button addtask;
        private System.Windows.Forms.Button deltask;
        private System.Windows.Forms.Button savenexit;
    }
}

