using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class Director
    {
        public void Build(IDatabaseBuilder builder)
        {
            builder.BuildConnection();
            builder.BuildCommand();
            builder.SetSettings();
        }
    }
}
