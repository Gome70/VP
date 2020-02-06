using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petSocketMovementScript : MonoBehaviour
{
    public Transform PetSocket;
    private Vector3 startingPos;
    private Vector3 newLocation;
    private float speed = 10.0f;
    private float amount = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        PetSocket = gameObject.transform;
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        PetSocket.localPosition = startingPos + new Vector3(0.0f,(Mathf.Sin(Time.time * speed) * amount),0.0f);
    }
}
