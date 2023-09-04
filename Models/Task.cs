﻿using System.ComponentModel.DataAnnotations;

namespace Assignment16.Models
{
    
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

    }
}
