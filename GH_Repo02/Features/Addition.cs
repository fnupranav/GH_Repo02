using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH_Repo02.Features
{
    public class Addition : IFeature
    {
        public int Operation(int a, int b) 
        {
            return a + b;
        }
    }
}
