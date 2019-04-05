﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThemePark.ViewModels
{
    public class EmployeeVM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeVM()
        {
            ADMITTED_BY = new HashSet<ADMITTED_BY>();
            EmployeeLogins = new HashSet<EmployeeLogin>();
            MANAGED_BY = new HashSet<MANAGED_BY>();
            PERFORMED_BY = new HashSet<PERFORMED_BY>();
            SOLD_BY = new HashSet<SOLD_BY>();
            Rides = new HashSet<Ride>();
        }

        [Key]
        public long EmployeeID { get; set; }

        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string MiddleName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string StreetAddress { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(5)]
        public string ZipCode { get; set; }

        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(20)]
        public string JobTitle { get; set; }

        public long? DepartmentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADMITTED_BY> ADMITTED_BY { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLogin> EmployeeLogins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANAGED_BY> MANAGED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFORMED_BY> PERFORMED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLD_BY> SOLD_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ride> Rides { get; set; }




        [Key]
        [StringLength(40)]
        public string LoginEmail { get; set; }

        [StringLength(20)]
        public string Pswd { get; set; }

    }
}