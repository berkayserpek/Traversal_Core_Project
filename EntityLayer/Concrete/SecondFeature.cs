﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SecondFeature
    {
        [Key]
        public int SecondFeatureID { get; set; }
        public string SecondtPostTitle { get; set; }
        public string SecondPostDescription { get; set; }
        public string SecondPostImage { get; set; }
        public bool SecondPostStatus { get; set; }
    }
}
