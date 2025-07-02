using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioListenerFollower : MonoBehaviour
{
    public Camera[] allCameras;

    void Update()
    {
        Camera activeCam = null;

        foreach (Camera cam in allCameras)
        {
            if (cam.enabled && cam.gameObject.activeInHierarchy)
            {
                activeCam = cam;
                break;
            }
        }

        if (activeCam != null)
        {
            transform.position = activeCam.transform.position;
            transform.rotation = activeCam.transform.rotation;
        }
    }
}
