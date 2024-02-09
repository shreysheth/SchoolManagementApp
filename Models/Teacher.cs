using System;
using System.Collections.Generic;

namespace SchoolManagementApp.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
