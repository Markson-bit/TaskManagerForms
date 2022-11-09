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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addtask = new System.Windows.Forms.Button();
            this.deltask = new System.Windows.Forms.Button();
            this.tasksbox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addtask
            // 
            this.addtask.Location = new System.Drawing.Point(403, 271);
            this.addtask.Name = "addtask";
            this.addtask.Size = new System.Drawing.Size(147, 69);
            this.addtask.TabIndex = 1;
            this.addtask.Text = "Add Task";
            this.addtask.UseVisualStyleBackColor = true;
            this.addtask.Click += new System.EventHandler(this.addtask_Click);
            // 
            // deltask
            // 
            this.deltask.Location = new System.Drawing.Point(625, 271);
            this.deltask.Name = "deltask";
            this.deltask.Size = new System.Drawing.Size(147, 69);
            this.deltask.TabIndex = 2;
            this.deltask.Text = "Delete Task";
            this.deltask.UseVisualStyleBackColor = true;
            this.deltask.Click += new System.EventHandler(this.deltask_Click);
            // 
            // tasksbox
            // 
            this.tasksbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasksbox.FormattingEnabled = true;
            this.tasksbox.ItemHeight = 26;
            this.tasksbox.Location = new System.Drawing.Point(12, 12);
            this.tasksbox.Name = "tasksbox";
            this.tasksbox.Size = new System.Drawing.Size(365, 420);
            this.tasksbox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(403, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input task here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tasksbox);
            this.Controls.Add(this.deltask);
            this.Controls.Add(this.addtask);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "TaskManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addtask;
        private System.Windows.Forms.Button deltask;
        private System.Windows.Forms.ListBox tasksbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

