﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionPinMessage" />
///</summary>
[TlObject(0x94bd38ed)]
public sealed class TMessageActionPinMessage : IMessageAction
{
    public uint ConstructorId => 0x94bd38ed;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}