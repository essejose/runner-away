using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var height = Camera.main.orthographicSize * 2f;
        var widht = height * Screen.width / Screen.height;

        if(gameObject.name == "Background")
        {
            transform.localScale = new Vector3(widht, height, 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
        var height = Camera.main.orthographicSize * 2f;
        var widht = height * Screen.width / Screen.height;

        if (gameObject.name == "Background")
        {
            transform.localScale = new Vector3(widht, height, 0);
        }
        else
        {
            transform.localScale = new Vector3(widht +3f, 5, 0);
        }
    }
}
