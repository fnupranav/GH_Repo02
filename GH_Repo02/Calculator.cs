using GH_Repo02.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH_Repo02
{
    public class Calculator
    {
        private IFeature feature;

        public int operations(string optr, int a, int b)
        {
            switch (optr)
            {
                case "ADD":
                    feature = new Addition();
                    break;
                default:
                    return -1;
            }
            return feature.Operation(a, b);
        }
    }
}
