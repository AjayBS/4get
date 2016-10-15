using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEditor;
using UnityEngine.SceneManagement;

public class LoadGameObjects : MonoBehaviour {
    //Sprite tile;
    // Use this for initialization


    public GameObject empty_tiles;
    public GameObject alphabet_tiles;
    public GameObject[] tiles;
    public Texture2D texture;

    public GameObject picture;
    GameObject family_pic;
    Sprite[] sprites;
    Sprite differentAlphabet;
    Sprite photograph;
    public Texture btnTexture;
    public bool buttonHide=true;
    public Vector3 picturePosition;
    public Vector3 pictureScale;

    void Start () {
        
        tiles = GameObject.FindGameObjectsWithTag("Tiles");
        for (int j = 0; j < tiles.Length; j++)
        {
            tiles[j].GetComponent<SpriteRenderer>().sprite = sprites[j];
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        sprites = Resources.LoadAll<Sprite>(texture.name);
        photograph = Resources.Load<Sprite>("Family-Pic");
        // differentAlphabet = Resources.Load<Sprite>("Tiles-Sprite_0");

        for (int y = -4; y < -3; y++)
        {
            for (int x = -2; x < 3; x++)
            {
                GameObject tempTile;
                tempTile = Instantiate(alphabet_tiles, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                tempTile.name = "AlphabetTile" + x;

            }
        }

        for (int y = -2; y < -1; y++)
        {
            for (int x = -2; x < 3; x++)
            {
                GameObject tempTile;
                tempTile = Instantiate(empty_tiles, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                tempTile.name = "EmptyTile" + x;
            }
        }
        picturePosition = new Vector3(0, 2f, 0);
        family_pic =Instantiate(picture, picturePosition, Quaternion.identity) as GameObject;
        pictureScale= new Vector3(0.5f, 0.4f, 0);
        family_pic.transform.localScale = pictureScale;
       
    }

    void OnGUI()
    {
        if(buttonHide) { 
        if (GUI.Button(new Rect(330, 230, 50, 50), btnTexture,GUIStyle.none))
        {
            Debug.Log("Clicked the button with an image");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
            //Loads a level
            //Application.LoadLevel(//The name of the level you want to reload here);
        }
    }
}
