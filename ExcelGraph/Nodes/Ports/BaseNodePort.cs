using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExcelGraph.Nodes.Ports
{
    public abstract class BaseNodePort
    {
        public BaseNode Belong { get; set; } = null;
        public string Label { get; set; } = null;
        public abstract void OnDraw(Graphics g);
    }
}
