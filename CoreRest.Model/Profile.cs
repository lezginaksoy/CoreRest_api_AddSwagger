using CoreRest.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRest.Model
{
    public class Profile
    {
        public Guid ProfileId { get; set; }
        public string ProfileCode { get; set; }
        public IEnumerable<Skills> Skills { get; set; }
        public Department Department { get; set; }
    }
}
