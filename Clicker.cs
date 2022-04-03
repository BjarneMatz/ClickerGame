using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clicker : MonoBehaviour
{
    
    public double clicks = 0;
    public TMP_Text count;
    public AudioSource clickSound;
    public AudioSource upSound;

    public void Click ()
    {
        clicks++;
        clickSound.Play();
        count.text = "" + clicks;


        if (clicks % 100 == 0)
        {
            upSound.Play();
            Debug.Log("Up");
        }
    }
}
