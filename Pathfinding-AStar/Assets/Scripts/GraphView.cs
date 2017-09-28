using UnityEngine;

[RequireComponent(typeof(Graph))]
public class GraphView : MonoBehaviour {

    public GameObject NodeViewPrefab;

    public Color baseColor = Color.white;
    public Color wallColor = Color.black;

    /**************************************************/

    public void Init(Graph graph) {
        if (graph == null) {
            Debug.LogWarning("GRAPHVIEW No graph to initialize");
            return;
        }

        foreach (Node n in graph.nodes) {
            GameObject instance = Instantiate(NodeViewPrefab, Vector3.zero, Quaternion.identity);
            NodeView nodeView = instance.GetComponent<NodeView>();
            if (nodeView != null) {
                nodeView.Init(n);

                if (n.nodeType == NodeType.Blocked) {
                    nodeView.ColorNode(wallColor);
                } else {
                    nodeView.ColorNode(baseColor);
                }
            }
        }
    }

}