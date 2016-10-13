using System;
using UnityEngine;

public class TileButtons : MonoBehaviour {

    GameObject empty_tile;
    public GameObject[] tiles;
    Vector3 position;
    // Use this for initialization
    void Start () {
        empty_tile = GameObject.FindGameObjectWithTag("Empty_Tiles");
        if (tiles == null)
            tiles = GameObject.FindGameObjectsWithTag("Tiles");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello");
        //    if (Input.GetMouseButtonDown(0))        {

        //        RaycastHit2D hit = Physics2D.Raycast(transform.position,-Vector2.up);

        //        if (hit.collider != null && hit.collider.gameObject.tag == "Tiles")
        //        {
        //            Debug.Log("This is a tile click");
        //        }
        //    }
        //}
    }    

    void OnMouseDown()
    {
        position=empty_tile.transform.position;
        Debug.Log("This is a tile click"+ position);
        transform.position = position;
    }
}
