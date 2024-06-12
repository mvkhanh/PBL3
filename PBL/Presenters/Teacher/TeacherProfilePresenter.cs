using PBL.Models;
using PBL.Models.Lesson;
using PBL.Models.Test;
using PBL.Views.Teacher.TeacherLessonView;
using PBL.Views.Teacher.TeacherProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PBL.Presenters.Teacher
{
    public class TeacherProfilePresenter
    {

        //Fields
        private ITeacherProfileView view;
        private ITeacherRepository teacherRepository;
        private ILessonRepository lessonRepository;
        private ITestRepository testRepository;
        private int TeacherId;
        private TeacherModel TeacherModel;
        private static bool check = false;
        public TeacherProfilePresenter(ITeacherProfileView view, ITeacherRepository teacherRepository, ILessonRepository lessonRepository, ITestRepository testRepository, int id)
        {
            this.view = view;
            this.testRepository = testRepository;
            this.lessonRepository = lessonRepository;
            this.teacherRepository = teacherRepository;
            this.TeacherId = id;
            //Subscribe event handler methods to view events
            this.view.EditEvent += EditTeacher;
            this.view.ChangePassEvent += ChangeTeacherPass;
            this.view.CancelEvent += CancelAction;
            //Load Teacher infor
            LoadTeacherInfo();
        }
        private void LoadTeacherInfo()
        {
            TeacherModel = teacherRepository.GetByValue(TeacherId.ToString()).First();
            view.TeacherName = TeacherModel.Name;
            view.TeacherPhone = TeacherModel.Phone;
            view.TeacherBirth = TeacherModel.Birth;
            view.TeacherEmail = TeacherModel.Email;
            view.TotalLesson = lessonRepository.GetAll().ToList().Where(x => x.Id_Teacher == TeacherId).Count();
            view.TotalTest = testRepository.GetAll().ToList().Where(x => x.Id_Teacher == TeacherId).Count();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.TeacherBirth = TeacherModel.Birth;
            view.TeacherPhone = TeacherModel.Phone;
            view.TeacherName = TeacherModel.Name;
            view.TeacherEmail = TeacherModel.Email;
            view.TeacherCurrentPassword = view.TeacherNewPassword = "";
            view.TotalLesson = lessonRepository.GetAll().ToList().Where(x => x.Id_Teacher == TeacherId).Count();
            view.TotalTest = testRepository.GetAll().ToList().Where(x => x.Id_Teacher == TeacherId).Count();
        }

        private void ChangeTeacherPass(object sender, EventArgs e)
        {
            MessageBox.Show(view.TeacherCurrentPassword+" "+ TeacherModel.Password);
            if (view.TeacherCurrentPassword != TeacherModel.Password)
            {
                view.Message = "Wrong password";
                view.IsSuccessful = false;
                return;
            }
            string oldPassword = TeacherModel.Password;
            TeacherModel.Password = view.TeacherNewPassword;
            try
            {
                new Common.ModelDataValidation().Validate(TeacherModel);
                teacherRepository.Edit(TeacherModel);
                view.IsSuccessful = true;
                view.Message = "Change password successfully";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                TeacherModel.Password = oldPassword;
            }
        }

        private void EditTeacher(object sender, EventArgs e)
        {
            string oldPhone = TeacherModel.Phone;
            string oldEmail = TeacherModel.Email;
            string oldName = TeacherModel.Name;
            DateTime oldBirth = TeacherModel.Birth;
            TeacherModel.Phone = view.TeacherPhone;
            TeacherModel.Email = view.TeacherEmail;
            TeacherModel.Birth = view.TeacherBirth;
            TeacherModel.Name = view.TeacherName;
            try
            {
                new Common.ModelDataValidation().Validate(TeacherModel);
                teacherRepository.Edit(TeacherModel);
                view.IsSuccessful = true;
                view.Message = "Edit profile successfully";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                TeacherModel.Phone = oldPhone;
                TeacherModel.Email = oldEmail;
                TeacherModel.Birth = oldBirth;
                TeacherModel.Name = oldName;
            }
        }
    }
}
