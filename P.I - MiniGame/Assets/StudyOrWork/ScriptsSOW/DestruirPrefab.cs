using UnityEngine;

public class DestruirPrefab : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
