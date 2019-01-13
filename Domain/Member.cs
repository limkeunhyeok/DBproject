using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Member
    {
        string id;
        string pw;
        string name;
        string personal_no;
        string sex;
        string address;
        string email;
        string question;
        string answer;
        string 음식이름;
        string 음식가격;
        string 주문횟수;

        public string Id { get => id; set => id = value; }
        public string Pw { get => pw; set => pw = value; }
        public string Name { get => name; set => name = value; }
        public string Personal_no { get => personal_no; set => personal_no = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Sex { get => sex; set => sex = value; }
        public string 음식이름1 { get => 음식이름; set => 음식이름 = value; }
        public string 음식가격1 { get => 음식가격; set => 음식가격 = value; }
        public string 주문횟수1 { get => 주문횟수; set => 주문횟수 = value; }
    }
}
