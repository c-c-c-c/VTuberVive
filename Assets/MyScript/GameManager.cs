using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager StaticGameManager
    {
        get; private set;
    }
    public int score = 0;

    void Awake()
    {
        if (StaticGameManager != null)
        {
            Destroy(gameObject);
            return;
        }
        StaticGameManager = this;
        DontDestroyOnLoad(gameObject);

        score = 30;
    }

    // click callback
    void Update()
    {
        //Application.LoadLevel(1);


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            score += 30;
            print(score);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("DanceStudioScene");
        }

    }

}
