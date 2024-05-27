using PBL.Views.Admin.Lessons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class LessonView : Form, ILessonView
    {
        //Fields
        private bool _IsEdit;
        private bool _IsSuccessful;
        private string _Message;

        public LessonView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageLessonDetail);
            tabControl1.TabPages.Remove(tabPageLessonContent);
            Teachers = new List<CBBItem>();
            cbbTeacherName.DataSource = Teachers;
            
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
                tabControl1.TabPages.Remove(tabPageLessonList);
                tabControl1.TabPages.Add(tabPageLessonDetail);
                tabPageLessonDetail.Text = "Add new Lesson";
            };
            btnEdit.Click += delegate
            {
                try
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageLessonList);
                    tabControl1.TabPages.Add(tabPageLessonDetail);
                    tabPageLessonDetail.Text = "Edit Lesson";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Lesson?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSave.Click += delegate
            {
                if (!IsEdit && string.IsNullOrEmpty(txtPdf.Texts)) MessageBox.Show("Chua chon file noi dung.");
                else
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        tabControl1.TabPages.Remove(tabPageLessonDetail);
                        tabControl1.TabPages.Add(tabPageLessonList);
                    }
                    MessageBox.Show(Message);
                }
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageLessonDetail);
                tabControl1.TabPages.Add(tabPageLessonList);
            };
            btnView.Click += delegate
            {
                ViewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageLessonList);
                tabControl1.TabPages.Add(tabPageLessonContent);
                DisplayContent();
            };
        }

        //Properties
        public int LessonId
            { get => Convert.ToInt32(txtId.Texts); set => txtId.Texts = value.ToString(); }
        public string LessonName 
            { get => txtName.Texts; set => txtName.Texts = value; }
        public DateTime LessonPublishDay 
            { get => regist.Value.Date; set => regist.Value = value.Date; }
        public string LessonContentPath 
            { get => txtPdf.Texts; set => txtPdf.Texts = value; }
        public byte[] LessonContent 
            { get; set; }
        public int LessonViews 
            { get => Convert.ToInt32(txtView.Texts); set => txtView.Texts = value.ToString(); }
        public int LessonId_Teacher
        {
            get => ((CBBItem)cbbTeacherName.SelectedItem).Value;
            set
            {
                foreach (var item in cbbTeacherName.Items) if(((CBBItem)item).Value == value)
                    {
                        cbbTeacherName.SelectedItem = item;
                    }
            }
        }
        public string SearchValue 
            { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit
            { get => _IsEdit; set => _IsEdit = value; }
        public bool IsSuccessful 
            { get => _IsSuccessful; set => _IsSuccessful = value; }
        public string Message 
            { get => _Message; set => _Message = value; }
        public List<CBBItem> Teachers
            { get; set; }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ViewEvent;

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Content" || e.Column.Name == "Id_Teacher") e.Column.Visible = false;
        }

        private void DisplayContent()
        {
            try
            {
                string fileName = "tmp.pdf";
                File.WriteAllBytes(fileName, LessonContent);
                pdfViewer1.LoadFromFile(fileName);
                File.Delete(fileName);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured when display content");
                btnBack.PerformClick();
            }
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageLessonContent);
            tabControl1.TabPages.Add(tabPageLessonList);
        }

        private void btnAddPdf_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files (*.pdf)|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPdf.Texts = ofd.FileName;
            }

        }
        //Methods
        public void SetLessonListBindingSource(BindingSource lessonList)
        {
            dataGridView1.DataSource = lessonList;
        }

        //Singleton
        private static LessonView instance;
        public static LessonView GetInstance()
        {
            if (instance == null || instance.IsDisposed) instance = new LessonView();
            return instance;
        }
    }
}
