using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterfaceV2
{
    public class Map
    {
        public static Map Generate(List<PictureBox> obstructionList, PictureBox startingBox, PictureBox endingBox)
        {
            var map = new Map();

          

            for (double i = 0; i < 890; i += 14)
            {
                for (double j = 0; j < 388; j += 14)
                {
                    var newNode = Node.GetRandom(i / 890, j / 388, i.ToString() + "," + j.ToString());
                    if (!newNode.InsideObs(obstructionList))
                        map.Nodes.Add(newNode);
                }
            }

            var startNode = Node.GetRandom((double)startingBox.Location.X / 890, (double)startingBox.Location.Y / 388, "Start");
            map.Nodes.Add(startNode);

            var endNode = Node.GetRandom((double)endingBox.Location.X / 890, (double)endingBox.Location.Y / 388, "End");
            map.Nodes.Add(endNode);

            foreach (var node in map.Nodes)
                node.ConnectClosestNodes(map.Nodes);
            map.StartBoundary = startNode;
            map.EndBoundary = endNode;
            return map;
        }

        public List<Node> Nodes { get; set; } = new List<Node>();

        public Node StartBoundary { get; set; }

        public Node EndBoundary { get; set; }

        public List<Node> ShortestPath { get; set; } = new List<Node>();
    }

    public class Node
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Point Point { get; set; }
        public List<Edge> Connections { get; set; } = new List<Edge>();

        public double? MinCostToStart { get; set; }
        public Node NearestToStart { get; set; }
        public bool Visited { get; set; }
        public double StraightLineDistanceToEnd { get; set; }

        internal static Node GetRandom(double x, double y, string name)
        {
            return new Node
            {
                Point = new Point
                {
                    X = x,
                    Y = y
                },
                Id = Guid.NewGuid(),
                Name = name
            };
        }

        internal void ConnectClosestNodes(List<Node> boundaries)
        {
            var connections = new List<Edge>();
            foreach (var boundary in boundaries)
            {
                if (boundary.Id == this.Id)
                    continue;

                double dist = Math.Sqrt(Math.Pow(Point.X - boundary.Point.X, 2) + Math.Pow(Point.Y - boundary.Point.Y, 2));
                if (dist < 0.04)
                {
                    connections.Add(new Edge
                    {
                        ConnectedNode = boundary,
                        Length = dist,
                        Cost = dist,
                    });
                }
            }
            connections = connections.OrderBy(x => x.Length).ToList();
            var counter = 0;
            foreach (var cnn in connections)
            {
                
                if (!Connections.Any(c => c.ConnectedNode == cnn.ConnectedNode))
                    Connections.Add(cnn);
                counter++;

               
                if (!cnn.ConnectedNode.Connections.Any(cc => cc.ConnectedNode == this))
                {
                    var backConnection = new Edge { ConnectedNode = this, Length = cnn.Length };
                    cnn.ConnectedNode.Connections.Add(backConnection);
                }
                if (counter == 10)
                    return;
            }
        }

        public double StraightLineDistanceTo(Node end)
        {
            return Math.Sqrt(Math.Pow(Point.X - end.Point.X, 2) + Math.Pow(Point.Y - end.Point.Y, 2));
        }

        internal bool InsideObs(List<PictureBox> obstructionList)
        {
            foreach (PictureBox obstruction in obstructionList)
            {
                double x1 = obstruction.Location.X - 10;
                double y1 = obstruction.Location.Y - 10;
                double x2 = x1 + obstruction.Width + 20;
                double y2 = y1 + obstruction.Height + 20;

                

                double x = Point.X * 890;
                double y = Point.Y * 388;

                if ((x > x1) && (x < x2) && (y > y1) && (y < y2))
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Edge
    {
        public double Length { get; set; }
        public double Cost { get; set; }
        public Node ConnectedNode { get; set; }

        public override string ToString()
        {
            return "-> " + ConnectedNode.ToString();
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
