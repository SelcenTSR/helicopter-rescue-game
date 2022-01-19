using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class helicoptmove : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    helicopobs cameraMove;
   public Vector3 oldPos;
    helicopobs islevelend;
    public int count;
    public GameObject hanglefto, hangrighto;
    private Vector2 fingerStart;
    public static Swipes direction;
    private Vector2 fingerEnd;
    public float desiredDuration = 10f;
    public float elapsedTime;
    public float percentageComplete;
    public enum Swipes { None, Left, Right };
    public float minSwipeLength = 200f;
    Vector2 currentSwipe;
    private Quaternion _targetRotation = Quaternion.identity;
    public float turningRate = 10f;
  
    Vector3 screenPoint;
    Vector3 offset;
    Vector3 realPoint;
    Vector3 realPosition;
    public Rigidbody rb;
    public float rotationSpeed = 5f;
    public float MoveRange = 150f;
    public float Speed = 100f;
    public float speed = 10f;
    public float levelendspeed = 120f;
   movementstart gamestarted;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
        }
        text.SetText("LEVEL " + PlayerPrefs.GetInt("level"));
       
       
        cameraMove = GetComponent<helicopobs>();
        islevelend = GetComponent<helicopobs>();
        gamestarted = GetComponent<movementstart>();
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
  
       

    {
        
        elapsedTime += Time.deltaTime;
        percentageComplete = elapsedTime / desiredDuration;
       
        rb.constraints = RigidbodyConstraints.FreezePosition;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetRotation, turningRate * Time.deltaTime);


        if (gamestarted.isGameStarted && !islevelend.levelend)
        {
            //Camera.main.transform.Translate(transform.forward * Time.deltaTime * Speed, Space.World);

            //Ýleri Hareket

            transform.Translate(transform.forward * Time.deltaTime * Speed, Space.World);
        }
        if (islevelend.levelend)
        {
            transform.Translate(transform.forward * Time.deltaTime * levelendspeed, Space.World);
            transform.DOMoveX(-22, 1f);
        }
        if (cameraMove.cameramove==false)
        {
            Camera.main.transform.DOLocalMoveY(-70f, 1);
          
            

        }

        if (!islevelend.levelend)
        {

            movement();
        }
        changingRotation();

        ////Eðer range içindeyse yana harekete et
        if (transform.position.x > -MoveRange && transform.position.x < MoveRange&&islevelend.levelend==false)
        {
            AxisXMovement();
        }

    }

    

    void AxisXMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
         

            screenPoint = Camera.main.WorldToScreenPoint(transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));


        }
        if (Input.GetMouseButton(0))
        {

            realPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            realPosition = Camera.main.ScreenToWorldPoint(realPoint) + offset;
      
            if (realPosition.x > -MoveRange && realPosition.x < MoveRange)
            {
                Vector3 pos = transform.position;
                pos.x = Mathf.Lerp(transform.position.x, realPosition.x, 0.05f);
                transform.position = pos;
             
                Debug.Log(offset + "OFFSET");

            }

        }
    }
   
        public void changingRotation()
        {
            count = hanglefto.transform.childCount - hangrighto.transform.childCount;
            Debug.Log(count + "SAYI");
            if (count > 0)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 20), 0.1f);
            }
            if (count < 0)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -20), 0.1f);
            }

        }
    public void movement()
    {
             Debug.Log(Input.GetAxis("Mouse X"));
        Vector3 movement = transform.position - oldPos;
        if (movement.x > 0 && Input.GetAxis("Mouse X")>0)
        {
            Debug.Log("SAÐA GÝDÝYOR");
       
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -50* Input.GetAxis("Mouse X")),0.1f);
        }
        else if (movement.x < 0&& Input.GetAxis("Mouse X")<0)
        {
            Debug.Log("SOLA GÝDÝYOR")
                  ;
            Debug.Log(Input.GetAxis("Mouse X"));
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -50*Input.GetAxis("Mouse X")), 0.1f);
        }
        oldPos = transform.position;
    }
    
}