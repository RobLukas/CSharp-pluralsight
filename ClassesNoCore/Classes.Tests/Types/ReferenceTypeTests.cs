using ClassesNoCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            addGrades(grades);
            Assert.AreEqual(89.23f, grades[1]);
        }

        private void addGrades(float[] grade)
        {
            grade = new float[5];
            grade[1] = 89.23f;
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Assert.AreEqual("Grade book", g1.Name);
        }
        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Grade book";
        }
        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            //g1 = new GradeBook();
            g1.Name = "Rob grade book";
            Assert.AreEqual("Rob grade book", g2.Name);
        }
    }
}
