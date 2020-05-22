using Cw11.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Services
{
    public interface IDBService
    {
        public IEnumerable<Doctor> getDoctors();

        public IActionResult addDoctor(Doctor D);

        public IActionResult ModifyDoctor (Doctor D);

        public IActionResult RemoveDoctor(int ID);
    }
}
