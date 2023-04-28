﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateChat" />
///</summary>
[TlObject(0xf89a6a4e)]
public sealed class TUpdateChat : IUpdate
{
    public uint ConstructorId => 0xf89a6a4e;
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