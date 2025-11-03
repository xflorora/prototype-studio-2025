using UnityEngine;

public class AudioScript : MonoBehaviour
{
   public AudioSource lavaSource;
   public AudioSource discoSource;
   public AudioSource forestSource;
   public AudioClip lavaClip;
   public AudioClip discoClip;
   public AudioClip forestClip;

   void Start()
   {
      
   }

   public void playLava()
   {
      lavaSource.Play();
      discoSource.Stop();
      forestSource.Stop();
   }
   
   public void playDisco()
   {
      discoSource.Play();
      lavaSource.Stop();
      forestSource.Stop();
   }

   public void playForest()
   {
      forestSource.Play();
      lavaSource.Stop();
      discoSource.Stop();
   }
}
