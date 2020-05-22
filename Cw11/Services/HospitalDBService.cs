using Cw11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace Cw11.Services
{
    public class HospitalDBService : IDBService
    {
        private readonly s18309DbContext Db;

        public HospitalDBService(s18309DbContext D)
        {
            Db = D;
        }
        public IActionResult addDoctor(Doctor D)
        {
            Db.Doctor.Add(D);
            Db.SaveChanges();
            return new OkResult();
        }

        public IEnumerable<Doctor> getDoctors()
        {
            return Db.Doctor.ToList();
        }

        public IActionResult ModifyDoctor(Doctor D)
        { 

            var doc = Db.Doctor.Where(d => d.IdDoctor == D.IdDoctor).First();


            if (D.FirstName != null && !D.FirstName.Equals(doc.FirstName))
            {
                doc.FirstName = D.FirstName;
            }
            if (D.LastName != null && !D.LastName.Equals(doc.LastName))
            {
                doc.LastName = D.LastName;
            }
            if (D.Email != null && !D.FirstName.Equals(doc.FirstName))
            {
                doc.Email = D.Email;
            }

            Db.SaveChanges();
            return new OkResult();
        }

        public IActionResult RemoveDoctor(int ID)
        {
            var doc = Db.Doctor.Where(d => d.IdDoctor == ID).First();
            Db.Doctor.Remove(doc);
            Db.SaveChanges();
            return new OkResult();
        }
    }
}
