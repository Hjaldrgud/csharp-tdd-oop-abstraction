﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Administrator : Account
    {

        public Administrator(string email, string password) : base(email, password)
        {
            setAdmin(true);
        }
    }
}
