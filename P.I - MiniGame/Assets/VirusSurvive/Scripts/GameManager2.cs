using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{

    private PlayerMov2 playermov2; 
    
    private TimerVS timervs;

    void Start()
    {
        playermov2 = GameObject.Find("Capsule").GetComponent<PlayerMov2>();
        timervs = GameObject.Find("Cronometro").GetComponent<TimerVS>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (timervs.tempo2 != 0 && playermov2.pontoHealth == 4)
        {
            CarregarWinner2();
        }

        if (timervs.tempo2 <= 0 && playermov2.pontoHealth != 4)
        {
            CarregarGameOver2();
        }

    }

    void CarregarWinner2()
    {
        SceneManager.LoadScene("Ganhador 4");
    }

    void CarregarGameOver2()
    {
        SceneManager.LoadScene("Perdedor 4");
    }
}
