﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The bot attachment menu entry is available in the chat with the bot that offers it
/// See <a href="https://corefork.telegram.org/constructor/attachMenuPeerTypeSameBotPM" />
///</summary>
[TlObject(0x7d6be90e)]
public sealed class TAttachMenuPeerTypeSameBotPM : IAttachMenuPeerType
{
    public uint ConstructorId => 0x7d6be90e;


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