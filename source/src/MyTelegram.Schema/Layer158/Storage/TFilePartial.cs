﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Storage;


///<summary>
///See <a href="https://core.telegram.org/constructor/storage.filePartial" />
///</summary>
[TlObject(0x40bc6f52)]
public sealed class TFilePartial : IFileType
{
    public uint ConstructorId => 0x40bc6f52;


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