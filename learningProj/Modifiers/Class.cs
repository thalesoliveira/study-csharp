using System;
using System.Collections.Generic;
using System.Text;

namespace Modifiers

{
    public class Class
    {
        public int ProPublic { get; set; }
        private int ProPrivada { get; set; }
        protected int PropProtected { get; set; }
        internal int PropInternal { get; set; }
        protected internal int PropProtectedInternal { get; set; }
        private protected  int PropPrivateProtected { get; set; }

    }
    
}
