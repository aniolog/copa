﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Server.Models
{
    public class CrewMember:User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [Required] 
        [MinLength(1)]
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MinLength(1)]
        public string LastName { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string ProfileImage { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<TeamMember> TeamMembers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Device> Devices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Place> Places { get; set; }


        public CrewMember()
        {
            this.TeamMembers = new HashSet<TeamMember>();
            this.Devices = new HashSet<Device>();
            this.Places = new HashSet<Place>();
            
        }

    }
}