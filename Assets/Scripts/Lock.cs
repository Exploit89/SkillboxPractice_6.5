using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    private const int MaxPinValue = 10;
    private const int MinPinValue = 0;

    [SerializeField] private Text[] _pinText = new Text[3];
    [SerializeField] private EndgameHandler _endGameHandler;
    [SerializeField] private int[] _initialPins;
    [SerializeField] private int[] _winState;

    private int[] _pins = new int[3];

    private void Start()
    {
        InitLock();
    }

    private void ValidateLock()
    {
        for (var i = 0; i < _winState.Length; i++)
        {
            if (_pins[i] != _winState[i])
                break;
            _endGameHandler.GameWin();
        }
    }

    private void UpdatePinsView(int index)
    {
        _pinText[index].text = _pins[index].ToString();
    }

    public void MovePins(int[] values)
    {
        for (int i = 0; i < _pins.Length; i++)
        {
            _pins[i] += values[i];
            _pins[i] = Mathf.Clamp(_pins[i], MinPinValue, MaxPinValue);
            UpdatePinsView(i);
            ValidateLock();
        }
    }

    public void InitLock()
    {
        for (int i = 0; i < _initialPins.Length; i++)
        {
            _pins[i] = _initialPins[i];
            _pinText[i].text = _initialPins[i].ToString();
        }
    }
}
