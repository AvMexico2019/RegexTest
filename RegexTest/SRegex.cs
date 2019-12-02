using System.Runtime.Serialization;

[DataContract]
public class SRegex
{
    [DataMember(Name = "RegexDef", Order = 0)]
    public string RegexDef { get; set; }

    public string ToCadena()
    {
        return "RegexDef: " + RegexDef;
    }
}
