using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAnomalyDetection
{
    public class ServerMetrics
    {
        [LoadColumn(1)]
        public float cpu;

        [LoadColumn(2)]
        public float ram;

        [LoadColumn(3)]
        public float disk;        
        
        [LoadColumn(4)]
        public float network;
    }
}
