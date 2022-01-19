using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "cube")
        {
            Debug.Log("DOKUNDUM");
            if (gameObject.name == "Spherekrt1")
            {
                GameObject person= GameObject.FindGameObjectWithTag("person1");
                person.SetActive(true);
            }
           else if (gameObject.name == "Spherekrt2")
            {
                GameObject person = GameObject.FindGameObjectWithTag("person2");
                person.SetActive(true);
            }
          else  if (gameObject.name == "Spherekrt3")
            {
                GameObject person = GameObject.FindGameObjectWithTag("person3");
                person.SetActive(true);
            }
         else   if (gameObject.name == "Spherekrt4")
            {
                GameObject person = GameObject.FindGameObjectWithTag("person4");
                person.SetActive(true);
            }
           else if (gameObject.name == "Spherekrt5")
            {
                GameObject person = GameObject.FindGameObjectWithTag("person5");
                person.SetActive(true);
            }
          else  if (gameObject.name == "Spherekrt6")
            {
                GameObject person = GameObject.FindGameObjectWithTag("person6");
                person.SetActive(true);
            }
        }
    }
}
