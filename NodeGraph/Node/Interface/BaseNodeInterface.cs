using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGraph.Node.Interface
{
    public enum InterfaceType : uint
    {
        IT_FROM         = 0x80000000,
        IT_TO           = 0xC0000000,
        IT_FLOW_MASK    = 0x80000000,
        IT_INPUT        = 0x08000000,
        IT_OUTPUT       = 0x0C000000,
        IT_IO_MASK      = 0x08000000,
        IT_DNUMBER      = 0x00008001,
        IT_DSTRING      = 0x00008002,
        IT_DRANGE       = 0x00008004,
        IT_DBOOL        = 0x00008008,
        IT_DT_MASK      = 0x0000800F,
    }

    public class BaseNodeInterface
    {

    }
}
