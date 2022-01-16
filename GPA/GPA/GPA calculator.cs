using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    internal class GPA_calculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 4;
        private string name = string.Empty; //""
        private string alldata = string.Empty;

        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + "-->" + gpa + Environment.NewLine;

            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;

            }
            if (this.min > gpa)
            {
                this.min = gpa;
                this.name = name;
            }

        }
        public double getMin()
        {
            return min;
        }
        public string getMinName()
        {
            return name;
        }
        internal void addGPA(double dInput, object nme)
        {
            throw new NotImplementedException();
        }
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return name;
        }
        public string getAlldata()
        {
            return alldata;
        }
    }
}
