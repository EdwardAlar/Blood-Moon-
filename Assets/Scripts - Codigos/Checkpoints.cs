using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    public SpriteRenderer theSR;

    public Sprite cpOn, cpOff;


    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Patroclo"))
        {
            theSR.sprite = cpOn;
        }
    }

}
