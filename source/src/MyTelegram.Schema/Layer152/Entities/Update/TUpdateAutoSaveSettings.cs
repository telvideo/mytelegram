﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateAutoSaveSettings" />
///</summary>
[TlObject(0xec05b097)]
public sealed class TUpdateAutoSaveSettings : IUpdate
{
    public uint ConstructorId => 0xec05b097;


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