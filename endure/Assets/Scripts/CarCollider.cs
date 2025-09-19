using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CarCollider : MonoBehaviour
{

    public GameObject player;
    public GameObject rawImage;
    public GameObject videoPlayer;
    public AudioSource audioSource;
    public AudioClip audioClip;
    //private bool onGround = false;
    

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("ground"))
        {
            Destroy(player);
            Debug.Log("Player collided");
            audioSource.PlayOneShot(audioClip);
            rawImage.SetActive(true);
            videoPlayer.SetActive(true);
            //onGround = true;
            StartCoroutine(nameof(Endure));
        }
    }
    

   IEnumerator Endure()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("gameoverscene");
        yield return null;
    }


}
