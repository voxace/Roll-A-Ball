using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // Calculate the offset between the player and camera
        offset = transform.position - player.transform.position;
	}

    private void LateUpdate()
    {
        // Move camera to player position + update
        transform.position = player.transform.position + offset;
    }
}
