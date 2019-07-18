using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
List<double> grades;

        public Book (string name){
            grades=new List<double>();
            this.name=name;
        }
        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        
        }
        public Statistics GetStatistics(){
             var result = new Statistics();
            result.Avarage=0.0;
            result.Low=double.MaxValue;
            result.High=double.MinValue;
            foreach(var grade in grades){
                result.Avarage+=grade;
                result.High= Math.Max(grade,result.High);
                result.Low= Math.Min(grade,result.Low);
                
            }
             result.Avarage/=grades.Count;
             return result;
                  }
            private string name; 

    }
}