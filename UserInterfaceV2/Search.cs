using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceV2
{
    public class SearchEngine
    {
        public event EventHandler Updated;
        private void OnUpdated()
        {
            Updated?.Invoke(null, EventArgs.Empty);
        }
        public Map Map { get; set; }
        public Node Begin { get; set; }
        public Node End { get; set; }
        public int NodeVisits { get; private set; }
        public double ShortestRouteLength { get; set; }

        public SearchEngine(Map map)
        {
            Map = map;
            End = map.EndBoundary;
            Begin = map.StartBoundary;
        }

        private void BuildShortestRoute(List<Node> list, Node node)
        {
            if (node.NearestToStart == null)
                return;
            list.Add(node.NearestToStart);
            ShortestRouteLength += node.Connections.Single(x => x.ConnectedNode == node.NearestToStart).Length;
            BuildShortestRoute(list, node.NearestToStart);
        }

        public List<Node> GetShortestPathAstart()
        {
            foreach (var node in Map.Nodes)
                node.StraightLineDistanceToEnd = node.StraightLineDistanceTo(End);
            AstarSearch();
            var shortestRoute = new List<Node>();
            shortestRoute.Add(End);
            BuildShortestRoute(shortestRoute, End);
            shortestRoute.Reverse();
            return shortestRoute;
        }

        private void AstarSearch()
        {
            NodeVisits = 0;
            Begin.MinCostToStart = 0;
            var prioQueue = new List<Node>();
            prioQueue.Add(Begin);
            do
            {
                prioQueue = prioQueue.OrderBy(x => x.MinCostToStart + x.StraightLineDistanceToEnd).ToList();
                var node = prioQueue.First();
                prioQueue.Remove(node);
                NodeVisits++;
                foreach (var connection in node.Connections.OrderBy(x => x.Length))
                {
                    var childNode = connection.ConnectedNode;
                    if (childNode.Visited)
                        continue;
                    if (childNode.MinCostToStart == null ||
                        node.MinCostToStart + connection.Length < childNode.MinCostToStart)
                    {
                        childNode.MinCostToStart = node.MinCostToStart + connection.Length;
                        childNode.NearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                            prioQueue.Add(childNode);
                    }
                }
                node.Visited = true;
                if (node == End)
                    return;
            } while (prioQueue.Any());
        }
    }
}
