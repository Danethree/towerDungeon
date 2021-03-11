using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.PlayerEnumerators;
namespace Scripts
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;
        public AudioSource musicTheme, musicMenu;
        public AudioClip musicIntro;


        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(instance);
        }

        void Start()
        {

        }

        public void PlayMusicTheme()
        {
            musicTheme.Play();
        }
        public void StopMusicMenu()
        {
            musicMenu.Stop();
        }
        public void StopMusicTheme()
        {
            musicTheme.Stop();
        }
        public void PlayMusicMenu()
        {
            musicMenu.Play();
        }
        void Update()
        {
           
        }
        
    }

}
