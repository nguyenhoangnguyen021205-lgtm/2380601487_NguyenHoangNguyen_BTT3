using Microsoft.AspNetCore.Mvc;
using StudentRegister_BTT3.Models;

namespace StudentRegister.Controllers
{
    public class StudentController : Controller
    {
        // Danh sách giả lập sinh viên đã đăng ký
        static List<Student> dsSinhVien = new List<Student>();

        // GET: Student
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult ShowKQ(Student sv)
        {
            // Đếm số SV cùng ngành
            dsSinhVien.Add(sv);

            int soLuong = dsSinhVien.Count(x => x.ChuyenNganh == sv.ChuyenNganh);

            ViewBag.SoLuong = soLuong;
            return View(sv);
        }
    }
}