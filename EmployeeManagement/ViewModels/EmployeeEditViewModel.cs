using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
        public int Id { get; set; }

        public string ExistingPhotoPath { get; set; }
    }
}
