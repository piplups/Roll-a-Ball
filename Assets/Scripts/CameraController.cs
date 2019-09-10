using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // For follow cameras, procedural animation gathering last
    // known states, use LateUpdate, used like Update but it is
    // guaranteed to run after all items have been processed in Update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
