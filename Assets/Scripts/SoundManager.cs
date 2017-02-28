using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    public AudioClip[] clips;

    AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = gameObject.GetComponent<AudioSource>();
        StartCoroutine("Wait");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Wait()
    {        
        yield return new WaitForSeconds(17);

        int rand = Random.Range(0, 4);
        //print(rand);
        audio.clip = clips[rand];
        audio.Play();

        StartCoroutine("Wait");
    }
}
