using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatTrigger : MonoBehaviour
{

    Scene m_Scene;
    string sceneName;
    private Movement player;


    private void FixedUpdate()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        
    }

    void OnCollisionEnter2D(Collision2D collisioninfo)
    {

        player = FindObjectOfType<Movement>();

        if (collisioninfo.collider.tag == "Enemy")

        {
            player.startPoint = "CombatStart";
            if (sceneName  != "Combat")

            {
                DontDestroyOnLoad(collisioninfo.gameObject);
                SceneManager.LoadScene("Combat");
                collisioninfo.gameObject.transform.position = (player.transform.position + new Vector3(15, 15, 0));
                


            }
        }
        
    }
}
