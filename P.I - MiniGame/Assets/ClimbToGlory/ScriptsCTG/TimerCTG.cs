using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerCTG : MonoBehaviour
{
    public float contador = 40f;
    public float tempo;
    public TMP_Text timer;

    void Start()
    {
        tempo = contador;
        UpdateTimerText();
    }

    void Update()
    {
        if (tempo > 0)
        {
            tempo -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            tempo = 0;
            UpdateTimerText();

        }
        
        if (tempo == 0)
        {
            SceneManager.LoadScene("Perdedor 3");
        }

    }

    private void UpdateTimerText()
    {
        timer.text = tempo.ToString("F2");
    }
}
