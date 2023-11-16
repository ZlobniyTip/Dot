using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _delayBeforeAddition = 4;
    private int _delayBeforeHacking = 8;

    private void Start()
    {
        _text.DOText("Текст изменен", 3);
        _text.DOText(" и дополнен", 3).SetRelative().SetDelay(_delayBeforeAddition);
        _text.DOText("Текст взломан", 3, true, ScrambleMode.All).SetDelay(_delayBeforeHacking);

    }
}
