using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public override bool Equals(object other)
        {
            if (other.GetType() != GetType())
                return false;
            var that = (EntityBase)other;
            return Id == that.Id;
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
    }
}
