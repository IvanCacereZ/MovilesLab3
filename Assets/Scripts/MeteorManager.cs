using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorManager : MonoBehaviour
{
    public GameObject meteorPrefab;
    public SelectorSO templatePlayer;
    public float minY = 0f;
    public float maxY = 10f;
    public float spawnX = 20f;
    private float intervaloGeneracion = 1f;
    void Start()
    {
        intervaloGeneracion = templatePlayer.playerSelected.GenerationSpeed;
        InvokeRepeating("GenerarMeteorito", 0f, intervaloGeneracion);
    }
    void GenerarMeteorito()
    {
        float posY = Random.Range(minY, maxY);
        Instantiate(meteorPrefab, new Vector3(spawnX, posY, 0f), Quaternion.Euler(0f, 0f, 45.09f));
    }
}
