using PBL._Repositories;
using PBL.Models.Answer;
using PBL.Models.Question;
using PBL.Models.Test;
using PBL.Models;
using PBL.Views.Admin.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Views.Teacher.TeacherTestView;
using System.IO;

namespace PBL.Presenters.Teacher
{
    public class TeacherTestPresenter
    {
        //Fields
        private ITeacherTestView view;
        private ITestRepository testRepository;
        private IQuestionRepository questionRepository;
        private IAnswerRepository answerRepository;
        private BindingSource testsBindingSource;
        private IEnumerable<TestModel> testList;
        //Constructor
        public TeacherTestPresenter(ITeacherTestView view, ITestRepository testRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository,int id)
        {
            this.testsBindingSource = new BindingSource();
            this.view = view;
            this.testRepository = testRepository;
            this.questionRepository = questionRepository;
            this.answerRepository = answerRepository;
            //Load Teachers to CBB
            view.TeacherID = id;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchTest;
            this.view.AddNewEvent += AddNewTest;
            this.view.EditEvent += LoadSelectedTestToEdit;
            this.view.DeleteEvent += DeleteSelectedTest;
            this.view.SaveEvent += SaveTest;
            this.view.CancelEvent += CancelAction;
            //Set Tests binding source
            this.view.SetTestListBindingSource(testsBindingSource);
            //Load Test list view
            LoadAllTestList();
        }

        //Methods

        private void LoadAllTestList()
        {
            testList = this.testRepository.GetAll().Where(x => x.Id_Teacher == view.TeacherID).ToList();
            testsBindingSource.DataSource = testList;
        }

        private void SearchTest(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                testList = this.testRepository.GetAll().Where(x => x.Id_Teacher == view.TeacherID).ToList();
            }
            else testList = testRepository.GetByValue(this.view.SearchValue).Where(x => x.Id_Teacher == view.TeacherID).ToList();
            testsBindingSource.DataSource = testList;
        }

        private void AddNewTest(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }
        private void LoadSelectedTestToEdit(object sender, EventArgs e)
        {
            if (testsBindingSource.Current == null) throw new Exception("An error occured, could not edit Test");
            var test = (TestModel)testsBindingSource.Current;
            view.TestId = test.Id;
            view.TestName = test.Name;
            view.TestCount = test.Count;
            view.TestPublishDay = test.PublishDay;
            view.TeacherID = test.Id_Teacher;
            view.TestDescription = test.Description;
            view.TestAudio = test.Audio;
            view.IsEdit = true;
            var questionList = questionRepository.GetByTest(test.Id).ToList();
            int j = 0;
            for (int i = 0; i < 7; i++)
            {
                int num;
                switch (i)
                {
                    case 0: num = 6; break;
                    case 1: num = 25; break;
                    case 2: num = 39; break;
                    case 3: case 4: num = 30; break;
                    case 5: num = 16; break;
                    default: num = 54; break;
                }
                for (int k = 0; k < num; k++)
                {
                    view.Questions[i][k].QuestionId = questionList[j].Id;
                    view.Questions[i][k].QuestionContent = questionList[j].Content;
                    view.Questions[i][k].QuestionAnswer = questionList[j].RightAnswer;
                    view.Questions[i][k].QuestionImage = questionList[j].Image;
                    var answerList = answerRepository.GetByQuestion(questionList[j].Id).ToList();
                    view.Questions[i][k].AnswerAId = answerList[0].Id;
                    view.Questions[i][k].AnswerAContent = answerList[0].Content;
                    view.Questions[i][k].AnswerBId = answerList[1].Id;
                    view.Questions[i][k].AnswerBContent = answerList[1].Content;
                    view.Questions[i][k].AnswerCId = answerList[2].Id;
                    view.Questions[i][k].AnswerCContent = answerList[2].Content;
                    if (answerList.Count == 4)
                    {
                        view.Questions[i][k].AnswerDId = answerList[3].Id;
                        view.Questions[i][k].AnswerDContent = answerList[3].Content;
                    }
                    ++j;
                }
            }
        }
        private void SaveTest(object sender, EventArgs e)
        {
            var model = new TestModel();
            model.Id = view.TestId;
            model.Name = view.TestName;
            model.PublishDay = view.TestPublishDay;
            model.Description = view.TestDescription;
            if (!string.IsNullOrEmpty(view.TestAudioPath)) model.Audio = File.ReadAllBytes(view.TestAudioPath);
            model.Count = view.TestCount;
            model.Id_Teacher = view.TeacherID;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    testRepository.Edit(model);
                    AddOrEditQuestions();
                    view.Message = "Test edited successfully";
                }
                else
                {
                    testRepository.Add(model);
                    view.TestId = testRepository.GetLast();
                    AddOrEditQuestions();
                    view.Message = "Test added successfully";
                }
                view.IsSuccessful = true;
                LoadAllTestList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void AddOrEditQuestions()
        {
            for (int i = 0; i < view.Questions.Count; i++)
            {
                foreach (var question in view.Questions[i])
                {
                    var questionModel = new QuestionModel();
                    questionModel.Id = question.QuestionId;
                    questionModel.Id_Test = view.TestId;
                    questionModel.Content = question.QuestionContent;
                    if (!string.IsNullOrEmpty(question.ImagePath)) questionModel.Image = File.ReadAllBytes(question.ImagePath);
                    questionModel.RightAnswer = question.QuestionAnswer;
                    if (view.IsEdit)
                    {
                        questionRepository.Edit(questionModel);
                    }
                    else
                    {
                        questionRepository.Add(questionModel);
                        questionModel.Id = questionRepository.GetLast();
                    }
                    var answerList = new List<AnswerModel>();
                    answerList.AddRange(new AnswerModel[]
                    {
                        new AnswerModel{ Id = question.AnswerAId, Content = question.AnswerAContent, Id_Question = questionModel.Id },
                        new AnswerModel{ Id = question.AnswerBId, Content = question.AnswerBContent, Id_Question = questionModel.Id },
                        new AnswerModel{ Id = question.AnswerCId, Content = question.AnswerCContent, Id_Question = questionModel.Id }
                    });
                    if (i != 1) answerList.Add(new AnswerModel { Id = question.AnswerDId, Content = question.AnswerDContent, Id_Question = questionModel.Id });
                    if (view.IsEdit)
                    {
                        foreach (var answer in answerList) { answerRepository.Edit(answer); }
                    }
                    else
                    {
                        foreach (var answer in answerList) { answerRepository.Add(answer); }
                    }
                }
            }
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedTest(object sender, EventArgs e)
        {
            try
            {
                var Test = (TestModel)testsBindingSource.Current;
                testRepository.Delete(Test.Id);
                view.IsSuccessful = true;
                view.Message = "Test deleted successfully";
                LoadAllTestList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete Test";
            }
        }

        private void CleanViewFields()
        {
            view.TestId = 0;
            view.TestName = "";
            view.TestCount = 0;
            view.TestDescription = "";
            view.TestPublishDay = DateTime.Today;
            view.TestAudioPath = "";
            view.TestAudio = null;
            foreach (var part in view.Questions) foreach (var question in part)
                {
                    question.ClearFields();
                }
        }
    }
}
