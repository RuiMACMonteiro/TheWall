using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall
{

    public interface ILevel
    {
        float Slow { get; }
        float Normal { get; }
        float High { get; }
        float getVelocity();
        void setVelocity(int level);
    }
}
