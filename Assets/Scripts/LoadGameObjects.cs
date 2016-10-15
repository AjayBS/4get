using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEditor;
using UnityEngine.SceneManagement;

public class LoadGameObjects : MonoBehaviour {
    //Sprite tile;
    // Use this for initialization


    public GameObject empty_tiles_prefab;
    public GameObject alphabet_tiles_prefab;
    public GameObject[] alphabet_tiles;
    public GameObject[] empty_tiles;
    public Texture2D texture;

    public GameObject picture;
    GameObject family_pic;
    Sprite[] sprites;
    Sprite[] sprites1;
    Sprite differentAlphabet;
    Sprite photograph;
    public Texture btnTexture;
    public bool buttonHide=true;
    public Vector3 picturePosition;
    public Vector3 pictureScale;

    void Start () {
        
        alphabet_tiles = GameObject.FindGameObjectsWithTag("Tiles");
        empty_tiles = GameObject.FindGameObjectsWithTag("Empty_Tiles");
        for (int j = 0; j < alphabet_tiles.Length; j++)
        {
            alphabet_tiles[j].GetComponent<SpriteRenderer>().sprite = sprites[j];
        }
        for (int j = 0; j < empty_tiles.Length; j++)
        {
            empty_tiles[j].GetComponent<SpriteRenderer>().sprite = sprites[53];
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        sprites = Resources.LoadAll<Sprite>(texture.name);
        sprites1 = Resources.LoadAll<Sprite>(texture.name);
        photograph = Resources.Load<Sprite>("Family-Pic");
        // differentAlphabet = Resources.Load<Sprite>("Tiles-Sprite_0");


        LoadAlphabetTiles();
        Vector3 position = new Vector3(-2.5f,1.1f,0);
        string direction = "Sideways";
        LoadEmptyTiles(position, direction);




        picturePosition = new Vector3(0, 3.2f, 0);
        family_pic =Instantiate(picture, picturePosition, Quaternion.identity) as GameObject;
        pictureScale= new Vector3(0.5f, 0.3f, 0);
        family_pic.transform.localScale = pictureScale;
       
    }

    void LoadAlphabetTiles()
    {
       
            for (int x = -2; x < 3; x++)
            {
                GameObject tempTile;
                tempTile = Instantiate(alphabet_tiles_prefab, new Vector3(x, -3.5f, 0), Quaternion.identity) as GameObject;
                tempTile.name = "AlphabetTile" + x;
                      
        }
    }

    void LoadEmptyTiles(Vector3 position,string direction)
    {
      int i = 0;
        if (direction.Equals("Sideways")) { 
      GameObject tempTile;
      tempTile = Instantiate(empty_tiles_prefab, position, Quaternion.identity) as GameObject;
      tempTile.name = "EmptyTile" + i;
      i++;
      position.x += 1f;
      tempTile = Instantiate(empty_tiles_prefab, position, Quaternion.identity) as GameObject;
        tempTile.name = "EmptyTile" + i;
        i++;
        position.x += 1f;
        tempTile = Instantiate(empty_tiles_prefab, position, Quaternion.identity) as GameObject;
        tempTile.name = "EmptyTile" + i;
        i++;
        position.x += 1f;
        tempTile = Instantiate(empty_tiles_prefab, position, Quaternion.identity) as GameObject;
        tempTile.name = "EmptyTile" + i;
        i++;
        position.x += 1f;
        tempTile = Instantiate(empty_tiles_prefab, position, Quaternion.identity) as GameObject;
        tempTile.name = "EmptyTile" + i;
        i++;
        }
    }

    void OnGUI()
    {
        if(buttonHide) { 
        if (GUI.Button(new Rect(30, 150, 50, 50), btnTexture,GUIStyle.none))
        {
            Debug.Log("Clicked the button with an image");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
            //Loads a level
            //Application.LoadLevel(//The name of the level you want to reload here);
        }
    }
}
