using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleMain : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _titleText;
    [SerializeField]
    private ButtonController _buttonController;

    void Start()
    {
        _titleText.text = "Simple Tarot";

        _buttonController.LabelText.text = "Pick Tarot";
        _buttonController.SetButtonOnClick(LoadMainScene);
    }
    
    private void LoadMainScene()
    {
        SceneManager.LoadScene(SceneNames.MainScene);
    }
}
