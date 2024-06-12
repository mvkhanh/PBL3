using NAudio.CoreAudioApi;
using NAudio.Wave;
using PBL.Controller;
using PBL.Resources.Components.Question;
using PBL.Resources.Components;
using PBL.Views.Teacher.TeacherMain;
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

namespace PBL.Views.Teacher.TeacherTestView
{
    public partial class TeacherTestView : Form,ITeacherTestView
    {
        //Fields
        private bool _IsEdit;
        private bool _IsSuccessful;
        private string _Message;
        private int[] QuestionNumEachPart = { 6, 25, 39, 30, 30, 16, 54 };
        private int currentPage = 0;
        private RoundButton currentButton;

        //Constructor
        public TeacherTestView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Remove(tabPageQuestionList);
            InitQuestionTab();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTestList);
                tabControl1.TabPages.Add(tabPageTestDetail);
                tabPageTestDetail.Text = "Add new Test";
            };
            btnEdit.Click += delegate
            {
                try
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageTestList);
                    tabControl1.TabPages.Add(tabPageTestDetail);
                    tabPageTestDetail.Text = "Edit Test";
                    if (TestAudio != null) btnPlay.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Test?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ClearAudio();
                    tabControl1.TabPages.Remove(tabPageTestDetail);
                    tabControl1.TabPages.Add(tabPageTestList);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate
            {
                ClearAudio();
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTestDetail);
                tabControl1.TabPages.Add(tabPageTestList);
            };
        }
        private void InitQuestionTab()
        {
            Questions = new List<List<QuestionBox>>();
            InitQuestionList();
            AddQuestionToPanel();
            SetCurrentButton(btnPart1);
        }

        private void InitQuestionList()
        {
            int partNum = 7, j = 0;
            for (int i = 0; i < partNum; i++)
            {
                var list = new List<QuestionBox>();
                int maxNum = j + QuestionNumEachPart[i];
                switch (i)
                {
                    case 0:
                        while (++j <= maxNum) list.Add(new Part1() { QuestionNum = j });
                        break;
                    case 1:
                        while (++j <= maxNum) list.Add(new Part2() { QuestionNum = j });
                        break;
                    case 4:
                        while (++j <= maxNum) list.Add(new Part5() { QuestionNum = j });
                        break;
                    default:
                        while (++j <= maxNum) list.Add(new Part3467() { QuestionNum = j });
                        break;
                }
                j--;
                Questions.Add(list);
            }
        }
        private void AddQuestionToPanel()
        {
            lbPart.Text = "Part " + (currentPage + 1);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(lbPart);
            panelMain.Controls.AddRange(Questions[currentPage].ToArray());
            panelMain.Controls.Add(panelBtn);
            btnBack.Visible = btnNext.Visible = btnPrevious.Visible = btnFinish.Visible = true;
            if (currentPage == 6) btnNext.Visible = false;
            else
            {
                if (currentPage == 0) btnPrevious.Visible = false;
            }
        }

        #region Properties
        public int TestId
        { get => Convert.ToInt32(txtId.Texts); set => txtId.Texts = value.ToString(); }
        public string TestName
        { get => txtName.Texts; set => txtName.Texts = value; }
        public DateTime TestPublishDay
        { get => regist.Value.Date; set => regist.Value = value.Date; }
        public string TestDescription
        { get => txtDescription.Texts; set => txtDescription.Texts = value; }
        public int TestCount
        { get => Convert.ToInt32(txtPaticipant.Texts); set => txtPaticipant.Texts = value.ToString(); }
        public string TeacherName { get => lbTeacherName.Text= txtTeacherName.Text ; set => txtTeacherName.Texts = lbTeacherName.Text = value; }
        public int TeacherID { get; set; }
        public string TestAudioPath { get; set; }
        public byte[] TestAudio { get; set; }

        public string SearchValue
        { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit
        { get => _IsEdit; set => _IsEdit = value; }
        public bool IsSuccessful
        { get => _IsSuccessful; set => _IsSuccessful = value; }
        public string Message
        { get => _Message; set => _Message = value; }
        public List<List<QuestionBox>> Questions { get; set; }
        #endregion

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetTestListBindingSource(BindingSource TestList)
        {
            dataGridView1.DataSource = TestList;
        }

        #region Singleton
        private static TeacherTestView instance;
        public static TeacherTestView GetInstance()
        {
            if (instance == null || instance.IsDisposed) instance = new TeacherTestView();
            return instance;
        }
        #endregion

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Id_Teacher" || e.Column.Name == "Description" || e.Column.Name == "Questions" || e.Column.Name == "Audio") e.Column.Visible = false;
        }
        #region Question list events ...
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Add(tabPageQuestionList);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageQuestionList);
            tabControl1.TabPages.Add(tabPageTestDetail);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //Check for empty data
            tabControl1.TabPages.Remove(tabPageQuestionList);
            tabControl1.TabPages.Add(tabPageTestDetail);
            btnPart1.PerformClick();
        }
        private void btnPart_Click(object sender, EventArgs e)
        {
            RoundButton btn = (RoundButton)sender;
            SetCurrentButton(btn);
            currentPage = btn.Text[btn.Text.Length - 1] - '0' - 1;
            AddQuestionToPanel();
        }
        private void SetCurrentButton(RoundButton btnPart)
        {
            if (currentButton != null)
            {
                SetNotChooseButton(currentButton);
            }
            currentButton = btnPart;
            SetChooseButton(currentButton);
        }

        private void SetChooseButton(RoundButton btn)
        {
            btn.BorderSize = 0;
            btn.BackgroundColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;
        }

        private void SetNotChooseButton(RoundButton btn)
        {
            btn.BorderSize = 2;
            btn.BackgroundColor = Color.White;
            btn.ForeColor = Color.MediumSlateBlue;
        }
        #endregion

        #region Audio
        private void btnAddAudio_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files (*.mp3)|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing) { outputDevice.Stop(); }
                TestAudioPath = ofd.FileName;
                btnPlay.Visible = true;
                ChangeBtnPlay(true);
                InitAudio(TestAudioPath);
            }
        }

        private bool isPlaying = false;
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        private string fileName;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                try
                {
                    if (string.IsNullOrEmpty(TestAudioPath))
                    {
                        fileName = "sdcdad.mp3";
                        File.WriteAllBytes(fileName, TestAudio);
                        InitAudio(fileName);
                    }
                    outputDevice.Play();
                    ChangeBtnPlay(false);
                    isPlaying = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error when play audio file");
                }
            }
            else
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Pause();
                    ChangeBtnPlay(true);
                }
                else
                {
                    outputDevice.Play();
                    ChangeBtnPlay(false);
                }
            }
        }
        private void InitAudio(string fileName)
        {
            audioFile = new AudioFileReader(fileName);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            isPlaying = false;
        }

        private void ClearAudio()
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing) outputDevice.Stop();
            if (File.Exists(fileName)) File.Delete(fileName);
            isPlaying = false;
            btnPlay.Visible = false;
            ChangeBtnPlay(true);
        }

        private void ChangeBtnPlay(bool state)
        {
            if (state)
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                btnPlay.Text = "Play";
            }
            else
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btnPlay.Text = "Pause";
            }
        }
        #endregion
    }
}
