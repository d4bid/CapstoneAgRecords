using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class ProductionData
    {
        public List<int> Years { get; set; }
        public List<double> HistoricalProduction { get; set; }
        public List<double> ForecastedProduction { get; set; }
    }
}
