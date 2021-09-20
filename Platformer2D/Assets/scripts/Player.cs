using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool _ground = false;
    private Audioplay _audioController;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audioController = Audioplay.Instance;
    }

    void Update()
    {
        _rb.velocity = new Vector2(4.5f, 0f);
        if (Input.GetKeyDown(KeyCode.Space) && _ground == true)
        {
            _ground = false;
                _rb.AddForce(Vector2.up * 10000f, ForceMode2D.Force);         
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("finish"))
        {
            Time.timeScale = 0;
            _audioController._audio.Stop();

        }
        if (col.gameObject.CompareTag("ground"))
        {
            _ground = true;
        }
    }
}
