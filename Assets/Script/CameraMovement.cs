using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    float cameraBaseOffset = 2;
    float target;
    Vector3 myXPosWithOffset;
    float diff;
    bool inRight = false;
    bool inLeft = false;

    void Start()
    {
        myXPosWithOffset = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        CameraControl();
    }
    void MoveCameraPosition()
    {
            myXPosWithOffset = Vector3.MoveTowards(new Vector3(transform.position.x, 0,-1), new Vector3(target, 0,-1), 0.01f);
            Mathf.Clamp(transform.position.x, player.transform.position.x + -cameraBaseOffset, player.transform.position.x + cameraBaseOffset);
            diff = myXPosWithOffset.x - player.transform.position.x;
 
    }
    void MoveCameraLeftPosition()
    {
        
    }
    void CameraControl()
    {
        
        transform.position = new Vector3(transform.position.x + diff, transform.position.y,transform.position.z);
        if (Input.GetKeyDown(KeyCode.D))
        {
            target = player.transform.position.x + cameraBaseOffset;
            CancelInvoke(nameof(MoveCameraPosition));
            Invoke(nameof(MoveCameraPosition), 2);
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            target = player.transform.position.x + -cameraBaseOffset;
            CancelInvoke(nameof(MoveCameraPosition));
            Invoke(nameof(MoveCameraPosition), 2);
        }
    }
}
