﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDb.Models;

public partial class Customer
{
    public string FirstLast
    {
        get => $"{FirstName} {LastName}";
    }
}