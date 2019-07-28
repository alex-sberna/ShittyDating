using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShittySpeedDating.Types
{
    public class DateObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Personality { get; set; }
        public int Rating { get; set; }
        public QuestionObject QuestionObject1 { get; set; }
        public QuestionObject QuestionObject2 { get; set; }
        public QuestionObject QuestionObject3 { get; set; }
        public QuestionObject QuestionObject4 { get; set; }
        public QuestionObject QuestionObject5 { get; set; }
    }

    public class QuestionObject
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int Answer1Score { get; set; }
        public int Answer2Score { get; set; }
        public int Answer3Score { get; set; }
        public int Answer4Score { get; set; }
        public QuestionObject()
        {
            QuestionObject questionObject = new QuestionObject();
        }
    }
}
