using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowm : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0, 0, 50);
       gameObject.transform.Rotate(rotation * Time.deltaTime);
    }
}
