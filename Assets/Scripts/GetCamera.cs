using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GetCamera : MonoBehaviour
{

    public NetworkObject networkObject;
    // Start is called before the first frame update
    void Start()
    {
        if (networkObject.HasInputAuthority)
        {
            CinemachineVirtualCamera pl = GameObject.FindObjectOfType<CinemachineVirtualCamera>();
            pl.Follow = transform;
            pl.LookAt = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
