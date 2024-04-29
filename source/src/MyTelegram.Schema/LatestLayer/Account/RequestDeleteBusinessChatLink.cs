﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// See <a href="https://corefork.telegram.org/method/account.deleteBusinessChatLink" />
///</summary>
[TlObject(0x60073674)]
public sealed class RequestDeleteBusinessChatLink : IRequest<IBool>
{
    public uint ConstructorId => 0x60073674;
    public string Slug { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Slug);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Slug = reader.ReadString();
    }
}