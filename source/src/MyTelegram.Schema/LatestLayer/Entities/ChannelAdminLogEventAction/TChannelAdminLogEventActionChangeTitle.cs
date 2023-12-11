﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Channel/supergroup title was changed
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionChangeTitle" />
///</summary>
[TlObject(0xe6dfb825)]
public sealed class TChannelAdminLogEventActionChangeTitle : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0xe6dfb825;
    ///<summary>
    /// Previous title
    ///</summary>
    public string PrevValue { get; set; }

    ///<summary>
    /// New title
    ///</summary>
    public string NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(PrevValue);
        writer.Write(NewValue);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        PrevValue = reader.ReadString();
        NewValue = reader.ReadString();
    }
}