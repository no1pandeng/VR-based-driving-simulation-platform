using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public bool ifFollow;
    public GameObject Player;

    void Update()
    {
        if (ifFollow)
        {
            transform.position = Player.transform.position;
        }
    }
}
