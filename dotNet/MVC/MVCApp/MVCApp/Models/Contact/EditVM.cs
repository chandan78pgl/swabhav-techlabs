﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Contact
{
    public class EditVM
    {
        public int Id { set; get; }
        public string ContactNo { set; get; }
        public string FName { set; get; }
        public string LName { set; get; }
        public string Email { set; get; }
    }
}