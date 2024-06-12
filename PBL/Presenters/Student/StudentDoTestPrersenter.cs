using PBL._Repositories;
using PBL.Models.Question;
using PBL.Models.StudentTest;
using PBL.Models.Test;
using PBL.Resources.Components.Test.TestQuestion;
using PBL.Views.Student.StudentDoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PBL.Presenters.Student
{
    public class StudentDoTestPrersenter
    {
        private IStudentDoTestView view;
        private IQuestionRepository questionRepository;
        private ITestRepository testRepository;
        private StudentTestPresenter presenter;
        private int testId;
        private bool isFullTest = false;
        public StudentDoTestPrersenter(StudentTestPresenter studentTestPresenter, IStudentDoTestView view, ITestRepository testRepository, IQuestionRepository questionRepository, int testId , List<int> parts, int minutes)
        {
            this.view = view;
            this.presenter = studentTestPresenter;
            this.testRepository = testRepository;
            this.questionRepository = questionRepository;
            this.testId = testId;
            if (parts.Count == 0)
            {
                isFullTest = true;
                minutes = 120;
                for (int i = 1; i <= 7; i++) parts.Add(i);
            }
            this.view.Minutes = minutes;
            this.view.Parts = parts;
            
            this.view.SubmitTestEvent += SubmitAction;

            LoadTest();

            this.view.Show();
        }

        private void LoadTest()
        {
            if(this.view.Parts.Where(p => p <= 4).Any()) view.Audio = new TestRepository().GetByValue(testId.ToString()).First().Audio;
            var QuestionNumEachPart = new List<(int Start, int End)>
            {
                (1, 6), (7, 31), (32, 70), (71 , 100), (101 , 130), (131 , 146), (147 , 200)
            };
            var questionList = questionRepository.GetByTest(testId).ToList();
            for (int i = 0; i < view.Parts.Count; i++)
            {
                var part = view.Parts[i] - 1;
                var list = new List<TestQuestionBox>();
                for (int j = QuestionNumEachPart[part].Start; j <= QuestionNumEachPart[part].End; j++)
                {
                    TestQuestionBox testBox;
                    switch (part)
                    {
                        case 0: testBox = new Test1();
                            break;
                        case 1: testBox = new Test2();
                            break;
                        default:
                            testBox = new Test34567();
                            break;
                    }
                    testBox.QuestionNum = j;
                    testBox.QuestionContent = questionList[j - 1].Content;
                    testBox.QuestionAnswer = questionList[j - 1].RightAnswer;
                    testBox.QuestionImage = questionList[j - 1].Image;
                    var answerList = new AnswerRepository().GetByQuestion(questionList[j - 1].Id).ToList();
                    testBox.QuestionA = answerList[0].Content;
                    testBox.QuestionB = answerList[1].Content;
                    testBox.QuestionC = answerList[2].Content;
                    if(answerList.Count > 3)
                    {
                        testBox.QuestionD = answerList[3].Content;
                    }
                    list.Add(testBox);
                }
                view.TestQuestionBoxes.Add(list);
            }
        }

        private void SubmitAction(object sender, EventArgs e)
        {
            presenter.Submit(view.TestQuestionBoxes, view.TestTime, isFullTest, view.Parts);
        }
    }
}
