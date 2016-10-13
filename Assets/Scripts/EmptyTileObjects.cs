using UnityEngine;
using System.Collections;

public class EmptyTileObjects : MonoBehaviour {

    public bool selected = false;
    public bool isEmpty = false;
    public GameObject[] empty_tiles;
    // Use this for initialization
    void Start () {
        empty_tiles = GameObject.FindGameObjectsWithTag("Empty_Tiles");
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {
        for(int i=0;i<empty_tiles.Length;i++)
        {
            if(empty_tiles[i].name.Equals(name))
            {
                transform.localScale = new Vector3(1.2f, 1.2f, 0);
                empty_tiles[i].GetComponent<EmptyTileObjects>().selected = true;
            }
            else
            {
                empty_tiles[i].GetComponent<EmptyTileObjects>().selected = false;
               // empty_tiles[i].GetComponent('').VariableName selected = false;
                empty_tiles[i].transform.localScale = new Vector3(1f, 1f, 0);
            }
        }
        
        Debug.Log("This is asa tile click "+ name);
       // transform.position = position;
    }
}
