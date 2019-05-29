using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MemberWebApiProject.Models;

namespace MemberWebApiProject.Service
{
    public class ProcessMembers
    {

        public List<Member> GetMembers()
        {
            var list = new List<Member>();

            var member = new Member
            {
                MemberID = 1,
                MemberName = "Joe",
                PhoneNumber = "303-555-5555"
            };

            list.Add(member);

            member = new Member
            {
                MemberID = 2,
                MemberName = "Bob",
                PhoneNumber = "303-555-6666"
            };

            list.Add(member);

            member = new Member
            {
                MemberID = 3,
                MemberName = "Al",
                PhoneNumber = "303-555-7777"
            };

            list.Add(member);

            return list;
        }
    }
}