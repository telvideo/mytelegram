﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Clients should update <a href="https://corefork.telegram.org/api/folders">folder</a> info
/// See <a href="https://corefork.telegram.org/constructor/updateDialogFilters" />
///</summary>
[TlObject(0x3504914f)]
public sealed class TUpdateDialogFilters : IUpdate
{
    public uint ConstructorId => 0x3504914f;


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