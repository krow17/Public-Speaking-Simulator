using UnityEngine;
using System.Collections;

public class SlidesManager : MonoBehaviour {

    public Material[] slides;
    int slideNum = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (slideNum < slides.Length - 1){
                slideNum ++;
            }
            else{
                slideNum = 0;
            }
            
            gameObject.GetComponent<Renderer>().sharedMaterial = slides[slideNum];
        }
	}
}
