using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class birdmov : MonoBehaviour
{
    helicopobs hit;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (transform.position == new Vector3(transform.position.x, transform.position.y, 3685))
        {

            transform.DOMoveZ(-3685, 35f).OnComplete(() =>

            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 3685);

            });

        }



    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        
    }

}
