using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameplayMenuScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _buttonStage1;
    [SerializeField] Button _buttonStage2;
    // Start is called before the first frame update
    void Start()
    {
      
        _backButton.onClick.AddListener(delegate{ BackToMainMenuButtonClick(_backButton);});
        
        _buttonStage1.onClick.AddListener(delegate{ ButtonStage1Click(_buttonStage1);});
         _buttonStage2.onClick.AddListener(delegate{ ButtonStage2Click(_buttonStage1);});
    }

    // Update is called once per frame
    void Update()
    { 

    }
    public void BackToMainMenuButtonClick(Button button)
        { 
            SceneManager.LoadScene("SceneMainMenu");
        } 

    public void ButtonStage1Click(Button button)
         {
            SceneManager.UnloadSceneAsync("SceneGameplay");
           SceneManager.LoadScene("SceneStage1");
          }

            public void ButtonStage2Click(Button button)
         {
            SceneManager.UnloadSceneAsync("SceneGameplay");
           SceneManager.LoadScene("SceneStage2");
          }

    }
