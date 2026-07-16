using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLogicLayer
{
    public class clsSpecialazation
    {
        public static Dictionary<string, int> GetSpecialazations()
        {
            return clsSpeciazationDA.GetSpecialazations();
        }
    }
}
