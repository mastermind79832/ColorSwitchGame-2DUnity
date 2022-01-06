using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    
    public Transform player = null;

    public float followDistance = 0;
    

    // Update is called once per frame
    void Update()
    {

        if(player.position.y + followDistance > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y + followDistance, transform.position.z);
        }
        
    }
}
