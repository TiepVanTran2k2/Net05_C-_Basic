using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T02.Problem03
{
    internal class Student : IGraduate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public decimal SqlMark { get; set; }
        public decimal CSharpMark { get; set; }
        public decimal DsaMark { get; set; }
        public decimal GPA { get; set; }

        public Student(int id, string name, decimal sqlMark, decimal csharpMark, decimal dsaMark)
        {
            this.Id = id;
            this.Name = name;
            this.SqlMark = sqlMark;
            this.CSharpMark = csharpMark;
            this.DsaMark = dsaMark;
        }

        GraduateLevel graduateLevel;

        public void Graduate()
        {
            GPA = (SqlMark + CSharpMark + DsaMark) / 3;

            if (GPA >= 9)
                graduateLevel = GraduateLevel.Excellent;
            else if (GPA >= 8 && GPA < 9)
                graduateLevel = GraduateLevel.VeryGood;
            else if (GPA >= 7 && GPA < 8)
                graduateLevel = GraduateLevel.Good;
            else if (GPA >= 5 && GPA < 7)
                graduateLevel = GraduateLevel.Average;
            else
                graduateLevel = GraduateLevel.Failed;
        }

        public string GetCertificate()
        {
            return "Name: " + Name 
                + "\nSqlMark: " + SqlMark 
                + "\nCsharpMark: " + CSharpMark 
                + "\nDsaMark: " + DsaMark 
                + "\nGPA: " + Math.Round(GPA, 2) 
                + "\nGraduateLevel: " + graduateLevel;
        }

        public enum GraduateLevel
        {
            Excellent, 
            VeryGood, 
            Good, 
            Average, 
            Failed
        }
    }
}
