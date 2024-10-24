﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/updateDeleteQuickReplyMessages" />
///</summary>
[TlObject(0x566fe7cd)]
public sealed class TUpdateDeleteQuickReplyMessages : IUpdate
{
    public uint ConstructorId => 0x566fe7cd;
    public int ShortcutId { get; set; }
    public TVector<int> Messages { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ShortcutId);
        writer.Write(Messages);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ShortcutId = reader.ReadInt32();
        Messages = reader.Read<TVector<int>>();
    }
}