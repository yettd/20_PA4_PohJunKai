using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loadscene", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void loadscene()
    {
        SceneManager.LoadScene("cubescene");
    }
}
