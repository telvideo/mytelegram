﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// Get info about an unsupported deep link, see <a href="https://corefork.telegram.org/api/links#unsupported-links">here for more info »</a>.
/// See <a href="https://corefork.telegram.org/method/help.getDeepLinkInfo" />
///</summary>
[TlObject(0x3fedc75f)]
public sealed class RequestGetDeepLinkInfo : IRequest<MyTelegram.Schema.Help.IDeepLinkInfo>
{
    public uint ConstructorId => 0x3fedc75f;
    ///<summary>
    /// Path component of a <code>tg:</code> link
    ///</summary>
    public string Path { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Path);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Path = reader.ReadString();
    }
}