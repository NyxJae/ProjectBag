
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.demo
{
public sealed partial class Reward : Luban.BeanBase
{
    public Reward(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
        { if(!_buf["desc"].IsString) { throw new SerializationException(); }  Desc = _buf["desc"]; }
        { if(!_buf["count"].IsNumber) { throw new SerializationException(); }  Count = _buf["count"]; }
    }

    public static Reward DeserializeReward(JSONNode _buf)
    {
        return new demo.Reward(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 名称
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// 描述
    /// </summary>
    public readonly string Desc;
    /// <summary>
    /// 个数
    /// </summary>
    public readonly int Count;
   
    public const int __ID__ = -920121926;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "count:" + Count + ","
        + "}";
    }
}

}