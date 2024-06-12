using NAudio.Wave;
using PBL.Controller;
using PBL.Resources.Components.Test.TestQuestion;
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
using PBL.Views.Student.StudentDoTest;
using System.IO;

namespace PBL.Views.Student.StudentTest
{
    public partial class StudentDoTestView : Form, IStudentDoTestView
    {
        //Properties
        private List<(int Start, int End)> QuestionNumEachPart;
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        private bool isPlaying = false;
        private int currentPage = 0;
        private int _Minutes;
        private string fileName = "mvk.mp3";
        //List round button question num
        private List<List<RoundButton>> btns = new List<List<RoundButton>>();
        private int seconds = 0;

        #region Properties
        //List question box
        public List<List<TestQuestionBox>> TestQuestionBoxes { get; set; }
        //List of part for practice
        public List<int> Parts { get; set; }
        public int Minutes { get => _Minutes; set => _Minutes = value; }
        public byte[] Audio { get; set; }
        public int TestTime { get; set; }
        #endregion

        //Constructor
        public StudentDoTestView()
        {
            InitializeComponent();
            QuestionNumEachPart = new List<(int, int)>
            {
                (1, 6), (7, 31), (32, 70), (71 , 100), (101 , 130), (131 , 146), (147 , 200)
            };
            TestQuestionBoxes = new List<List<TestQuestionBox>>();
            Parts = new List<int>();
            WindowState = FormWindowState.Maximized;
            btnFinish.Click += delegate
            {
                if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing) { outputDevice.Stop(); }
                SubmitTestEvent?.Invoke(this, EventArgs.Empty);
                this.Dispose();
            };
        }

        //Event
        public event EventHandler SubmitTestEvent;
        public void InitPanelQuestionNum()
        {
            for (int i = 0; i < QuestionNumEachPart.Count; i++)
            {
                var list = new List<RoundButton>();
                if (!Parts.Contains(i + 1))
                {
                    continue;
                }
                panelQuestionNum.Controls.Add(new Label
                {
                    Text = $"Part {i + 1}",
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                    Width = panelQuestionNum.Width - 5
                });
                for (int j = QuestionNumEachPart[i].Start; j <= QuestionNumEachPart[i].End; j++)
                {
                    var btn = new RoundButton 
                    {
                        BorderColor = Color.Black,
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Width = Height = 35,
                        Text = j.ToString(),
                        BorderRadius = 15
                    };
                    btn.Click += click_link;
                    list.Add(btn);
                }
                panelQuestionNum.Controls.AddRange(list.ToArray());
                btns.Add(list);
            }
        }

        private void TestBox_CheckedChanged(object sender, EventArgs e)
        {
            var btn = btns[currentPage].Where(p => p.Text == ((TestQuestionBox)sender).QuestionNum.ToString()).First();
            btn.BackColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;
        }
        
        public void click_link(object sender, EventArgs e)
        {
            currentPage = btns.IndexOf(btns.Where(p => p.Contains((RoundButton)sender)).First());
            AddQuestionToPanel();
            var ques = this.panelMain.Controls.OfType<TestQuestionBox>()
                            .FirstOrDefault(p => p.QuestionNum == Convert.ToInt32(((Button)sender).Text));
            panelMain.ScrollControlIntoView(ques);
        }

        public void AddQuestionToPanel()
        {
            panelMain.Controls.Clear();
            foreach (var test in TestQuestionBoxes[currentPage])
            {
                if (test.QuestionImage != null)
                {
                    var panel = new Panel
                    {
                        Size = new Size(1000, 600),
                        AutoScroll = true,
                        AutoSize = false,
                    };
                    var pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.AutoSize
                    };
                    using (var ms = new MemoryStream(test.QuestionImage))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    panel.Controls.Add(pictureBox);
                    panelMain.Controls.Add(panel);
                }
                panelMain.Controls.Add(test);
            }
            panelMain.Controls.Add(panelBtn);
            if (currentPage == 0) { btnPrevious.Visible = false; } else { btnPrevious.Visible = true; }
            if (currentPage == Parts.Count - 1) { btnNext.Visible = false; } else { btnNext.Visible = true; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && isPlaying)
            {
                if (audioFile.CurrentTime.TotalSeconds > 0)
                {
                    double progress = (audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds) * 100;
                    colorSlider1.Value = (int)progress;
                    TimeSpan remainingTime = audioFile.TotalTime - audioFile.CurrentTime;
                    lbAudio.Text = remainingTime.ToString(@"mm\:ss"); // Display remaining time
                }
                else
                {
                    StopPlayback();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Minutes > 0 || seconds > 0)
            {
                seconds--;
                if (seconds < 0)
                {
                    seconds = 59;
                    Minutes--;
                }
                TestTime++;
                lbTime.Text = Minutes + ":" + seconds + "";
            }
            else
            {
                btnFinish.PerformClick();
            }
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            if (audioFile != null && isPlaying)
            {
                double progress = (double)colorSlider1.Value / 100;
                double targetTime = progress * audioFile.TotalTime.TotalSeconds;
                audioFile.CurrentTime = TimeSpan.FromSeconds(targetTime);
            }
        }

        private void StopPlayback()
        {
            timer1.Stop();
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            isPlaying = false;
            btnPlay.Text = "Play";
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                try
                {
                    File.WriteAllBytes(fileName, Audio);
                    audioFile = new AudioFileReader(fileName);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    File.Delete(fileName);
                    outputDevice.Play();
                    isPlaying = true;
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                    timer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing file: " + ex.Message);
                }
            }
            else
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Pause();
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                }
                else
                {
                    outputDevice.Play();
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                }
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;
            AddQuestionToPanel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            AddQuestionToPanel();
        }

        private void StudentDoTestView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing) { outputDevice.Stop(); }
        }

        private void StudentDoTestView_Load(object sender, EventArgs e)
        {
            InitPanelQuestionNum();
            AddQuestionToPanel();
            if (Audio == null)
            {
                colorSlider1.Visible = false;
                btnPlay.Visible = false;
                lbAudio.Visible = false;
            }
            foreach(var part in TestQuestionBoxes) foreach(var testBox in  part)
                {
                    testBox.CheckedChanged += TestBox_CheckedChanged;
                }
            if(Minutes != 0) timer2.Start();
            else
            {
                lbTime.Visible = lbTimeRemain.Visible = false;
            }
        }
        #region Singleton pattern 
        private static StudentDoTestView instance;

        public static StudentDoTestView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentDoTestView();
            }
            return instance;
        }
        #endregion
    }
}
