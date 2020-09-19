using System;
using System.Collections.Generic;
using System.Text;

namespace Dreieck
{
    class RechtwinkligesDreieck
    {
        private double alpha;
        private double hypothenuse;
        private double beta;
        private double kathete_a;
        private double kathete_b;
        public double GetAlpha()
        {
            return alpha;
        }
        public double GetBeta()
        {
            return beta;
        }

        public double GetKathete_a()
        {
            kathete_a = Math.Sin(alpha / 180 * Math.PI) * hypothenuse;
            return kathete_a;
        }
        public double GetKathete_b()
        {
            kathete_b = Math.Sin(beta / 180 * Math.PI) * hypothenuse;
            return kathete_b;
        }

        public double GetHypothenuse()
        {
            return hypothenuse;
        }

        public void SetAlpha(double alpha)
        {
            if (alpha > 0 && alpha < 90)
            {
                this.alpha = alpha;
                beta = 90 - alpha;
            }
        }
        
        public void SetHypothenuse(double hypothenuse)
        {
            this.hypothenuse = hypothenuse;
        }


    }
}
