﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/inputBusinessAwayMessage" />
///</summary>
[TlObject(0x832175e0)]
public sealed class TInputBusinessAwayMessage : IInputBusinessAwayMessage
{
    public uint ConstructorId => 0x832175e0;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool OfflineOnly { get; set; }
    public int ShortcutId { get; set; }
    public MyTelegram.Schema.IBusinessAwayMessageSchedule Schedule { get; set; }
    public MyTelegram.Schema.IInputBusinessRecipients Recipients { get; set; }

    public void ComputeFlag()
    {
        if (OfflineOnly) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(ShortcutId);
        writer.Write(Schedule);
        writer.Write(Recipients);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { OfflineOnly = true; }
        ShortcutId = reader.ReadInt32();
        Schedule = reader.Read<MyTelegram.Schema.IBusinessAwayMessageSchedule>();
        Recipients = reader.Read<MyTelegram.Schema.IInputBusinessRecipients>();
    }
}