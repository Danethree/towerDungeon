using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.PlayerEnumerators;
namespace Scripts
{
    public class StatusStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.gameState = GameState.starting;
        SoundManager.instance.PlayMusicMenu();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}

