using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _delayBeforeAddition = 4;
    private int _delayBeforeHacking = 8;
    private int _durationChange = 3;

    private void Start()
    {
        _text.DOText("Текст изменен", _durationChange);
        _text.DOText(" и дополнен", _durationChange).SetRelative().SetDelay(_delayBeforeAddition);
        _text.DOText("Текст взломан", _durationChange, true, ScrambleMode.All).SetDelay(_delayBeforeHacking);

    }
}
