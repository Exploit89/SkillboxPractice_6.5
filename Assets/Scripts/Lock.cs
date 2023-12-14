using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    [SerializeField] private Text[] _pinText = new Text[3];
    [SerializeField] private EndgameHandler _endGameHandler;

    private int[] _initialPins = new int[3] { 2, 5, 7 };
    private int[] _winState = new int[3] { 5, 5, 5 };
    private int[] _pins = new int[3];
    private int _maxPinValue = 10;
    private int _minPinValue = 0;

    public void MovePins(int[] values)
    {
        for (int i = 0; i < _pins.Length; i++)
        {
            _pins[i] += values[i];
            ValidatePin(i);
            _pinText[i].text = _pins[i].ToString();
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

    private void Start()
    {
        InitLock();
    }

    private void Update()
    {
        for (var i = 0; i < _winState.Length; i++)
        {
            if (_pins[i] == _winState[i])
            {
                if (i == _pins.Length - 1)
                {
                    _endGameHandler.GameWin();
                }
                continue;
            }
            else
                break;
        }
    }

    private void ValidatePin(int index)
    {
        if (_pins[index] < _minPinValue)
            _pins[index] = _minPinValue;
        else if (_pins[index] > _maxPinValue)
            _pins[index] = _maxPinValue;
    }
}
