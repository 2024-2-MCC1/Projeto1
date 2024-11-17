using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private Player2 player2; // Referência ao script PlayerStats
    private PlayerController playerController;
    private CountdownTimer timer;

    void Start()
    {
        player2 = GameObject.Find("mao1").GetComponent<Player2>();

        playerController = GameObject.Find("mao2").GetComponent<PlayerController>();

        timer = GameObject.Find("Contagem").GetComponent<CountdownTimer>();

        if (timer != null)
        {
            // Agora você pode acessar a variável pontoCoin
            Debug.Log("Ponto Coin: " + timer.tempo);
        }
        else
        {
            Debug.LogError("PlayerStats não encontrado!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.tempo != 0 && player2.pontoCoin >= 10 && playerController.pontoBook >= 10)
        {
            CarregarWinner();
        } 
        
        if (timer.tempo == 0) 
        {
            CarregarGameOver();
        }
        
    }

    void CarregarWinner()
    {
        SceneManager.LoadScene("Ganhador 1");
    }

    void CarregarGameOver()
    {
        SceneManager.LoadScene("Perdedor 1");
    }
}
