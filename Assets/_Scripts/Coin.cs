using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(2);
            Destroy(gameObject);
            SceneManager.LoadScene("Background");
        }
    }
}
