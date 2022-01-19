using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class helicopobs : MonoBehaviour
{
    public GameObject levelfailpanel;
    public GameObject levelendpanel;
    public bool theend = false;
    public bool cameramove = true;
    public GameObject sphere1, sphere2, sphere3, sphere4, sphere5, sphere6, sphere7, sphere8;
    public GameObject cameraM;
    public int count = 0;
    public float duration = 0.2f;
    private GameObject bird;
    movementstart gamestart;
    public bool isHit = false;
    public bool ispoleHite = false;
    public bool levelend = false;

    public ParticleSystem electricparticle, electricparticle1, explosparticle, featherparticle, fireparticle, fireparticle1, fireparticle2, endparticle;
    private void Awake()
    {
        featherparticle.Stop();
        electricparticle.Stop();
        endparticle.Stop();
    }
    void Start()
    {

        //PlayerPrefs.SetInt("level", 1);
        fireparticle.Stop();
        fireparticle1.Stop();
        fireparticle2.Stop();
        PlayerPrefs.SetInt("count", 0);
        gamestart = GetComponent<movementstart>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(PlayerPrefs.GetInt("count") + "COUNT");

        //if (ispoleHite)
        //{

        //    Camera.main.DOShakePosition(duration, 4/*, fadeOut: true*/);

        //    transform.DOShakePosition(0.5f, 3/*,fadeOut:true*/).
        //        OnComplete(()=> {

        //            ispoleHite = false;
        //            electricparticle.Stop();

        //        });  
        //}
        if (!ispoleHite &&( PlayerPrefs.GetInt("level") == 2 || PlayerPrefs.GetInt("level") == 1))
        {
            if (PlayerPrefs.GetInt("count") == 1)
            {
                fireparticle.Play();
            }
            if (PlayerPrefs.GetInt("count") == 2)
            {
                fireparticle1.Play();
            }
            if (PlayerPrefs.GetInt("count") == 3)
            {
                endparticle.transform.position = transform.position;
                endparticle.transform.parent = transform;
                cameraM.transform.DOShakePosition(duration, 5/*, fadeOut: true*/);

                transform.DOShakePosition(0.3f, 5/*,fadeOut:true*/).
                    OnComplete(() =>
                    {

                        endparticle.Play();
                        StartCoroutine("levelfail");

                    });

            }
        }
        if (!ispoleHite && (PlayerPrefs.GetInt("level") == 3 || PlayerPrefs.GetInt("level") == 4))
        {
            if (PlayerPrefs.GetInt("count") == 2)
            {
                fireparticle.Play();
            }
            if (PlayerPrefs.GetInt("count") == 4)
            {
                fireparticle1.Play();
            }
            if (PlayerPrefs.GetInt("count") == 5)
            {
                endparticle.transform.position = transform.position;
                endparticle.transform.parent = transform;
                cameraM.transform.DOShakePosition(duration, 5/*, fadeOut: true*/);

                transform.DOShakePosition(0.3f, 5/*,fadeOut:true*/).
                    OnComplete(() =>
                    {

                        endparticle.Play();
                        StartCoroutine("levelfail");

                    });

            }
        }
        //if (PlayerPrefs.GetInt("count") == 4)
        //{
        //    StartCoroutine("levelfail");

        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Pole")
        {

            Collider collider = other.GetComponent<Collider>();
            collider.enabled = false;

            Debug.Log("VURMA SAYISI" + PlayerPrefs.GetInt("count"));
            ispoleHite = true;
            electricparticle.Play();
            cameraM.transform.DOShakePosition(duration, 4/*, fadeOut: true*/);
            PlayerPrefs.SetInt("count", PlayerPrefs.GetInt("count") + 1);
            ispoleHite = false;
            if (PlayerPrefs.GetInt("count") != 3)
            {
                transform.DOShakePosition(0.2f, 3/*,fadeOut:true*/).
              OnComplete(() =>
              {

                  electricparticle.Stop();
                  Debug.Log("saaaaa");

              });

            }
        }
        if (other.transform.tag == "streetlight")
        {

            Collider collider1 = other.GetComponent<Collider>();
            collider1.enabled = false;

            Debug.Log("VURMA SAYISI" + PlayerPrefs.GetInt("count"));
            ispoleHite = true;
            electricparticle.Play();
            cameraM.transform.DOShakePosition(duration, 4/*, fadeOut: true*/);
            PlayerPrefs.SetInt("count", PlayerPrefs.GetInt("count") + 1);
            ispoleHite = false;
            if (PlayerPrefs.GetInt("count") != 5)
            {
                transform.DOShakePosition(0.2f, 3/*,fadeOut:true*/).
              OnComplete(() =>
              {

                  electricparticle.Stop();
                  Debug.Log("saaaaa");

              });

            }
        }


                //gamestart.isGameStarted = false;
                //Camera.main.DOShakeRotation(1f, new Vector3(45f, 0f, 0f), 10f, 90f, true);
           
            if (other.transform.tag == "Building")
            {
                gamestart.isGameStarted = false;
                explosparticle.transform.position = gameObject.transform.position;
                explosparticle.Play();
            }
            if (other.transform.tag == "Bird")
            {
                bird = other.gameObject;
                DOTween.Kill(other.transform);
                //gamestart.isGameStarted = false;
                featherparticle.transform.position = other.transform.position;
                featherparticle.Play();
                other.gameObject.GetComponent<Animator>().enabled = false;
                isHit = true;
                bird.SetActive(false);

            }
            if (other.transform.tag == "levelendcube")
            {
                Destroy(sphere1);
                Destroy(sphere2);
                Destroy(sphere3);
                Destroy(sphere4);
                Destroy(sphere5);
                Destroy(sphere6);
                Destroy(sphere7);
                Destroy(sphere8);
            levelend = true;
                cameramove = false;
            }
            if (other.transform.tag == "theend")
            {
                gamestart.isGameStarted = false;
                levelendpanel.SetActive(true);
                theend = true;

                Debug.Log(PlayerPrefs.GetInt("level"));
            }
        }
        IEnumerator levelscene()
        {


            yield return new WaitForSeconds(4f);


        }
        IEnumerator levelfail()
        {
            Debug.Log("SONDAYIM");

            yield return new WaitForSeconds(0.5f);

            gamestart.isGameStarted = false;
            levelfailpanel.SetActive(true);
        }
    }
