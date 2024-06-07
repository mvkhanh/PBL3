using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.Question
{
    public partial class QuestionBox : UserControl
    {
        public virtual int QuestionId {  get; set; }
        public virtual int AnswerAId { get; set; }
        public virtual int AnswerBId { get; set; }
        public virtual int AnswerCId { get; set; }
        public virtual int AnswerDId { get; set; }
        public virtual string AnswerAContent { get; set; }
        public virtual string AnswerBContent { get; set; }
        public virtual string AnswerCContent { get; set; }
        public virtual string AnswerDContent { get; set; }
        public virtual string QuestionContent { get; set; }
        public virtual int QuestionNum { get; set; }
        public virtual byte[] QuestionImage {  get; set; }
        public virtual int QuestionAnswer { get; set; }
        public QuestionBox()
        {
            InitializeComponent();
        }
        protected string _ImagePath;
        public virtual string ImagePath
        {
            get => _ImagePath;
            set
            {
                _ImagePath = value;
                OnImagePathChanged();
            }
        }

        protected virtual void OnImagePathChanged()
        {
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
