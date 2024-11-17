using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float contador = 20f; 
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

        
    }

    private void UpdateTimerText()
    {
        timer.text = tempo.ToString("F2"); 
    }
}
