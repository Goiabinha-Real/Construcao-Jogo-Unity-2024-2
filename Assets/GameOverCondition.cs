using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverCondition : MonoBehaviour
{
    public Transform destination, player;
    public GameObject Jogador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {   
    Jogador.SetActive(false);
    yield return new WaitForSeconds(1);
    player.position = destination.position;
    yield return new WaitForSeconds(0.5f);
    Jogador.SetActive(true);
    }
}