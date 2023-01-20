using System;
using System.Collections.Generic;

namespace ResourceManagerAPI.Models
{
    public partial class Skill
    {
        public int ID { get; set; }
        public string resource_name { get; set; }
        public string email_id { get; set; }
        public string skill_group { get; set; }
        public string skill { get; set; }
        public string master_resource_uid { get; set; }
        public string skill_set_uid { get; set; }

    }
}