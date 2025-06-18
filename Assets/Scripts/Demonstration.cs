using System.Linq;
using TMPro;
using UnityEngine;

public class Demonstration : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text nameTitle;

    private string m_name;
    public string playerName
    {
        get { return m_name; } //encapsulation
        set
        {
            if (!value.Any(char.IsDigit))
            {
                m_name = value;
            }
            else
            {
                m_name = "no numbers!!!";
            }
            nameTitle.text = m_name;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameInput.onEndEdit.AddListener(ChangeName);
    }

    void ChangeName(string newName)
    {
        playerName = newName;
    }
}