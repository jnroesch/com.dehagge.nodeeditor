using System;

namespace Packages.com.dehagge.nodeeditor.Runtime
{
    public abstract class Node : XNode.Node
    {
        public Guid Guid;

        protected override void Init()
        {
            if (Guid.Equals(Guid.Empty))
            {
                Guid = Guid.NewGuid();
            }
        }
    }
}
