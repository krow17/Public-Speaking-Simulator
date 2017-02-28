using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class WalkOut : MonoBehaviour {

    Animator anim;
    bool changeDir = false;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        StartCoroutine("Wait");
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("Walk"))
        {
            gameObject.GetComponent<AutoMoveAndRotate>().SetMoveSpeed(new Vector3(0, 0, 1));

            if (!changeDir)
                gameObject.GetComponent<AutoMoveAndRotate>().SetRotateSpeed(new Vector3(0, -15, 0));
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(60);

        anim.SetBool("Walk", true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChangeDir")
        {
            gameObject.GetComponent<AutoMoveAndRotate>().SetRotateSpeed(new Vector3(0, 0, 0));
            changeDir = true;
        }

        if (other.tag == "Door")
        {
            Destroy(gameObject);
        }
    }
}
