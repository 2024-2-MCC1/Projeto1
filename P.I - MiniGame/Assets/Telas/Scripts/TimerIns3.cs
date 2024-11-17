using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerIns3 : MonoBehaviour
{
    public float contador = 40f;
    public float tempo2;
    public TMP_Text timer;

    void Start()
    {
        tempo2 = contador;
        UpdateTimerText();
    }

    void Update()
    {
        if (tempo2 > 0)
        {
            tempo2 -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            tempo2 = 0;
            UpdateTimerText();

        }

        if (tempo2 == 0)
        {
            SceneManager.LoadScene("ClimbToGlory");
        }

    }

    private void UpdateTimerText()
    {
        timer.text = tempo2.ToString("F0");
    }
}

