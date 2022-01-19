using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//using RootMotion.Dynamics;

public class levelend : MonoBehaviour
{

    public int count;
    public GameObject hanglefto, hangrighto;
    public Transform cube, cube1, cube2, cube3, cube4, cube5, cube6,cube7,cube8;
    public GameObject person1, person2, person3, person4, person5, person6;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "levelendplane")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                Debug.Log("COUNT:" + count);
             
                GameObject child = hanglefto.transform.GetChild(count).gameObject;
                Debug.Log("CHILD:" + child);
                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                  
                    var persona=  Instantiate(person1, child.transform.position, Quaternion.identity);
                  
                    persona.transform.DOMove(cube.transform.position,0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {

                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                  
                    persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {

                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
              
                    persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {

                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
              
                    persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
           

                    persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                  
                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
              
             
                    persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
        else  if(hanglefto.transform.childCount == 0 )
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
              
                        persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person1")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
        
                        persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
            
                        persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person5")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
                     
                        persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person6")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                  
                        persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
               
                        persona.transform.DOMove(cube.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane1")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                Debug.Log("COUNT:" + count);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;
                Debug.Log("CHILD:" + child);
                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                
                    persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
           
                    persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
       
                    persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
         else  if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
 
                        persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
                      
                        persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
               
                        persona.transform.DOMove(cube1.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane2")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
               
                    persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
         
                    persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
            
                    persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
         else  if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
              
                        persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                 
                        persona.transform.DOMove(cube2.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane3")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
             
                    persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
             
                    persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
 
                    persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
        else if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                
                        persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
              
                        persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
           
                        persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                
                        persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
          
                        persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                      
                        persona.transform.DOMove(cube3.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane4")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                 
                    persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
               
                    persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                  
                    persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
           else if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube4.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane5")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
           else  if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube5.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane6")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
           else if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube6.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane8")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
            else if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube8.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
        if (other.transform.tag == "levelendplane7")
        {
            if (hanglefto.transform.childCount != 0)
            {
                count = Random.Range(0, hanglefto.transform.childCount);
                GameObject child = hanglefto.transform.GetChild(count).gameObject;

                Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                GameObject person = rb.transform.root.gameObject;
                GameObject obj = person.transform.GetChild(1).gameObject;
                GameObject personchild = person.transform.GetChild(2).gameObject;
                child.transform.parent = null;
                Destroy(child);
                if (person.transform.tag == "person1")
                {
                    var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person2")
                {
                    var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person3")
                {
                    var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person4")
                {
                    var persona = Instantiate(person4, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }
                if (person.transform.tag == "person5")
                {
                    person.SetActive(false);
                    child.transform.parent = null;
                    var persona = Instantiate(person5, child.transform.position, Quaternion.identity);

                    persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });

                }
                if (person.transform.tag == "person6")
                {
                    var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                    persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                    {
                        Animator anim = persona.GetComponent<Animator>();
                        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                    });
                    person.SetActive(false);
                    child.transform.parent = null;
                }

            }
            else if (hanglefto.transform.childCount == 0)
            {
                if (hangrighto.transform.childCount != 0)
                {
                    count = Random.Range(0, hangrighto.transform.childCount);
                    GameObject child = hangrighto.transform.GetChild(count).gameObject;

                    Rigidbody rb = child.transform.GetComponent<FixedJoint>().connectedBody;
                    GameObject person = rb.transform.root.gameObject;
                    GameObject obj = person.transform.GetChild(1).gameObject;
                    GameObject personchild = person.transform.GetChild(2).gameObject;
                    child.transform.parent = null;
                    Destroy(child);
                    if (person.transform.tag == "person1")
                    {
                        var persona = Instantiate(person1, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person2")
                    {
                        var persona = Instantiate(person2, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person5")
                    {
                        var persona = Instantiate(person5, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person6")
                    {
                        var persona = Instantiate(person6, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                    if (person.transform.tag == "person4")
                    {
                        person.SetActive(false);
                        child.transform.parent = null;
                        var persona = Instantiate(person4, child.transform.position, Quaternion.identity);

                        persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });

                    }
                    if (person.transform.tag == "person3")
                    {
                        var persona = Instantiate(person3, child.transform.position, Quaternion.identity);
                        persona.transform.DOMove(cube7.transform.position, 0.4f).OnComplete(() =>
                        {
                            Animator anim = persona.GetComponent<Animator>();
                            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("dance");
                        });
                        person.SetActive(false);
                        child.transform.parent = null;
                    }
                }
            }
        }
    
}
}
   
