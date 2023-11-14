using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        _text.DOText("Текст изменен", 3);
        _text.DOText(" и дополнен", 3).SetRelative().SetDelay(4);
        _text.DOText("Текст взломан", 3, true, ScrambleMode.All).SetDelay(8);

    }
}
