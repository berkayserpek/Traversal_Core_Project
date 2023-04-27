using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public string FirstPostTitle { get; set; }
        public string FirstPostDescription { get; set; }
        public string FirstPostImage { get; set; }
        public bool FirstPostStatus { get; set; }
    }
}
