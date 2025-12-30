using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class StoryNode
{
    [TextArea(3, 6)]
    public string text;

    public string optionA;
    public int nextA;

    public string optionB;
    public int nextB;

    public string optionC;
    public int nextC;
}

public class StoryManager : MonoBehaviour
{
    [Header("UI References")]
    public TextMeshProUGUI narrativeText;
    public TextMeshProUGUI optionAText;
    public TextMeshProUGUI optionBText;
    public TextMeshProUGUI optionCText;

    [Header("Story Data")]
    public List<StoryNode> storyNodes = new List<StoryNode>();

    private int currentNodeIndex = 0;

    void Start()
    {
        ShowNode(0);
    }

    void ShowNode(int index)
    {
        currentNodeIndex = index;
        StoryNode node = storyNodes[index];

        narrativeText.text = node.text;

        optionAText.text = node.optionA;
        optionBText.text = node.optionB;
        optionCText.text = node.optionC;
    }

    public void ChooseOptionA()
    {
        ShowNode(storyNodes[currentNodeIndex].nextA);
    }

    public void ChooseOptionB()
    {
        ShowNode(storyNodes[currentNodeIndex].nextB);
    }

    public void ChooseOptionC()
    {
        ShowNode(storyNodes[currentNodeIndex].nextC);
    }
}
