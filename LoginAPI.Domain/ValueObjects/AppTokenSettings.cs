﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.ValueObjects
{
    public class AppTokenSettings
    {
        public int RefreshTokenExpiration { get; set; }
    }
}
