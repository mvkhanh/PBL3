using PBL.Resources.Components;
using PBL.Views;
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
    
    public partial class StudentTestView : Form
    {
        public Point DisplayPartResult(string namePart, int start, int end, Point cur)
        {
            AddPartLabel part1 = new AddPartLabel();
            
            part1.nameP = namePart;
            part1.Location = new Point(cur.X, cur.Y + 40);
            
            int k = 0, j = 200;
            if(start % 2 != 0)
            {
                for (int i = start; i <= end; i++)
                {
                    AddQuestionResult q = new AddQuestionResult();
                    q.numQues = i.ToString();
                    if (i % 2 != 0)
                    {
                        k += 30;
                        q.Location = new Point(part1.Location.X, part1.Location.Y + k);
                        
                            if (i == end - 1 || i == end) cur = q.Location;
                        

                    }
                    else
                    {
                        q.Location = new Point(part1.Location.X + j, part1.Location.Y + k);
                        
                    }
                    this.tabPageTestResult1.Controls.Add(q);
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    AddQuestionResult q = new AddQuestionResult();
                    q.numQues = i.ToString();
                    if (i % 2 == 0)
                    {
                        k += 30;
                        q.Location = new Point(part1.Location.X, part1.Location.Y + k);
                        if (i == end - 1 || i == end) cur = q.Location;

                    }
                    else
                    {
                        q.Location = new Point(part1.Location.X + j, part1.Location.Y + k);

                    }
                    this.tabPageTestResult1.Controls.Add(q);
                }
            }
            

            this.tabPageTestResult1.Controls.Add(part1);
            return cur;
        }
        public StudentTestView()
        {
            InitializeComponent();
            this.tabPageTestDetail.AutoScroll = true;
            this.tabPageTestResult1.AutoScroll = true;
            int time = 5;
            while(time<141)
            {
                cbbTime.Items.Add(time.ToString());
                time += 5;

            }
            //Add CommentBox
            CommentsBox comment = new CommentsBox();
            comment.Location = new Point(80, 410);
            comment.AutoScroll = true;
            comment.AutoSize = false;
            this.tabPageTestDetail.Controls.Add(comment);
            //AddPartsResult
            Point currentPoint = new Point(80,190);
            currentPoint = DisplayPartResult("Part 1", 1, 6, currentPoint);
            currentPoint = DisplayPartResult("Part 2", 7, 31, currentPoint);
            currentPoint = DisplayPartResult("Part 3", 32, 70, currentPoint);
            currentPoint = DisplayPartResult("Part 4", 71, 100, currentPoint);
            currentPoint = DisplayPartResult("Part 5", 101, 130, currentPoint);
            currentPoint = DisplayPartResult("Part 6", 131, 146, currentPoint);
            currentPoint = DisplayPartResult("Part 7", 147, 200, currentPoint);
        }

        private void Pratice_Click(object sender, EventArgs e)
        {
            

        }

        //Singleton pattern 
        private static StudentTestView instance;
        public static StudentTestView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentTestView();
            }
            return instance;
        }
    }
}
