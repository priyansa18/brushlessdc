using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadIndexScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLearnigScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadAnimationScene()
    {
        SceneManager.LoadScene(2);
    }
    public void loadquizeTestScene()
    {
        SceneManager.LoadScene(3);
    }

    public void loadTestIndexScene()
    {
        SceneManager.LoadScene(4);
    }
}
