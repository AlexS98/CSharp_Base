using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    public interface ICommonObject
    {
        int Id { get; set; }
        DateTimeOffset CreateDate { get; set; }
        DateTimeOffset UpdateDate { get; set; }
    }
}
