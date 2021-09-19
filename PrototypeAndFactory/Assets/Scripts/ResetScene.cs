using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    //called when reset button is pressed
    public void ResetsScene()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); ;
    }
}