using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoint : MonoBehaviour
{
    public SceneManager sm;
    private GameObject sprite1;
    private GameObject sprite2;
    public bool hideFirstSprite = true;


    void Start()
    {
        if (transform.childCount >= 2)
        {
            sprite1 = transform.GetChild(0).gameObject;
            sprite2 = transform.GetChild(1).gameObject;
        }

        if (sprite1 != null)
        {
            sprite1.SetActive(true);
        }
        if (sprite2 != null)
        {
            sprite2.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (sm != null && sm.IsDialogActive())
        {
            return;
        }

        sm.UpdatePosition(this.gameObject);
        Move();

        var components = GetComponents<MonoBehaviour>();
        foreach (var comp in components)
        {
            var type = comp.GetType();
            var isFuncField = type.GetField("isFunc");
            if (isFuncField != null && isFuncField.FieldType == typeof(bool))
            {
                bool isFunc = (bool)isFuncField.GetValue(comp);
                if (isFunc)
                {
                    var triggerMethod = type.GetMethod("trigger");
                    if (triggerMethod != null)
                    {
                        triggerMethod.Invoke(comp, new object[] { sm });
                    }
                }
            }
        }
    }

    public void Move()
    {
        if (sprite1 != null && hideFirstSprite)
        {
            sprite1.SetActive(false);
        }
        if (sprite2 != null)
        {
            sprite2.SetActive(true);
        }
    }

    public void Leave()
    {
        if (sprite1 != null)
        {
            sprite1.SetActive(true);
        }
        if (sprite2 != null)
        {
            sprite2.SetActive(false);
        }
    }
}
