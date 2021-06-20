using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowedPlayer : MonoBehaviour
{
    public GameObject objectToFollow;
    public float camOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = Vector3.Lerp(this.transform.position, 
        new Vector3(objectToFollow.transform.position.x, objectToFollow.transform.position.y  + camOffset, 
        objectToFollow.transform.position.z - 1),
        300 * Time.deltaTime);
    }
}
