using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BNextGarden : MonoBehaviour
{
    public bool isFunc = true;
    public GameObject dancer1;
    public GameObject dancer2;
    public GameObject dancer3;
    public GameObject dancer4;
    public GameObject musicPlayerGO;
    

    public void trigger(STManager sm)
    {
        dialogUI dm = sm.DialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if (dancer1.GetComponent<dragableDancer>().correct() &&
                dancer2.GetComponent<dragableDancer>().correct() &&
                dancer3.GetComponent<dragableDancer>().correct() &&
                dancer4.GetComponent<dragableDancer>().correct())
            {
                sm.step4();
                musicPlayerGO.GetComponent<musicPlayer>().Stop();
            }
            else
            {
                Debug.Log($"Dancer1 correct: {dancer1.GetComponent<dragableDancer>().correct()}");
                Debug.Log($"Dancer2 correct: {dancer2.GetComponent<dragableDancer>().correct()}");
                Debug.Log($"Dancer3 correct: {dancer3.GetComponent<dragableDancer>().correct()}");
                Debug.Log($"Dancer4 correct: {dancer4.GetComponent<dragableDancer>().correct()}");
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("----当旋律错乱，舞步也失了节拍；----", null, 0.65f, null, 0.74f),
                    new DialogData("----拖动女舞者，让音与心相契，舞会方能再度和鸣。----", null, 0.65f, null, 0.74f),
                };
                dm.ShowDialog(startDialogs);
            }
        }
    }
}
