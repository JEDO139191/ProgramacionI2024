using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Positions
    {
        

        
        public const string Secretaria = "Secretaria";
        public const string Director = "Director";

        public static IEnumerable<string> GetPositions()
        {
            var positions = new List<string>();
            positions.Add(Secretaria);
            positions.Add(Director);
            positions.Sort();
            return positions;
        }
    }
}
