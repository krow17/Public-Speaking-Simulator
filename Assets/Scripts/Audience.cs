using UnityEngine;
using System.Collections;

public class Audience : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        StartCoroutine("Wait");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator Wait()
    {        
        yield return new WaitForSeconds(10);

        int rand = Random.Range(1, 4);
        //print(rand);
        if (rand == 1)
        {
            anim.SetTrigger("Embar");
        }
        else if (rand == 2)
        {
            anim.SetTrigger("Nod1");
        }
        if (rand == 3)
        {
            anim.SetTrigger("Nod2");
        }

        StartCoroutine("Wait");
    }
}
