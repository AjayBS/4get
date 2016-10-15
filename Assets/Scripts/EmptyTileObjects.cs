using UnityEngine;
using System.Collections;

public class EmptyTileObjects : MonoBehaviour {

    public bool selected = false;
    public bool isEmpty = false;
    public GameObject[] empty_tiles;
    Sprite[] emptyTileSprite;
    public Texture2D texture;
    //public string[] groupName;
    //public string previousName


    // Use this for initialization
    void Start () {
        empty_tiles = GameObject.FindGameObjectsWithTag("Empty_Tiles");
        emptyTileSprite = Resources.LoadAll<Sprite>(texture.name);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {
        for (int i = 0; i < empty_tiles.Length; i++)
        {
            if (empty_tiles[i].name.Equals(name))
            {
               
                empty_tiles[i].GetComponent<EmptyTileObjects>().selected = true;
                empty_tiles[i].GetComponent<SpriteRenderer>().sprite = emptyTileSprite[52];
            }
            else
            {
                empty_tiles[i].GetComponent<EmptyTileObjects>().selected = false;
                // empty_tiles[i].GetComponent('').VariableName selected = false;
                //empty_tiles[i].GetComponent<SpriteRenderer>().sprite = emptyTileSprite[53];
            }
        }
        string groupName = getGroupName(name);
        for (int i = 0; i < empty_tiles.Length; i++)
        {
            if(groupName.Equals(getGroupName(empty_tiles[i].name))&& (!empty_tiles[i].name.Equals(name)))
            {
                empty_tiles[i].GetComponent<SpriteRenderer>().sprite = emptyTileSprite[54];
            }
            else if((!empty_tiles[i].name.Equals(name)))
            {
                empty_tiles[i].GetComponent<SpriteRenderer>().sprite = emptyTileSprite[53];
            }
        }

            // transform.position = position;
    }

    public string getGroupName(string s)
    {
        int l = s.IndexOf("-");
        if (l > 0)
        {
            return s.Substring(0, l);
        }
        return "";

    }
}
