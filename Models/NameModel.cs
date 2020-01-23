using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestCompany.Models
{
    public class NameModel
    {
        // Properties:
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int DeptNumber { get; set; }
        public char Type { get; set; } = 's';
        public bool IsActive { get; set; } = true;
 
        // Constructor
        public NameModel()
        {

        }
 
    }

    
}