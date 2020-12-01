// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System.Collections.Generic;


namespace SwishDiagram.Models
{
    public class Diagram
    {
        private List<GraphicObject> objects = new List<GraphicObject>();

        public List<GraphicObject> Objects
        {
            get { return objects; }
        }
    }
}
