using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPos : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerCamera;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerCamera.position;
    }
}
