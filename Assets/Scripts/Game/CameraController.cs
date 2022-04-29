using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        float ypos = (player.transform.position.y / PlayerPrefs.GetInt("size")) * 5 + 2.5f;
        transform.position = new Vector3(transform.position.x, ypos, transform.position.z);
    }
}
