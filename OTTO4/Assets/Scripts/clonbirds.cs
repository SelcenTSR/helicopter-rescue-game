using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonbirds : MonoBehaviour
{
    helicopobs islevelend;
    public GameObject gameObjectbird;
    movementstart start;
    public GameObject birds;
    helicopobs polehit;
    // Start is called before the first frame update
    void Start()
    {
        islevelend = GetComponent<helicopobs>();
        start = GetComponent<movementstart>();
        InvokeRepeating("clon", 0, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clon()
    {      
            if (start.isGameStarted&&islevelend.levelend==false)
            {
                clonBirds(birds);
            }
    }
    public void clonBirds(GameObject objectt)
    {
        GameObject clon = Instantiate(objectt);
        clon.SetActive(true);
        clon.transform.position = new Vector3(-18f, 100, 3685);
        
    }
}
