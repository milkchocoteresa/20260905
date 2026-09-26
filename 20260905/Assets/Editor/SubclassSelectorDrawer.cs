using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SubclassSelectorAttribute))]
public class SubclassSelectorDrawer : PropertyDrawer
{
    private static Type GetFieldType(SerializedProperty property)
    {
        // —á: "Assembly-CSharp ChipSettingTiming" ‚Æ‚¢‚¤Œ`‚Ì•¶Žš—ñ‚ª“ü‚Á‚Ä‚¢‚é
        string[] parts = property.managedReferenceFieldTypename.Split(' ');
        return Type.GetType($"{parts[1].Replace('/', '+')}, {parts[0]}");
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Type[] candidates = TypeCache.GetTypesDerivedFrom(GetFieldType(property))
                                     .Where(t => !t.IsAbstract).ToArray();
        string[] names = new[] { "(‚È‚µ)" }.Concat(candidates.Select(t => t.Name)).ToArray();

        string current = property.managedReferenceFullTypename;
        int index = Array.FindIndex(candidates,
            t => $"{t.Assembly.GetName().Name} {t.FullName}" == current) + 1;

        Rect popupRect = new Rect(position.x + EditorGUIUtility.labelWidth, position.y,
            position.width - EditorGUIUtility.labelWidth, EditorGUIUtility.singleLineHeight);
        int newIndex = EditorGUI.Popup(popupRect, index, names);

        if (newIndex != index)
        {
            property.managedReferenceValue =
                newIndex == 0 ? null : Activator.CreateInstance(candidates[newIndex - 1]);
            property.serializedObject.ApplyModifiedProperties();
        }
        EditorGUI.PropertyField(position, property, label, true);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        => EditorGUI.GetPropertyHeight(property, label, true);
}