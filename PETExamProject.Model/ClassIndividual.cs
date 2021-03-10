using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETExamProject.Model
{
    public class ClassIndividual
    {
        #region Fields

        private int _Id;
        private string _FirstName;
        private string _LastName;
        private string _Address;
        private string _ZipCode;

        private ClassNationality _Nationality;
        private float _Height;
        private string _EyeColour;
        private string _HairColour;
        private string _Ethnicity;

        private List<string> _Keywords;
        private Bitmap _Photo;

        #endregion

        #region Constructors
        protected ClassIndividual()
        {

        }

        public ClassIndividual(ClassIndividual individual)
        {
            Id = individual.Id;
            FirstName = individual.FirstName;
            LastName = individual.LastName;
            Address = individual.Address;
            ZipCode = individual.ZipCode;
            Nationality = individual.Nationality;
            Height = individual.Height;
            EyeColour = individual.EyeColour;
            HairColour = individual.HairColour;
            Ethnicity = individual.Ethnicity;
            Keywords = individual.Keywords;
            Photo = individual.Photo;
        }

        #endregion

        #region Properties
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        public ClassNationality Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }
        public string EyeColour
        {
            get { return _EyeColour; }
            set { _EyeColour = value; }
        }

        public string HairColour
        {
            get { return _HairColour; }
            set { _HairColour = value; }
        }

        public string Ethnicity
        {
            get { return _Ethnicity; }
            set { _Ethnicity = value; }
        }

        public float Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public List<string> Keywords
        {
            get { return _Keywords; }
            set { _Keywords = value; }
        }

        public Bitmap Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        }

        #endregion
    }
}
