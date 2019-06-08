using Jace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class FunctionUtils
    {
        const double intStep = 1E-2;

        //Известные: ню, каппа(как x), кси0, u0(z)- функция
        private static double An(double nu, double kappa, double xi0, double h, double n, Func<IDictionary<string, double>, double> u0, Dictionary<string, double> arg)
        {
            double res = 0;

            for(double z = intStep; z <= h; z += intStep)
            {
                arg["z"] = z;

                res += intStep *
                    ((xi0 / 2 / nu * (z * z - h * z) + u0(arg)) * Math.Sin(Math.PI * n * z / h));
            }

            res *= 2;
            res /= h;

            return res;
        }

        public static double a(double z, double t, double xi0, double nu, double h, double kappa, Func<IDictionary<string, double>, double> u0, Dictionary<string, double> arg, int sumSteps)
        {
            double res = -xi0 / 2 / nu * (z * z - h * z);

            for(int n = 1; n < sumSteps; ++n)
            {
                res += An(nu, kappa, xi0, h, n, u0, arg) * 
                       Math.Exp(-nu * Math.PI * Math.PI * n * n * t / 
                       (h * h + kappa * Math.PI * Math.PI * n * n)) * 
                       Math.Sin(Math.PI * n * z / h);
            }

            return res;
        }
    }
}
