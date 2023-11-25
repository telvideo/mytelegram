﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Credit card info URL provided by the bank
/// See <a href="https://corefork.telegram.org/constructor/bankCardOpenUrl" />
///</summary>
[TlObject(0xf568028a)]
public sealed class TBankCardOpenUrl : IBankCardOpenUrl
{
    public uint ConstructorId => 0xf568028a;
    ///<summary>
    /// Info URL
    ///</summary>
    public string Url { get; set; }

    ///<summary>
    /// Bank name
    ///</summary>
    public string Name { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Url);
        writer.Write(Name);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Url = reader.ReadString();
        Name = reader.ReadString();
    }
}