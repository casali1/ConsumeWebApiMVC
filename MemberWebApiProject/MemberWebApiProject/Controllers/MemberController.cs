using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MemberWebApiProject.Models;
using MemberWebApiProject.Service;

namespace MemberWebApiProject.Controllers
{
    public class MemberController : ApiController
    {
        ProcessMembers data = new ProcessMembers();

        public IEnumerable<Member> Get()
        {
            return data.GetMembers();
        }

        public Member Get(int id)
        {
            return data.GetMembers().FirstOrDefault(x => x.MemberID == id);
        }
    }
}
