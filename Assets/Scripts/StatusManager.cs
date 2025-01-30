using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatusManager : MonoBehaviour
{
    public OptionData optionData;
    public TextMeshProUGUI resultText;
    public GameObject optionPanel;
    public string sceneName;
    public TextMeshProUGUI[] texts;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < texts.Length; i++)
        {
            texts[i].text = optionData.option.prizeName[i];
        }
        optionPanel.SetActive(false);
        resultText.text = "START を押してスロットを回しましょう";
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.isSpinning == true)
        {
            resultText.text = " リールが回っています ...";
            return;
        }
        else
        {
            if(GameManager.result != null)
            {
                resultText.text = GameManager.result;
            }
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenPanel()
    {
        optionPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        optionPanel.SetActive(false);
    }
}
