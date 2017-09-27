using UnityEngine;

public class MapData : MonoBehaviour {

    public int width = 10;
    public int height = 10;

    /**************************************************/

    public int[,] MakeMap() {
        int[,] map = new int[width, height];

        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++) {
                map[x, y] = 0; // NodeType.Open
            }
        }

        map[1, 0] = 1; // NodeType.Blocked;
        map[1, 1] = 1; // NodeType.Blocked;
        map[1, 2] = 1; // NodeType.Blocked;
        map[3, 2] = 1; // NodeType.Blocked;
        map[3, 3] = 1; // NodeType.Blocked;
        map[3, 4] = 1; // NodeType.Blocked;
        map[4, 2] = 1; // NodeType.Blocked;
        map[5, 1] = 1; // NodeType.Blocked;
        map[5, 2] = 1; // NodeType.Blocked;
        map[6, 2] = 1; // NodeType.Blocked;
        map[6, 3] = 1; // NodeType.Blocked;
        map[8, 0] = 1; // NodeType.Blocked;
        map[8, 1] = 1; // NodeType.Blocked;
        map[8, 2] = 1; // NodeType.Blocked;
        map[8, 4] = 1; // NodeType.Blocked;

        return map;
    }

}