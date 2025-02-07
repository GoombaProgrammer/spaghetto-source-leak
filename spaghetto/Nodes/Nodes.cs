﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaghetto {
    public abstract class Node {
        public Position posStart;
        public Position posEnd;

        public abstract RuntimeResult Visit(Context context);
        public virtual string GenerateCSharp() {
            throw new Exception("Feature not supported for Compilation: " + this.GetType().Name);
        }

        public Node Clone()
        {
            return (Node)this.MemberwiseClone();
        }
    }
}
