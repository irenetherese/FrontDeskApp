﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FrontDeskApp.Common.Models
{
    public class CurrentStorageInfo
    {
        public BoxType BoxType { get; set; }
        public int Quantity { get; set; }
    }
}
