﻿namespace BlazorApp3.Models.Entity
{
    public class TodoItem

    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }


    }
}
