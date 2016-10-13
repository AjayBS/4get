using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEditor;

public class LoadGameObjects : MonoBehaviour {
    //Sprite tile;
    // Use this for initialization


    public GameObject empty_tiles;
    public GameObject alphabet_tiles;
    void Start () {


        for (int y = -2; y < -1; y++)
        {
            for (int x = -2; x < 3; x++)
            {
                GameObject tempTile;
                tempTile = Instantiate(alphabet_tiles, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                tempTile.name = "AlphabetTile" + x;

            }
        }

        for (int y = 0; y < 1; y++)
        {
            for (int x = -2; x < 3; x++)
            {
                GameObject tempTile;
                tempTile = Instantiate(empty_tiles, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                tempTile.name = "EmptyTile" + x;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        //GameObject go = new GameObject();
        //SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();

        //renderer.sprites[] = Resources.Load("Sprites/Player", typeof(Sprite)) as Sprite;



        //Sprite[] sprites;
        //sprites = Resources.LoadAll<Sprite>("Tiles-Sprite");
        //sprites[0].transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
        //SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        //if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
        //    spriteRenderer.sprite = sprites[0];
        //Debug.Log(sprites.Length);
    }
}
