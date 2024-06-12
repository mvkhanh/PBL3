using PBL.Models;
using PBL.Models.StudentTest;
using PBL.Views.Student.StudentProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters.Student
{
    public class StudentProfilePresenter
    {
        //Fields
        private IStudentProfileView view;
        private IStudentRepository repository;
        private IStudentTestRepository studentTestRepository;
        private int studentId;
        private StudentModel studentModel;

        public StudentProfilePresenter(IStudentProfileView view, IStudentRepository repository, IStudentTestRepository studentTestRepository, int studentId)
        {
            this.view = view;
            this.repository = repository;
            this.studentTestRepository = studentTestRepository;
            this.studentId = studentId;
            //Subscribe event handler methods to view events
            this.view.EditEvent += EditStudent;
            this.view.ChangePassEvent += ChangeStudentPass;
            this.view.CancelEvent += CancelAction;
            //Load student infor
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            studentModel = repository.GetByValue(studentId.ToString()).First();
            view.StudentName = studentModel.Name;
            view.StudentPhone = studentModel.Phone;
            view.StudentBirth = studentModel.Birth;
            view.StudentEmail = studentModel.Email;
            view.StudentTests = studentTestRepository.GetByStudent(studentId).Count();
            view.StudentAverageScores = Convert.ToInt32(studentTestRepository.GetByStudent(studentId).Select(p => p.Scores).Average());
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.StudentBirth = studentModel.Birth;
            view.StudentPhone = studentModel.Phone;
            view.StudentName = studentModel.Name;
            view.StudentEmail = studentModel.Email;
            view.StudentCurrentPassword = view.StudentNewPassword = "";
        }

        private void ChangeStudentPass(object sender, EventArgs e)
        {
            if(view.StudentCurrentPassword != studentModel.Password)
            {
                view.Message = "Wrong password";
                view.IsSuccessful = false;
                return;
            }
            string oldPassword = studentModel.Password;
            studentModel.Password = view.StudentNewPassword;
            try
            {
                new Common.ModelDataValidation().Validate(studentModel);
                repository.Edit(studentModel);
                view.IsSuccessful = true;
                view.Message = "Change password successfully";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                studentModel.Password = oldPassword;
            }
        }

        private void EditStudent(object sender, EventArgs e)
        {
            string oldPhone = studentModel.Phone;
            string oldEmail = studentModel.Email;
            string oldName = studentModel.Name;
            DateTime oldBirth = studentModel.Birth;
            studentModel.Phone = view.StudentPhone;
            studentModel.Email = view.StudentEmail;
            studentModel.Birth = view.StudentBirth;
            studentModel.Name = view.StudentName;
            try
            {
                new Common.ModelDataValidation().Validate(studentModel);
                repository.Edit(studentModel);
                view.IsSuccessful = true;
                view.Message = "Edit profile successfully";
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                studentModel.Phone = oldPhone;
                studentModel.Email = oldEmail;
                studentModel.Birth = oldBirth;
                studentModel.Name = oldName;
            }
        }
    }
}
