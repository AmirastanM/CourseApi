﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Admin.Students
{
    public class StudentCreateDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<int> GroupId { get; set; }
    }
}
