using UnityEngine;
using System.Collections;

public class ImageManipulation : MonoBehaviour {

    bool zoomedPic=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if(zoomedPic) { 
        transform.localScale = new Vector3(0.6f,0.5f,0);
            zoomedPic = false;
        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.4f, 0);
            zoomedPic = true;
        }
    }
 }
