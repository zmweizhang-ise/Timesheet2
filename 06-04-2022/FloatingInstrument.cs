using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingInstrument : MonoBehaviour
{

    [SerializeField] private float rotateSpeedX;
    [SerializeField] private float rotateSpeedY = 10;
    [SerializeField] private float rotateSpeedZ;

    [SerializeField] private float height;
    [SerializeField] private float floatSpeed;
    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeedX * Time.deltaTime, rotateSpeedY * Time.deltaTime, rotateSpeedZ * Time.deltaTime);

        float newY = Mathf.Sin(Time.time * floatSpeed) * height + newPosition.y;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
