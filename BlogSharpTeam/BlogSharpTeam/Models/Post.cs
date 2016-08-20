﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BlogSharpTeam.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace BlogSharpTeam.Models
{
    public class Post
    {
        public Post()
        {            
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }
       
        
        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }

        public string Author_Id { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
    }
}