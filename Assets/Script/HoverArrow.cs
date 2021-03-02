using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverArrow : MonoBehaviour
{
    Vector3 startPosition;
    Vector3 endPosition;
    Vector3 differenceVector = new Vector3(0, (float)0.25, 0);
    bool goingUp = true;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = gameObject.transform.position;
        endPosition = startPosition + differenceVector;
    }

    // Update is called once per frame
    void Update()
    {
       if(goingUp)
        {
           
            
            moveUp();
            if (endPosition.y <= gameObject.transform.position.y)
            {
                goingUp = false;
            }  
        }
        else
        { 
            moveDown();
            if (startPosition.y >= gameObject.transform.position.y)
            {
                goingUp = true;
            }
        }
    }

    void moveUp()
    {
        gameObject.transform.position += differenceVector * Time.deltaTime;
    }

    void moveDown()
    {
        gameObject.transform.position -= differenceVector * Time.deltaTime;
    }
}
