using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 50f;

    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Ensure the spotlight is at the same Z position as the camera

        // Move the spotlight towards the mouse position
        transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * speed);
    }
}
