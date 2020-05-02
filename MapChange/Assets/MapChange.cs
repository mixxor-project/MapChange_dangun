using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMap(int a)
    {
        switch (a)
        {
            case 1:
                SceneManager.LoadScene("1chap");
                break;

            case 2:
                SceneManager.LoadScene("2chap");
                break;

            case 3:
                SceneManager.LoadScene("3chap");
                break;

            case 4:
                SceneManager.LoadScene("4chap");
                break;

            case 5:
                SceneManager.LoadScene("5chap");
                break;

            case 6:
                SceneManager.LoadScene("6chap");
                break;

            case 7:
                SceneManager.LoadScene("7chap");
                break;

            case 8:
                SceneManager.LoadScene("8chap");
                break;

        }
    }
}
