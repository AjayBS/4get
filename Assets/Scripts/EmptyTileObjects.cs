using UnityEngine;
using System.Collections;

public class EmptyTileObjects : MonoBehaviour {

    public bool selected = false;
    public bool isEmpty = false;
    public GameObject[] empty_tiles;
    Sprite[] sprites1;
    public Texture2D texture;
    // Use this for initialization
    void Start () {
        empty_tiles = GameObject.FindGameObjectsWithTag("Empty_Tiles");
        sprites1 = Resources.LoadAll<Sprite>(texture.name);
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
                empty_tiles[i].GetComponent<EmptyTileObjects>().selected = true;
                empty_tiles[i].GetComponent<SpriteRenderer>().sprite = sprites1[52];
            }
            else
            {
                empty_tiles[i].GetComponent<EmptyTileObjects>().selected = false;
               // empty_tiles[i].GetComponent('').VariableName selected = false;
                empty_tiles[i].GetComponent<SpriteRenderer>().sprite = sprites1[53];
            }
        }
        
        Debug.Log("This is asa tile click "+ name);
       // transform.position = position;
    }
}
