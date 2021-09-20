using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject _start;
    private Audioplay _audioController;
    private void Start()
    {
        _audioController = Audioplay.Instance;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = _start.transform.position;
            _audioController._audio.Play();
        }
    }
 
}
