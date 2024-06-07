using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Question
{
    public interface IQuestionRepository
    {
        void Add(QuestionModel questionModel);
        void Edit(QuestionModel questionModel);
        IEnumerable<QuestionModel> GetByTest(int testId);
        int GetLast();
    }
}
