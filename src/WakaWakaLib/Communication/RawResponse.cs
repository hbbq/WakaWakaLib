using System;
using System.Collections.Generic;
using System.Text;

namespace WakaWakaLib.Communication
{

    public class RawResponse
    {

        public bool Success { get; set; }
        public int Code { get; set; }
        public string Content { get; set; }

    }

}
