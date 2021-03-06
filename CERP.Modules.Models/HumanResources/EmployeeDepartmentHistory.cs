﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
    public class EmployeeDepartmentHistory
    {
        [Key,Column(Order = 1)][ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [Key, Column(Order = 2)]
        public int DepartmentID { get; set; }
        [Key, Column(Order = 3)]
        public int ShiftID { get; set; }
        [Key, Column(Order = 4)]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
