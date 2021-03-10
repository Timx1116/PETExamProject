using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETExamProject.Model
{
    public class ClassNationality
    {
        private int _Id;
        private string _CountryName;
        private string _CountryCode;
        private string _Nationality;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        public string CountryCode
        {
            get { return _CountryCode; }
            set { _CountryCode = value; }
        }

        public string Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }

    }
}
