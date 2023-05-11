using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayAudioClipOnCollision : MonoBehaviour
{
    
    Rigidbody objectsRigidBody;    
    AudioSource objectsAudioSource;

    private void Start()
    {
        objectsRigidBody = GetComponent<Rigidbody>();
        objectsAudioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Sound volume will depend on how fast the object is moving
        objectsAudioSource.PlayOneShot(objectsAudioSource.clip, objectsRigidBody.velocity.magnitude);
        
    }
}
