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


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("ground"))
        {
            Destroy(player);
            Debug.Log("Player collided");
            AudioClip clip = audioClip;
            rawImage.SetActive(true);
            videoPlayer.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("gameoverscene");
            }
            //StartCoroutine("Endure");
        }
    }

    /*IEnumerator Endure()
    {
        rawImage.SetActive(true);
        videoPlayer.SetActive(true);
        WaitForSeconds wait = new WaitForSeconds(10f);
        SceneManager.LoadScene("gameoverscene");
        yield return null;
    }*/


}
