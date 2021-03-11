using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.WarriorScripts.Camera
{
    public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public GameObject archer,warrior;
    private Vector2     velocity;
     public Vector2      smoothTime;
    void Start()
    {
        if(archer.activeSelf)
        {
             target = archer.GetComponent<Transform>();
        }
        else if(warrior.activeSelf)
        {
             target = warrior.GetComponent<Transform>();
        }
       
    }

   
    void Update()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref velocity.x,smoothTime.x);
            float posY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref velocity.y, smoothTime.y);
            transform.position = new Vector3(posX,posY,transform.position.z);
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }
}
}

