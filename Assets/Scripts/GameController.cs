using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] bgList;
    

    public void OnDropdownChange(int index)
    {
        if (index == 0)
        {
            audioSource.clip = bgList[0];
            audioSource.Play();
            cancelFocus();
        }
        else
        {
            audioSource.clip = bgList[1];
            audioSource.Play();
            //audioSource.volume = 0;
        }
    }

    public void OnSliderChange(float value)
    {
        audioSource.volume = value;
    }

    void cancelFocus()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }
}
/*public class GameController : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] bgList;

    public void OnToggleChange(bool t){
        audioSource.mute = t;
        cancelFocus();
    }

    public void OnDropdownChange(int index){
        audioSource.clip = bgList[index];
        audioSource.Play();
        cancelFocus();
    }

    public void OnSliderChange(float value){
        audioSource.volume = value;
    }

    void cancelFocus(){
        EventSystem.current.SetSelectedGameObject(null);
    }
}
*/
