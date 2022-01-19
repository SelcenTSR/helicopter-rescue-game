using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicoptper : MonoBehaviour
{
    
    public GameObject per;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 rotation = new Vector3(0, 0, 1000);
        per.transform.Rotate(rotation*Time.deltaTime);
    }
}
