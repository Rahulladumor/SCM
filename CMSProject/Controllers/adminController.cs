using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMSProject.Models;
using System.IO;

namespace CMSProject.Controllers
{
    public class adminController : Controller
    {
        CMSDBEntities cms = new CMSDBEntities();
        // GET: admin
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(FormCollection form)
        {
            string email = form["email"].ToString();
            string password = form["password"].ToString();

            var check_login = cms.AdminTBs.Where(x => x.Admin_email == email && x.Admin_password == password).FirstOrDefault();

            if(check_login == null)
            {
                TempData["login_error"] = "Username or Password is Incorrect...";
                return View(check_login);
            }
            else
            {
                Session["admin_id"] = check_login.Admin_id;
                return RedirectToAction("dashboard", "admin");
            }
        }

        public ActionResult dashboard()
        {
            TempData["total_courses"] = cms.CourseTBs.Count();
            TempData["total_students"] = cms.StudentTBs.Count();
            TempData["total_teachers"] = cms.TeacherTBs.Count();
            TempData["total_classes"] = cms.ClassTBs.Count();    
            return View();
        }

        public ActionResult add_admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult add_admin(AdminTB addadmin)
        {
            AdminTB new_admin = new AdminTB();
            new_admin.Admin_name = addadmin.Admin_name;
            new_admin.Admin_email = addadmin.Admin_email;
            new_admin.Admin_password = addadmin.Admin_password;

            new_admin.Admin_image = "image";

            cms.AdminTBs.Add(new_admin);
            cms.SaveChanges();

            return RedirectToAction("view_admin");
        }
        public ActionResult view_admin()
        {
            var data = cms.AdminTBs.ToList();
            return View(data);
        }

        public ActionResult add_student()
        {
            TempData["course_list"] = cms.CourseTBs.ToList();
            TempData["class_list"] = cms.ClassTBs.ToList();
            return View();
        }

        public ActionResult add_existing_student()
        {
            return View();
        }
        public ActionResult view_student()
        {
            return View();
        }

        public ActionResult add_teacher()
        {
            TempData["subject_list"] = cms.SubjectTBs.ToList();
            return View();
        }

        public ActionResult view_teacher()
        {
            var data = cms.TeacherTBs.ToList();
            return View(data);
        }

        public ActionResult add_class()
        {
            return View();
        }

        public ActionResult view_class()
        {
            var data = cms.ClassTBs.ToList();
            return View(data);
        }

        public ActionResult add_course()
        {
            return View();
        }

        public ActionResult view_course()
        {
            var data = cms.CourseTBs.ToList();
            return View(data);
        }

        public ActionResult add_subject()
        {
            return View();
        }

        public ActionResult view_subject()
        {
            var data = cms.SubjectTBs.ToList();
            return View(data);
        }

        public ActionResult add_attendance()
        {
            return View();
        }

        public ActionResult view_attendance()
        {
            return View();
        }

        public ActionResult add_exam()
        {
            return View();
        }

        public ActionResult view_exam()
        {
            var data = cms.ExamTBs.ToList();
            return View(data);
        }

        public ActionResult add_result()
        {
            return View();
        }

        public ActionResult view_result()
        {
            return View();
        }

        public ActionResult add_notice()
        {
            return View();
        }

        public ActionResult view_notice()
        {
            var data = cms.NoticeTBs.ToList();
            return View(data);
        }

        public ActionResult add_payment()
        {
            return View();
        }

        public ActionResult view_payment()
        {
            var data = cms.PaymentTBs.ToList();
            return View(data);
        }

        public ActionResult view_fees()
        {
            var data = cms.FeesdetailsTBs.ToList();
            return View(data);
        }
    }
}