using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TarotMain : MonoBehaviour
{
    [SerializeField]
    private TarotManager _tarotManager;
    [SerializeField]
    private TarotCardController[] _tarotCardControllers;
    [SerializeField]
    private ButtonController _buttonController;

    void Start()
    {
        _buttonController.LabelText.text = "Back";
        _buttonController.SetButtonOnClick(LoadTitleScene);

        PickTarot();
        ViewTarot();
    }

    void PickTarot()
    {
        _tarotManager.PickTarot(3);
    }

    void ViewTarot()
    {
        for (var i = 0; i < 3; i++)
        {
            var tarotCardController = _tarotCardControllers[i];
            var card = _tarotManager.TarotCards[i];

            tarotCardController.Image.sprite = Resources.Load<Sprite>(card.Id.ToString());
            if (card.IsReverse)
            {
                tarotCardController.Image.transform.Rotate(0f, 0f, 180f);
            }

            var id = card.GetID();
            tarotCardController.TitleText.text = TarotData.TarotNameDictionary_Jpn[id];
            tarotCardController.AbilityText.text = TarotData.TarotMeanDictionary_Jpn[id];
            if (card.IsReverse)
            {
                tarotCardController.AbilityText.text +=
                    "\n正位置の意味 : " + TarotData.TarotMeanDictionary_Jpn[card.Id + "_0"];
            }
        }
    }
    
    private void LoadTitleScene()
    {
        SceneManager.LoadScene(SceneNames.TitleScene);
    }
}
