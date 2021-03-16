using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;
using UnityEngine.UI;
using Scripts.UI;
namespace Scripts.WarriorScripts
{
    public class Poison : MonoBehaviour
    {
        PlayerLife playerLife_script;
        bool isPoisoned = false;
        SpriteRenderer player_sprite;
        public PowerUpUI powerUpUI_script;
        void Start()
        {
            playerLife_script = GetComponent<PlayerLife>();
            player_sprite = GetComponent<SpriteRenderer>();
            powerUpUI_script = GameObject.Find("panelpowerUp").GetComponent<PowerUpUI>();
                powerUpUI_script.ActiveFeedbackPowerUp(powerUpUI_script.poison_img,isPoisoned);
        }



        IEnumerator poisonPlayer()
        {

            player_sprite.color = new Color(118, 0, 95,255);
            powerUpUI_script.ActiveFeedbackPowerUp(powerUpUI_script.poison_img,isPoisoned);
            while (isPoisoned)
            {
             
                yield return new WaitForSeconds(3f);
                playerLife_script.TakeDamage();
            }

        }


        IEnumerator endPoisoned()
        {
            yield return new WaitForSeconds(10f);
            StopCoroutine("poisonPlayer");
            isPoisoned = false;
            player_sprite.color = Color.white;
            powerUpUI_script.ActiveFeedbackPowerUp(powerUpUI_script.poison_img,isPoisoned);
        }

        void Update()
        {
            if (isPoisoned)
            {
                StartCoroutine("endPoisoned");
                   player_sprite.color = Color.Lerp(new Color(118, 0, 95,255),Color.white,Mathf.PingPong(2*Time.time,.5f));
            }
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("poison"))
            {
                if (!isPoisoned)
                {
                    isPoisoned = true;
                    StartCoroutine("poisonPlayer");
                }
            }
        }
    }
}

