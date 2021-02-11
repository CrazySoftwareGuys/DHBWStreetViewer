using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureSphereScript : MonoBehaviour
{
    public List<GameObject> Arrows;

    private void Start()
    { 
        foreach(Transform child in transform)
        {
            if(child.tag == "Arrow")
            {
                Arrows.Add(child.gameObject);
            }
        }
        
    }
}
