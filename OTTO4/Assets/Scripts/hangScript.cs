//using RootMotion.Dynamics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hangScript : MonoBehaviour
{
    //public FixedJoint fixedJoint;
    //PuppetMaster puppet;
    Animator animator;

    public List<GameObject> person;
    public GameObject hanglefto, hangrighto;
    public float Yaxis;
    public bool isBeingHeld = false;
   
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hanglefto.transform.childCount + "Sol çocuk");
        Debug.Log(hangrighto.transform.childCount + "Sað çocuk");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Sphere")
        {
            if (other.transform.childCount != 0)
            {
               GameObject arrow = other.transform.GetChild(0).gameObject;
                arrow.SetActive(false);
            }
            Debug.Log("SSSSSSSSS");
            Rigidbody rb = other.GetComponent<Rigidbody>();
          rb.isKinematic = true;
          
           other.transform.parent = gameObject.transform;
            Rigidbody rb1 = other.transform.GetComponent<FixedJoint>().connectedBody;
            GameObject person1 = rb1.transform.root.gameObject;
            GameObject obj = person1.transform.GetChild(1).gameObject;
            GameObject obj1 = person1.transform.GetChild(2).gameObject;
            //obj.GetComponent<PuppetMaster>().pinWeight = 0;
            //if(other.gameObject.fi)
            //puppet = GameObject.FindWithTag("puppet");
            //Transform child = puppet.transform.GetChild(0);//hips
            //Transform childofchild = child.transform.GetChild(2);//spine
            //Transform childofchildofchild = childofchild.transform.GetChild(0);//leftarm
            //Transform childofchildofchildof = childofchildofchild.transform.GetChild(0);//forearm
            //Transform hand = childofchildofchildof.transform.GetChild(0);//hand

            if (other.transform.parent != null)
            {
                //foreach (GameObject p in person )
                //{

                //    Debug.Log(p);
                //}
                obj1.gameObject.GetComponent<Animator>().enabled = false;
                isBeingHeld = true;
              
            }
            if (isBeingHeld)
            {
                person.Add(other.gameObject);
                Yaxis = Random.Range(-1f, 1f);
                Debug.Log(Yaxis + "random sayý");
               other.transform.localPosition = new Vector3(0, Yaxis, 0);
            }


        }

    }
   //public void DisableRagdoll()
   // {
   //     rb:Rigidbody;
   //     for (rb in GetComponentsInChildren(Rigidbody))
   //     {
   //         rb.enabled = false;
   //     }
   // }
}