using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddly3.Models;
using Viddly3.ViewModels;

namespace Viddly3.Controllers
{
    public class MemberController : Controller
    {

        private ApplicationDbContext _context;

        public MemberController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Member/New
        public ActionResult New()
        {

            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new MemberFormViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("MemberForm", viewModel);
        }      

        [HttpPost]
        public ActionResult Create(Member member)
        {
            //MembershipType member = new MembershipType { };

            //member.Name = Member.MembershipType.Name


            //    Member.MembershipType;

            //member.Id = Member.MembershipType.Id;



            if (member.Id == 0)
            {
                _context.Members.Add(member);
            }
            else
            {
                var memberFromDb = _context.Members.Single(x => x.Id == member.Id);

                memberFromDb.Name = member.Name;
                memberFromDb.BirthDate = member.BirthDate;
                memberFromDb.MembershipTypeId = member.MembershipTypeId;
                memberFromDb.IsSubscribedToNewsLetter = member.IsSubscribedToNewsLetter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Member");
        }


        // GET: Member/Index
        public ActionResult Index()
        {


            var members = _context.Members.Include(c => c.MembershipType).ToList();

            //var Member1 = new Member() { };
            //Member1.Name = "Carlos";
            //Member1.Age = 28;
            //Member1.Sex = "Male";
            //Member1.Company = "Kubix Systems";
            //Member1.Id = 1;

            //var Member2 = new Member() { };
            //Member2.Name = "Horacio";
            //Member2.Age = 30;
            //Member2.Sex = "Male";
            //Member2.Company = "Katon LLC";
            //Member2.Id = 2;

            //var ListOfMembers = new List<Member>() { };

            //ListOfMembers.Add(Member1);
            //ListOfMembers.Add(Member2);

            //var viewModel = new MemberIndexViewModel() { };

            //viewModel.Members = ListOfMembers;

            return View(members);
        }

        // GET: Member/Details/id
        public ActionResult Details(int id)
        {
            Member member = _context.Members.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);


            //var Member1 = new Member() { };
            //Member1.Name = "Carlos";
            //Member1.Age = 28;
            //Member1.Sex = "Male";
            //Member1.Company = "Kubix Systems";
            //Member1.Id = 1;

            //var Member2 = new Member() { };
            //Member2.Name = "Horacio";
            //Member2.Age = 30;
            //Member2.Sex = "Male";
            //Member2.Company = "Katon LLC";
            //Member2.Id = 2;

            //var ListOfMembers = new List<Member>() { };

            //ListOfMembers.Add(Member1);
            //ListOfMembers.Add(Member2);

            //var viewModel = new MemberDetailsViewModel() { };

            //foreach (var member in ListOfMembers)
            //{
            //    if (member.Id == id)
            //    {
            //        viewModel.Member = member;
            //    }
            //}

            return View(member);

        }



        // GET: Member/Edit/id
        public ActionResult Edit(int id)
        {
            var member = _context.Members.SingleOrDefault(c => c.Id == id);

            if (member == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MemberFormViewModel()
            {
                Member = member,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("MemberForm", viewModel);
        }
    }
}