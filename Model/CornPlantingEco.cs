using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class CornPlantingEco
    {
        public int cornPlantingEcoId { get; set; }
        public string cornPrId { get; set; }
        public int brgyId { get; set; }
        public int landTypeId { get; set; }
        public int growthStageId { get; set; }
        public int seedTypeId { get; set; }
        public int colorTypeId { get; set; }
        public int zoneId { get; set; }
        public float size { get; set; }
        public DateTime logDate { get; set; }
    }
}
