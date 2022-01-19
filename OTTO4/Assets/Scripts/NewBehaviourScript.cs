using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  
    void Start()
    {
        gameObject.GetComponent<Animator>().enabled =true;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("wait");
        gameObject.GetComponent<Animator>().enabled = false;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);

    }
}
