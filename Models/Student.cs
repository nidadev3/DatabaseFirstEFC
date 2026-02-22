using System;
using System.Collections.Generic;

namespace DatabaseFirstEFCore.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentGender { get; set; } = null!;

    public int StudentAge { get; set; }
}
