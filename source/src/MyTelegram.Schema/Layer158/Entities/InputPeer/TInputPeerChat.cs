﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputPeerChat" />
///</summary>
[TlObject(0x35a95cb9)]
public sealed class TInputPeerChat : IInputPeer
{
    public uint ConstructorId => 0x35a95cb9;
    public long ChatId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(ChatId);
    }

    public void Deserialize(BinaryReader br)
    {
        ChatId = br.ReadInt64();
    }
}