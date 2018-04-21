using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter02_01
{
    class CMyClass
    {
        public int theStudentCount; //멤버변수
        public string theName;
        public int theGrade;

        public CMyClass()
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = 0;
        }

        public CMyClass(int aGrade) //사용자 오버로딩
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = aGrade;
        }

        public CMyClass(int aGrade, string aName) : this() //this를 상속받은 것처럼 됨. (super)
        {
            theName = aName;
            theGrade = aGrade;
        }
        public string GetName()
        {
            string res = string.Format("{0}학년 {1}, {2}명", theGrade, theName, theStudentCount);
            return (res);
        }

        public void Increase(int aValue)
        {
            aValue++;
        }

        public void Increase(ref int aValue)
        {
            aValue++;
        }
        public void MakeValue(out int aValue) //ref와 out에 이름이 같으면 안됨.
            //return을 여러번 사용하기 위해 out을 사용
        {
            aValue = 19;
        }
    }
}
