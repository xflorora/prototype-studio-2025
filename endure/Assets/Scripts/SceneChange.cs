using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Sequences;

public class SceneChange : MonoBehaviour
{
    public SceneReference thatScene;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MovetoScene()
    {
        SceneManager.LoadScene(thatScene);
    }

   
}
