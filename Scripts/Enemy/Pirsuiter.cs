using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy.EnemyScriptableObjects;

namespace Enemy
{
    public class Pirsuiter : MonoBehaviour
{
     [SerializeField] private float speed;
    public EnemySO enemyScriptableObject;
     [SerializeField] Transform player;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        speed = enemyScriptableObject.speed;
      
    }

    
    void Update()
    {
      
    }
    public void PirsuitPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position,speed*Time.deltaTime);
    }
}

}
