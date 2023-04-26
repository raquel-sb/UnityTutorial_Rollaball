using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; //To reference player position
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; //Get difference between player and camera
    }

    // Update is called once per frame
    // Usamos LateUpdate pq no sabemos qué escripts se ejecutarán antes y después del Update, pero LastUpdate
    // se ejecuta después de que todos los scripts se hayan ejecutado
    void LateUpdate() 
    {
        transform.position = player.transform.position + offset; //When player moves the sphere, the camera is moved too
    }
}
