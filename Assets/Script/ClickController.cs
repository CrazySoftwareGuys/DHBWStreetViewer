using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{

    public CameraMovement cameraMovement;
    // Update is called once per frame

    private void Start()
    {
        cameraMovement = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovement>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                if (hitInfo.transform.gameObject.tag == "Arrow")
                {
                    ArrowScript script = hitInfo.transform.GetComponent<ArrowScript>();
                    Vector3 goToPosition = GameObject.Find(script.GoesToSphere).GetComponent<Transform>().position;
                    cameraMovement.InitCameraMovement(goToPosition, 5f);
                }
            }
        }
    }
}
