using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public static UIController instance;

    public Image hearth1, hearth2, hearth3;

    public Sprite hearthFull, hearthEmpty, heartHalf;
    private void Awake() 
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay()
    {
        switch(PlayerHearthController.instance.currentHealth)
        {
            case 6:
            hearth1.sprite = hearthFull;
            hearth2.sprite = hearthFull;
            hearth3.sprite = hearthFull;

            break;

            case 5:
            hearth1.sprite = hearthFull;
            hearth2.sprite = hearthFull;
            hearth3.sprite = heartHalf;

            break;

            case 4:
            hearth1.sprite = hearthFull;
            hearth2.sprite = hearthFull;
            hearth3.sprite = hearthEmpty;

            break;

            case 3:
            hearth1.sprite = hearthFull;
            hearth2.sprite = heartHalf;
            hearth3.sprite = hearthEmpty;

            break;

            case 2:
            hearth1.sprite = hearthFull;
            hearth2.sprite = hearthEmpty;
            hearth3.sprite = hearthEmpty;

            break;

            case 1:
            hearth1.sprite = heartHalf;
            hearth2.sprite = hearthEmpty;
            hearth3.sprite = hearthEmpty;

            break;

            case 0:
            hearth1.sprite = hearthEmpty;
            hearth2.sprite = hearthEmpty;
            hearth3.sprite = hearthEmpty;

            break;

            default:
            hearth1.sprite = hearthEmpty;
            hearth2.sprite = hearthEmpty;
            hearth3.sprite = hearthEmpty;

            break;

        }
    }
}
