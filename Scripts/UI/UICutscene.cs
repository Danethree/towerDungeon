using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICutscene : MonoBehaviour
{
    public GameObject panel,arrow;
    public GameObject unselectedChar;
    public void ActivePanel()
    {
        panel.SetActive(true);
    }
    public void DisableGO()
    {
        gameObject.SetActive(false);
    }
    public void DisableUnselectedChar()
    {
        unselectedChar.SetActive(false);
    }

    public void ActiveButtonSelect()
    {
        
    }
}
