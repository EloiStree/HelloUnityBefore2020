using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class TagBean  {

    public static Dictionary<string, TagBean> _tags = new Dictionary<string, TagBean>();


    #region STATIC ACCESS
    public static TagBean Create(string id, string name = "")
    {
        if (string.IsNullOrEmpty(id))
            return null;

        TagBean tag = null;
        if (_tags.ContainsKey(id))
        {
            tag = _tags[id];
            tag._id = id;
            tag._name = name;
        }
        else _tags.Add(id, new TagBean(id, name));

        return tag;
    }
    public static TagBean Get(string id)
    {
        if (string.IsNullOrEmpty(id))
            return null;

        TagBean tag = null;
        if (_tags.ContainsKey(id))
        {
            tag = _tags[id];
        }
        else tag = Create(id, "");

        return tag;
    }
    #endregion



    #region CLASS DEFINITION

    private TagBean(string id, string name)
    {
        _id = id;
        _name = name;
    }

    [SerializeField]
    private string _id;
    [SerializeField]
    private string _name;

    public string GetId()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    } 
    #endregion
}
