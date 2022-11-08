using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskManagerForms
{

    public partial class Form1 : Form
    {
        string filePath = Application.StartupPath + @"\tasks.txt";
        public Form1()
        {
            InitializeComponent();
            tasksbox.Items.Clear();
            string[] content = File.ReadAllLines(filePath);
            foreach (string inside in content)
            {
                tasksbox.Items.Add(inside);
            }
        }

        private void addtask_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                if (tasksbox.Items.Contains(textBox1.Text))
                {
                    DialogResult result = MessageBox.Show("Exactly same tasks already exist. Are you sure you want to add it again?", "Action needed.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        tasksbox.Items.Add(textBox1.Text);
                        string content = textBox1.Text + Environment.NewLine;
                        File.AppendAllText(filePath, content);
                        textBox1.Clear();
                    }
                    else
                    {
                        textBox1.Clear();
                        return;
                    }
                }
                else
                {
                    tasksbox.Items.Add(textBox1.Text);
                    string content = textBox1.Text + Environment.NewLine;
                    File.AppendAllText(filePath, content);
                    textBox1.Clear();
                }
            }
        }

        private void deltask_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedTask = new ListBox.SelectedObjectCollection(tasksbox);
            selectedTask = tasksbox.SelectedItems;

            string[] inventoryData = File.ReadAllLines(filePath);
            List<string> inventoryDataList = inventoryData.ToList();

            if (inventoryDataList.Remove(tasksbox.Text))
            {
                File.WriteAllLines(filePath, inventoryDataList.ToArray());
            }

            if (tasksbox.SelectedIndex != -1)
            {
                for (int i = selectedTask.Count - 1; i >= 0; i--)
                {
                    tasksbox.Items.Remove(selectedTask[i]);
                }
            }
        }
    }
}
