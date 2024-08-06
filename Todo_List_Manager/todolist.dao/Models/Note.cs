using System;
using System.Collections.Generic;

namespace todolist.dao.Models;

public class Note
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateOnly? CreateAt { get; set; }

    public bool? Status { get; set; }
}
