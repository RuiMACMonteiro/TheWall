/*
************************************************************************************************************* 
*    21179 - Laboratório de Desenvolvimento de Software                                                     *
*    1501903 - Rui Miguel Monteiro                                                                          *
*    Modulo: Model.cs class - Model                                                                         *
*************************************************************************************************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall
{
    public class Level: ILevel
    {
        static float velocity;
        public Level()
        {
            setVelocity(1);
        }

        public Level(int level)
        {
            setVelocity(level);
        }

        public float getVelocity()
        {
            return velocity;
        }

        public float High
        {
            get
            {
                return 0.07f;
            }
        }

        public float Normal
        {
            get
            {
                return 0.05f;
            }
        }

        public float Slow
        {
            get
            {
                return 0.02f;
            }
        }

        public void setVelocity(int level)
        {
            
            switch(level)
            {
                case 0:
                    {
                        velocity = Slow;
                        break;
                    }
                case 1:
                    {
                        velocity = Normal;
                        break;
                    }
                case 2:
                    {
                        velocity = High;
                        break;
                    }
                default:
                    {
                        velocity = Normal;
                        break;
                    }

            }

        }
    }
}
