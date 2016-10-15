using UnityEngine;
using System.Collections;

public class ImageManipulation : MonoBehaviour {

    bool zoomedPic=true;
    GameObject obj;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        obj = GameObject.FindGameObjectWithTag("PageLoad");
        if (zoomedPic) {
            
            obj.GetComponent<LoadGameObjects>().buttonHide = false;
            transform.Rotate(Vector3.forward * -90);
            transform.localScale = new Vector3(0.98f,0.65f,0);
            transform.position = new Vector3(0,0,0);
            zoomedPic = false;
        }
        else
        {
            transform.Rotate(Vector3.forward * 90);
            obj.GetComponent<LoadGameObjects>().buttonHide = true;
            transform.localScale = obj.GetComponent<LoadGameObjects>().pictureScale;
            transform.position = obj.GetComponent<LoadGameObjects>().picturePosition;
            zoomedPic = true;
        }
    }
 }
