using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.WarriorScripts
{
        public class ForcePowerUp : MonoBehaviour
    {

          public  SpriteRenderer player_sprite;
           public PlayerLife playerLife_script;
           public int savePreviousPower;
           
           public PlayerControl playerControl_script;
            int powered;
            public bool powerUpActivated;
            void Start()
            {
                playerLife_script = GetComponent<PlayerLife>();
                playerControl_script = GetComponent<PlayerControl>();
                
                savePreviousPower = playerControl_script.myPower;
                powered = 5;
                player_sprite = GetComponent<SpriteRenderer>();

            }
            void Update()
            {
                if(powerUpActivated)
                {
                    player_sprite.color = Color.Lerp(Color.blue,Color.white,Mathf.PingPong(2*Time.time,.5f));
                }
            }
            void OnTriggerEnter2D(Collider2D other)
            {
                if(other.gameObject.CompareTag("force"))
                {
                    StartCoroutine("growPower");
                }
            }

            IEnumerator growPower()
                {
                    powerUpActivated = true;
                   playerControl_script.myPower = powered;
                    Debug.Log( playerControl_script.myPower);
                    yield return new WaitForSeconds(10f);
                    powerUpActivated = false;
                    player_sprite.color = Color.white;
                    playerControl_script.myPower = savePreviousPower;           
                     Debug.Log( "Power atual: "+playerControl_script.myPower);
                    

                }



                    

                       

                }

    }


