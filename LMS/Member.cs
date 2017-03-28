using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Member
    {
        private static int iDCounter = 1;
        private string iD;
        private string name;
        public List<Book> booksBorrowed = new List<Book>();

        public Member(string MemberName)
        {
            iD = "LM-" + Convert.ToString(iDCounter);
            name = MemberName;
            iDCounter++;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string ID
        {
            get
            {
                return iD;
            }
        }

    }
}
