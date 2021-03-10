using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETExamProject.Model
{
    public class ClassReport
    {
        private int _Id;
        private string _Title;
        private string _TextBody;
        private DateTime _SubmissionDate;
        private ClassEmployee _Author;
        private IObserved  _Subject;

        public IObserved Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        public ClassEmployee Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public DateTime SubmissionDate
        {
            get { return _SubmissionDate; }
            set { _SubmissionDate = value; }
        }

        public string TextBody
        {
            get { return _TextBody; }
            set { _TextBody = value; }
        }


        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public ClassReport()
        {

        }
    }
}
