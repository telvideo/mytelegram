﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// Get Telegram Premium promotion information
/// See <a href="https://corefork.telegram.org/method/help.getPremiumPromo" />
///</summary>
[TlObject(0xb81b93d4)]
public sealed class RequestGetPremiumPromo : IRequest<MyTelegram.Schema.Help.IPremiumPromo>
{
    public uint ConstructorId => 0xb81b93d4;

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}