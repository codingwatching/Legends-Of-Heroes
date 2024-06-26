//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System;


namespace ET
{

public sealed partial class ActionEventConfig: Bright.Config.BeanBase
{
    public ActionEventConfig(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        ActionEventType = (EActionEventType)_buf.ReadInt();
        IsClientOnly = _buf.ReadBool();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Params = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); Params.Add(_e0);}}
        PostInit();
    }

    public static ActionEventConfig DeserializeActionEventConfig(ByteBuf _buf)
    {
        return new ActionEventConfig(_buf);
    }

    /// <summary>
    /// 行为事件ID
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Desc { get; private set; }
    /// <summary>
    /// 事件类型
    /// </summary>
    public EActionEventType ActionEventType { get; private set; }
    /// <summary>
    /// 客户端独有
    /// </summary>
    public bool IsClientOnly { get; private set; }
    /// <summary>
    /// 参数
    /// </summary>
    public System.Collections.Generic.List<int> Params { get; private set; }

    public const int __ID__ = 424251974;
    public override int GetTypeId() => __ID__;

    public  void Resolve(ConcurrentDictionary<Type, IConfigSingleton> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "ActionEventType:" + ActionEventType + ","
        + "IsClientOnly:" + IsClientOnly + ","
        + "Params:" + Bright.Common.StringUtil.CollectionToString(Params) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}