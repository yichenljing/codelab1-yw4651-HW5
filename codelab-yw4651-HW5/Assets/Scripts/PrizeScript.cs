using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrizeScript : MonoBehaviour
{
    public Color colorA;
    public Color colorB;
    
    public static int currentLevel = 0;
    
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision) //If another GameObject with a 2D Collider on it hits this GameObject's collider
    {
        if (transform.GetComponent<SpriteRenderer>().color != colorB) //when the prize is green on collison
      
        {
            Destroy(this.gameObject);
            currentLevel++; //increate the level number
                SceneManager.LoadScene(currentLevel); //go to the next level

            }

        if (transform.GetComponent<SpriteRenderer>().color != colorA) //when the prize is green on collison

        {

        }

    }
}
