using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapData : MonoBehaviour {

    public int width = 1;
    public int height = 1;

    public TextAsset textAsset;

    /**************************************************/

    public void SetDimensions(List<string> textLines) {
        height = textLines.Count;

        foreach (string line in textLines) {
            if (line.Length > width) {
                width = line.Length;
            }
        }
    }

    public List<string> GetTextFromFile(TextAsset tAsset) {
        List<string> lines = new List<string>();

        if (tAsset != null) {
            string textData = tAsset.text;
            char[] delimiters = { '\n', '\r' };
            lines = textData.Split(delimiters).ToList();
            lines.Reverse();

        } else {
            Debug.LogWarning("MAPDATA GetTextFromFile Error: invalid TextAsset!");
        }

        return lines;
    }

    public List<string> GetTextFromFile() {
        return GetTextFromFile(textAsset);
    }

    public int[,] MakeMap() {
        List<string> lines = GetTextFromFile();
        SetDimensions(lines);

        int[,] map = new int[width, height];
        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++) {
                if (lines[y].Length > x) {
                    map[x, y] = (int)char.GetNumericValue(lines[y][x]);
                }
            }
        }

        return map;
    }

}