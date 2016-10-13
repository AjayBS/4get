using System;
using UnityEngine;

public class TileButtons : MonoBehaviour {

    GameObject[] empty_tile;
    public GameObject[] tiles;
    Vector3 position;
    public bool assigned;
    // Use this for initialization
    void Start () {
        empty_tile = GameObject.FindGameObjectsWithTag("Empty_Tiles");
        if (tiles == null)
            tiles = GameObject.FindGameObjectsWithTag("Tiles");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < empty_tile.Length; i++)
        {
            bool isEmptyTile = true;
            for (int j = 0; j < tiles.Length; j++)
            {
                if (empty_tile[i].transform.position.x == tiles[j].transform.position.x)
                {
                    empty_tile[i].GetComponent<EmptyTileObjects>().filled = true;
                    isEmptyTile = false;
                }
            }
            if (isEmptyTile)
            {
                empty_tile[i].GetComponent<EmptyTileObjects>().filled = false;
            }
        }
    }    

    void OnMouseDown()
    {
        
        for(int i=0;i<empty_tile.Length;i++)
        {
            if (empty_tile[i].GetComponent<EmptyTileObjects>().selected == true && !empty_tile[i].GetComponent<EmptyTileObjects>().filled)
            {
                empty_tile[i].GetComponent<EmptyTileObjects>().filled = true;
                transform.position = empty_tile[i].transform.position;
                assigned = true;
            }
        }
        
        Debug.Log("This is a tile click"+ position);
        //if (transform.position!=position)
        //{
        //    assigned = true;
        //    transform.position = position;
        //}

        
    }
}
