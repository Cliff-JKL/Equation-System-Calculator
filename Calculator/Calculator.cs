using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Equations { public static int x, y, z; public Equations() { } }    // "TEST"

    public class Calculator
    {
        
        public static Equations eqSystem = new Equations(); // Система уравнений
        public static int variables;                        // Количество переменных
        public static double[] solutions;                   // Массив решений системы уравнений

        public Calculator(int inpVariables, Equations inpEquation)
        {

            variables = inpVariables;
            eqSystem = inpEquation;
            solutions = null;
        }

        public Calculator()
        {
            variables = 0;
            eqSystem = null;
            solutions = null;
        }

        public double[] Solution()
        {
            double[] sols = new double[variables];
            // "TEST"
            sols[0] = 4.5;
            sols[1] = 3;
            return sols;
        }

        public override string ToString()
        {
            string sol = "";
            char[] vbs = { 'x', 'y', 'z' };
            int i = 0;
            foreach (double d in solutions)
            {
                string.Concat(sol, vbs[i], " = ", d.ToString(), " ");
            }
            return sol;
        }
    }
}
