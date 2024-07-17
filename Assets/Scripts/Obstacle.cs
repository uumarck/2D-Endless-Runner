using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");        
    }

    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player);
            // Aqui você pode adicionar lógica para reduzir a vida do jogador ou finalizar o jogo
            // Por exemplo:
            // GameManager.instance.GameOver();
        }    
    }
}
