using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class ToolGenerator
    {
        Dictionary<string, Tool> dictionaryTool;

        public ToolGenerator()
        {
            dictionaryTool = new Dictionary<string, Tool>
            {
                { "Line",   new LineTool() },
                { "Circle", new CircleTool() },
                { "Rectangle", new RectangleTool() },
                { "Parabola", new ParabolaTool() },
                { "Hyperbola", new HyperbolaTool() },
                { "Move", new MoveTool() },
                { "Rotate", new RotateTool() },
                { "Scale", new ScaleTool() },
                { "Polygon", new PolygonTool() },
                { "Bezier", new BezierTool() },
                { "Text", new TextTool() },
                { "Selection", new SelectionTool() },
                { "Zigzag", new ZigzagTool() }
            };
        }

        public Tool Generate(string chosenTool)
        {
            if (dictionaryTool.ContainsKey(chosenTool))
                return dictionaryTool[chosenTool];
            return null;
        }
    }
}
