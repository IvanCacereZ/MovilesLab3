using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MeteorBehaviour : MonoBehaviour
{
    public SelectorSO templatePlayer;
    private float velocidad = 1.0f;
    private void Start()
    {
        velocidad = templatePlayer.playerSelected.GenerationSpeed;
    }
    void Update()
    {
        transform.position = new Vector2(transform.position.x - (velocidad * Time.deltaTime), transform.position.y);
        if(transform.position.x <= -10)
        {
            Destroy(this.gameObject);
        }
    }
}
