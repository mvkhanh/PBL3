using PBL.Resources.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class TestView : Form
    {
        public List<AddQuestion> li;
        public List<AddQuestion2> li2;
        public TestView()
        {
            InitializeComponent();
            li = new List<AddQuestion>();
            li2 = new List<AddQuestion2>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            
            AddQuestion addQuestion = new AddQuestion();
            addQuestion.Dock = DockStyle.Fill;
            panel.Controls.Add(addQuestion);
            panel.Size = new Size(887, 376);
            li.Add(addQuestion);
            flowLayoutPanel1.Controls.Add(panel);
            flowLayoutPanel1.Controls.Add(panel1);

        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            string y = "";  // Initialize y as an empty string
            li.ForEach(x => y +=   x.AnswerA + " ");  // Concatenate each AnswerA with a space
            MessageBox.Show(y);  // Display the concatenated string in a message box

        }
        private void Add2(int i, ref int count)
        {
            for (int j = 1; j <= i; j++)
            {
                AddQuestion2 addQuestion2 = new AddQuestion2();
                addQuestion2.ID = "câu " + count;
                Panel panel = new Panel();
                addQuestion2.Dock = DockStyle.Fill;
                panel.Controls.Add(addQuestion2);
                panel.Size = new Size(887, 376);
                li2.Add(addQuestion2);
                tabControl1.SelectedIndex = 2;
                flowLayoutPanel1.Controls.Add(panel);
                flowLayoutPanel1.Controls.Add(panel1);
                count++;
            }
        }
        private void Add(int i, ref int count)
        {
            for (int j = 1; j <= i; j++)
            {
                AddQuestion addQuestion = new AddQuestion();
                addQuestion.ID = "câu " + count;
                Panel panel = new Panel();
                addQuestion.Dock = DockStyle.Fill;
                panel.Controls.Add(addQuestion);
                panel.Size = new Size(887, 376);
                li.Add(addQuestion);
                tabControl1.SelectedIndex = 2;
                flowLayoutPanel1.Controls.Add(panel);
                flowLayoutPanel1.Controls.Add(panel1);
                count++;
            }
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            int count = 1;
            for (int i = 1; i <= checkedListBox1.CheckedItems.Count; i++)
            {
                
                if (checkedListBox1.CheckedItems[i-1].ToString() == "Part 1")
                {
                    MessageBox.Show(checkedListBox1.SelectedItems[0].ToString());
                    Add2(6, ref count);
                }
                else
                {
                   
                    if(checkedListBox1.CheckedItems[i-1].ToString() == "Part 2")
                    {
                        Add(25, ref count);
                    }
                    if (checkedListBox1.CheckedItems[i-1].ToString() == "Part 3")
                    {
                        Add(39, ref count);
                    }
                    if (checkedListBox1.CheckedItems[i-1].ToString() == "Part 4")
                    {
                        Add(30, ref count);
                    }
                    if (checkedListBox1.CheckedItems[i-1].ToString() == "Part 5")
                    {
                        Add(30, ref count);
                    }
                    if (checkedListBox1.CheckedItems[i-1].ToString() == "Part 6")
                    {
                        Add(16, ref count);
                    }
                    if (checkedListBox1.CheckedItems[i-1].ToString() == "Part 7")
                    {
                        Add(54,ref count);
                    }
                }
            }
            tabControl1.SelectedIndex = 2;
        }
    }
}
