using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    

    public Transform farBackground, middleBackground, middleBackground2, middleBackground3, middleBackground4;

    public float minHeight, MaxHeight;

    private Vector2 lastPos;

       // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);


        

        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);

        farBackground.position = farBackground.position + new Vector3(amountToMove.x, amountToMove.y, 0f);
        middleBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;
        middleBackground2.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;
        middleBackground3.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;
        middleBackground4.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;
        


        lastPos = transform.position; 
    }
}
