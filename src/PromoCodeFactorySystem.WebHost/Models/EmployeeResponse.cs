﻿using System;
using System.Collections.Generic;
using PromoCodeFactorySystem.Core.Domain.Administration;

namespace PromoCodeFactorySystem.WebHost.Models
{
    public class EmployeeResponse
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }

        public RoleItemResponse Role { get; set; }

        public int AppliedPromocodesCount { get; set; }
    }
}