﻿namespace Graph3D.Vrml.Nodes {
    public class ScriptNode : BaseNode {

        public ScriptNode() {
        }

        protected override BaseNode createInstance() {
            return new ScriptNode();
        }

        public override void AcceptVisitor(INodeVisitor visitor) {
            visitor.Visit(this);
        }

    }
}
