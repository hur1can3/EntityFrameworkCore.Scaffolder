﻿using System;
using System.Collections.Generic;
using ClearBlueDesign.EntityFrameworkCore.Scaffolder.Samples.Web.Data.Abstractions;

namespace ClearBlueDesign.EntityFrameworkCore.Scaffolder.Samples.Web.Data
{
    public partial class Employee : EmptyBase
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public virtual Employee ReportsToNavigation { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; } = new HashSet<EmployeeTerritory>();
        public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new HashSet<Employee>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
