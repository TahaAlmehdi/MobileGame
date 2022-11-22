using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public float Restartdelay = 1f;
  

    [SerializeField] private string loadLevel;
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadLevel);
            Invoke("Restart", 2f);
        }
        
    }
}
