using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopControler : MonoBehaviour
{
    public GameObject player;
    private float offsetX;


    public void Start()
    {
        this.offsetX = this.transform.position.x - this.player.transform.position.x;
    }

    public void Update()
    {
        Vector3 position = this.transform.position;
        position.x = player.transform.position.x + offsetX;
        this.transform.position = position;
    }
}