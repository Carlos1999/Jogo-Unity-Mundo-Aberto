using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapa : MonoBehaviour
{
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = camera.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        transform.rotation = Quaternion.Euler(90f, camera.eulerAngles.y,0f);

    }
}
