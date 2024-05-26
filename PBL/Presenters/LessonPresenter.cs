using PBL._Repositories;
using PBL.Models;
using PBL.Models.Lesson;
using PBL.Views.Admin.Lessons;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters
{
    public class LessonPresenter
    {
        //Fields
        private ILessonView view;
        private ILessonRepository repository;
        private BindingSource lessonsBindingSource;
        private IEnumerable<LessonModel> lessonList;

        //Constructor
        public LessonPresenter(ILessonView view, ILessonRepository repository)
        {
            this.lessonsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchLesson;
            this.view.AddNewEvent += AddNewLesson;
            this.view.EditEvent += LoadSelectedLessonToEdit;
            this.view.DeleteEvent += DeleteSelectedLesson;
            this.view.SaveEvent += SaveLesson;
            this.view.CancelEvent += CancelAction;
            this.view.ViewEvent += ViewLesson;
            //Set Lessons binding source
            this.view.SetLessonListBindingSource(lessonsBindingSource);
            //Load Lesson list view
            LoadAllLessonList();
            //Load Teachers to CBB
            LoadTeachersCBB();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadTeachersCBB()
        {
            var teacherList = new TeacherRepository().GetAll();
            foreach (var teacher in teacherList)
            {
                this.view.Teachers.Add(new CBBItem { Value = teacher.Id, Text = teacher.Name });
            }
        }

        private void LoadAllLessonList()
        {
            lessonList = this.repository.GetAll();
            lessonsBindingSource.DataSource = lessonList;
        }

        private void SearchLesson(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                lessonList = repository.GetAll();
            }
            else lessonList = repository.GetByValue(this.view.SearchValue);
            lessonsBindingSource.DataSource = lessonList;
        }

        private void AddNewLesson(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }
        private void LoadSelectedLessonToEdit(object sender, EventArgs e)
        {
            if (lessonsBindingSource.Current == null) throw new Exception("An error occured, could not edit Lesson");
            var lesson = (LessonModel)lessonsBindingSource.Current;
            view.LessonId = lesson.Id;
            view.LessonName = lesson.Name;
            view.LessonViews = lesson.Views;
            view.LessonPublishDay = lesson.PublishDay;
            view.LessonId_Teacher = lesson.Id_Teacher;
            view.IsEdit = true;
        }
        private void SaveLesson(object sender, EventArgs e)
        {
            var model = new LessonModel();
            model.Id = view.LessonId;
            model.Name = view.LessonName;
            model.PublishDay = view.LessonPublishDay;
            if (!string.IsNullOrEmpty(view.LessonContentPath)) model.Content = ConvertPathToContent(view.LessonContentPath);
            model.Views = view.LessonViews;
            model.Id_Teacher = view.LessonId_Teacher;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Lesson edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Lesson added successfully";
                }
                view.IsSuccessful = true;
                LoadAllLessonList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedLesson(object sender, EventArgs e)
        {
            try
            {
                var lesson = (LessonModel)lessonsBindingSource.Current;
                repository.Delete(lesson.Id);
                view.IsSuccessful = true;
                view.Message = "Lesson deleted successfully";
                LoadAllLessonList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete Lesson";
            }
        }
        private void ViewLesson(object sender, EventArgs e)
        {
            var lesson = (LessonModel)lessonsBindingSource.Current;
            view.LessonContent = lesson.Content;
        }
       
        private byte[] ConvertPathToContent(string lessonContentPath)
        {
            byte[] buffer;
            using(FileStream fileStream = new FileStream(lessonContentPath, FileMode.Open, FileAccess.Read))
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read
                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }
            return buffer;
        }

        private void CleanViewFields()
        {
            view.LessonId = 0;
            view.LessonName = "";
            view.LessonViews = 0;
            view.LessonContentPath = "";
            view.LessonPublishDay = DateTime.Today;
        }
        //public void chay1()
        //{
        //    using (SqlConnection conn = new SqlConnection("Data Source=WINDOWS-10\\NTTKING;Initial Catalog=Test;Integrated Security=True;Encrypt=False"))
        //    {
        //        conn.Open();

        //        // Retrieve all columns from the table1 table
        //        string sql = "SELECT KTXX FROM table1 where KC = 2";
        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                // Iterate through the results
        //                while (reader.Read())
        //                {
        //                    // Get the column index for the PDF data column
        //                    int pdfColumnIndex = reader.GetOrdinal("KTXX");

        //                    // Retrieve the PDF data and write it to a file
        //                    byte[] pdfData = (byte[])reader[pdfColumnIndex];

        //                    try
        //                    {
        //                        // Tạo thư mục "D:\createPDF" nếu chưa tồn tại
        //                        string folderPath = @"D:\createPDF";
        //                        if (!Directory.Exists(folderPath))
        //                        {
        //                            Directory.CreateDirectory(folderPath);
        //                        }

        //                        // Lưu file PDF vào thư mục "D:\createPDF"
        //                        string filePath = Path.Combine(folderPath, "KLXX1.pdf");
        //                        File.WriteAllBytes(filePath, pdfData);
        //                        Console.WriteLine($"PDF saved to: {filePath}");
        //                        Console.WriteLine("PDF saved successfully.");
        //                        pdfViewer1.LoadFromFile(filePath);
        //                        xoaFile();
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        Console.WriteLine($"Error saving PDF file: {ex.Message}");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //public void xoaFile()
        //{
        //    string filePath = Path.Combine(@"D:\createPDF", "KLXX.pdf");

        //    try
        //    {
        //        // Kiểm tra xem file có tồn tại không
        //        if (File.Exists(filePath))
        //        {
        //            // Xóa file
        //            File.Delete(filePath);
        //            Console.WriteLine("File đã được xóa thành công.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("File không tồn tại.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Lỗi khi xóa file: {ex.Message}");
        //    }
        //}
    }
}
