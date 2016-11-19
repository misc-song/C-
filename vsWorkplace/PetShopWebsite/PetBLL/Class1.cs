using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBLL
{
    public class PetProductService
    {
        public List<PetProduct> getData()
        {
            return new PetProductDao().GetData();
        }
    }
    public class Class1
    {
    }
}
