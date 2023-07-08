using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum TileType
{
    groundtile,
    walltile,

}

public class Tile : MonoBehaviour
{
    public Transform pointTogo;
    // Start is called before the first frame update
    void Start()
    {
        pointTogo = transform;
    }
}
