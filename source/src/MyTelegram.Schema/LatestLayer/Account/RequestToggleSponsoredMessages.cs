﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// See <a href="https://corefork.telegram.org/method/account.toggleSponsoredMessages" />
///</summary>
[TlObject(0xb9d9a38d)]
public sealed class RequestToggleSponsoredMessages : IRequest<IBool>
{
    public uint ConstructorId => 0xb9d9a38d;
    public bool Enabled { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Enabled);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Enabled = reader.Read();
    }
}