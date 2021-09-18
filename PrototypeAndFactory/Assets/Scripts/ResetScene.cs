using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public void ResetsScene()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); ;
    }
}