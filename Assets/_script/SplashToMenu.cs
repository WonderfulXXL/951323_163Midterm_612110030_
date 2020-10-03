using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    [SerializeField] Button _buttonToMenu ;
    // Start is called before the first frame update
    void Start()
    {
        _buttonToMenu.onClick.AddListener(delegate{SplashToMenuClick(_buttonToMenu);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SplashToMenuClick(Button button)
    {
          SceneManager.LoadScene("SceneMainMenu");   
    }
}
