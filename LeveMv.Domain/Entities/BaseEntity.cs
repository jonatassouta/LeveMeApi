using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMv.Domain.Entities
{
    public class BaseEntity
    {
        public static Guid GenerateId()
        {
            return Guid.NewGuid();
        }
    }
}
